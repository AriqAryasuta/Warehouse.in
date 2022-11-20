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
    public partial class ExportForm : Form
{
    public ExportForm()
    {
        InitializeComponent();
    }
        private NpgsqlConnection conn3;
        string connstring3 = "Host=localhost;Port=5432;Username=postgres;Password=atA_251201;Database=WarehouseinDb";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh2_Click(object sender, EventArgs e)
        {
            conn3 = new NpgsqlConnection(connstring3);
            try
            {
                conn3.Open();
                dgvData.DataSource = null;
                sql = "select * from st_select()";
                cmd = new NpgsqlCommand(sql, conn3);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;

                conn3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "GAGAL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExport_Click_1(object sender, EventArgs e)
        {
            conn3 = new NpgsqlConnection(connstring3);
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris barang yang akan dikirim!", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Apakah anda yakin mengirim barang " + r.Cells["_items"].Value.ToString() + "?", "Konfirmasi Pengiriman",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    conn3.Open();
                    sql = @"select * from st_delete(:_id)";
                    cmd = new NpgsqlCommand(sql, conn3);
                    cmd.Parameters.AddWithValue("_id", r.Cells["_id"].Value.ToString());
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Barang berhasil dikirim", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn3.Close();
                        btnRefresh2.PerformClick();
                        tbName.Text = tbQuantity.Text = tbCategory.Text = null;
                        r = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Pengiriman Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];
                tbName.Text = r.Cells["_items"].Value.ToString();
                tbCategory.Text = r.Cells["_category"].Value.ToString();
                tbQuantity.Text = r.Cells["_quantity"].Value.ToString();
            }
        }
    }
}
