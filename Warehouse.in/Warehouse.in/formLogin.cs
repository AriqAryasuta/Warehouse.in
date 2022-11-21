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
    public partial class formLogin : Form
{
    public formLogin()
    {
        InitializeComponent();
    }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();

            homepage.Show();
            this.Hide();
        }

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            if(tbUsername.Text == "Enter username")
            {
                tbUsername.Text = "";

                tbUsername.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                tbUsername.Text = "Enter username";

                tbUsername.StateCommon.Content.Color1 = Color.DarkGray;
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

        private void lblSignup_Click(object sender, EventArgs e)
        {
            FormSignup signup = new FormSignup();

            signup.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
