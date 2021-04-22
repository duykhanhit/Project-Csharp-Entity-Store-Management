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
    public partial class frmOrderDetail : Form
    {
        private int orderID;
        StoreEntities data = new StoreEntities();
        public frmOrderDetail()
        {
            InitializeComponent();
        }

        public int OrderID { get => orderID; set => orderID = value; }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            getAllInfor();
            getAllProduct();
        }
        public void getAllInfor()
        {
            Order order = data.Orders.Where(p => p.orderID == orderID).SingleOrDefault();
            lbOrderID.Text = lbOrderID.Text + order.orderID;
            lbTotalMoney.Text = lbTotalMoney.Text + order.totalAmount+"vnđ";
            String[] date = order.createdAt.ToString().Split(' ');
            lbDate.Text = lbDate.Text + date[0];
            User user = data.Users.Where(p => p.userID == order.userID).SingleOrDefault();
            lbUserID.Text = lbUserID.Text + user.userID;
            lbUsername.Text = lbUsername.Text + user.username;
            Customer customer = data.Customers.Where(p => p.customerID == order.customerID).SingleOrDefault();
            lbCustomerName.Text = lbCustomerName.Text + customer.name;
            lbCustomerAddress.Text = lbCustomerAddress.Text + customer.address;
            lbCustomerPhone.Text = lbCustomerPhone.Text + customer.phone;
        }
        public void getAllProduct()
        {
            //nối 2 bảng và tìm tất cả các sản phẩm trong OrderDetails theo OrderID
            var result = (from a in data.OrderDetails.Where(a => a.orderID == orderID)
                          from b in data.Products.Where(b => b.productID == a.productID)
                          select new
                          {
                              maHang = a.productID,
                              tenHang = b.name,
                              soLuong = a.quantity,
                              donGia = a.price,
                              giamGia = a.discount,
                              thanhTien = a.price * a.quantity - a.price*a.quantity*a.discount/100
                          }).ToList();
            dgvListProduct.DataSource = result;
            dgvListProduct.Columns[0].HeaderText = "Mã hàng";
            dgvListProduct.Columns[1].HeaderText = "Tên hàng";
            dgvListProduct.Columns[2].HeaderText = "Số lượng";
            dgvListProduct.Columns[3].HeaderText = "Đơn giá";
            dgvListProduct.Columns[4].HeaderText = "Giảm giá";
            dgvListProduct.Columns[5].HeaderText = "Thành tiền";


        }
    }
}
