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
    public partial class RequestForm : Form
{
    public RequestForm()
    {
        InitializeComponent();
    }
        private NpgsqlConnection conn2;
        string connstring2 = "Host=localhost;Port=5432;Username=postgres;Password=atA_251201;Database=WarehouseinDb";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        public void RefreshData()
        {
            conn2 = new NpgsqlConnection(connstring2);
            try
            {
                conn2.Open();
                dgvData.DataSource = null;
                sql = "select * from st_select()";
                cmd = new NpgsqlCommand(sql, conn2);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;

                conn2.Close();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn2 = new NpgsqlConnection(connstring2);
            try
            {
                conn2.Open();
                sql = @"select * from st_insert(:_items, :_quantity, :_category)";
                cmd = new NpgsqlCommand(sql, conn2);
                cmd.Parameters.AddWithValue("_items", tbName.Text);
                cmd.Parameters.AddWithValue("_quantity", int.Parse(tbQuantity.Text));
                cmd.Parameters.AddWithValue("_category", cbCategory.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data item berhasil disimpan", "Well Done!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn2.Close();
                    RefreshData();
                    tbName.Text = tbQuantity.Text = cbCategory.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "INSERT FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn2.Close();
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RequestForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
