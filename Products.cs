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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();

        }

        private void LoadProducts()
        {
            DB db = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Products", db.getconnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void showDataButton_Click(object sender, EventArgs e)
        {
            LoadProducts();
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

        private void button2_Click(object sender, EventArgs e)
        {
            AddProduct product = new AddProduct();
            product.Show();
        }

        private void deleteData_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.Show();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            ChangeForm changeForm = new ChangeForm();

            changeForm.Show();
        }
    }
}
