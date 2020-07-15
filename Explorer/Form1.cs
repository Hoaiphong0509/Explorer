using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
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
        public static string strPath = Application.StartupPath + @"..\..\..\";
        //public static string strPath = @"D:\";
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
            InitTreeView();
        }

        private void InitTreeView()
        {
            foreach (var item in directoryInfo.GetDirectories())
            {
                TreeNode temp_Node = new TreeNode(item.Name);
                temp_Node.ImageKey = "folder";
                temp_Node.SelectedImageKey = "folder open";
                treeView1.Nodes.Add(temp_Node);
                LoadTreeNode(temp_Node);
            }


            LoadListView(strPath);
            txtPath.Text = "\\";
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
                temp_Node.ImageKey = "folder";
                temp_Node.SelectedImageKey = "folder open";
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

            stack_Previous.Push(PathNow);
            LoadListView(strPath + "\\" + treeNode.FullPath);
            

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
            txtPath.Text = strPath.Substring(Form1.strPath.Length);
            Console.WriteLine("Path : " + PathNow);
            listView1.Items.Clear();
            listView1.Update();
            string[] Files = Directory.GetFiles(strPath);

            Icon iconForFile;
            foreach (var item in Files)
            {
                FileInfo fileInfo = new FileInfo(item);
                if (!SmallIcon.Images.ContainsKey(fileInfo.Extension))
                {

                    iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(fileInfo.FullName);
                    SmallIcon.Images.Add(fileInfo.Extension, iconForFile);
                    LargeIcon.Images.Add(fileInfo.Extension, iconForFile);
                }

                listView1.Items.Add(new ListViewItem(new string[] { fileInfo.Name, fileInfo.LastWriteTime.ToString(), GetNameTypeFormExtension(fileInfo.Extension), GetSizeString(fileInfo.Length) }, fileInfo.Extension));
            }

            foreach (var item in Directory.GetDirectories(strPath))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(item);
                listView1.Items.Add(new ListViewItem(new string[] { directoryInfo.Name, directoryInfo.LastWriteTime.ToString(), "Folder" }, "folder"));
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
                    
                    if (Registry.ClassesRoot.OpenSubKey(temp) == null || Registry.ClassesRoot.OpenSubKey(temp).GetValue("") == null)
                        temp2 = "File";
                    else temp2 = Registry.ClassesRoot.OpenSubKey(temp).GetValue("").ToString();

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
            }
            else
            {
                FileInfo fileInfo = new FileInfo(PathNow + "\\" + listView1.SelectedItems[0].Text);
                if (fileInfo.Extension.Length < 1)
                {
                    return;
                }

                if (strExtensionImage.IndexOf(fileInfo.Extension.Substring(1).ToUpper()) >= 0)
                {
                    Process.Start(fileInfo.FullName);
                }
                else
                {
                    if (MessageBox.Show("Bạn đang mở không phải file ảnh. File ảnh có các định dạng sau : BMP, GIF, JPG, JPEG, PNG, JFIF\nBạn có muốn tiếp tục ?", "Mở file khác.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            Process.Start(fileInfo.FullName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi : " + ex.Message, "Lỗi");
                        }
                        
                    }
                }
            }
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
                switch (radioButton.Text)
                {
                    case "Small Icon":
                        listView1.View = View.SmallIcon;
                        break;
                    case "Title":
                        listView1.View = View.Tile;
                        break;
                    case "Large Icon":
                        listView1.View = View.LargeIcon;
                        break;
                    default:
                        listView1.View = View.Details;
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

        private void btnGoto_Click(object sender, EventArgs e) //Enable = true khi click vao che do 2
        {
            if (txtPath.Text == "") txtPath.Text = "\\";
            if (Directory.Exists(strPath + txtPath.Text) == false)
            {
                MessageBox.Show("Đường dẫn không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPath.Text = PathNow.Substring(strPath.Length);
            }
            else
            {
                LoadListView(strPath + txtPath.Text);
            }
            
        }

        private void tsb_Delete_Click(object sender, EventArgs e)
        {
            deleteToolStripMenuItem_Click(deleteToolStripMenuItem, EventArgs.Empty);
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
            pasteToolStripMenuItem.Enabled = tsb_Paste.Enabled = true;

        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            if (e.KeyData == Keys.F2)
            {
                listView1.LabelEdit = true;
                listView1.SelectedItems[0].BeginEdit();
            }
            else if (e.KeyData == Keys.Delete)
            {
                deleteToolStripMenuItem_Click(deleteToolStripMenuItem, EventArgs.Empty);
            }
        }

        private void listView1_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (e.Label.IndexOf('\\') >= 0 || e.Label.IndexOf('/') >= 0 || e.Label.IndexOf(':') >= 0 || e.Label.IndexOf('*') >= 0 || e.Label.IndexOf('?') >= 0 || e.Label.IndexOf('"') >= 0 || e.Label.IndexOf('>') >= 0 || e.Label.IndexOf('<') >= 0 || e.Label.IndexOf('|') >= 0)
            {
                MessageBox.Show("Tên tập tin hoặc thư mục không hợp lệ.\nKhông thể đặt các dấu : \\ / : * ? \" < > |", "Lỗi tên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listView1.LabelEdit = false;
                e.CancelEdit = true;
                return;
            }
            if (e.Label.ToUpper() == "CON" || (e.Label.ToUpper().Substring(0,4) == "CON."))
            {
                MessageBox.Show("Không thể đặt tên thư mục, tập tin tên này.", "Lỗi tên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listView1.LabelEdit = false;
                e.CancelEdit = true;
                return;
            }

            try
            {
                if (listView1.FocusedItem.SubItems[2].Text == "Folder")
                {
                    Directory.Move(PathNow + "\\" + listView1.FocusedItem.Text, PathNow + "\\" + e.Label);
                }
                else
                {
                    File.Move(PathNow + "\\" + listView1.FocusedItem.Text, PathNow + "\\" + e.Label);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                pasteToolStripMenuItem.Enabled = tsb_Paste.Enabled = false;
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

            pasteToolStripMenuItem.Enabled = tsb_Paste.Enabled = true;
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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool DelFolder = false;
            if (listView1.SelectedItems.Count == 0) return;
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                if (item.SubItems[2].Text == "Folder")
                {
                    Directory.Delete(PathNow + "\\" + item.Text, true);
                    DelFolder = true;
                }
                else
                {
                    File.Delete(PathNow + "\\" + item.Text);
                }
            }

            if (DelFolder)
            {
                button1_Click(btnRefresh, EventArgs.Empty);
            }
            else
            {
                LoadListView(PathNow);
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //txtPath.Text = PathNow;
            string PathNowtemp = PathNow;
            while (treeView1.Nodes.Count > 0)
            {
                treeView1.Nodes.RemoveAt(0);
            }

            InitTreeView();
            listView1.Items.Clear();
            LoadListView(PathNowtemp);
        }

        private void txtPath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGoto_Click(btnGoto, EventArgs.Empty);
            }
        }

        private void newFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FolderName = "New Folder";
            while (listView1.FindItemWithText(FolderName) != null)
            {
                FolderName += "2";
            }

            Directory.CreateDirectory(PathNow + "\\" + FolderName);

            LoadListView(PathNow);
            if (listView1.FindItemWithText(FolderName) == null)
            {
                MessageBox.Show("Lỗi tạo thư mục", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listView1.Update();
            listView1.FindItemWithText(FolderName).Selected = true;
            listView1.Update();
            listView1_KeyDown(listView1, new KeyEventArgs(Keys.F2));

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            cutToolStripMenuItem.Enabled = copyToolStripMenuItem.Enabled = deleteToolStripMenuItem.Enabled = tsb_Cut.Enabled;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tsb_Cut.Enabled = tsb_Coppy.Enabled = tsb_Delete.Enabled = listView1.SelectedItems.Count > 0;
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

