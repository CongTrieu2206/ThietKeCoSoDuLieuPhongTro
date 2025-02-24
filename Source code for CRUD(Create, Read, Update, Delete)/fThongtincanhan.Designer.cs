namespace hihi
{
    partial class fThongtincanhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThongtincanhan));
            pictureBox2 = new PictureBox();
            label1 = new Label();
            lblHoten = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            lblSDT = new Label();
            label4 = new Label();
            btnExit = new Button();
            panel3 = new Panel();
            lblCCCD = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.account_avatar_face_man_people_profile_user_icon_123197;
            pictureBox2.Location = new Point(124, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(122, 113);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 15);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 3;
            label1.Text = "Họ và tên:";
            label1.Click += label1_Click;
            // 
            // lblHoten
            // 
            lblHoten.AutoSize = true;
            lblHoten.Location = new Point(135, 15);
            lblHoten.Name = "lblHoten";
            lblHoten.Size = new Size(111, 20);
            lblHoten.TabIndex = 4;
            lblHoten.Text = "Nguyễn Thị Dịu";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblHoten);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(51, 141);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 49);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblSDT);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(51, 196);
            panel2.Name = "panel2";
            panel2.Size = new Size(281, 49);
            panel2.TabIndex = 6;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(135, 15);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(89, 20);
            lblSDT.TabIndex = 4;
            lblSDT.Text = "0855052510";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 15);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại:";
            label4.Click += label4_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(231, 322);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(101, 46);
            btnExit.TabIndex = 7;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblCCCD);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(51, 251);
            panel3.Name = "panel3";
            panel3.Size = new Size(281, 49);
            panel3.TabIndex = 7;
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Location = new Point(135, 15);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(89, 20);
            lblCCCD.TabIndex = 4;
            lblCCCD.Text = "0855052510";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 15);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 3;
            label6.Text = "Số CCCD:";
            // 
            // fThongtincanhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 404);
            Controls.Add(panel3);
            Controls.Add(btnExit);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fThongtincanhan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin cá nhân";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label1;
        private Label lblHoten;
        private Panel panel1;
        private Panel panel2;
        private Label lblSDT;
        private Label label4;
        private Button btnExit;
        private Panel panel3;
        private Label lblCCCD;
        private Label label6;
    }
}