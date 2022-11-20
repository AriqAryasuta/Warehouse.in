using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Warehouse.@in
{
    public partial class FormSignup : Form
{
        public FormSignup()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=atA_251201;Database=WarehouseinDb";
        public static NpgsqlCommand cmd;
        private string sql = null;


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
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "Enter password";

                tbPassword.StateCommon.Content.Color1 = Color.DarkGray;
            }
        }

        private void tbConfpass_Enter(object sender, EventArgs e)
        {
            if (tbConfpass.Text == "Confirm password")
            {
                tbConfpass.Text = "";

                tbConfpass.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void tbConfpass_Leave(object sender, EventArgs e)
        {
            if (tbConfpass.Text == "")
            {
                tbConfpass.Text = "Confirm password";

                tbConfpass.StateCommon.Content.Color1 = Color.DarkGray;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbUsername.Text) || string.IsNullOrEmpty(tbPassword.Text) || string.IsNullOrEmpty(tbEmail.Text) || string.IsNullOrEmpty(tbConfpass.Text))
            {
                MessageBox.Show("Mohon isi semua kolom");
                return;
            }
            else
            {
                if (tbPassword.Text == tbConfpass.Text)
                {
                    var user = new Person
                    {
                        Username = tbUsername.Text,
                        Password = tbPassword.Text,
                        Email = tbEmail.Text
                    };
                    newAcount(user);
                }
                else
                {
                    MessageBox.Show("Password tidak sesuai dengan Konfirmasi Password");
                }
            }
            

        }

        private void newAcount(Person user)
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                sql = @"select * from user_insert(:_username, :_password, :_email)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_username", user.Username);
                cmd.Parameters.AddWithValue("_password", user.Password);
                cmd.Parameters.AddWithValue("_email", user.Email);
                if((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Pendaftaran berhasil");
                    Homepage home = new Homepage();
                    this.Hide();
                    home.Show();
                }
            }
            catch
            {
                MessageBox.Show("Pendaftaran Gagal");
            }
        }
    }
}
