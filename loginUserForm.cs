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
    public partial class loginUserForm : Form
    {
        public loginUserForm()
        {
            InitializeComponent();
        }


        private void label2_Click_1(object sender, EventArgs e)
        {
            this.Close();

            registerUser register = new registerUser();

            register.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String loginUser = loginMail.Text;
            String passUser = loginPassword.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE mail = @uL AND password = @uP", db.getconnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;

            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                Hide();
                UserInterface userInterface = new UserInterface();
                userInterface.Show();
            }
            else
            {
                MessageBox.Show("Невірний логін чи пароль! Спробуйте ще раз.");
            }
        }
    }
}
