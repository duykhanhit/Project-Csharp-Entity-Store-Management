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
    public partial class frmManagementOrder : Form
    {
        int orderIDTemp = -1;
        StoreEntities data = new StoreEntities();
        public frmManagementOrder()
        {
            InitializeComponent();
        }

        private void frmManagementOrder_Load(object sender, EventArgs e)
        {

            loadData();
            
        }
        public void loadData()
        {
            var result = data.Orders.Select(p => new {
                orderID = p.orderID,
                customerID = p.customerID,
                userId = p.userID,
                createAt = p.createdAt
            }).ToList();

            dgvOrder.DataSource = result.ToList();
        }

        private void cellClickItem(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataGridViewRow = dgvOrder.CurrentRow;
            String orderID = dataGridViewRow.Cells[0].Value.ToString();
            String cusID = dataGridViewRow.Cells[1].Value.ToString();
            String userID = dataGridViewRow.Cells[2].Value.ToString();
            String dateCreate = dataGridViewRow.Cells[3].Value.ToString();
            orderIDTemp = int.Parse(orderID);
            
            lbOrderID.Text = "Mã hóa đơn:" + orderID;
            lbCusID.Text = "Mã khách hàng: " + cusID;
            lbCreateAt.Text = "Ngày lập: " + dateCreate;
            lbUserID.Text = "Mã nhân viên: " + userID;
        }

        private void btnDeleteAOrder_Click(object sender, EventArgs e)
        {
            
            if (orderIDTemp!=-1)
            {
                DialogResult dialog =  MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (dialog.Equals(DialogResult.Yes))
                {
                    Order order = data.Orders.Find(orderIDTemp);
                    data.Orders.Remove(order);
                    data.SaveChanges();
                    loadData();
                }
                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 hóa đơn để xóa!", "Thông báo");
            }
        }

        private void btnShowAOrder_Click(object sender, EventArgs e)
        {
            if (orderIDTemp!=-1)
            {
                frmOrderDetail frmOrderDetail = new frmOrderDetail();
                frmOrderDetail.OrderID = orderIDTemp;
                frmOrderDetail.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 hóa đơn để xem!", "Thông báo");
            }
        }
    }
}
