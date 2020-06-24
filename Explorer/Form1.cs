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
using System.Security.AccessControl;

namespace Explorer
{
    public partial class Form1 : Form
    {
        //static string strPath = Application.StartupPath + @"..\..\..\";
        static string strPath = @"D:\";
        DirectoryInfo directoryInfo = new DirectoryInfo(strPath);
        public Form1()
        {
            InitializeComponent();
            InitTreeView(treeView1);
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            
        }

        private void InitTreeView(TreeView treeView)
        {
            foreach (var item in directoryInfo.GetDirectories())
            {
                TreeNode temp_Node = new TreeNode(item.Name);
                treeView.Nodes.Add(temp_Node);
                LoadTreeNode(temp_Node);
            }

            if (treeView.Nodes.Count > 0)
            {
                treeView.Nodes[0].Checked = true;
            }
        }

        private void LoadTreeNode(TreeNode treeNode)
        {
            DirectoryInfo directoryInfo = Directory.CreateDirectory(strPath + treeNode.FullPath);

            try
            {
                DirectorySecurity security = Directory.GetAccessControl(strPath + treeNode.FullPath);
                security.GetAccessRules(true, true, typeof(System.Security.Principal.SecurityIdentifier));
            }
            catch (Exception)
            {
                treeNode.Remove();
                return;
            }

            foreach (var item in directoryInfo.GetDirectories())
            {
                TreeNode temp_Node = new TreeNode(item.Name);
                treeNode.Nodes.Add(temp_Node);
                LoadTreeNode(temp_Node);
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Console.WriteLine("CLick");
            treeView1.SelectedNode = e.Node;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txtPath.Text = "\\" + e.Node.FullPath;

            listView1.Items.Clear();
            string[] Files = Directory.GetFiles(strPath + e.Node.FullPath);
            foreach (var item in Files)
            {
                FileInfo fileInfo = new FileInfo(item);
                listView1.Items.Add(new ListViewItem(new string[] { fileInfo.Name, fileInfo.LastWriteTime.ToString(), fileInfo.Extension, fileInfo.Length.ToString()}));
            }

            foreach (var item in e.Node.Nodes)
            {
                listView1.Items.Add(((TreeNode)item).Text);
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            //Console.WriteLine("Active");
            //ListView item = (ListView)sender;
            
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView item = (ListView)sender;
            //item.SelectedItems[0].Text;
            


        }
    }
}

