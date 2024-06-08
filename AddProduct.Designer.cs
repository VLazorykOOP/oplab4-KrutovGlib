namespace Lab_4
{
    partial class AddProduct
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
            AddType = new TextBox();
            AddBrand = new TextBox();
            AddDateEx = new TextBox();
            AddManuc = new TextBox();
            AddPrice = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // AddType
            // 
            AddType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddType.Location = new Point(12, 45);
            AddType.MaximumSize = new Size(159, 40);
            AddType.MinimumSize = new Size(159, 40);
            AddType.Name = "AddType";
            AddType.Size = new Size(159, 40);
            AddType.TabIndex = 0;
            AddType.TextAlign = HorizontalAlignment.Center;
            // 
            // AddBrand
            // 
            AddBrand.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddBrand.Location = new Point(185, 45);
            AddBrand.MaximumSize = new Size(159, 40);
            AddBrand.MinimumSize = new Size(159, 40);
            AddBrand.Name = "AddBrand";
            AddBrand.Size = new Size(159, 40);
            AddBrand.TabIndex = 0;
            AddBrand.TextAlign = HorizontalAlignment.Center;
            // 
            // AddDateEx
            // 
            AddDateEx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddDateEx.Location = new Point(536, 45);
            AddDateEx.MaximumSize = new Size(159, 40);
            AddDateEx.MinimumSize = new Size(159, 40);
            AddDateEx.Name = "AddDateEx";
            AddDateEx.Size = new Size(159, 40);
            AddDateEx.TabIndex = 0;
            AddDateEx.TextAlign = HorizontalAlignment.Center;
            // 
            // AddManuc
            // 
            AddManuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddManuc.Location = new Point(359, 45);
            AddManuc.MaximumSize = new Size(159, 40);
            AddManuc.MinimumSize = new Size(159, 40);
            AddManuc.Name = "AddManuc";
            AddManuc.Size = new Size(159, 40);
            AddManuc.TabIndex = 0;
            AddManuc.TextAlign = HorizontalAlignment.Center;
            // 
            // AddPrice
            // 
            AddPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddPrice.Location = new Point(711, 45);
            AddPrice.MaximumSize = new Size(159, 40);
            AddPrice.MinimumSize = new Size(159, 40);
            AddPrice.Name = "AddPrice";
            AddPrice.Size = new Size(159, 40);
            AddPrice.TabIndex = 0;
            AddPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(376, 126);
            button1.Name = "button1";
            button1.Size = new Size(142, 41);
            button1.TabIndex = 1;
            button1.Text = "Додати ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(64, 11);
            label1.Name = "label1";
            label1.Size = new Size(53, 31);
            label1.TabIndex = 2;
            label1.Text = "Тип";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(221, 11);
            label2.Name = "label2";
            label2.Size = new Size(81, 31);
            label2.TabIndex = 2;
            label2.Text = "Бренд";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(376, 11);
            label3.Name = "label3";
            label3.Size = new Size(124, 31);
            label3.TabIndex = 2;
            label3.Text = "Виробник";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(526, 11);
            label4.Name = "label4";
            label4.Size = new Size(175, 31);
            label4.TabIndex = 2;
            label4.Text = "Придатний до:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(758, 11);
            label5.Name = "label5";
            label5.Size = new Size(64, 31);
            label5.TabIndex = 2;
            label5.Text = "Ціна";
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(882, 212);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(AddPrice);
            Controls.Add(AddManuc);
            Controls.Add(AddDateEx);
            Controls.Add(AddBrand);
            Controls.Add(AddType);
            Name = "AddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AddType;
        private TextBox AddBrand;
        private TextBox AddDateEx;
        private TextBox AddManuc;
        private TextBox AddPrice;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}