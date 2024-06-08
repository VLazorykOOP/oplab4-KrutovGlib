namespace Lab_4
{
    partial class loginAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginAdmin));
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            loginAdminPassword = new TextBox();
            loginAdminMail = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(106, 86, 154);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(53, 184, 200);
            label1.Location = new Point(128, 42);
            label1.Name = "label1";
            label1.Size = new Size(299, 41);
            label1.TabIndex = 1;
            label1.Text = "Вхід адміністратора";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 255);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(222, 378);
            button1.Name = "button1";
            button1.Size = new Size(115, 49);
            button1.TabIndex = 3;
            button1.Text = "Вхід";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(25, 276);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 173);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // loginAdminPassword
            // 
            loginAdminPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginAdminPassword.Location = new Point(104, 296);
            loginAdminPassword.MaximumSize = new Size(390, 50);
            loginAdminPassword.MaxLength = 10;
            loginAdminPassword.MinimumSize = new Size(390, 40);
            loginAdminPassword.Name = "loginAdminPassword";
            loginAdminPassword.PasswordChar = '*';
            loginAdminPassword.PlaceholderText = "Password";
            loginAdminPassword.Size = new Size(390, 40);
            loginAdminPassword.TabIndex = 2;
            loginAdminPassword.TextAlign = HorizontalAlignment.Center;
            loginAdminPassword.UseSystemPasswordChar = true;
            // 
            // loginAdminMail
            // 
            loginAdminMail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            loginAdminMail.Location = new Point(104, 193);
            loginAdminMail.MaxLength = 50;
            loginAdminMail.MinimumSize = new Size(390, 40);
            loginAdminMail.Name = "loginAdminMail";
            loginAdminMail.PlaceholderText = "Mail";
            loginAdminMail.Size = new Size(390, 40);
            loginAdminMail.TabIndex = 1;
            loginAdminMail.TextAlign = HorizontalAlignment.Center;
            // 
            // loginAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(187, 153, 255);
            ClientSize = new Size(519, 475);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(loginAdminPassword);
            Controls.Add(loginAdminMail);
            Controls.Add(panel1);
            Name = "loginAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "loginAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox loginAdminPassword;
        private TextBox loginAdminMail;
    }
}