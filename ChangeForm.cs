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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_4
{
    public partial class ChangeForm : Form
    {
        public ChangeForm()
        {
            InitializeComponent();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idForChange.Text); 
            string type = СhType.Text;
            string brand = ChBrand.Text;
            string manufacturer = ChManuc.Text;
            string expiryDate = ChDateEx.Text;
            string price = ChPrice.Text;

            DB db = new DB();

            MySqlCommand command = new MySqlCommand();
            command.Connection = db.getconnection();

            string query = "UPDATE Products SET ";
            bool hasSet = false;

            if (!string.IsNullOrWhiteSpace(type))
            {
                query += "Type = @type";
                command.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;
                hasSet = true;
            }

            if (!string.IsNullOrWhiteSpace(brand))
            {
                if (hasSet) query += ", ";
                query += "Brand = @brand";
                command.Parameters.Add("@brand", MySqlDbType.VarChar).Value = brand;
                hasSet = true;
            }

            if (!string.IsNullOrWhiteSpace(manufacturer))
            {
                if (hasSet) query += ", ";
                query += "Manufacturer = @manufacturer";
                command.Parameters.Add("@manufacturer", MySqlDbType.VarChar).Value = manufacturer;
                hasSet = true;
            }

            if (!string.IsNullOrWhiteSpace(expiryDate))
            {
                if (hasSet) query += ", ";
                query += "ExpiryDate = @expiryDate";
                command.Parameters.Add("@expiryDate", MySqlDbType.Date).Value = DateTime.Parse(expiryDate);
                hasSet = true;
            }

            if (!string.IsNullOrWhiteSpace(price))
            {
                if (hasSet) query += ", ";
                query += "Price = @price";
                command.Parameters.Add("@price", MySqlDbType.Decimal).Value = decimal.Parse(price);
                hasSet = true;
            }

            if (!hasSet)
            {
                MessageBox.Show("No fields to update.");
                return;
            }

            query += " WHERE Id = @id";
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.CommandText = query;

            db.openConnection();

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Product updated successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to update product.");
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
