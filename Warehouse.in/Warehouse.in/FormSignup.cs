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

                tbUsername.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void tbEmail_Enter(object sender, EventArgs e)
        {
            if (tbEmail.Text == "Enter email")
            {
                tbEmail.Text = "";

                tbEmail.StateCommon.Content.Color1 = Color.Black;
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

                tbUsername.StateCommon.Content.Color1 = Color.DarkGray;
            }
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                tbEmail.Text = "Enter email";

                tbEmail.StateCommon.Content.Color1 = Color.DarkGray;
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Enter password")
            {
                tbPassword.Text = "";

                tbPassword.StateCommon.Content.Color1 = Color.Black;
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "Enter password";

                tbPassword.StateCommon.Content.Color1 = Color.DarkGray;
                tbPassword.UseSystemPasswordChar = false;

            }
        }

        private void tbConfpass_Enter(object sender, EventArgs e)
        {
            if (tbConfpass.Text == "Confirm password")
            {
                tbConfpass.Text = "";

                tbConfpass.StateCommon.Content.Color1 = Color.Black;
                tbConfpass.UseSystemPasswordChar = true;

            }
        }

        private void tbConfpass_Leave(object sender, EventArgs e)
        {
            if (tbConfpass.Text == "")
            {
                tbConfpass.Text = "Confirm password";

                tbConfpass.StateCommon.Content.Color1 = Color.DarkGray;
                tbConfpass.UseSystemPasswordChar = false;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
