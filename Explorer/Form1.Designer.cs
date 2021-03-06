﻿namespace Explorer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnGoto = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_Previous = new System.Windows.Forms.ToolStripButton();
            this.tsb_Next = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ch_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LargeIcon = new System.Windows.Forms.ImageList(this.components);
            this.SmallIcon = new System.Windows.Forms.ImageList(this.components);
            this.tc_Menu1 = new System.Windows.Forms.TabControl();
            this.tb_Home = new System.Windows.Forms.TabPage();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.tsb_Cut = new System.Windows.Forms.ToolStripButton();
            this.tsb_Coppy = new System.Windows.Forms.ToolStripButton();
            this.tsb_Paste = new System.Windows.Forms.ToolStripButton();
            this.tsb_Delete = new System.Windows.Forms.ToolStripButton();
            this.tb_View = new System.Windows.Forms.TabPage();
            this.rb_Largeicon = new System.Windows.Forms.RadioButton();
            this.rb_Smallicon = new System.Windows.Forms.RadioButton();
            this.rb_Title = new System.Windows.Forms.RadioButton();
            this.rb_Details = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tc_Menu1.SuspendLayout();
            this.tb_Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tb_View.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 403);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.treeView1);
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.btnGoto);
            this.panel3.Controls.Add(this.toolStrip1);
            this.panel3.Controls.Add(this.txtPath);
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(713, 403);
            this.panel3.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.FullRowSelect = true;
            this.treeView1.HideSelection = false;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 26);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(198, 374);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView1_KeyDown);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "images.png");
            this.imageList1.Images.SetKeyName(1, "folder.png");
            this.imageList1.Images.SetKeyName(2, "download.png");
            this.imageList1.Images.SetKeyName(3, "pc.png");
            this.imageList1.Images.SetKeyName(4, "document.png");
            this.imageList1.Images.SetKeyName(5, "music.png");
            this.imageList1.Images.SetKeyName(6, "folder");
            this.imageList1.Images.SetKeyName(7, "folder open");
            this.imageList1.Images.SetKeyName(8, "refresh");
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.ImageKey = "refresh";
            this.btnRefresh.ImageList = this.imageList1;
            this.btnRefresh.Location = new System.Drawing.Point(640, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(21, 21);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGoto
            // 
            this.btnGoto.Location = new System.Drawing.Point(660, 0);
            this.btnGoto.Name = "btnGoto";
            this.btnGoto.Size = new System.Drawing.Size(49, 21);
            this.btnGoto.TabIndex = 4;
            this.btnGoto.Text = "Goto";
            this.btnGoto.UseVisualStyleBackColor = true;
            this.btnGoto.Click += new System.EventHandler(this.btnGoto_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Previous,
            this.tsb_Next,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(7, -2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(64, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsb_Previous
            // 
            this.tsb_Previous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Previous.Enabled = false;
            this.tsb_Previous.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Previous.Image")));
            this.tsb_Previous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Previous.Name = "tsb_Previous";
            this.tsb_Previous.Size = new System.Drawing.Size(23, 22);
            this.tsb_Previous.Text = "Back";
            // 
            // tsb_Next
            // 
            this.tsb_Next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Next.Enabled = false;
            this.tsb_Next.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Next.Image")));
            this.tsb_Next.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Next.Name = "tsb_Next";
            this.tsb_Next.Size = new System.Drawing.Size(23, 22);
            this.tsb_Next.Text = "Next";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(74, 0);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(560, 20);
            this.txtPath.TabIndex = 2;
            this.txtPath.Text = "\\";
            this.txtPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPath_KeyDown);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_name,
            this.ch_Date,
            this.ch_Type,
            this.ch_Size});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.LargeIcon;
            this.listView1.Location = new System.Drawing.Point(202, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(511, 377);
            this.listView1.SmallImageList = this.SmallIcon;
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 1;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_AfterLabelEdit);
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            // 
            // ch_name
            // 
            this.ch_name.Text = "Name";
            this.ch_name.Width = 196;
            // 
            // ch_Date
            // 
            this.ch_Date.Text = "Date Modified";
            this.ch_Date.Width = 145;
            // 
            // ch_Type
            // 
            this.ch_Type.Text = "Type";
            this.ch_Type.Width = 75;
            // 
            // ch_Size
            // 
            this.ch_Size.Text = "Size";
            this.ch_Size.Width = 99;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.newFolderToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Enabled = false;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // newFolderToolStripMenuItem
            // 
            this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
            this.newFolderToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.newFolderToolStripMenuItem.Text = "New Folder";
            this.newFolderToolStripMenuItem.Click += new System.EventHandler(this.newFolderToolStripMenuItem_Click);
            // 
            // LargeIcon
            // 
            this.LargeIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("LargeIcon.ImageStream")));
            this.LargeIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.LargeIcon.Images.SetKeyName(0, "folder");
            // 
            // SmallIcon
            // 
            this.SmallIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SmallIcon.ImageStream")));
            this.SmallIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.SmallIcon.Images.SetKeyName(0, "folder");
            // 
            // tc_Menu1
            // 
            this.tc_Menu1.Controls.Add(this.tb_Home);
            this.tc_Menu1.Controls.Add(this.tb_View);
            this.tc_Menu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tc_Menu1.Location = new System.Drawing.Point(0, 0);
            this.tc_Menu1.Name = "tc_Menu1";
            this.tc_Menu1.SelectedIndex = 0;
            this.tc_Menu1.Size = new System.Drawing.Size(713, 81);
            this.tc_Menu1.TabIndex = 2;
            // 
            // tb_Home
            // 
            this.tb_Home.Controls.Add(this.bindingNavigator1);
            this.tb_Home.Location = new System.Drawing.Point(4, 22);
            this.tb_Home.Name = "tb_Home";
            this.tb_Home.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Home.Size = new System.Drawing.Size(705, 55);
            this.tb_Home.TabIndex = 0;
            this.tb_Home.Text = "Home";
            this.tb_Home.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Cut,
            this.tsb_Coppy,
            this.tsb_Paste,
            this.tsb_Delete});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(699, 49);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // tsb_Cut
            // 
            this.tsb_Cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Cut.Enabled = false;
            this.tsb_Cut.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Cut.Image")));
            this.tsb_Cut.ImageTransparentColor = System.Drawing.Color.White;
            this.tsb_Cut.Name = "tsb_Cut";
            this.tsb_Cut.Size = new System.Drawing.Size(34, 46);
            this.tsb_Cut.Text = "Cut";
            this.tsb_Cut.Click += new System.EventHandler(this.tsb_Cut_Click);
            // 
            // tsb_Coppy
            // 
            this.tsb_Coppy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Coppy.Enabled = false;
            this.tsb_Coppy.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Coppy.Image")));
            this.tsb_Coppy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Coppy.Name = "tsb_Coppy";
            this.tsb_Coppy.Size = new System.Drawing.Size(34, 46);
            this.tsb_Coppy.Text = "Coppy";
            this.tsb_Coppy.Click += new System.EventHandler(this.tsb_Coppy_Click);
            // 
            // tsb_Paste
            // 
            this.tsb_Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Paste.Enabled = false;
            this.tsb_Paste.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Paste.Image")));
            this.tsb_Paste.ImageTransparentColor = System.Drawing.Color.White;
            this.tsb_Paste.Name = "tsb_Paste";
            this.tsb_Paste.Size = new System.Drawing.Size(34, 46);
            this.tsb_Paste.Text = "Paste";
            this.tsb_Paste.Click += new System.EventHandler(this.tsb_Paste_Click);
            // 
            // tsb_Delete
            // 
            this.tsb_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Delete.Enabled = false;
            this.tsb_Delete.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Delete.Image")));
            this.tsb_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Delete.Name = "tsb_Delete";
            this.tsb_Delete.Size = new System.Drawing.Size(34, 46);
            this.tsb_Delete.Text = "Delete";
            this.tsb_Delete.Click += new System.EventHandler(this.tsb_Delete_Click);
            // 
            // tb_View
            // 
            this.tb_View.Controls.Add(this.rb_Largeicon);
            this.tb_View.Controls.Add(this.rb_Smallicon);
            this.tb_View.Controls.Add(this.rb_Title);
            this.tb_View.Controls.Add(this.rb_Details);
            this.tb_View.Location = new System.Drawing.Point(4, 22);
            this.tb_View.Name = "tb_View";
            this.tb_View.Padding = new System.Windows.Forms.Padding(3);
            this.tb_View.Size = new System.Drawing.Size(705, 55);
            this.tb_View.TabIndex = 1;
            this.tb_View.Text = "View";
            this.tb_View.UseVisualStyleBackColor = true;
            // 
            // rb_Largeicon
            // 
            this.rb_Largeicon.AutoSize = true;
            this.rb_Largeicon.Location = new System.Drawing.Point(65, 29);
            this.rb_Largeicon.Name = "rb_Largeicon";
            this.rb_Largeicon.Size = new System.Drawing.Size(76, 17);
            this.rb_Largeicon.TabIndex = 4;
            this.rb_Largeicon.Text = "Large Icon";
            this.rb_Largeicon.UseVisualStyleBackColor = true;
            this.rb_Largeicon.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_Smallicon
            // 
            this.rb_Smallicon.AutoSize = true;
            this.rb_Smallicon.Location = new System.Drawing.Point(65, 6);
            this.rb_Smallicon.Name = "rb_Smallicon";
            this.rb_Smallicon.Size = new System.Drawing.Size(74, 17);
            this.rb_Smallicon.TabIndex = 3;
            this.rb_Smallicon.Text = "Small Icon";
            this.rb_Smallicon.UseVisualStyleBackColor = true;
            this.rb_Smallicon.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_Title
            // 
            this.rb_Title.AutoSize = true;
            this.rb_Title.Location = new System.Drawing.Point(6, 29);
            this.rb_Title.Name = "rb_Title";
            this.rb_Title.Size = new System.Drawing.Size(45, 17);
            this.rb_Title.TabIndex = 2;
            this.rb_Title.Text = "Title";
            this.rb_Title.UseVisualStyleBackColor = true;
            this.rb_Title.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_Details
            // 
            this.rb_Details.AutoSize = true;
            this.rb_Details.Checked = true;
            this.rb_Details.Location = new System.Drawing.Point(6, 6);
            this.rb_Details.Name = "rb_Details";
            this.rb_Details.Size = new System.Drawing.Size(57, 17);
            this.rb_Details.TabIndex = 1;
            this.rb_Details.TabStop = true;
            this.rb_Details.Text = "Details";
            this.rb_Details.UseVisualStyleBackColor = true;
            this.rb_Details.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 403);
            this.panel2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 484);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tc_Menu1);
            this.Name = "Form1";
            this.Text = "Explorer";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tc_Menu1.ResumeLayout(false);
            this.tb_Home.ResumeLayout(false);
            this.tb_Home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tb_View.ResumeLayout(false);
            this.tb_View.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabControl tc_Menu1;
        private System.Windows.Forms.TabPage tb_Home;
        private System.Windows.Forms.TabPage tb_View;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColumnHeader ch_name;
        private System.Windows.Forms.ColumnHeader ch_Date;
        private System.Windows.Forms.ColumnHeader ch_Type;
        private System.Windows.Forms.ColumnHeader ch_Size;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton tsb_Cut;
        private System.Windows.Forms.ToolStripButton tsb_Paste;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_Previous;
        private System.Windows.Forms.ToolStripButton tsb_Next;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsb_Coppy;
        private System.Windows.Forms.ToolStripButton tsb_Delete;
        private System.Windows.Forms.RadioButton rb_Largeicon;
        private System.Windows.Forms.RadioButton rb_Smallicon;
        private System.Windows.Forms.RadioButton rb_Title;
        private System.Windows.Forms.RadioButton rb_Details;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnGoto;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList LargeIcon;
        private System.Windows.Forms.ImageList SmallIcon;
        private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem;
    }
}

