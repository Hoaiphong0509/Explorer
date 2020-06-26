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
using System.Collections;
using System.Web;
using Microsoft.Win32;

namespace Explorer
{
    public partial class Form1 : Form
    {
        static string strPath = Application.StartupPath + @"..\..\..\";
        //static string strPath = @"D:\";
        static string strRoot = "root";
        Stack<string> stack_Previous = new Stack<string>();
        Stack<string> stack_Next = new Stack<string>();
        DirectoryInfo directoryInfo = new DirectoryInfo(strPath);

        Dictionary<string, string> NameTypeofExtension = new Dictionary<string, string>();
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
            treeView1.SelectedNode = e.Node;
            LoadFolder(e.Node);
        }

        // Load thư Listview khi click hoặc ấn Enter.
        private void LoadFolder(TreeNode treeNode)
        {
            txtPath.Text = strRoot + "\\" + treeNode.FullPath;
            LoadListView(strPath + treeNode.FullPath);

        }

        private void LoadListView(string strPath)
        {
            listView1.Items.Clear();
            string[] Files = Directory.GetFiles(strPath);
            foreach (var item in Files)
            {
                FileInfo fileInfo = new FileInfo(item);
                listView1.Items.Add(new ListViewItem(new string[] { fileInfo.Name, fileInfo.LastWriteTime.ToString(), GetNameTypeFormExtension(fileInfo.Extension), fileInfo.Length.ToString() }));
            }

            foreach (var item in Directory.GetDirectories(strPath))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(item);
                listView1.Items.Add(new ListViewItem(new string[] { directoryInfo.Name, directoryInfo.LastWriteTime.ToString(), "Folder" }));
            }
        }

        private string GetNameTypeFormExtension(string ext)
        {
            if (NameTypeofExtension.ContainsKey(ext))
            {
                return NameTypeofExtension[ext];
            }

            string temp = null, temp2 = "File";
            try
            {
                temp = (string)Registry.ClassesRoot.OpenSubKey(ext).GetValue("");

                if (temp == null)
                {
                    temp = (string)Registry.ClassesRoot.OpenSubKey(ext).OpenSubKey("OpenWithProgids").GetValue("");
                    if (temp == null)
                    {
                        temp = Registry.ClassesRoot.OpenSubKey(ext).OpenSubKey("OpenWithProgids").GetValueNames()[0];
                        if (temp == null)
                        {
                            temp2 = ext.Substring(1).ToUpper() + " File";
                        }
                    }
                }
                else
                {
                    temp2 = Registry.ClassesRoot.OpenSubKey(temp).GetValue("").ToString();
                }
            }
            catch (Exception)
            {
                NameTypeofExtension.Add(ext, ext.Substring(1).ToUpper() + " File");
                return NameTypeofExtension[ext];
            }

            NameTypeofExtension.Add(ext, temp2);
            return temp2;
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

        private void treeView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (treeView1.SelectedNode != null)
                {
                    LoadFolder(treeView1.SelectedNode);
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked == true)
            {
                int rdbType = 0;
                switch (radioButton.Text)
                {
                    case "Small Icon":
                        listView1.View = View.SmallIcon;
                        rdbType = 1;
                        break;
                    case "Title":
                        listView1.View = View.Tile;
                        rdbType = 2;
                        break;
                    case "Large Icon":
                        listView1.View = View.LargeIcon;
                        rdbType = 3;
                        break;
                    default:
                        listView1.View = View.Details;
                        rdbType = 0;
                        break;
                }
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "tsb_Next")
            {

            }
            else
            {
                string strPath = stack_Next.Pop();

            }
            
        }
    }
}

