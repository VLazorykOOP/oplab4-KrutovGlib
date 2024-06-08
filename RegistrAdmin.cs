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
    public partial class RegistrAdmin : Form
    {
        public RegistrAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String DirectorPassword = "00000";

            if (regAdminMail.Text == "")
            {
                MessageBox.Show("Введіть пошту адміністратора!");
                return;
            }

            if (regAdminPassword.Text == "")
            {
                MessageBox.Show("Введіть пароль адміністратора!");
                return;
            }

            if(directorCode.Text != DirectorPassword)
            {
                MessageBox.Show("У доступі відказано. Невірний код директора.");
                return;
            }
            

            if (isUserExist())
            {
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO admins (mail,password) VALUES (@mail, @password)", db.getconnection());
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = regAdminMail.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = regAdminPassword.Text;
           

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Акаунт успішно зареєстровано!");
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

            MySqlCommand command = new MySqlCommand("SELECT * FROM admins WHERE mail = @uL", db.getconnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = regAdminMail.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Користувач з таким логіном вже існує.");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
