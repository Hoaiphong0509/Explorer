namespace Explorer
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Document");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Music");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Video");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Images");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("MyComputer", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ch_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.rb_SortbyName = new System.Windows.Forms.RadioButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tc_Home = new System.Windows.Forms.TabControl();
            this.tb_Home = new System.Windows.Forms.TabPage();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bnb_Create = new System.Windows.Forms.ToolStripButton();
            this.bnb_Delete = new System.Windows.Forms.ToolStripButton();
            this.bnb_previous = new System.Windows.Forms.ToolStripButton();
            this.bnb_next = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bnb_Cut = new System.Windows.Forms.ToolStripButton();
            this.bnb_Paste = new System.Windows.Forms.ToolStripButton();
            this.tb_View = new System.Windows.Forms.TabPage();
            this.rb_Size = new System.Windows.Forms.RadioButton();
            this.rb_Type = new System.Windows.Forms.RadioButton();
            this.rb_Date = new System.Windows.Forms.RadioButton();
            this.rb_Name = new System.Windows.Forms.RadioButton();
            this.lb_Sort = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tc_Home.SuspendLayout();
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
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Controls.Add(this.rb_SortbyName);
            this.panel3.Controls.Add(this.treeView1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(705, 477);
            this.panel3.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_name,
            this.ch_Date,
            this.ch_Type,
            this.ch_Size});
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(202, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(503, 477);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // rb_SortbyName
            // 
            this.rb_SortbyName.AutoSize = true;
            this.rb_SortbyName.Location = new System.Drawing.Point(322, 35);
            this.rb_SortbyName.Name = "rb_SortbyName";
            this.rb_SortbyName.Size = new System.Drawing.Size(87, 17);
            this.rb_SortbyName.TabIndex = 0;
            this.rb_SortbyName.TabStop = true;
            this.rb_SortbyName.Text = "Sort by name";
            this.rb_SortbyName.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "tne_Document";
            treeNode1.Text = "Document";
            treeNode2.Name = "tne_Music";
            treeNode2.Text = "Music";
            treeNode3.Name = "tne_Video";
            treeNode3.Text = "Video";
            treeNode4.Name = "tne_Images";
            treeNode4.Text = "Images";
            treeNode5.Name = "tne_Computer";
            treeNode5.Text = "MyComputer";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(202, 477);
            this.treeView1.TabIndex = 0;
            // 
            // tc_Home
            // 
            this.tc_Home.Controls.Add(this.tb_Home);
            this.tc_Home.Controls.Add(this.tb_View);
            this.tc_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.tc_Home.Location = new System.Drawing.Point(0, 0);
            this.tc_Home.Name = "tc_Home";
            this.tc_Home.SelectedIndex = 0;
            this.tc_Home.Size = new System.Drawing.Size(713, 81);
            this.tc_Home.TabIndex = 2;
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
            this.bindingNavigator1.AddNewItem = this.bnb_Create;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = this.bnb_Delete;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bnb_previous,
            this.bnb_next,
            this.bindingNavigatorSeparator2,
            this.bnb_Create,
            this.bnb_Delete,
            this.bnb_Cut,
            this.bnb_Paste});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = this.bnb_next;
            this.bindingNavigator1.MovePreviousItem = this.bnb_previous;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(699, 49);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bnb_Create
            // 
            this.bnb_Create.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnb_Create.Image = ((System.Drawing.Image)(resources.GetObject("bnb_Create.Image")));
            this.bnb_Create.ImageTransparentColor = System.Drawing.Color.Aqua;
            this.bnb_Create.Name = "bnb_Create";
            this.bnb_Create.Size = new System.Drawing.Size(23, 46);
            this.bnb_Create.Text = "Add new";
            // 
            // bnb_Delete
            // 
            this.bnb_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnb_Delete.Image = ((System.Drawing.Image)(resources.GetObject("bnb_Delete.Image")));
            this.bnb_Delete.ImageTransparentColor = System.Drawing.Color.White;
            this.bnb_Delete.Name = "bnb_Delete";
            this.bnb_Delete.Size = new System.Drawing.Size(23, 46);
            this.bnb_Delete.Text = "Delete";
            // 
            // bnb_previous
            // 
            this.bnb_previous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnb_previous.Image = ((System.Drawing.Image)(resources.GetObject("bnb_previous.Image")));
            this.bnb_previous.ImageTransparentColor = System.Drawing.Color.White;
            this.bnb_previous.Name = "bnb_previous";
            this.bnb_previous.RightToLeftAutoMirrorImage = true;
            this.bnb_previous.Size = new System.Drawing.Size(23, 46);
            this.bnb_previous.Text = "Move previous";
            // 
            // bnb_next
            // 
            this.bnb_next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnb_next.Image = ((System.Drawing.Image)(resources.GetObject("bnb_next.Image")));
            this.bnb_next.ImageTransparentColor = System.Drawing.Color.White;
            this.bnb_next.Name = "bnb_next";
            this.bnb_next.RightToLeftAutoMirrorImage = true;
            this.bnb_next.Size = new System.Drawing.Size(23, 46);
            this.bnb_next.Text = "Move next";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 49);
            // 
            // bnb_Cut
            // 
            this.bnb_Cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnb_Cut.Image = ((System.Drawing.Image)(resources.GetObject("bnb_Cut.Image")));
            this.bnb_Cut.ImageTransparentColor = System.Drawing.Color.White;
            this.bnb_Cut.Name = "bnb_Cut";
            this.bnb_Cut.Size = new System.Drawing.Size(23, 46);
            this.bnb_Cut.Text = "Cut";
            // 
            // bnb_Paste
            // 
            this.bnb_Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnb_Paste.Image = ((System.Drawing.Image)(resources.GetObject("bnb_Paste.Image")));
            this.bnb_Paste.ImageTransparentColor = System.Drawing.Color.White;
            this.bnb_Paste.Name = "bnb_Paste";
            this.bnb_Paste.Size = new System.Drawing.Size(23, 46);
            this.bnb_Paste.Text = "Paste";
            // 
            // tb_View
            // 
            this.tb_View.Controls.Add(this.rb_Size);
            this.tb_View.Controls.Add(this.rb_Type);
            this.tb_View.Controls.Add(this.rb_Date);
            this.tb_View.Controls.Add(this.rb_Name);
            this.tb_View.Controls.Add(this.lb_Sort);
            this.tb_View.Location = new System.Drawing.Point(4, 22);
            this.tb_View.Name = "tb_View";
            this.tb_View.Padding = new System.Windows.Forms.Padding(3);
            this.tb_View.Size = new System.Drawing.Size(705, 55);
            this.tb_View.TabIndex = 1;
            this.tb_View.Text = "View";
            this.tb_View.UseVisualStyleBackColor = true;
            // 
            // rb_Size
            // 
            this.rb_Size.AutoSize = true;
            this.rb_Size.Location = new System.Drawing.Point(107, 29);
            this.rb_Size.Name = "rb_Size";
            this.rb_Size.Size = new System.Drawing.Size(45, 17);
            this.rb_Size.TabIndex = 4;
            this.rb_Size.Text = "Size";
            this.rb_Size.UseVisualStyleBackColor = true;
            // 
            // rb_Type
            // 
            this.rb_Type.AutoSize = true;
            this.rb_Type.Location = new System.Drawing.Point(107, 6);
            this.rb_Type.Name = "rb_Type";
            this.rb_Type.Size = new System.Drawing.Size(49, 17);
            this.rb_Type.TabIndex = 3;
            this.rb_Type.Text = "Type";
            this.rb_Type.UseVisualStyleBackColor = true;
            // 
            // rb_Date
            // 
            this.rb_Date.AutoSize = true;
            this.rb_Date.Location = new System.Drawing.Point(48, 29);
            this.rb_Date.Name = "rb_Date";
            this.rb_Date.Size = new System.Drawing.Size(48, 17);
            this.rb_Date.TabIndex = 2;
            this.rb_Date.Text = "Date";
            this.rb_Date.UseVisualStyleBackColor = true;
            // 
            // rb_Name
            // 
            this.rb_Name.AutoSize = true;
            this.rb_Name.Checked = true;
            this.rb_Name.Location = new System.Drawing.Point(48, 6);
            this.rb_Name.Name = "rb_Name";
            this.rb_Name.Size = new System.Drawing.Size(53, 17);
            this.rb_Name.TabIndex = 1;
            this.rb_Name.TabStop = true;
            this.rb_Name.Text = "Name";
            this.rb_Name.UseVisualStyleBackColor = true;
            // 
            // lb_Sort
            // 
            this.lb_Sort.AutoSize = true;
            this.lb_Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Sort.Location = new System.Drawing.Point(3, 13);
            this.lb_Sort.Name = "lb_Sort";
            this.lb_Sort.Size = new System.Drawing.Size(39, 20);
            this.lb_Sort.TabIndex = 0;
            this.lb_Sort.Text = "Sort";
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
            this.Controls.Add(this.tc_Home);
            this.Name = "Form1";
            this.Text = "Explorer";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tc_Home.ResumeLayout(false);
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
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl tc_Home;
        private System.Windows.Forms.TabPage tb_Home;
        private System.Windows.Forms.TabPage tb_View;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColumnHeader ch_name;
        private System.Windows.Forms.ColumnHeader ch_Date;
        private System.Windows.Forms.ColumnHeader ch_Type;
        private System.Windows.Forms.ColumnHeader ch_Size;
        private System.Windows.Forms.RadioButton rb_SortbyName;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bnb_Create;
        private System.Windows.Forms.ToolStripButton bnb_Delete;
        private System.Windows.Forms.ToolStripButton bnb_previous;
        private System.Windows.Forms.ToolStripButton bnb_next;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bnb_Cut;
        private System.Windows.Forms.ToolStripButton bnb_Paste;
        private System.Windows.Forms.Label lb_Sort;
        private System.Windows.Forms.RadioButton rb_Name;
        private System.Windows.Forms.RadioButton rb_Size;
        private System.Windows.Forms.RadioButton rb_Type;
        private System.Windows.Forms.RadioButton rb_Date;
    }
}

