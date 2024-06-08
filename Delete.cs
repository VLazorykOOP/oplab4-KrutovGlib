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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string type = DelType.Text;
            string brand = DelBrand.Text;
            string manufacturer = DelManuc.Text;
            string expiryDate = DelDateEx.Text;
            string price = DelPrice.Text;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand(
                "DELETE FROM Products WHERE Type = @type AND Brand = @brand AND Manufacturer = @manufacturer AND ExpiryDate = @expiryDate AND Price = @price",
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
                    MessageBox.Show("Product deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to delete product.");
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

