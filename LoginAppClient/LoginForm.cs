using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAppClient
{
    public partial class LoginForm : Form
    {
        LoginFormViewModel viewModel = new LoginFormViewModel();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                if (viewModel.ManageLogin(txtUsername.Text, txtPassword.Text))
                {
                    Close();
                }
                else
                {
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                    MessageBox.Show("Username or password incorrect.", "Access denied!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Username and password must be filled.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
