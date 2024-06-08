namespace Lab_4
{
    partial class RegistrAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrAdmin));
            button1 = new Button();
            regAdminPassword = new TextBox();
            regAdminMail = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            directorCode = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 255);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(191, 412);
            button1.Name = "button1";
            button1.Size = new Size(176, 49);
            button1.TabIndex = 4;
            button1.Text = "Зареєструватись";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // regAdminPassword
            // 
            regAdminPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            regAdminPassword.Location = new Point(95, 257);
            regAdminPassword.MaximumSize = new Size(390, 50);
            regAdminPassword.MaxLength = 10;
            regAdminPassword.MinimumSize = new Size(390, 40);
            regAdminPassword.Name = "regAdminPassword";
            regAdminPassword.PasswordChar = '*';
            regAdminPassword.PlaceholderText = "Password";
            regAdminPassword.Size = new Size(390, 40);
            regAdminPassword.TabIndex = 2;
            regAdminPassword.TextAlign = HorizontalAlignment.Center;
            regAdminPassword.UseSystemPasswordChar = true;
            // 
            // regAdminMail
            // 
            regAdminMail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            regAdminMail.Location = new Point(95, 161);
            regAdminMail.MaxLength = 50;
            regAdminMail.MinimumSize = new Size(390, 40);
            regAdminMail.Name = "regAdminMail";
            regAdminMail.PlaceholderText = "Mail";
            regAdminMail.Size = new Size(390, 40);
            regAdminMail.TabIndex = 1;
            regAdminMail.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(106, 86, 154);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(521, 125);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(53, 184, 200);
            label1.Location = new Point(93, 44);
            label1.Name = "label1";
            label1.Size = new Size(392, 41);
            label1.TabIndex = 0;
            label1.Text = "Реєстрація адміністратора";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 237);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // directorCode
            // 
            directorCode.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            directorCode.Location = new Point(93, 351);
            directorCode.MaximumSize = new Size(390, 50);
            directorCode.MaxLength = 5;
            directorCode.MinimumSize = new Size(390, 40);
            directorCode.Name = "directorCode";
            directorCode.PasswordChar = '*';
            directorCode.PlaceholderText = "Director Code";
            directorCode.Size = new Size(390, 40);
            directorCode.TabIndex = 3;
            directorCode.TextAlign = HorizontalAlignment.Center;
            directorCode.UseSystemPasswordChar = true;
            // 
            // RegistrAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(187, 153, 255);
            ClientSize = new Size(521, 482);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(directorCode);
            Controls.Add(regAdminPassword);
            Controls.Add(regAdminMail);
            Controls.Add(panel1);
            Name = "RegistrAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox regAdminPassword;
        private TextBox regAdminMail;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox directorCode;
    }
}