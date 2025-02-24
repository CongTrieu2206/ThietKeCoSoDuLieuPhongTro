namespace hihi
{
    partial class fChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChangePassword));
            panel1 = new Panel();
            panel5 = new Panel();
            label2 = new Label();
            textBox2 = new TextBox();
            panel4 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            btnLogin = new Button();
            panel3 = new Panel();
            lblPassword = new Label();
            txtBPassword = new TextBox();
            panel2 = new Panel();
            lblUsername = new Label();
            txtBUsername = new TextBox();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(655, 394);
            panel1.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(label2);
            panel5.Controls.Add(textBox2);
            panel5.Location = new Point(55, 273);
            panel5.Name = "panel5";
            panel5.Size = new Size(555, 43);
            panel5.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F);
            label2.Location = new Point(23, 12);
            label2.Name = "label2";
            label2.Size = new Size(156, 23);
            label2.TabIndex = 2;
            label2.Text = "Nhập lại mật khẩu:";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(185, 8);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(299, 27);
            textBox2.TabIndex = 1;
            textBox2.UseSystemPasswordChar = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(label1);
            panel4.Controls.Add(textBox1);
            panel4.Location = new Point(55, 224);
            panel4.Name = "panel4";
            panel4.Size = new Size(555, 43);
            panel4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(23, 12);
            label1.Name = "label1";
            label1.Size = new Size(122, 23);
            label1.TabIndex = 2;
            label1.Text = "Mật khẩu mới:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(185, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 27);
            textBox1.TabIndex = 1;
            textBox1.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._2776a46468188ac77c3f1f473c3fb311;
            pictureBox1.Location = new Point(257, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(452, 334);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(87, 45);
            btnExit.TabIndex = 3;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Highlight;
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(346, 334);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(87, 45);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Lưu";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblPassword);
            panel3.Controls.Add(txtBPassword);
            panel3.Location = new Point(55, 178);
            panel3.Name = "panel3";
            panel3.Size = new Size(555, 40);
            panel3.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblPassword.Location = new Point(23, 10);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(88, 23);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Mật khẩu:";
            // 
            // txtBPassword
            // 
            txtBPassword.BorderStyle = BorderStyle.FixedSingle;
            txtBPassword.Location = new Point(185, 6);
            txtBPassword.Name = "txtBPassword";
            txtBPassword.Size = new Size(299, 27);
            txtBPassword.TabIndex = 1;
            txtBPassword.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblUsername);
            panel2.Controls.Add(txtBUsername);
            panel2.Location = new Point(55, 131);
            panel2.Name = "panel2";
            panel2.Size = new Size(555, 41);
            panel2.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblUsername.Location = new Point(23, 10);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(128, 23);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Tên đăng nhập:";
            // 
            // txtBUsername
            // 
            txtBUsername.BorderStyle = BorderStyle.FixedSingle;
            txtBUsername.Location = new Point(185, 6);
            txtBUsername.Name = "txtBUsername";
            txtBUsername.Size = new Size(299, 27);
            txtBUsername.TabIndex = 0;
            // 
            // fChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 415);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fThongtincanhan";
            Load += fChangePassword_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnExit;
        private Button btnLogin;
        private Panel panel3;
        private Label lblPassword;
        private TextBox txtBPassword;
        private Panel panel2;
        private Label lblUsername;
        private TextBox txtBUsername;
        private Panel panel5;
        private Label label2;
        private TextBox textBox2;
        private Panel panel4;
        private Label label1;
        private TextBox textBox1;
    }
}