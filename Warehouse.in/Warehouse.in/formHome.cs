using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Warehouse.@in
{
    public partial class formHome : Form
    {
        public formHome()
        {
            InitializeComponent();
            //dateNow.Text = DateTime.Now.ToString("D");
        }

        private void formHome_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

    private void dateNow_Click_1(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeNow.Text = DateTime.Now.ToString("HH:mm:ss");
            dateNow.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void timeNow_Click(object sender, EventArgs e)
        {

        }
    }
}
