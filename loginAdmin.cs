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
    public partial class loginAdmin : Form
    {
        public loginAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String loginAdmin = loginAdminMail.Text;
            String passAdmin = loginAdminPassword.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM admins WHERE mail = @uL AND password = @uP", db.getconnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginAdmin;

            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passAdmin;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                Products products = new Products();
                products.Show();
            }
            else
            {
                MessageBox.Show("Невірний логін чи пароль! Спробуйте ще раз.");
            }
        }
    }
}
