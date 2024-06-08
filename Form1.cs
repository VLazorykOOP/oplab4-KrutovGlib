namespace Lab_4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void loginUser_Click(object sender, EventArgs e)
        {
            loginUserForm login = new loginUserForm();
            login.Show();


        }

        private void registerUser_Click(object sender, EventArgs e)
        {
            registerUser register = new registerUser();
            register.Show();
        }

        private void loginAdmin_Click(object sender, EventArgs e)
        {
            loginAdmin admin = new loginAdmin();
            admin.Show();
        }

        private void RegistrAdmin_Click(object sender, EventArgs e)
        {
            RegistrAdmin admin = new RegistrAdmin();
            admin.Show();
        }
    }
}
