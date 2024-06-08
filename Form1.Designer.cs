namespace Lab_4
{
    partial class MainForm
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
            panel1 = new Panel();
            label1 = new Label();
            loginUser = new Button();
            registerUser = new Button();
            loginAdmin = new Button();
            RegistrAdmin = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Desktop;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(35, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 124);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.YellowGreen;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(729, 74);
            label1.TabIndex = 0;
            label1.Text = "Вас вітає магазин косметики KrutovCosmetic!\r\nБудь ласка виберіть параметри входу.\r\n";
            // 
            // loginUser
            // 
            loginUser.Cursor = Cursors.Hand;
            loginUser.Font = new Font("Stencil", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            loginUser.Location = new Point(79, 268);
            loginUser.Name = "loginUser";
            loginUser.Size = new Size(208, 60);
            loginUser.TabIndex = 1;
            loginUser.Text = "Login as a User";
            loginUser.UseVisualStyleBackColor = true;
            loginUser.Click += loginUser_Click;
            // 
            // registerUser
            // 
            registerUser.Cursor = Cursors.Hand;
            registerUser.Font = new Font("Stencil", 10.2F);
            registerUser.Location = new Point(478, 268);
            registerUser.Name = "registerUser";
            registerUser.Size = new Size(208, 60);
            registerUser.TabIndex = 3;
            registerUser.Text = "Register as a User";
            registerUser.UseVisualStyleBackColor = true;
            registerUser.Click += registerUser_Click;
            // 
            // loginAdmin
            // 
            loginAdmin.Cursor = Cursors.Hand;
            loginAdmin.Font = new Font("Stencil", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            loginAdmin.Location = new Point(79, 404);
            loginAdmin.Name = "loginAdmin";
            loginAdmin.Size = new Size(208, 60);
            loginAdmin.TabIndex = 2;
            loginAdmin.Text = "Login as a Admin";
            loginAdmin.UseVisualStyleBackColor = true;
            loginAdmin.Click += loginAdmin_Click;
            // 
            // RegistrAdmin
            // 
            RegistrAdmin.Cursor = Cursors.Hand;
            RegistrAdmin.Font = new Font("Stencil", 10.2F);
            RegistrAdmin.Location = new Point(478, 404);
            RegistrAdmin.Name = "RegistrAdmin";
            RegistrAdmin.Size = new Size(208, 60);
            RegistrAdmin.TabIndex = 4;
            RegistrAdmin.Text = "Register as a admin";
            RegistrAdmin.UseVisualStyleBackColor = true;
            RegistrAdmin.Click += RegistrAdmin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Desktop;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(61, 234);
            label2.Name = "label2";
            label2.Size = new Size(250, 31);
            label2.TabIndex = 2;
            label2.Text = "Увійти як користувач";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Desktop;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(49, 362);
            label3.Name = "label3";
            label3.Size = new Size(280, 31);
            label3.TabIndex = 2;
            label3.Text = "Увійти як адміністратор";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Desktop;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(403, 234);
            label4.Name = "label4";
            label4.Size = new Size(361, 31);
            label4.TabIndex = 2;
            label4.Text = "Зареєструватися як користувач";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Desktop;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(403, 362);
            label5.Name = "label5";
            label5.Size = new Size(397, 31);
            label5.TabIndex = 2;
            label5.Text = "Зареєструватися як  адміністратор";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(828, 524);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(RegistrAdmin);
            Controls.Add(loginAdmin);
            Controls.Add(registerUser);
            Controls.Add(loginUser);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button loginUser;
        private Button registerUser;
        private Button loginAdmin;
        private Button RegistrAdmin;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
