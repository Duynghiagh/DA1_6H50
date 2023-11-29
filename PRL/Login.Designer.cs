namespace PRL
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel_login = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel_login
            // 
            panel_login.BackColor = Color.FromArgb(190, 0, 0);
            panel_login.Controls.Add(pictureBox2);
            panel_login.Controls.Add(textBox3);
            panel_login.Controls.Add(textBox2);
            panel_login.Controls.Add(pictureBox1);
            panel_login.Controls.Add(textBox1);
            panel_login.Controls.Add(label3);
            panel_login.Location = new Point(12, 12);
            panel_login.Name = "panel_login";
            panel_login.Size = new Size(603, 543);
            panel_login.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(232, 79);
            label3.Name = "label3";
            label3.Size = new Size(147, 35);
            label3.TabIndex = 52;
            label3.Text = "Đăng Nhập";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(217, 217, 217);
            pictureBox1.BackgroundImage = Properties.Resources.solar_user_broken;
            pictureBox1.Location = new Point(396, 196);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(217, 217, 217);
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(147, 188);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(302, 58);
            textBox1.TabIndex = 55;
            textBox1.Text = "Tài Khoản";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(217, 217, 217);
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(390, 278);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 58;
            pictureBox2.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(217, 217, 217);
            textBox2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(147, 271);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(302, 58);
            textBox2.TabIndex = 57;
            textBox2.Text = "Mật Khẩu";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(217, 217, 217);
            textBox3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(213, 392);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(166, 58);
            textBox3.TabIndex = 57;
            textBox3.Text = "Đăng Nhập";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(190, 0, 0);
            ClientSize = new Size(626, 570);
            Controls.Add(panel_login);
            Name = "Login";
            Text = "Login";
            panel_login.ResumeLayout(false);
            panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_login;
        private Label label3;
        private PictureBox pictureBox2;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox3;
    }
}