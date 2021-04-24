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
    public partial class frmManagementStockIn : Form
    {
        StoreEntities db =new StoreEntities();
        public frmManagementStockIn()
        {
            InitializeComponent();
        }

        #region methods
        void loadData()
        {
            var result = from c in db.StockIns select new { IDNCC = c.supplierID, IDSP = c.productID, soluong = c.quantity, createAt = c.createdAt, updateAt = c.updatedAt };
            dataNhapKho.DataSource = result.ToList();
            dataNhapKho.Columns[0].HeaderText = "Mã nhà cung cấp";
        
            dataNhapKho.Columns[1].HeaderText = "Mã hàng";
    
            dataNhapKho.Columns[2].HeaderText = "Số lượng";
            dataNhapKho.Columns[3].HeaderText = "Ngày nhập";
   
            dataNhapKho.Columns[4].HeaderText = "Ngày cập nhật";
        


        }
        void addStockIn()
        {
            try
            {
                int idSpThem = Convert.ToInt32(cbTen.SelectedValue);
                int idNCCThem = Convert.ToInt32(cbNCC.SelectedValue);
                StockIn stThem = db.StockIns.Find(idSpThem, idNCCThem);
                if (stThem == null)
                {

                    StockIn st = new StockIn() { productID = idSpThem, supplierID = Convert.ToInt32(cbNCC.SelectedValue), quantity = Convert.ToInt32(txtSoLuong.Text), createdAt = DateTime.Now, updatedAt = DateTime.Now };
                    db.StockIns.Add(st);
                }
                else
                {
                    stThem.quantity += Convert.ToInt32(txtSoLuong.Text);

                }
                db.SaveChanges();
                loadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi: " + ex.Message, "Cảnh báo");
            }

        }

        #endregion
        #region Events
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "")
            {
                txtSoLuong.Focus();
                errorProvider1.SetError(txtSoLuong, "Soluong can not be empty.");
            }
            else
                addStockIn();
        }

        private void frmManagementStockIn_Load(object sender, EventArgs e)
        {
            loadData();
            var resultNCC = from c in db.Suppliers select c;
            cbNCC.DataSource = resultNCC.ToList();
            cbNCC.DisplayMember = "name";
            cbNCC.ValueMember = "supplierID";
            var resultSP = from c in db.Products select c;
            cbTen.DataSource = resultSP.ToList();
            cbTen.DisplayMember = "name";
            cbTen.ValueMember = "productID";
        }

        private void dataNhapKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            cbTen.Focus();
            cbTen.SelectedValue = Convert.ToInt32(dataNhapKho.Rows[d].Cells[1].Value.ToString());
            cbNCC.SelectedValue = Convert.ToInt32(dataNhapKho.Rows[d].Cells[0].Value.ToString());
            txtSoLuong.Text = dataNhapKho.Rows[d].Cells[2].Value.ToString();
        }
        private void check_SoLuong(object sender, CancelEventArgs e)
        {
            int a;
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                txtSoLuong.Focus();
                errorProvider1.SetError(txtSoLuong, "Soluong can not be empty.");
            }
            else if (!int.TryParse(txtSoLuong.Text, out a))
            {
                txtSoLuong.Focus();
                errorProvider1.SetError(txtSoLuong, "soluong can not be number.");
            }
            else if (a <= 0)
            {
                txtSoLuong.Focus();
                errorProvider1.SetError(txtSoLuong, "so luong >0");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSoLuong, "");
            }
        }
        #endregion


    }
}
