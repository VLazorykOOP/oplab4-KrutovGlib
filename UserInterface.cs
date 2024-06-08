using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class UserInterface : Form
    {
        private List<Product> shoppingCart = new List<Product>();

        public UserInterface()
        {
            InitializeComponent();
            FillComboBoxes();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchType = searchByType.Text;
            string searchBrand = searchByBrand.Text;
            string searchManuc = searchByManuc.Text;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand();
            command.Connection = db.getconnection();

            string query = "SELECT * FROM Products WHERE 1=1";


            if (!string.IsNullOrWhiteSpace(searchType))
            {
                query += " AND Type LIKE @searchType";
                command.Parameters.Add("@searchType", MySqlDbType.VarChar).Value = "%" + searchType + "%";
            }

            if (!string.IsNullOrWhiteSpace(searchBrand))
            {
                query += " AND Brand LIKE @searchBrand";
                command.Parameters.Add("@searchBrand", MySqlDbType.VarChar).Value = "%" + searchBrand + "%";
            }

            if (!string.IsNullOrWhiteSpace(searchManuc))
            {
                query += " AND Manufacturer LIKE @searchManuc";
                command.Parameters.Add("@searchManuc", MySqlDbType.VarChar).Value = "%" + searchManuc + "%";
            }

            command.CommandText = query;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            try
            {
                adapter.Fill(table);
                dataGridView1.DataSource = table;

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("No products found matching the search criteria.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchValue1 = searchByType.Text;
            string searchValue2 = searchByBrand.Text;
            string searchValue3 = searchByManuc.Text;

            string selectedCategory1 = comboBox1.SelectedItem?.ToString();
            string selectedCategory2 = comboBox2.SelectedItem?.ToString();
            string selectedCategory3 = comboBox3.SelectedItem?.ToString();

            DB db = new DB();
            MySqlCommand command = new MySqlCommand();
            command.Connection = db.getconnection();

            // Початковий запит
            string query = "SELECT * FROM Products WHERE 1=1";

            // Додамо умови до запиту
            if (!string.IsNullOrWhiteSpace(selectedCategory1))
            {
                query += " AND Type LIKE @selectedCategory1";
                command.Parameters.Add("@selectedCategory1", MySqlDbType.VarChar).Value = "%" + selectedCategory1 + "%";
            }
            if (!string.IsNullOrWhiteSpace(selectedCategory2))
            {
                query += " AND Brand LIKE @selectedCategory2";
                command.Parameters.Add("@selectedCategory2", MySqlDbType.VarChar).Value = "%" + selectedCategory2 + "%";
            }
            if (!string.IsNullOrWhiteSpace(selectedCategory3))
            {
                query += " AND Manufacturer LIKE @selectedCategory3";
                command.Parameters.Add("@selectedCategory3", MySqlDbType.VarChar).Value = "%" + selectedCategory3 + "%";
            }

            command.CommandText = query;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            try
            {
                adapter.Fill(table);
                dataGridView1.DataSource = table;

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("No products found matching the search criteria.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void FillComboBoxes()
        {

            comboBox1.Items.Add("Крем");
            comboBox1.Items.Add("Гель");
            comboBox1.Items.Add("Парфюми");


            comboBox2.Items.Add("Nivea");
            comboBox2.Items.Add("Clinique");
            comboBox2.Items.Add("Neutrogena");


            comboBox3.Items.Add("Beiersdorf AG");
            comboBox3.Items.Add("Chanel S.A.");
            comboBox3.Items.Add("Estee Lauder");
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    Product product = new Product
                    {
                        Id = Convert.ToInt32(row.Cells["Id"].Value),
                        Type = row.Cells["Type"].Value.ToString(),
                        Brand = row.Cells["Brand"].Value.ToString(),
                        Manufacturer = row.Cells["Manufacturer"].Value.ToString(),
                        ExpiryDate = Convert.ToDateTime(row.Cells["ExpiryDate"].Value),
                        Price = Convert.ToDecimal(row.Cells["Price"].Value)
                    };

                    shoppingCart.Add(product);
                }

                UpdateTotalAmount();
            }
            else
            {
                MessageBox.Show("Please select a row to add to cart.");
            }
        }

        private void UpdateTotalAmount()
        {
            decimal totalAmount = shoppingCart.Sum(product => product.Price);
            CostLabel.Text = totalAmount.ToString();
        }


        private void cartButton_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart(shoppingCart);
            cart.Show();
        }


    }

    public class Product
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Manufacturer { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal Price { get; set; }
    }
}