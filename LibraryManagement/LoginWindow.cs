namespace LibraryManagement
{
    public partial class formLoginWindow : Form
    {
        public formLoginWindow()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string loginId = textBoxLoginID.Text;
            string password = textBoxPassword.Text;

            if (SqliteDataAccess.Authorize(loginId, password))
            {
                // MessageBox.Show("Login Successful");
                MainWindow mainWindow = new MainWindow();
                this.Hide();
                mainWindow.Show();
                // this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Login ID or Password\nPlease try again");
                textBoxLoginID.Text = "";
                textBoxPassword.Text = "";
            }
        }
    }
}