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

namespace Warehouse.@in
{
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=monopoki;Database=WarehouseinDb";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        public void RefreshData()
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                dgvData.DataSource = null;
                sql = "select * from st_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "GAGAL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            RefreshData();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormStock_Load(object sender, EventArgs e)
        {

        }

        public void searchData(string valueToSearch)
        {
            conn.Open();
            dgvData.DataSource = null;
            sql = "select * from tb_stock where concat(lower(id),lower(items),lower(category),quantity) like '%" + valueToSearch+"%'";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            NpgsqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            dgvData.DataSource = dt;

            conn.Close();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string valueToSearch = tbSearch.Text.ToString().ToLower();
            string query = "select * from tb_stock where concat(lower(id),lower(items),lower(category),quantity, lower(capacity), ExpDate, material) like '%" + valueToSearch + "%'";
            searchData( valueToSearch);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
