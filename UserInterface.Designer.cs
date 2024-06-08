namespace Lab_4
{
    partial class UserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            searchByManuc = new TextBox();
            searchByBrand = new TextBox();
            searchByType = new TextBox();
            searchButton = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            addToCartButton = new Button();
            label4 = new Label();
            label5 = new Label();
            cartButton = new Button();
            CostLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // searchByManuc
            // 
            searchByManuc.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            searchByManuc.Location = new Point(578, 92);
            searchByManuc.MaximumSize = new Size(180, 35);
            searchByManuc.MinimumSize = new Size(180, 35);
            searchByManuc.Name = "searchByManuc";
            searchByManuc.PlaceholderText = "Manufacturer";
            searchByManuc.Size = new Size(180, 35);
            searchByManuc.TabIndex = 13;
            searchByManuc.TextAlign = HorizontalAlignment.Center;
            // 
            // searchByBrand
            // 
            searchByBrand.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            searchByBrand.Location = new Point(392, 92);
            searchByBrand.MaximumSize = new Size(180, 35);
            searchByBrand.MinimumSize = new Size(180, 35);
            searchByBrand.Name = "searchByBrand";
            searchByBrand.PlaceholderText = "Brand";
            searchByBrand.Size = new Size(180, 35);
            searchByBrand.TabIndex = 12;
            searchByBrand.TextAlign = HorizontalAlignment.Center;
            // 
            // searchByType
            // 
            searchByType.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            searchByType.Location = new Point(206, 92);
            searchByType.MaximumSize = new Size(180, 35);
            searchByType.MinimumSize = new Size(180, 35);
            searchByType.Name = "searchByType";
            searchByType.PlaceholderText = "Type";
            searchByType.Size = new Size(180, 35);
            searchByType.TabIndex = 11;
            searchByType.TextAlign = HorizontalAlignment.Center;
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            searchButton.Location = new Point(19, 92);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(182, 35);
            searchButton.TabIndex = 10;
            searchButton.Text = "Пошук";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 263);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1201, 617);
            dataGridView1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1174, 34);
            label1.TabIndex = 14;
            label1.Text = "Тут ви можете переглянути увесь перелік нашої косметики і засобів для догляду за тілом";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(207, 180);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(364, 180);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 16;
            // 
            // comboBox3
            // 
            comboBox3.Cursor = Cursors.PanSouth;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(521, 180);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 17;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            button1.Location = new Point(20, 173);
            button1.Name = "button1";
            button1.Size = new Size(181, 36);
            button1.TabIndex = 18;
            button1.Text = "Вибрати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(21, 58);
            label2.Name = "label2";
            label2.Size = new Size(444, 31);
            label2.TabIndex = 19;
            label2.Text = "Введіть назву чи інші властивості товару.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(21, 139);
            label3.Name = "label3";
            label3.Size = new Size(209, 31);
            label3.TabIndex = 20;
            label3.Text = "Виберіть категорії.";
            // 
            // addToCartButton
            // 
            addToCartButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addToCartButton.Location = new Point(21, 897);
            addToCartButton.Name = "addToCartButton";
            addToCartButton.Size = new Size(327, 48);
            addToCartButton.TabIndex = 21;
            addToCartButton.Text = "Додати в кошик";
            addToCartButton.UseVisualStyleBackColor = true;
            addToCartButton.Click += addToCartButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 228);
            label4.Name = "label4";
            label4.Size = new Size(667, 29);
            label4.TabIndex = 22;
            label4.Text = "Натисніть на рядок з товаром який хочете замовити!";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ImageAlign = ContentAlignment.TopLeft;
            label5.Location = new Point(420, 909);
            label5.Name = "label5";
            label5.Size = new Size(186, 28);
            label5.TabIndex = 23;
            label5.Text = "Ціна замовлення: ";
            // 
            // cartButton
            // 
            cartButton.BackgroundImage = (Image)resources.GetObject("cartButton.BackgroundImage");
            cartButton.BackgroundImageLayout = ImageLayout.Stretch;
            cartButton.Location = new Point(1121, 886);
            cartButton.Name = "cartButton";
            cartButton.Size = new Size(99, 70);
            cartButton.TabIndex = 24;
            cartButton.UseVisualStyleBackColor = true;
            cartButton.Click += cartButton_Click;
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(640, 914);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(36, 20);
            CostLabel.TabIndex = 25;
            CostLabel.Text = "0.00";
            // 
            // UserInterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1237, 982);
            Controls.Add(CostLabel);
            Controls.Add(cartButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(addToCartButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(searchByManuc);
            Controls.Add(searchByBrand);
            Controls.Add(searchByType);
            Controls.Add(searchButton);
            Controls.Add(dataGridView1);
            Name = "UserInterface";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserInterface";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchByManuc;
        private TextBox searchByBrand;
        private TextBox searchByType;
        private Button searchButton;
        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Button button1;
        private Label label2;
        private Label label3;
        private Button addToCartButton;
        private Label label4;
        private Label label5;
        private Button cartButton;
        private Label CostLabel;
    }
}