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
    public partial class registerUser : Form
    {
        public registerUser()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();

            loginUserForm register = new loginUserForm();

            register.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (regMail.Text == "")
            {
                MessageBox.Show("Ви не ввели пошту!");
                return;
            }

            if (regPassword.Text == "")
            {
                MessageBox.Show("Ви не ввели пароль!");
                return;
            }

            if (isUserExist())
            {
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO users (mail, password) VALUES (@mail, @password)", db.getconnection());
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = regMail.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = regPassword.Text;
            

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Акаунт успішно зареєстровано! Здійсніть вхід.");
            }
            else
            {
                MessageBox.Show("Помилка при створенні акаунта!");
            }

            db.closeConnection();
        }

        public Boolean isUserExist()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE mail = @uL", db.getconnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = regMail.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Користувач з такою поштою вже існує.");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
