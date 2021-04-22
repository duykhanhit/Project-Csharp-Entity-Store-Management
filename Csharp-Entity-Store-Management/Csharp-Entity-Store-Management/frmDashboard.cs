using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Entity_Store_Management
{
    public partial class frmDashboard : Form
    {
        private User user;

        public User User { get => user; set => user = value; }

        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            grbFeature.Text = "Xin chào: " + user.fullname + " !";

            panel.Visible = false;

        }

        private void loadPanel()
        {
            panel.Controls.Clear();
            panel.Visible = true;
        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            loadPanel();
            frmSelling frm = new frmSelling();
            frm.TopLevel = false;
            panel.Controls.Add(frm);
            panel.AutoScroll = true;
            panel.BorderStyle = BorderStyle.FixedSingle;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            loadPanel();
            frmManagementProduct frm = new frmManagementProduct();
            frm.TopLevel = false;
            panel.Controls.Add(frm);
            panel.AutoScroll = true;
            panel.BorderStyle = BorderStyle.FixedSingle;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            loadPanel();
            frmManagementOrder frm = new frmManagementOrder();
            frm.TopLevel = false;
            panel.Controls.Add(frm);
            panel.AutoScroll = true;
            panel.BorderStyle = BorderStyle.FixedSingle;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void btnAccountManagement_Click(object sender, EventArgs e)
        {
            loadPanel();
            frmManagementAccount frm = new frmManagementAccount();
            frm.TopLevel = false;
            panel.Controls.Add(frm);
            panel.AutoScroll = true;
            panel.BorderStyle = BorderStyle.FixedSingle;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void btnCategoryManagement_Click(object sender, EventArgs e)
        {
            loadPanel();
            frmManagementCategory frm = new frmManagementCategory();
            frm.TopLevel = false;
            panel.Controls.Add(frm);
            panel.AutoScroll = true;
            panel.BorderStyle = BorderStyle.FixedSingle;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void btnStockInManagement_Click(object sender, EventArgs e)
        {
            loadPanel();
            frmManagementStockIn frm = new frmManagementStockIn();
            frm.TopLevel = false;
            panel.Controls.Add(frm);
            panel.AutoScroll = true;
            panel.BorderStyle = BorderStyle.FixedSingle;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void btnSuppilerManagement_Click(object sender, EventArgs e)
        {
            loadPanel();
            frmManagementSuppiler frm = new frmManagementSuppiler();
            frm.TopLevel = false;
            panel.Controls.Add(frm);
            panel.AutoScroll = true;
            panel.BorderStyle = BorderStyle.FixedSingle;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }
    }
}
