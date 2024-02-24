namespace scomp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            contextMenuStrip1 = new ContextMenuStrip(components);
            openToolStripMenuItem1 = new ToolStripMenuItem();
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            fileLocationToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            filenameToolStripMenuItem = new ToolStripMenuItem();
            hashToolStripMenuItem = new ToolStripMenuItem();
            pathToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            renameToolStripMenuItem = new ToolStripMenuItem();
            moveToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            recycleToolStripMenuItem = new ToolStripMenuItem();
            imageList1 = new ImageList(components);
            checkBox1 = new CheckBox();
            listView1 = new ListView();
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            howToToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            lblPath = new Label();
            label3 = new Label();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { openToolStripMenuItem1, copyToolStripMenuItem, toolStripMenuItem4, renameToolStripMenuItem, moveToolStripMenuItem, toolStripMenuItem2, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(118, 126);
            // 
            // openToolStripMenuItem1
            // 
            openToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { fileToolStripMenuItem1, toolStripMenuItem3, fileLocationToolStripMenuItem });
            openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            openToolStripMenuItem1.Size = new Size(117, 22);
            openToolStripMenuItem1.Text = "Open";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(141, 22);
            fileToolStripMenuItem1.Text = "File";
            fileToolStripMenuItem1.Click += fileToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(138, 6);
            // 
            // fileLocationToolStripMenuItem
            // 
            fileLocationToolStripMenuItem.Name = "fileLocationToolStripMenuItem";
            fileLocationToolStripMenuItem.Size = new Size(141, 22);
            fileLocationToolStripMenuItem.Text = "File Location";
            fileLocationToolStripMenuItem.Click += fileLocationToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { filenameToolStripMenuItem, hashToolStripMenuItem, pathToolStripMenuItem });
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(117, 22);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // filenameToolStripMenuItem
            // 
            filenameToolStripMenuItem.Name = "filenameToolStripMenuItem";
            filenameToolStripMenuItem.Size = new Size(122, 22);
            filenameToolStripMenuItem.Text = "Filename";
            filenameToolStripMenuItem.Click += filenameToolStripMenuItem_Click;
            // 
            // hashToolStripMenuItem
            // 
            hashToolStripMenuItem.Name = "hashToolStripMenuItem";
            hashToolStripMenuItem.Size = new Size(122, 22);
            hashToolStripMenuItem.Text = "Hash";
            hashToolStripMenuItem.Click += hashToolStripMenuItem_Click;
            // 
            // pathToolStripMenuItem
            // 
            pathToolStripMenuItem.Name = "pathToolStripMenuItem";
            pathToolStripMenuItem.Size = new Size(122, 22);
            pathToolStripMenuItem.Text = "Path";
            pathToolStripMenuItem.Click += pathToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(114, 6);
            // 
            // renameToolStripMenuItem
            // 
            renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            renameToolStripMenuItem.Size = new Size(117, 22);
            renameToolStripMenuItem.Text = "Rename";
            renameToolStripMenuItem.Click += renameToolStripMenuItem_Click;
            // 
            // moveToolStripMenuItem
            // 
            moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            moveToolStripMenuItem.Size = new Size(117, 22);
            moveToolStripMenuItem.Text = "Move";
            moveToolStripMenuItem.Click += moveToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(114, 6);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { recycleToolStripMenuItem });
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(117, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // recycleToolStripMenuItem
            // 
            recycleToolStripMenuItem.Name = "recycleToolStripMenuItem";
            recycleToolStripMenuItem.Size = new Size(114, 22);
            recycleToolStripMenuItem.Text = "Recycle";
            recycleToolStripMenuItem.Click += recycleToolStripMenuItem_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(24, 24);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.FromArgb(0, 192, 0);
            checkBox1.Location = new Point(823, 5);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(72, 19);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "TopMost";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.BackColor = SystemColors.Control;
            listView1.BackgroundImage = (Image)resources.GetObject("listView1.BackgroundImage");
            listView1.BackgroundImageTiled = true;
            listView1.ContextMenuStrip = contextMenuStrip1;
            listView1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.FullRowSelect = true;
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(12, 38);
            listView1.Name = "listView1";
            listView1.Size = new Size(883, 470);
            listView1.Sorting = SortOrder.Descending;
            listView1.TabIndex = 14;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.ColumnClick += listView1_ColumnClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(907, 32);
            panel1.TabIndex = 15;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(907, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(103, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { howToToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            // 
            // howToToolStripMenuItem
            // 
            howToToolStripMenuItem.Name = "howToToolStripMenuItem";
            howToToolStripMenuItem.Size = new Size(114, 22);
            howToToolStripMenuItem.Text = "How To";
            howToToolStripMenuItem.Click += howToToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblPath);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(checkBox1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 514);
            panel2.Name = "panel2";
            panel2.Size = new Size(907, 33);
            panel2.TabIndex = 16;
            // 
            // lblPath
            // 
            lblPath.ForeColor = Color.FromArgb(0, 192, 0);
            lblPath.Location = new Point(80, 9);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(578, 15);
            lblPath.TabIndex = 0;
            lblPath.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(0, 192, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 0;
            label3.Text = "Root Path:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 27, 28);
            ClientSize = new Size(907, 547);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(listView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Scomp";
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem openToolStripMenuItem1;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem fileLocationToolStripMenuItem;
        private ToolStripMenuItem renameToolStripMenuItem;
        private ToolStripMenuItem moveToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem recycleToolStripMenuItem;
        private CheckBox checkBox1;
        private ListView listView1;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem howToToolStripMenuItem;
        private Panel panel2;
        private Label label3;
        private Label lblPath;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem filenameToolStripMenuItem;
        private ToolStripMenuItem hashToolStripMenuItem;
        private ToolStripMenuItem pathToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem4;
    }
}
