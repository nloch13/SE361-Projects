using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class WelcomeForm : Form
    {
        private frmLogin loginForm;

        public WelcomeForm(frmLogin frmLogin, string username)
        {
            InitializeComponent();

            loginForm = frmLogin;
            lblName.Text = username;
        }

        private void WelcomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.Show();
        }
    }
}
