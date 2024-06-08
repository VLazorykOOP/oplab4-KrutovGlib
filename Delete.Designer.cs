namespace Lab_4
{
    partial class Delete
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            DelPrice = new TextBox();
            DelManuc = new TextBox();
            DelDateEx = new TextBox();
            DelBrand = new TextBox();
            DelType = new TextBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(758, 28);
            label5.Name = "label5";
            label5.Size = new Size(64, 31);
            label5.TabIndex = 9;
            label5.Text = "Ціна";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(526, 28);
            label4.Name = "label4";
            label4.Size = new Size(175, 31);
            label4.TabIndex = 10;
            label4.Text = "Придатний до:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(376, 28);
            label3.Name = "label3";
            label3.Size = new Size(124, 31);
            label3.TabIndex = 11;
            label3.Text = "Виробник";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(221, 28);
            label2.Name = "label2";
            label2.Size = new Size(81, 31);
            label2.TabIndex = 12;
            label2.Text = "Бренд";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(64, 28);
            label1.Name = "label1";
            label1.Size = new Size(53, 31);
            label1.TabIndex = 13;
            label1.Text = "Тип";
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(376, 143);
            button1.Name = "button1";
            button1.Size = new Size(142, 41);
            button1.TabIndex = 8;
            button1.Text = "Видалити";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DelPrice
            // 
            DelPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DelPrice.Location = new Point(711, 62);
            DelPrice.MaximumSize = new Size(159, 40);
            DelPrice.MinimumSize = new Size(159, 40);
            DelPrice.Name = "DelPrice";
            DelPrice.Size = new Size(159, 40);
            DelPrice.TabIndex = 3;
            DelPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // DelManuc
            // 
            DelManuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DelManuc.Location = new Point(359, 62);
            DelManuc.MaximumSize = new Size(159, 40);
            DelManuc.MinimumSize = new Size(159, 40);
            DelManuc.Name = "DelManuc";
            DelManuc.Size = new Size(159, 40);
            DelManuc.TabIndex = 4;
            DelManuc.TextAlign = HorizontalAlignment.Center;
            // 
            // DelDateEx
            // 
            DelDateEx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DelDateEx.Location = new Point(536, 62);
            DelDateEx.MaximumSize = new Size(159, 40);
            DelDateEx.MinimumSize = new Size(159, 40);
            DelDateEx.Name = "DelDateEx";
            DelDateEx.Size = new Size(159, 40);
            DelDateEx.TabIndex = 5;
            DelDateEx.TextAlign = HorizontalAlignment.Center;
            // 
            // DelBrand
            // 
            DelBrand.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DelBrand.Location = new Point(185, 62);
            DelBrand.MaximumSize = new Size(159, 40);
            DelBrand.MinimumSize = new Size(159, 40);
            DelBrand.Name = "DelBrand";
            DelBrand.Size = new Size(159, 40);
            DelBrand.TabIndex = 6;
            DelBrand.TextAlign = HorizontalAlignment.Center;
            // 
            // DelType
            // 
            DelType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DelType.Location = new Point(12, 62);
            DelType.MaximumSize = new Size(159, 40);
            DelType.MinimumSize = new Size(159, 40);
            DelType.Name = "DelType";
            DelType.Size = new Size(159, 40);
            DelType.TabIndex = 7;
            DelType.TextAlign = HorizontalAlignment.Center;
            // 
            // Delete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 212);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(DelPrice);
            Controls.Add(DelManuc);
            Controls.Add(DelDateEx);
            Controls.Add(DelBrand);
            Controls.Add(DelType);
            Name = "Delete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox DelPrice;
        private TextBox DelManuc;
        private TextBox DelDateEx;
        private TextBox DelBrand;
        private TextBox DelType;
    }
}