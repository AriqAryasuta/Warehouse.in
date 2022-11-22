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
        string connstring2 = "Host=localhost;Port=5432;Username=postgres;Password=010800;Database=WarehouseinDb";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        //public void RefreshData()
        //{
        //    conn2 = new NpgsqlConnection(connstring2);
        //    try
        //    {
        //        conn2.Open();
        //        dgvData.DataSource = null;
        //        sql = "select * from st_select()";
        //        cmd = new NpgsqlCommand(sql, conn2);
        //        dt = new DataTable();
        //        NpgsqlDataReader rd = cmd.ExecuteReader();
        //        dt.Load(rd);
        //        dgvData.DataSource = dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message, "Failed Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //protected override void OnShown(EventArgs e)
        //{
        //    base.OnShown(e);
        //    RefreshData();
        //}

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbExpire.Visible = false;
            lbExpire.Visible = false;
            tbCapacity.Visible = false;
            lbCapacity.Visible = false;
            tbMaterial.Visible = false;
            lbMaterial.Visible = false;
            if (cbCategory.SelectedItem.ToString() == "food")
            {
                tbExpire.Visible = true;
                lbExpire.Visible = true;
            }
            else if (cbCategory.SelectedItem.ToString() == "beverages")
            {
                tbCapacity.Visible = true;
                lbCapacity.Visible = true;
            }
            else
            {
                tbMaterial.Visible = true;
                lbMaterial.Visible = true;
            }

        }

        private void ndQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn2 = new NpgsqlConnection(connstring2);
            if (string.IsNullOrEmpty(tbName.Text) || ndQuantity.Text == null || string.IsNullOrEmpty(cbCategory.Text))
            {
                MessageBox.Show("Mohon isi semua kolom");
                return;
            }
            else
            {
                var user = new Item
                {
                    Items = tbName.Text,
                    Quantity = Convert.ToInt32(ndQuantity.Text),
                    Category = cbCategory.Text

                };
                checkItem(user);

            }
            
        }
        private void addNewItem(Item user)
        {
            conn2 = new NpgsqlConnection(connstring2);
            try
            {
                conn2.Open();
                sql = @"select * from st_insert(:_items, :_quantity, :_category)";
                cmd = new NpgsqlCommand(sql, conn2);
                cmd.Parameters.AddWithValue(":_items", user.Items);
                cmd.Parameters.AddWithValue(":_quantity", user.Quantity);
                cmd.Parameters.AddWithValue(":_category", user.Category);
                if((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Item" + user.Items +  "telah ditambahkan");
                    conn2.Close();
                }
                else
                {
                    if((MessageBox.Show("Item " + user.Items + "Telah ada pada gudang", "Anda ingin menambahkan jumlah barang?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes))
                    {
                        conn2.Close();
                        return;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "GAGAL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void checkItem(Item user)
        {
            conn2 = new NpgsqlConnection(connstring2);
            try
            {
                conn2.Open();
                sql = "select * from checkitem(:_items, :_category)";
                cmd = new NpgsqlCommand(sql, conn2);
                cmd.Parameters.AddWithValue("_items", user.Items);
                cmd.Parameters.AddWithValue(":_category", user.Category);
                if((int)cmd.ExecuteScalar() == 1)
                {
                    if ((MessageBox.Show("Item " + user.Items + " Telah ada pada gudang,anda ingin menambahkan jumlah?","konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes))
                    {
                        addNewItem(user);
                    }
                    else
                    {
                        MessageBox.Show("Item tidak ditambahkan");
                        return;
                    }

                }
                else
                {
                    addNewItem(user);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error!" + ex.Message + "why");
            }

        }
    }
}
