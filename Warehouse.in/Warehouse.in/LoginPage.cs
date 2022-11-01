using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Warehouse.@in
{
    public partial class formLogin : KryptonForm
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            formHomepage homepage = new formHomepage();

            homepage.Show();
            this.Hide();
        }
    }
}
