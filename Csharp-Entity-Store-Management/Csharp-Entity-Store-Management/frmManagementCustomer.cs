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
    public partial class frmManagementCustomer : Form
    {
        StoreEntities storeEntities;
        public int CustomerID { get; set; }
        public string PhoneNumber { get; set; }
        public frmManagementCustomer()
        {
            InitializeComponent();
            storeEntities = new StoreEntities();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int updateID = CustomerID;
            Customer customer = storeEntities.Customers.
                SingleOrDefault(c => c.customerID == updateID);

            customer.customerID = CustomerID;
            customer.name = txtCusName.Text;
            customer.address = txtCusAddress.Text;
            customer.phone = PhoneNumber;
            

            if (string.IsNullOrEmpty(customer.name) || string.IsNullOrEmpty(customer.name)
                || string.IsNullOrEmpty(customer.address) || string.IsNullOrEmpty(customer.address))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                storeEntities.SaveChanges();
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void frmManagementCustomer_Load(object sender, EventArgs e)
        {
            CustomerID = 1;
            PhoneNumber = "0377317662";
        }
    }
}
