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
            this.btnGoto = new System.Windows.Forms.Button();
            this.tb_Memu2 = new System.Windows.Forms.TabControl();
            this.tb_View1 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.tb_View2 = new System.Windows.Forms.TabPage();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.tb_View3 = new System.Windows.Forms.TabPage();
            this.treeView3 = new System.Windows.Forms.TreeView();
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tc_Menu1 = new System.Windows.Forms.TabControl();
            this.tb_Home = new System.Windows.Forms.TabPage();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.tsb_Add = new System.Windows.Forms.ToolStripButton();
            this.tsb_Coppy = new System.Windows.Forms.ToolStripButton();
            this.tsb_Cut = new System.Windows.Forms.ToolStripButton();
            this.tsb_Paste = new System.Windows.Forms.ToolStripButton();
            this.tsb_Delete = new System.Windows.Forms.ToolStripButton();
            this.tb_View = new System.Windows.Forms.TabPage();
            this.cbShowHidden = new System.Windows.Forms.CheckBox();
            this.cbShowImage = new System.Windows.Forms.CheckBox();
            this.cbShowOther = new System.Windows.Forms.CheckBox();
            this.cbShowFolder = new System.Windows.Forms.CheckBox();
            this.lbView = new System.Windows.Forms.Label();
            this.rb_Largeicon = new System.Windows.Forms.RadioButton();
            this.rb_Smallicon = new System.Windows.Forms.RadioButton();
            this.rb_Title = new System.Windows.Forms.RadioButton();
            this.rb_Details = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tb_Memu2.SuspendLayout();
            this.tb_View1.SuspendLayout();
            this.tb_View2.SuspendLayout();
            this.tb_View3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.panel3.Controls.Add(this.btnGoto);
            this.panel3.Controls.Add(this.tb_Memu2);
            this.panel3.Controls.Add(this.toolStrip1);
            this.panel3.Controls.Add(this.txtPath);
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(713, 403);
            this.panel3.TabIndex = 3;
            // 
            // btnGoto
            // 
            this.btnGoto.Enabled = false;
            this.btnGoto.Location = new System.Drawing.Point(660, 0);
            this.btnGoto.Name = "btnGoto";
            this.btnGoto.Size = new System.Drawing.Size(49, 21);
            this.btnGoto.TabIndex = 4;
            this.btnGoto.Text = "Goto";
            this.btnGoto.UseVisualStyleBackColor = true;
            this.btnGoto.Click += new System.EventHandler(this.btnGoto_Click);
            // 
            // tb_Memu2
            // 
            this.tb_Memu2.Controls.Add(this.tb_View1);
            this.tb_Memu2.Controls.Add(this.tb_View2);
            this.tb_Memu2.Controls.Add(this.tb_View3);
            this.tb_Memu2.Location = new System.Drawing.Point(0, 29);
            this.tb_Memu2.Name = "tb_Memu2";
            this.tb_Memu2.SelectedIndex = 0;
            this.tb_Memu2.Size = new System.Drawing.Size(200, 374);
            this.tb_Memu2.TabIndex = 3;
            this.tb_Memu2.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tb_Memu2_Selecting);
            // 
            // tb_View1
            // 
            this.tb_View1.Controls.Add(this.treeView1);
            this.tb_View1.Location = new System.Drawing.Point(4, 22);
            this.tb_View1.Name = "tb_View1";
            this.tb_View1.Padding = new System.Windows.Forms.Padding(3);
            this.tb_View1.Size = new System.Drawing.Size(192, 348);
            this.tb_View1.TabIndex = 0;
            this.tb_View1.Text = "CheDo1";
            this.tb_View1.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.FullRowSelect = true;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList2;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(186, 342);
            this.treeView1.TabIndex = 0;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView1_KeyDown);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "folder.png");
            // 
            // tb_View2
            // 
            this.tb_View2.Controls.Add(this.webBrowser);
            this.tb_View2.Controls.Add(this.treeView2);
            this.tb_View2.Location = new System.Drawing.Point(4, 22);
            this.tb_View2.Name = "tb_View2";
            this.tb_View2.Padding = new System.Windows.Forms.Padding(3);
            this.tb_View2.Size = new System.Drawing.Size(192, 348);
            this.tb_View2.TabIndex = 1;
            this.tb_View2.Text = "CheDo2";
            this.tb_View2.UseVisualStyleBackColor = true;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(3, 3);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(186, 342);
            this.webBrowser.TabIndex = 1;
            // 
            // treeView2
            // 
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView2.Location = new System.Drawing.Point(3, 3);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(186, 342);
            this.treeView2.TabIndex = 0;
            // 
            // tb_View3
            // 
            this.tb_View3.Controls.Add(this.treeView3);
            this.tb_View3.Location = new System.Drawing.Point(4, 22);
            this.tb_View3.Name = "tb_View3";
            this.tb_View3.Padding = new System.Windows.Forms.Padding(3);
            this.tb_View3.Size = new System.Drawing.Size(192, 348);
            this.tb_View3.TabIndex = 2;
            this.tb_View3.Text = "CheDo3";
            this.tb_View3.UseVisualStyleBackColor = true;
            // 
            // treeView3
            // 
            this.treeView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView3.Location = new System.Drawing.Point(3, 3);
            this.treeView3.Name = "treeView3";
            this.treeView3.Size = new System.Drawing.Size(186, 342);
            this.treeView3.TabIndex = 0;
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
            this.tsb_Previous.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Previous.Image")));
            this.tsb_Previous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Previous.Name = "tsb_Previous";
            this.tsb_Previous.Size = new System.Drawing.Size(23, 22);
            this.tsb_Previous.Text = "Back";
            // 
            // tsb_Next
            // 
            this.tsb_Next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
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
            this.txtPath.Size = new System.Drawing.Size(580, 20);
            this.txtPath.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_name,
            this.ch_Date,
            this.ch_Type,
            this.ch_Size});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(202, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(511, 352);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 1;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
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
            this.tsb_Add,
            this.tsb_Coppy,
            this.tsb_Cut,
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
            // tsb_Add
            // 
            this.tsb_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Add.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Add.Image")));
            this.tsb_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Add.Name = "tsb_Add";
            this.tsb_Add.Size = new System.Drawing.Size(34, 46);
            this.tsb_Add.Text = "Add new item";
            this.tsb_Add.Click += new System.EventHandler(this.tsb_Add_Click);
            // 
            // tsb_Coppy
            // 
            this.tsb_Coppy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Coppy.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Coppy.Image")));
            this.tsb_Coppy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Coppy.Name = "tsb_Coppy";
            this.tsb_Coppy.Size = new System.Drawing.Size(34, 46);
            this.tsb_Coppy.Text = "Coppy";
            // 
            // tsb_Cut
            // 
            this.tsb_Cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Cut.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Cut.Image")));
            this.tsb_Cut.ImageTransparentColor = System.Drawing.Color.White;
            this.tsb_Cut.Name = "tsb_Cut";
            this.tsb_Cut.Size = new System.Drawing.Size(34, 46);
            this.tsb_Cut.Text = "Cut";
            // 
            // tsb_Paste
            // 
            this.tsb_Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Paste.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Paste.Image")));
            this.tsb_Paste.ImageTransparentColor = System.Drawing.Color.White;
            this.tsb_Paste.Name = "tsb_Paste";
            this.tsb_Paste.Size = new System.Drawing.Size(34, 46);
            this.tsb_Paste.Text = "Paste";
            // 
            // tsb_Delete
            // 
            this.tsb_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Delete.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Delete.Image")));
            this.tsb_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Delete.Name = "tsb_Delete";
            this.tsb_Delete.Size = new System.Drawing.Size(34, 46);
            this.tsb_Delete.Text = "Delete";
            this.tsb_Delete.Click += new System.EventHandler(this.tsb_Delete_Click);
            // 
            // tb_View
            // 
            this.tb_View.Controls.Add(this.cbShowHidden);
            this.tb_View.Controls.Add(this.cbShowImage);
            this.tb_View.Controls.Add(this.cbShowOther);
            this.tb_View.Controls.Add(this.cbShowFolder);
            this.tb_View.Controls.Add(this.lbView);
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
            // cbShowHidden
            // 
            this.cbShowHidden.AutoSize = true;
            this.cbShowHidden.Location = new System.Drawing.Point(242, 7);
            this.cbShowHidden.Name = "cbShowHidden";
            this.cbShowHidden.Size = new System.Drawing.Size(60, 17);
            this.cbShowHidden.TabIndex = 9;
            this.cbShowHidden.Text = "Hidden";
            this.cbShowHidden.UseVisualStyleBackColor = true;
            // 
            // cbShowImage
            // 
            this.cbShowImage.AutoSize = true;
            this.cbShowImage.Location = new System.Drawing.Point(304, 7);
            this.cbShowImage.Name = "cbShowImage";
            this.cbShowImage.Size = new System.Drawing.Size(55, 17);
            this.cbShowImage.TabIndex = 8;
            this.cbShowImage.Text = "Image";
            this.cbShowImage.UseVisualStyleBackColor = true;
            // 
            // cbShowOther
            // 
            this.cbShowOther.AutoSize = true;
            this.cbShowOther.Location = new System.Drawing.Point(243, 30);
            this.cbShowOther.Name = "cbShowOther";
            this.cbShowOther.Size = new System.Drawing.Size(52, 17);
            this.cbShowOther.TabIndex = 7;
            this.cbShowOther.Text = "Other";
            this.cbShowOther.UseVisualStyleBackColor = true;
            // 
            // cbShowFolder
            // 
            this.cbShowFolder.AutoSize = true;
            this.cbShowFolder.Location = new System.Drawing.Point(304, 30);
            this.cbShowFolder.Name = "cbShowFolder";
            this.cbShowFolder.Size = new System.Drawing.Size(55, 17);
            this.cbShowFolder.TabIndex = 6;
            this.cbShowFolder.Text = "Folder";
            this.cbShowFolder.UseVisualStyleBackColor = true;
            // 
            // lbView
            // 
            this.lbView.AutoSize = true;
            this.lbView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbView.Location = new System.Drawing.Point(195, 5);
            this.lbView.Name = "lbView";
            this.lbView.Size = new System.Drawing.Size(41, 16);
            this.lbView.TabIndex = 5;
            this.lbView.Text = "Show";
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
            this.tb_Memu2.ResumeLayout(false);
            this.tb_View1.ResumeLayout(false);
            this.tb_View2.ResumeLayout(false);
            this.tb_View3.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton tsb_Add;
        private System.Windows.Forms.RadioButton rb_Largeicon;
        private System.Windows.Forms.RadioButton rb_Smallicon;
        private System.Windows.Forms.RadioButton rb_Title;
        private System.Windows.Forms.RadioButton rb_Details;
        private System.Windows.Forms.TabControl tb_Memu2;
        private System.Windows.Forms.TabPage tb_View1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage tb_View2;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.TabPage tb_View3;
        private System.Windows.Forms.TreeView treeView3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.CheckBox cbShowImage;
        private System.Windows.Forms.CheckBox cbShowOther;
        private System.Windows.Forms.CheckBox cbShowFolder;
        private System.Windows.Forms.Label lbView;
        private System.Windows.Forms.CheckBox cbShowHidden;
        private System.Windows.Forms.Button btnGoto;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

