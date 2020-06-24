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
        //static string Path = Application.StartupPath + @"..\..\..\";
        static string Path = @"D:\";
        DirectoryInfo directoryInfo = new DirectoryInfo(Path);
        public Form1()
        {
            InitializeComponent();
            InitTreeView(treeView1);
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            
            //DirectoryInfo directoryInfo = new DirectoryInfo(Application.StartupPath + @"..\..");
            //
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
            DirectoryInfo directoryInfo = Directory.CreateDirectory(Path + treeNode.FullPath);

            try
            {
                Directory.GetAccessControl(Path + treeNode.FullPath);
            }
            catch (Exception)
            {
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
            //Console.WriteLine(Path + treeView1.SelectedNode.FullPath);
            //Console.WriteLine(Path + e.Node.FullPath);
        }
    }
}

