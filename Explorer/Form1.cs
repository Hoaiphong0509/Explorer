using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.AccessControl;
using System.Web.UI;
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

        string strExtensionImage = "BMP, GIF, JPG, JPEG, PNG, JFIF";
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
            if (strPath + treeNode.FullPath == PathNow)
            {
                return;
            }
            txtPath.Text = strRoot + "\\" + treeNode.FullPath;

            stack_Previous.Push(PathNow);
            LoadListView(strPath + treeNode.FullPath);
            

        }

        private void LoadListView(string strPath)
        {
            // Nếu stack Previous rỗng thì disenable Prev
            if (stack_Previous.Count == 0)
            {
                tsb_Previous.Enabled = false;
            }
            else
            {
                tsb_Previous.Enabled = true;
            }

            PathNow = strPath;
            Console.WriteLine("Path : " + PathNow);
            listView1.Items.Clear();
            listView1.Update();
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
            }else if (ext.Length <= 1)
            {
                NameTypeofExtension.Add(ext, "File");
                return NameTypeofExtension[ext];
            }

            string temp = null, temp2 = "File";
            try
            {
                if (Registry.ClassesRoot.OpenSubKey(ext) == null)
                {
                    NameTypeofExtension.Add(ext, ext.Substring(1).ToUpper() + " File");
                    return NameTypeofExtension[ext];
                }
                temp = (string)Registry.ClassesRoot.OpenSubKey(ext).GetValue("");

                if (temp == null)
                {
                    if (Registry.ClassesRoot.OpenSubKey(ext).OpenSubKey("OpenWithProgids") == null)
                    {
                        NameTypeofExtension.Add(ext, ext.Substring(1).ToUpper() + " File");
                        return NameTypeofExtension[ext];
                    }

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
                stack_Previous.Push(PathNow);
                LoadListView(PathNow + "\\" + listView1.FocusedItem.Text);

                //foreach (TreeNode item in treeView1.SelectedNode.Nodes)
                //{
                //    if (item.Text == listView1.FocusedItem.Text)
                //    {
                //        treeView1.SelectedNode = item;
                //        LoadFolder(item);
                //        break;

                //    }
                //}
                
                //LoadListView(PathNow + "\\" + listView1.FocusedItem.Text);
                
            }
            else
            {
                FileInfo fileInfo = new FileInfo(PathNow + "\\" + listView1.SelectedItems[0].Text);
                if (fileInfo.Extension.Length < 4)
                {
                    return;
                }

                if (strExtensionImage.IndexOf(fileInfo.Extension.Substring(1).ToUpper()) >= 0)
                {
                    Process.Start(fileInfo.FullName);
                }

            }

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView item = (ListView)sender;
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
            // Lấy đường dẫn hiện tại thêm vào Prev vào load folder Next. ngược lại với Prev
            if (e.ClickedItem.Name == "tsb_Next")
            {
                stack_Previous.Push(PathNow);
                LoadListView(stack_Next.Pop());
                if (stack_Next.Count == 0)
                {
                    tsb_Next.Enabled = false;
                }
            }
            else
            {
                stack_Next.Push(PathNow);
                LoadListView(stack_Previous.Pop());
                tsb_Next.Enabled = true;
            }

        }

        //
        //CHE DO 2
        //

        private void btnGoto_Click(object sender, EventArgs e) //Enable = true khi click vao che do 2
        {
            
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
                listView1.FocusedItem.BeginEdit();
            }
        }

        private void listView1_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (listView1.FocusedItem.SubItems[2].Text == "Folder")
            {
                Directory.Move(PathNow + "\\" + listView1.FocusedItem.Text, PathNow + "\\" + e.Label);
            }
            else
            {
                File.Move(PathNow + "\\" + listView1.FocusedItem.Text, PathNow + "\\" + e.Label);
            }
            listView1.LabelEdit = false;
            e.CancelEdit = true;
            LoadListView(PathNow);
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
                // Nếu thư mục cut = thư mục hiện tại thì bỏ qua.
                if (listFileFolder[0].PathFolder == PathNow)
                {
                    return;
                }
                foreach (var item in listFileFolder)
                {
                    if (item.isFile)
                    {
                        string FileName = item.Name;

                        while (listView1.FindItemWithText(FileName) != null)
                        {
                            FileName = GetNameFileCopy(FileName, true);
                        }
                        File.Move(item.PathFolder + "\\" + item.Name, PathNow + "\\" + FileName);
                        Console.WriteLine($"Cut File from {item.PathFolder}\\{item.Name} to {PathNow}\\{FileName}");
                    }
                    else
                    {
                        string FileName = item.Name;

                        while (listView1.FindItemWithText(FileName) != null)
                        {
                            FileName = GetNameFileCopy(FileName, true);
                        }
                        Console.WriteLine($"Cut Dir from {item.PathFolder}\\{item.Name} to {PathNow}\\{FileName}");
                        Directory.Move(item.PathFolder + "\\" + item.Name, PathNow + "\\" + FileName);
                    }
                }
            }
            else
            {
                foreach (var item in listFileFolder)
                {
                    if (item.isFile)
                    {
                        string FileName = item.Name;

                        while (listView1.FindItemWithText(FileName) != null)
                        {
                            FileName = GetNameFileCopy(FileName, true);
                        }
                        File.Copy(item.PathFolder + "\\" + item.Name, PathNow + "\\" + FileName);
                        Console.WriteLine($"Copy File from {item.PathFolder}\\{item.Name} to {PathNow}\\{FileName}");
                    }
                    else
                    {
                        string FileName = item.Name;

                        while (listView1.FindItemWithText(FileName) != null)
                        {
                            FileName = GetNameFileCopy(FileName, true);
                        }
                        Console.WriteLine($"Copy Dir from {item.PathFolder}\\{item.Name} to {PathNow}\\{FileName}");
                        DirectoryCopy(item.PathFolder + "\\" + item.Name, PathNow + "\\" + FileName);
                    }
                }

                //if (listFileFolder[0].PathFolder == PathNow)
                //{
                //    foreach (var item in listFileFolder)
                //    {
                //        if (item.isFile)
                //        {
                //            string NewFileName = item.Name;
                //            for (int i = item.Name.Length - 1; i >= 0; i--)
                //            {
                //                if (item.Name[i] == '.')
                //                {
                //                    NewFileName = item.Name.Insert(i, " - copy");
                //                    break;
                //                }
                //                else if (i == 0)
                //                {
                //                    NewFileName = item.Name + " - copy";
                //                }
                //            }
                //            File.Copy(item.PathFolder + "\\" + item.Name, PathNow + "\\" + NewFileName);
                //            Console.WriteLine($"Copy File from {item.PathFolder}\\{item.Name} to {PathNow}\\{NewFileName}");
                //        }
                //        else
                //        {
                //            Console.WriteLine($"Copy Dir from {item.PathFolder}\\{item.Name} to {PathNow}\\{item.Name} - copy");
                //            DirectoryCopy(item.PathFolder + "\\" + item.Name, PathNow + "\\" + item.Name + " - copy");
                //        }
                //    }


                //}
                //else
                //{
                //    foreach (var item in listFileFolder)
                //    {
                //        if (item.isFile)
                //        {
                //            string FileName = item.Name;

                //            while (listView1.FindItemWithText(FileName) != null)
                //            {
                //                FileName = GetNameFileCopy(FileName, true);
                //            }
                //            File.Copy(item.PathFolder + "\\" + item.Name, PathNow + "\\" + FileName);
                //            Console.WriteLine($"Copy File from {item.PathFolder}\\{item.Name} to {PathNow}\\{FileName}");
                //        }
                //        else
                //        {
                //            string FileName = item.Name;

                //            while (listView1.FindItemWithText(FileName) != null)
                //            {
                //                FileName = GetNameFileCopy(FileName, true);
                //            }
                //            Console.WriteLine($"Copy Dir from {item.PathFolder}\\{item.Name} to {PathNow}\\{FileName}");
                //            DirectoryCopy(item.PathFolder + "\\" + item.Name, PathNow + "\\" + FileName);
                //        }
                //    }
                //}
            }

            LoadListView(PathNow);

            if (iTypePaste == TypePaste.CUT)
            {
                iTypePaste = TypePaste.NONE;
                listFileFolder.Clear();
            }

        }

        private string GetNameFileCopy(string FileName, bool isFile = true)
        {
            if (isFile)
            {
                string NewFileName = FileName;
                for (int i = FileName.Length - 1; i >= 0; i--)
                {
                    if (FileName[i] == '.')
                    {
                        NewFileName = FileName.Insert(i, " - copy");
                        break;
                    }
                    else if (i == 0)
                    {
                        NewFileName = FileName + " - copy";
                    }
                }
                return NewFileName;
            }
            else
            {
                return FileName + " - copy";
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

        private void tsb_Coppy_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem_Click(contextMenuStrip1, EventArgs.Empty);
        }

        private void tsb_Cut_Click(object sender, EventArgs e)
        {
            cutToolStripMenuItem_Click(contextMenuStrip1, EventArgs.Empty);
        }

        private void tsb_Paste_Click(object sender, EventArgs e)
        {
            pasteToolStripMenuItem_Click(contextMenuStrip1, EventArgs.Empty);
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (iTypePaste == TypePaste.NONE)
            {
                pasteToolStripMenuItem.Enabled = false;
            }
            else
            {
                pasteToolStripMenuItem.Enabled = true;
            }

            bool bTemp = true;
            if (listView1.SelectedItems.Count == 0)
            {
                bTemp = false;
            }

            cutToolStripMenuItem.Enabled = bTemp;
            copyToolStripMenuItem.Enabled = bTemp;
            deleteToolStripMenuItem.Enabled = bTemp;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                if (item.SubItems[2].Text == "Folder")
                {
                    Directory.Delete(PathNow + "\\" + item.Text, true);
                    button1_Click(btnRefresh, EventArgs.Empty);
                }
                else
                {
                    LoadListView(PathNow);
                    File.Delete(PathNow + "\\" + item.Text);
                }
            }
            
            //L

        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (treeView1.Nodes.Count > 0)
            {
                treeView1.Nodes.RemoveAt(0);
            }
            listView1.Items.Clear();
            InitTreeView(treeView1);
            LoadListView(strPath);
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

