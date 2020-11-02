using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCsharp
{
    public partial class frmMaintain : Form
    {
        pnOrders po = new pnOrders();
        pnProducts pp = new pnProducts();
        public frmMaintain()
        {
            InitializeComponent();
            
            
        }

        private void tpProducts_Click(object sender, EventArgs e)
        {

        }

        private void btnProductManage_Click(object sender, EventArgs e)
        {
            po.TopLevel = false;
            scManagement.Panel2.Controls.Add(po);
            po.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            po.Dock = DockStyle.Fill;
            po.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            pp.TopLevel = false;
            scManagement.Panel2.Controls.Add(pp);
            pp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pp.Dock = DockStyle.Fill;
            pp.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
