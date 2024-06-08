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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string type = AddType.Text;
            string brand = AddBrand.Text;
            string manufacturer = AddManuc.Text;
            string expiryDate = AddDateEx.Text;
            string price = AddPrice.Text;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand(
                "INSERT INTO Products (Type, Brand, Manufacturer, ExpiryDate, Price) VALUES (@type, @brand, @manufacturer, @expiryDate, @price)",
                db.getconnection()
            );

            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;
            command.Parameters.Add("@brand", MySqlDbType.VarChar).Value = brand;
            command.Parameters.Add("@manufacturer", MySqlDbType.VarChar).Value = manufacturer;
            command.Parameters.Add("@expiryDate", MySqlDbType.Date).Value = DateTime.Parse(expiryDate);
            command.Parameters.Add("@price", MySqlDbType.Decimal).Value = decimal.Parse(price);

            db.openConnection();

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Product added successfully!");
                    
                }
                else
                {
                    MessageBox.Show("Failed to add product.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }
    }
  }

