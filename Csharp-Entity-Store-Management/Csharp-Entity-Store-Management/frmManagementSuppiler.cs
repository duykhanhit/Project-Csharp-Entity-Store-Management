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
    public partial class frmManagementSuppiler : Form
    {
        StoreEntities StoreEntities;
        public frmManagementSuppiler()
        {
            InitializeComponent();
            StoreEntities = new StoreEntities();
            
        }

        private void LoadData()
        {
            dataGridViewSupplier.DataSource = StoreEntities.Suppliers
                .Select(s => new
                {
                    MaNCC = s.supplierID,
                    TenNCC = s.name,
                    DiaChi = s.address,
                    CreatedAt = s.createdAt,
                    UpdatedAt = s.updatedAt
                }).ToList();
        }
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            string tenNCC = txtTenNCC.Text;
            string diaChi = txtDCNCC.Text;

            Supplier supplier = new Supplier();
            supplier.name = tenNCC;
            supplier.address = diaChi;

            StoreEntities.Suppliers.Add(supplier);
            StoreEntities.SaveChanges();
            txtMaNCC.Text = supplier.supplierID + "";
            LoadData();
        }

        private void dataGridViewSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtMaNCC.Text = dataGridViewSupplier.Rows[row].Cells[0].Value + "";
            txtTenNCC.Text = dataGridViewSupplier.Rows[row].Cells[1].Value +"";
            txtDCNCC.Text = dataGridViewSupplier.Rows[row].Cells[2].Value + "";
        }

        private void frmManagementSuppiler_Load(object sender, EventArgs e)
        {
            LoadData();
            txtMaNCC.ReadOnly = true;
            SetWidth();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void btnDelSupplier_Click(object sender, EventArgs e)
        {
            int removeID = int.Parse(txtMaNCC.Text);
            Supplier supplier = StoreEntities.Suppliers.
                SingleOrDefault(s => s.supplierID == removeID);
            StoreEntities.Entry(supplier).State = System.Data.Entity.EntityState.Deleted;
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Cảnh báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult.Equals(DialogResult.Yes))
            {
                StoreEntities.SaveChanges();
                ClearTextBoxes();
                LoadData();
            }
        }
        private void ClearTextBoxes()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDCNCC.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            int updateID = int.Parse(txtMaNCC.Text);
            Supplier supplier = StoreEntities.Suppliers.
                SingleOrDefault(s => s.supplierID == updateID);

            supplier.name = txtTenNCC.Text;
            supplier.address = txtDCNCC.Text;
            ClearTextBoxes();
            StoreEntities.SaveChanges();
            LoadData();
        }
        private void SetWidth()
        {
            dataGridViewSupplier.Columns[0].Width = 50;
            dataGridViewSupplier.Columns[1].Width = 140;
            dataGridViewSupplier.Columns[2].Width = 80;
            dataGridViewSupplier.Columns[3].Width = 120;
            dataGridViewSupplier.Columns[4].Width = 120;
        }

        private void txtTenNCC_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtTenNCC.Text))
            {
                txtTenNCC.Focus();
                errTenNCC.SetError(txtTenNCC, "Chưa nhập dữ liệu");
            } else
            {
                e.Cancel = false;
                errTenNCC.SetError(txtTenNCC, "");
            }
        }

        private void txtDCNCC_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDCNCC.Text))
            {
                txtDCNCC.Focus();
                errDC.SetError(txtDCNCC, "Chưa nhập dữ liệu");
            }
            else
            {
                e.Cancel = false;
                errDC.SetError(txtDCNCC, "");
            }
        }
    }
}
