namespace Lab_4
{
    partial class Products
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
            dataGridView1 = new DataGridView();
            showDataButton = new Button();
            searchButton = new Button();
            button2 = new Button();
            searchByType = new TextBox();
            searchByBrand = new TextBox();
            searchByManuc = new TextBox();
            deleteData = new Button();
            ChangeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(806, 465);
            dataGridView1.TabIndex = 0;
            // 
            // showDataButton
            // 
            showDataButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            showDataButton.Location = new Point(23, 12);
            showDataButton.Name = "showDataButton";
            showDataButton.Size = new Size(181, 71);
            showDataButton.TabIndex = 1;
            showDataButton.Text = "Вся продукція";
            showDataButton.UseVisualStyleBackColor = true;
            showDataButton.Click += showDataButton_Click;
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            searchButton.Location = new Point(21, 99);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(181, 36);
            searchButton.TabIndex = 5;
            searchButton.Text = "Пошук";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(220, 12);
            button2.Name = "button2";
            button2.Size = new Size(181, 71);
            button2.TabIndex = 2;
            button2.Text = "Додати запис";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // searchByType
            // 
            searchByType.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            searchByType.Location = new Point(208, 99);
            searchByType.MaximumSize = new Size(180, 35);
            searchByType.MinimumSize = new Size(180, 35);
            searchByType.Name = "searchByType";
            searchByType.PlaceholderText = "Type";
            searchByType.Size = new Size(180, 35);
            searchByType.TabIndex = 6;
            searchByType.TextAlign = HorizontalAlignment.Center;
            // 
            // searchByBrand
            // 
            searchByBrand.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            searchByBrand.Location = new Point(394, 99);
            searchByBrand.MaximumSize = new Size(180, 35);
            searchByBrand.MinimumSize = new Size(180, 35);
            searchByBrand.Name = "searchByBrand";
            searchByBrand.PlaceholderText = "Brand";
            searchByBrand.Size = new Size(180, 35);
            searchByBrand.TabIndex = 7;
            searchByBrand.TextAlign = HorizontalAlignment.Center;
            // 
            // searchByManuc
            // 
            searchByManuc.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            searchByManuc.Location = new Point(580, 99);
            searchByManuc.MaximumSize = new Size(180, 35);
            searchByManuc.MinimumSize = new Size(180, 35);
            searchByManuc.Name = "searchByManuc";
            searchByManuc.PlaceholderText = "Manufacturer";
            searchByManuc.Size = new Size(180, 35);
            searchByManuc.TabIndex = 8;
            searchByManuc.TextAlign = HorizontalAlignment.Center;
            // 
            // deleteData
            // 
            deleteData.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteData.Location = new Point(417, 12);
            deleteData.Name = "deleteData";
            deleteData.Size = new Size(181, 71);
            deleteData.TabIndex = 3;
            deleteData.Text = "Видалити запис";
            deleteData.UseVisualStyleBackColor = true;
            deleteData.Click += deleteData_Click;
            // 
            // ChangeButton
            // 
            ChangeButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ChangeButton.Location = new Point(612, 12);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(181, 71);
            ChangeButton.TabIndex = 4;
            ChangeButton.Text = "Змінити запис";
            ChangeButton.UseVisualStyleBackColor = true;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(805, 605);
            Controls.Add(searchByManuc);
            Controls.Add(searchByBrand);
            Controls.Add(searchByType);
            Controls.Add(ChangeButton);
            Controls.Add(deleteData);
            Controls.Add(button2);
            Controls.Add(searchButton);
            Controls.Add(showDataButton);
            Controls.Add(dataGridView1);
            Name = "Products";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button showDataButton;
        private Button searchButton;
        private Button button2;
        private TextBox searchByType;
        private TextBox searchByBrand;
        private TextBox searchByManuc;
        private Button deleteData;
        private Button ChangeButton;
    }
}