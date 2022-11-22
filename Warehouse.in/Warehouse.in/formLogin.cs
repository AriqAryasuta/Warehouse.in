using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Npgsql.PostgresTypes;

namespace Warehouse.@in
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=atA_251201;Database=WarehouseinDb";
        public static NpgsqlCommand cmd;
        private string sql = null;

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbUsername.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Mohon isi semua kolom");
                return;
            }
            else
            {
                var login = new Person
                {
                    Username = tbUsername.Text,
                    Password = tbPassword.Text
                };
                accountLogin(login);

            }
            
        }

        private void accountLogin(Person login)
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                sql = "select * from account_login(:_username, :_password)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_username", login.Username);
                cmd.Parameters.AddWithValue("_password", login.Password);
                int check = (int)cmd.ExecuteScalar();
                if(check == 1)
                {
                    MessageBox.Show("Login Berhasil");
                    conn.Close();
                    Homepage homepage = new Homepage();
                    homepage.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Username atau Password salah");
                    return;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "GAGAL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            lblUsername.Visible = false;
        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                lblUsername.Visible = true;
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

        private void lblSignup_Click(object sender, EventArgs e)
        {
            FormSignup signup = new FormSignup();

            signup.Show();
            this.Hide();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
            tbUsername.Select();
            lblUsername.Visible = false;
        }

        private void lblPass_Click(object sender, EventArgs e)
        {
            tbPassword.Select();
            lblPass.Visible = false;
        }
    }
}
