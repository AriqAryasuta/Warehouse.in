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
            dtExpire.Visible = false;
    }
        
        private NpgsqlConnection conn2;
        string connstring2 = "Host=localhost;Port=5432;Username=postgres;Password=monopoki;Database=WarehouseinDb";

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Failed Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        { 
            lbExpire.Visible = false;
            tbCapacity.Visible = false;
            lbCapacity.Visible = false;
            tbMaterial.Visible = false;
            lbMaterial.Visible = false;
            dtExpire.Visible = false;

            if (cbCategory.SelectedItem.ToString() == "food")
            {
                dtExpire.Visible = true;
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
                if(cbCategory.SelectedItem.ToString() == "food")
                {
                    if (string.IsNullOrEmpty(dtExpire.Value.ToString()) || string.IsNullOrEmpty(tbName.Text) || ndQuantity.Text == null || string.IsNullOrEmpty(cbCategory.Text))
                    {
                        MessageBox.Show("Mohon isi semua kolom");
                        return;
                    }
                    else
                    {
                        var items = new food
                        {
                            Items = tbName.Text.ToLower(),
                            Quantity = Convert.ToInt32(ndQuantity.Text),
                            Category = cbCategory.Text,
                            ExpiredDate = dtExpire.Value.ToString("dd/MM/yyyy")

                        };
                        addNewFood(items);
                        MessageBox.Show("Item " + tbName.Text.ToString() + " berhasil ditambahkan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else if(cbCategory.SelectedItem.ToString() == "beverages")
                {
                    if(tbCapacity.Text == null || string.IsNullOrEmpty(tbName.Text) || ndQuantity.Text == null || string.IsNullOrEmpty(cbCategory.Text))
                    {
                        MessageBox.Show("Mohon isi semua kolom");
                        return;
                    }
                    else
                    {
                        var items = new beverage
                        {
                            Items = tbName.Text.ToLower(),
                            Quantity = Convert.ToInt32(ndQuantity.Text),
                            Category = cbCategory.Text,
                            Capacity = Convert.ToInt32(tbCapacity.Text),
                        };
                        addNewBeverage(items);
                        MessageBox.Show("Item " + tbName.Text.ToString() + " berhasil ditambahkan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else if(cbCategory.SelectedItem.ToString() == "furniture")
                {
                    if (tbMaterial.Text == null || string.IsNullOrEmpty(tbName.Text) || ndQuantity.Text == null || string.IsNullOrEmpty(cbCategory.Text))
                    {
                        MessageBox.Show("Mohon isi semua kolom");
                        return;
                    }
                    else
                    {
                        var items = new furniture
                        {
                            Items = tbName.Text,
                            Quantity = Convert.ToInt32(ndQuantity.Text),
                            Category = cbCategory.Text,
                            MadeOf = tbMaterial.Text
                        };
                        addNewFurniture(items);
                        MessageBox.Show("Item " + tbName.Text.ToString() + " berhasil ditambahkan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    var items = new Item
                    {
                        Items = tbName.Text,
                        Quantity = Convert.ToInt32(ndQuantity.Text),
                        Category = cbCategory.Text
                    };
                    addNewItem(items);
                }

            }
            
        }
        private void addNewFood(food user)
        {
            conn2 = new NpgsqlConnection(connstring2);
            try
            {
                conn2.Open();
                sql = @"select * from st_insertfood(:_items, :_quantity, :_category, :_date)";
                cmd = new NpgsqlCommand(sql, conn2);
                cmd.Parameters.AddWithValue(":_items", user.Items);
                cmd.Parameters.AddWithValue(":_quantity", user.Quantity);
                cmd.Parameters.AddWithValue(":_category", user.Category);
                cmd.Parameters.AddWithValue(":_date", user.ExpiredDate);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Item " + user.Items +  " telah ditambahkan sebelumnya");
                    conn2.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "GAGAL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void addNewBeverage(beverage user)
        {
            conn2 = new NpgsqlConnection(connstring2);
            try
            {
                conn2.Open();
                sql = @"select * from st_insertbeverage(:_items, :_quantity, :_category, :_capacity)";
                cmd = new NpgsqlCommand(sql, conn2);
                cmd.Parameters.AddWithValue(":_items", user.Items);
                cmd.Parameters.AddWithValue(":_quantity", user.Quantity);
                cmd.Parameters.AddWithValue(":_category", user.Category);
                cmd.Parameters.AddWithValue(":_capacity", user.Capacity);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Item " + user.Items + " telah ditambahkan");
                    conn2.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "GAGAL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void addNewFurniture(furniture user)
        {
            conn2 = new NpgsqlConnection(connstring2);
            try
            {
                conn2.Open();
                sql = @"select * from st_insertfurniture(:_items, :_quantity, :_category, :_material)";
                cmd = new NpgsqlCommand(sql, conn2);
                cmd.Parameters.AddWithValue(":_items", user.Items);
                cmd.Parameters.AddWithValue(":_quantity", user.Quantity);
                cmd.Parameters.AddWithValue(":_category", user.Category);
                cmd.Parameters.AddWithValue(":_material", user.MadeOf);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Item " + user.Items + " telah ditambahkan");
                    conn2.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "GAGAL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void addNewItem(Item user)
        {
            conn2 = new NpgsqlConnection(connstring2);
            try
            {
                conn2.Open();
                sql = @"select * from st_insertfood(:_items, :_quantity, :_category)";
                cmd = new NpgsqlCommand(sql, conn2);
                cmd.Parameters.AddWithValue(":_items", user.Items);
                cmd.Parameters.AddWithValue(":_quantity", user.Quantity);
                cmd.Parameters.AddWithValue(":_category", user.Category);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Item " + user.Items + " telah ditambahkan");
                    conn2.Close();
                }
                else
                {
                    if ((MessageBox.Show("Item " + user.Items + "Telah ada pada gudang", "Anda ingin menambahkan jumlah barang?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes))
                    {
                        conn2.Close();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "GAGAL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
