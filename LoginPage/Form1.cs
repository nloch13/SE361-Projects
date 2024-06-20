namespace LoginForm
{
    public partial class frmLogin : Form
    {
        WelcomeForm welcomeForm;
        Database myDatabase;

        public frmLogin()
        {
            InitializeComponent();
            myDatabase = new Database();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Butler Bulldogs");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool result = myDatabase.Query(txtUsername.Text, txtPassword.Text);

            if (result)
            {
                welcomeForm = new WelcomeForm(this, txtUsername.Text);

                this.Hide();

                welcomeForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
