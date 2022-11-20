using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse.@in
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }
        private Form activeForm;

        private void OpenChildForm( Form childForm, object btnSender)
        {
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            buttonHome.PerformClick();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formHome(), sender);
        }

        private void buttonRequest_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RequestForm(), sender);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonStock_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormStock(), sender);
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ExportForm(), sender);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panelDesktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }
    }
}
