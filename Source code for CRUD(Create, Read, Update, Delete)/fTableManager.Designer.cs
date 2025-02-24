namespace hihi
{
    partial class fTableManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTableManager));
            menuStrip1 = new MenuStrip();
            toolStripMenuHome = new ToolStripMenuItem();
            toolStripMenuIfunction = new ToolStripMenuItem();
            toolStripMenuIaccount = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem1 = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            lbltitlehomepage = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DeepSkyBlue;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuHome, toolStripMenuIfunction, toolStripMenuIaccount });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5);
            menuStrip1.Size = new Size(790, 44);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuHome
            // 
            toolStripMenuHome.BackColor = Color.Transparent;
            toolStripMenuHome.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            toolStripMenuHome.ForeColor = SystemColors.ButtonFace;
            toolStripMenuHome.Name = "toolStripMenuHome";
            toolStripMenuHome.Padding = new Padding(5);
            toolStripMenuHome.RightToLeft = RightToLeft.No;
            toolStripMenuHome.Size = new Size(91, 34);
            toolStripMenuHome.Text = "Trang chủ";
            toolStripMenuHome.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuIfunction
            // 
            toolStripMenuIfunction.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            toolStripMenuIfunction.ForeColor = SystemColors.ButtonFace;
            toolStripMenuIfunction.Name = "toolStripMenuIfunction";
            toolStripMenuIfunction.Padding = new Padding(5);
            toolStripMenuIfunction.RightToLeft = RightToLeft.No;
            toolStripMenuIfunction.Size = new Size(96, 34);
            toolStripMenuIfunction.Text = "Chức năng";
            toolStripMenuIfunction.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuIaccount
            // 
            toolStripMenuIaccount.Alignment = ToolStripItemAlignment.Right;
            toolStripMenuIaccount.DropDownItems.AddRange(new ToolStripItem[] { thôngTinCáNhânToolStripMenuItem, đăngXuấtToolStripMenuItem, đăngXuấtToolStripMenuItem1 });
            toolStripMenuIaccount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            toolStripMenuIaccount.ForeColor = SystemColors.ButtonFace;
            toolStripMenuIaccount.Name = "toolStripMenuIaccount";
            toolStripMenuIaccount.Padding = new Padding(5);
            toolStripMenuIaccount.RightToLeft = RightToLeft.No;
            toolStripMenuIaccount.Size = new Size(89, 34);
            toolStripMenuIaccount.Text = "Tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Size = new Size(216, 26);
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            thôngTinCáNhânToolStripMenuItem.Click += thôngTinCáNhânToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(216, 26);
            đăngXuấtToolStripMenuItem.Text = "Đổi mật khẩu";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem1
            // 
            đăngXuấtToolStripMenuItem1.Name = "đăngXuấtToolStripMenuItem1";
            đăngXuấtToolStripMenuItem1.Size = new Size(216, 26);
            đăngXuấtToolStripMenuItem1.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem1.Click += đăngXuấtToolStripMenuItem1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._2776a46468188ac77c3f1f473c3fb311;
            pictureBox1.Location = new Point(137, 139);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(513, 293);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lbltitlehomepage
            // 
            lbltitlehomepage.AutoSize = true;
            lbltitlehomepage.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltitlehomepage.ForeColor = Color.DodgerBlue;
            lbltitlehomepage.Location = new Point(153, 95);
            lbltitlehomepage.Name = "lbltitlehomepage";
            lbltitlehomepage.Size = new Size(486, 41);
            lbltitlehomepage.TabIndex = 2;
            lbltitlehomepage.Text = "Chào mừng đến với Mân's Home!";
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 504);
            Controls.Add(lbltitlehomepage);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "fTableManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ";
            Load += fTableManager_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuHome;
        private ToolStripMenuItem toolStripMenuIaccount;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label lbltitlehomepage;
        private ToolStripMenuItem toolStripMenuIfunction;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem1;
    }
}