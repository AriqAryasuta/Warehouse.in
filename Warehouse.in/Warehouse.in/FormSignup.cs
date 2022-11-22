using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=atA_251201;Database=WarehouseinDb";
        public static NpgsqlCommand cmd;
        private string sql = null;

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            lblUsername.Visible = false;
        }

        private void tbEmail_Enter(object sender, EventArgs e)
        {
            lblEmail.Visible = false;
        }

        private void tbUsername_Validated(object sender, EventArgs e)
        {

        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                lblUsername.Visible = true;
            }
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                lblEmail.Visible = true;
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            lblPass.Visible = false;
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                lblPass.Visible = true;

            }
        }

        private void tbConfpass_Enter(object sender, EventArgs e)
        {
            lblConfpass.Visible = false;
        }

        private void tbConfpass_Leave(object sender, EventArgs e)
        {
            if (tbConfpass.Text == "")
            {
                lblConfpass.Visible = true;

            }
        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            formLogin login = new formLogin();

            login.Show();
            this.Hide();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text) || string.IsNullOrEmpty(tbPassword.Text) || string.IsNullOrEmpty(tbEmail.Text) || string.IsNullOrEmpty(tbConfpass.Text))
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
                        Username = tbUsername.Text.ToLower(),
                        Password = tbPassword.Text,
                        Email = tbEmail.Text
                    };
                    accountCheck(user);
                }
                else
                {
                    MessageBox.Show("Password tidak sesuai dengan Konfirmasi Password");
                }
            }
        }

        private void newAccount(Person user)
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
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Pendaftaran berhasil");
                    Homepage home = new Homepage();
                    conn.Close();
                    this.Hide();
                    home.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "GAGAL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accountCheck(Person user)
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                sql = "select * from account_check(:_username)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_username", user.Username);
                int check = (int)cmd.ExecuteScalar();
                if(check == 1)
                {
                    MessageBox.Show("Username telah digunakan");
                    return;
                }
                else
                {
                    newAccount(user);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "GAGAL!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FormSignup_Load(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
            tbUsername.Select();
            lblUsername.Visible = false;
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {
            tbEmail.Select();
            lblEmail.Visible = false;
        }

        private void lblPass_Click(object sender, EventArgs e)
        {
            tbPassword.Select();
            lblPass.Visible = false;
        }

        private void lblConfpass_Click(object sender, EventArgs e)
        {
            tbConfpass.Select();
            lblConfpass.Visible = false;
        }
    }
}
