using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse.@in
{
    public partial class FormSignup : Form
{
    public FormSignup()
    {
        InitializeComponent();
    }

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Enter username")
            {
                tbUsername.Text = "";

                tbUsername.ForeColor = Color.Black;
            }
        }

        private void tbEmail_Enter(object sender, EventArgs e)
        {
            if (tbEmail.Text == "Enter email")
            {
                tbEmail.Text = "";

                tbEmail.ForeColor = Color.Black;
            }
        }

        private void tbUsername_Validated(object sender, EventArgs e)
        {

        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                tbUsername.Text = "Enter username";

                tbUsername.ForeColor = Color.Silver;
            }
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                tbEmail.Text = "Enter email";

                tbEmail.ForeColor = Color.Silver;
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Enter password")
            {
                tbPassword.Text = "";

                tbPassword.ForeColor = Color.Black;
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "Enter password";

                tbPassword.StateCommon.Content.Color1 = Color.Silver;
            }
        }

        private void tbConfpass_Enter(object sender, EventArgs e)
        {
            if (tbConfpass.Text == "Confirm password")
            {
                tbConfpass.Text = "";

                tbConfpass.ForeColor = Color.Black;
            }
        }

        private void tbConfpass_Leave(object sender, EventArgs e)
        {
            if (tbConfpass.Text == "")
            {
                tbConfpass.Text = "Confirm password";

                tbConfpass.ForeColor = Color.Silver;
            }
        }
    }
}
