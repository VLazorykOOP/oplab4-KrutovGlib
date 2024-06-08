namespace Lab_4
{
    partial class ChangeForm
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
            idForChange = new TextBox();
            ChangeButton = new Button();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            ChPrice = new TextBox();
            ChManuc = new TextBox();
            ChDateEx = new TextBox();
            ChBrand = new TextBox();
            СhType = new TextBox();
            SuspendLayout();
            // 
            // idForChange
            // 
            idForChange.Location = new Point(247, 26);
            idForChange.Name = "idForChange";
            idForChange.Size = new Size(125, 27);
            idForChange.TabIndex = 0;
            // 
            // ChangeButton
            // 
            ChangeButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ChangeButton.Location = new Point(368, 193);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(133, 46);
            ChangeButton.TabIndex = 1;
            ChangeButton.Text = "Змінити";
            ChangeButton.UseVisualStyleBackColor = true;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(210, 31);
            label1.TabIndex = 2;
            label1.Text = "Введіть ID запису:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(759, 90);
            label5.Name = "label5";
            label5.Size = new Size(64, 31);
            label5.TabIndex = 19;
            label5.Text = "Ціна";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(527, 90);
            label4.Name = "label4";
            label4.Size = new Size(175, 31);
            label4.TabIndex = 20;
            label4.Text = "Придатний до:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(377, 90);
            label3.Name = "label3";
            label3.Size = new Size(124, 31);
            label3.TabIndex = 21;
            label3.Text = "Виробник";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(222, 90);
            label2.Name = "label2";
            label2.Size = new Size(81, 31);
            label2.TabIndex = 22;
            label2.Text = "Бренд";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(65, 90);
            label6.Name = "label6";
            label6.Size = new Size(53, 31);
            label6.TabIndex = 23;
            label6.Text = "Тип";
            // 
            // ChPrice
            // 
            ChPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ChPrice.Location = new Point(712, 124);
            ChPrice.MaximumSize = new Size(159, 40);
            ChPrice.MinimumSize = new Size(159, 40);
            ChPrice.Name = "ChPrice";
            ChPrice.Size = new Size(159, 40);
            ChPrice.TabIndex = 14;
            ChPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // ChManuc
            // 
            ChManuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ChManuc.Location = new Point(360, 124);
            ChManuc.MaximumSize = new Size(159, 40);
            ChManuc.MinimumSize = new Size(159, 40);
            ChManuc.Name = "ChManuc";
            ChManuc.Size = new Size(159, 40);
            ChManuc.TabIndex = 15;
            ChManuc.TextAlign = HorizontalAlignment.Center;
            // 
            // ChDateEx
            // 
            ChDateEx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ChDateEx.Location = new Point(537, 124);
            ChDateEx.MaximumSize = new Size(159, 40);
            ChDateEx.MinimumSize = new Size(159, 40);
            ChDateEx.Name = "ChDateEx";
            ChDateEx.Size = new Size(159, 40);
            ChDateEx.TabIndex = 16;
            ChDateEx.TextAlign = HorizontalAlignment.Center;
            // 
            // ChBrand
            // 
            ChBrand.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ChBrand.Location = new Point(186, 124);
            ChBrand.MaximumSize = new Size(159, 40);
            ChBrand.MinimumSize = new Size(159, 40);
            ChBrand.Name = "ChBrand";
            ChBrand.Size = new Size(159, 40);
            ChBrand.TabIndex = 17;
            ChBrand.TextAlign = HorizontalAlignment.Center;
            // 
            // СhType
            // 
            СhType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            СhType.Location = new Point(13, 124);
            СhType.MaximumSize = new Size(159, 40);
            СhType.MinimumSize = new Size(159, 40);
            СhType.Name = "СhType";
            СhType.Size = new Size(159, 40);
            СhType.TabIndex = 18;
            СhType.TextAlign = HorizontalAlignment.Center;
            // 
            // ChangeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(879, 251);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(ChPrice);
            Controls.Add(ChManuc);
            Controls.Add(ChDateEx);
            Controls.Add(ChBrand);
            Controls.Add(СhType);
            Controls.Add(label1);
            Controls.Add(ChangeButton);
            Controls.Add(idForChange);
            Name = "ChangeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idForChange;
        private Button ChangeButton;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private TextBox ChPrice;
        private TextBox ChManuc;
        private TextBox ChDateEx;
        private TextBox ChBrand;
        private TextBox СhType;
    }
}