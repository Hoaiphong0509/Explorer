using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Explorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateTreeView();
            this.treeView2.NodeMouseClick += new TreeNodeMouseClickEventHandler(this.treeView2_MouseClick);
        }
        private void PopulateTreeView() {
            TreeNode Noderoot;
            DirectoryInfo info = new DirectoryInfo(@"../..");
            if (info.Exists) {
                Noderoot = new TreeNode(info.Name);
                Noderoot.Tag = info;
                GetDirectories(info.GetDirectories(), Noderoot);
                treeView2.Nodes.Add(Noderoot);
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeAdd) {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs) {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeAdd.Nodes.Add(aNode);
            }
        }

        private void treeView2_MouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            listView1.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;
            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[] {
     new ListViewItem.ListViewSubItem(item, "Directory"), new ListViewItem.ListViewSubItem(item, dir.LastAccessTime.ToShortDateString())
    };
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[] {
     new ListViewItem.ListViewSubItem(item, "File"), new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString())
    };
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void Form1_Load(object sender, EventArgs e) { }
        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + @"/../..\..\" + treeView1.SelectedNode.FullPath + "\\" + listView1.FocusedItem.Text);
        }
    }
}

