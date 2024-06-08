namespace Lab_4
{
    partial class registerUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerUser));
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            regPassword = new TextBox();
            regMail = new TextBox();
            label2 = new Label();
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
            panel1.Size = new Size(521, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(53, 184, 200);
            label1.Location = new Point(93, 44);
            label1.Name = "label1";
            label1.Size = new Size(355, 41);
            label1.TabIndex = 0;
            label1.Text = "Реєстрація користувача";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 255);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(200, 357);
            button1.Name = "button1";
            button1.Size = new Size(176, 49);
            button1.TabIndex = 9;
            button1.Text = "Зареєструватись";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 268);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 165);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // regPassword
            // 
            regPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            regPassword.Location = new Point(93, 288);
            regPassword.MaximumSize = new Size(390, 50);
            regPassword.MaxLength = 10;
            regPassword.MinimumSize = new Size(390, 40);
            regPassword.Name = "regPassword";
            regPassword.PasswordChar = '*';
            regPassword.PlaceholderText = "Password";
            regPassword.Size = new Size(390, 40);
            regPassword.TabIndex = 5;
            regPassword.TextAlign = HorizontalAlignment.Center;
            regPassword.UseSystemPasswordChar = true;
            // 
            // regMail
            // 
            regMail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            regMail.Location = new Point(93, 185);
            regMail.MaxLength = 50;
            regMail.MinimumSize = new Size(390, 40);
            regMail.Name = "regMail";
            regMail.PlaceholderText = "Mail";
            regMail.Size = new Size(390, 40);
            regMail.TabIndex = 6;
            regMail.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(134, 432);
            label2.Name = "label2";
            label2.Size = new Size(294, 25);
            label2.TabIndex = 10;
            label2.Text = "Вже маєте акаунт? Здійсніть вхід.\r\n";
            label2.Click += label2_Click;
            // 
            // registerUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(187, 153, 255);
            ClientSize = new Size(521, 482);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(regPassword);
            Controls.Add(regMail);
            Controls.Add(panel1);
            Name = "registerUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "registeruser";
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
        private TextBox regPassword;
        private TextBox regMail;
        private Label label2;
    }
}