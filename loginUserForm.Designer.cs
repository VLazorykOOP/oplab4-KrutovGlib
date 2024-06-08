namespace Lab_4
{
    partial class loginUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginUserForm));
            panel1 = new Panel();
            label1 = new Label();
            loginMail = new TextBox();
            loginPassword = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(106, 86, 154);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(521, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(53, 184, 200);
            label1.Location = new Point(137, 39);
            label1.Name = "label1";
            label1.Size = new Size(262, 41);
            label1.TabIndex = 0;
            label1.Text = "Вхід користувача";
            // 
            // loginMail
            // 
            loginMail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            loginMail.Location = new Point(97, 186);
            loginMail.MaxLength = 50;
            loginMail.MinimumSize = new Size(390, 40);
            loginMail.Name = "loginMail";
            loginMail.PlaceholderText = "Mail";
            loginMail.Size = new Size(390, 40);
            loginMail.TabIndex = 1;
            loginMail.TextAlign = HorizontalAlignment.Center;
            // 
            // loginPassword
            // 
            loginPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginPassword.Location = new Point(97, 289);
            loginPassword.MaximumSize = new Size(390, 50);
            loginPassword.MaxLength = 10;
            loginPassword.MinimumSize = new Size(390, 40);
            loginPassword.Name = "loginPassword";
            loginPassword.PasswordChar = '*';
            loginPassword.PlaceholderText = "Password";
            loginPassword.Size = new Size(390, 40);
            loginPassword.TabIndex = 2;
            loginPassword.TextAlign = HorizontalAlignment.Center;
            loginPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 269);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 255);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(230, 361);
            button1.Name = "button1";
            button1.Size = new Size(115, 49);
            button1.TabIndex = 3;
            button1.Text = "Вхід";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(202, 432);
            label2.Name = "label2";
            label2.Size = new Size(174, 27);
            label2.TabIndex = 4;
            label2.Text = "Створити акаунт.";
            label2.Click += label2_Click_1;
            // 
            // loginUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(187, 153, 255);
            ClientSize = new Size(521, 482);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(loginPassword);
            Controls.Add(loginMail);
            Controls.Add(panel1);
            Name = "loginUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login User";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox loginMail;
        private TextBox loginPassword;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Label label2;
    }
}