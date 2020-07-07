using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace Explorer
{

    public partial class Form1 : Form
    {
        struct TypePaste
        {
            public const int CUT = 1, COPY = 2, NONE = 0;
        }

        int iTypePaste = TypePaste.NONE;
        //public static string strPath = Application.StartupPath + @"..\..\..\";
        public static string strPath = @"D:\";
        static string strRoot = "root";
        Stack<string> stack_Previous = new Stack<string>();
        Stack<string> stack_Next = new Stack<string>();
        DirectoryInfo directoryInfo = new DirectoryInfo(strPath);

        List<InfoPaste> listFileFolder = new List<InfoPaste>();

        public static string PathNow = strPath;


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
            Form1.PathNow = strPath;
            listView1.Items.Clear();
            string[] Files = Directory.GetFiles(strPath);
            foreach (var item in Files)
            {
                FileInfo fileInfo = new FileInfo(item);
                listView1.Items.Add(new ListViewItem(new string[] { fileInfo.Name, fileInfo.LastWriteTime.ToString(), GetNameTypeFormExtension(fileInfo.Extension), GetSizeString(fileInfo.Length) }));
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

        private string GetSizeString(long sizefile)
        {


            if (sizefile > 573741824)
            {
                return Math.Round(((double)sizefile / 1073741824), 2) + " GB";
            }
            else if (sizefile > 3145728)
            {
                return Math.Round(((double)sizefile / 1048576), 2) + " MB";
            }
            else if (sizefile > 1024)
            {
                return Math.Round(((double)sizefile / 1024), 2) + " KB";
            }
            else
            {
                return sizefile.ToString();
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            if (listView1.FocusedItem.SubItems[2].Text == "Folder")
            {
                foreach (TreeNode item in treeView1.SelectedNode.Nodes)
                {
                    if (item.Text == listView1.FocusedItem.Text)
                    {
                        treeView1.SelectedNode = item;
                        LoadFolder(item);



                        break;

                    }
                }
            }
            else
            {

            }

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
                if (webBrowser.CanGoForward) webBrowser.GoForward(); //CHE DO 2
            }
            else
            {
                if (webBrowser.CanGoBack) webBrowser.GoBack();
                //string strPath = stack_Next.Pop();

            }

        }

        //
        //CHE DO 2
        //

        private void btnGoto_Click(object sender, EventArgs e) //Enable = true khi click vao che do 2
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                webBrowser.Url = new Uri(fbd.SelectedPath);
                txtPath.Text = fbd.SelectedPath;
                listView1.Clear();
            }
        }

        private void tb_Memu2_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Name == "tb_View2")
                btnGoto.Enabled = true;
            else
                btnGoto.Enabled = false;
        }

        private void tsb_Add_Click(object sender, EventArgs e)
        {
            string newFile = "";
            CreateFile cf = new CreateFile();

            if (newFile == "")
            {
                cf.Show();
                newFile = cf.NameFile;

            }
            if (newFile != "")
            {
                TreeNode node = new TreeNode(newFile);
                treeView1.Nodes.Add(node);
            }
        }

        //
        //Remove file
        //
        private void tsb_Delete_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            iTypePaste = TypePaste.CUT;
            listFileFolder.Clear();

            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listFileFolder.Add(new InfoPaste(PathNow, item.Text, (item.SubItems[2].Text == "Folder" ? false : true)));
            }

        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2 && listView1.SelectedItems.Count > 0)
            {
                listView1.LabelEdit = true;
                listView1.SelectedItems[0].BeginEdit();
            }
        }

        private void listView1_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (iTypePaste == TypePaste.NONE || listFileFolder.Count == 0)
            {
                Console.WriteLine("No Cut or Copy");
                return;
            }

            if (iTypePaste == TypePaste.CUT)
            {
                foreach (var item in listFileFolder)
                {
                    if (item.isFile)
                    {
                        File.Move(item.PathFolder + "\\" + item.Name, PathNow + "\\" + item.Name);
                        Console.WriteLine($"Cut File from {item.PathFolder}\\{item.Name} to {PathNow}\\{item.Name}");
                    }
                    else
                    {
                        Console.WriteLine($"Cut Dir from {item.PathFolder}\\{item.Name} to {PathNow}\\{item.Name}");
                        Directory.Move(item.PathFolder + "\\" + item.Name, PathNow + "\\" + item.Name);
                    }
                }
            }
            else
            {
                if (listFileFolder[0].PathFolder == PathNow)
                {
                    foreach (var item in listFileFolder)
                    {
                        if (item.isFile)
                        {
                            string NewFileName = item.Name;
                            for (int i = item.Name.Length - 1; i >= 0; i--)
                            {
                                if (item.Name[i] == '.')
                                {
                                    NewFileName = item.Name.Insert(i, " - copy");
                                    break;
                                }
                                else if (i == 0)
                                {
                                    NewFileName = item.Name + " - copy";
                                }
                            }
                            File.Copy(item.PathFolder + "\\" + item.Name, PathNow + "\\" + NewFileName);
                            Console.WriteLine($"Copy File from {item.PathFolder}\\{item.Name} to {PathNow}\\{NewFileName}");
                        }
                        else
                        {
                            Console.WriteLine($"Copy Dir from {item.PathFolder}\\{item.Name} to {PathNow}\\{item.Name} - copy");
                            DirectoryCopy(item.PathFolder + "\\" + item.Name, PathNow + "\\" + item.Name + " - copy");
                        }
                    }

                    
                }
                else
                {
                    foreach (var item in listFileFolder)
                    {
                        if (item.isFile)
                        {
                            File.Copy(item.PathFolder + "\\" + item.Name, PathNow + "\\" + item.Name);
                            Console.WriteLine($"Copy File from {item.PathFolder}\\{item.Name} to {PathNow}\\{item.Name}");
                        }
                        else
                        {
                            Console.WriteLine($"Copy Dir from {item.PathFolder}\\{item.Name} to {PathNow}\\{item.Name}");
                            DirectoryCopy(item.PathFolder + "\\" + item.Name, PathNow + "\\" + item.Name);
                        }
                    }
                }
            }

            LoadListView(PathNow);

            if (iTypePaste == TypePaste.CUT)
            {
                iTypePaste = TypePaste.NONE;
                listFileFolder.Clear();
            }

        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs = true)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            iTypePaste = TypePaste.COPY;
            listFileFolder.Clear();

            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listFileFolder.Add(new InfoPaste(PathNow, item.Text, (item.SubItems[2].Text == "Folder" ? false : true)));
            }
        }
    }

    class InfoPaste
    {
        public string PathFolder, Name;
        public bool isFile;

        //public InfoPaste() { };
        public InfoPaste(string PathFolder, string Name, bool isFile)
        {
            this.PathFolder = PathFolder;
            this.Name = Name;
            this.isFile = isFile;
        }
    }

}

