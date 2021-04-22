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
    public partial class frmManagementProduct : Form
    {
        StoreEntities db = new StoreEntities();
        public frmManagementProduct()
        {
            InitializeComponent();
            loadData();
            addBinding();
        }
        #region methods
        void addBinding()
        {
            txtTen.DataBindings.Clear();
            cbLoai.DataBindings.Clear();
            txtSoLuong.DataBindings.Clear();
            txtDonGia.DataBindings.Clear();
            

            txtTen.DataBindings.Add(new Binding("Text", dataSanPham.DataSource, "tensp", true, DataSourceUpdateMode.Never));
            cbLoai.DataBindings.Add(new Binding("Text", dataSanPham.DataSource, "loai", true, DataSourceUpdateMode.Never));
            txtSoLuong.DataBindings.Add(new Binding("Text", dataSanPham.DataSource, "soluong", true, DataSourceUpdateMode.Never));
            txtDonGia.DataBindings.Add(new Binding("Text", dataSanPham.DataSource, "dongia", true, DataSourceUpdateMode.Never));
         

        }
        void loadData()
        {
            var result = from c in db.Products select new { ID = c.productID, tensp = c.name, loai = c.Category.name, soluong = c.stockOnHand, dongia = c.price, ngaytao = c.createdAt, ngaycapnhat = c.updatedAt };
            dataSanPham.DataSource = result.ToList();
            dataSanPham.Columns[0].HeaderText = "ID";
            dataSanPham.Columns[0].Width = 50;
            dataSanPham.Columns[1].HeaderText = "Tên hàng";
            dataSanPham.Columns[2].HeaderText = "Loại hàng";
            dataSanPham.Columns[3].HeaderText = "Số lượng";
            dataSanPham.Columns[4].HeaderText = "Đơn giá";
            
            dataSanPham.Columns[5].HeaderText = "Ngày nhập";
            dataSanPham.Columns[5].Width = 150;
            dataSanPham.Columns[6].HeaderText = "Ngày cập nhật";
            dataSanPham.Columns[6].Width = 150;
        }
        void addProduct()
        {
            try
            {
                Product sp = new Product() { name = txtTen.Text, stockOnHand = Convert.ToInt32(txtSoLuong.Text), price = long.Parse(txtDonGia.Text), categoryID = Convert.ToInt32(cbLoai.SelectedValue), createdAt=DateTime.Now,updatedAt=DateTime.Now };
                db.Products.Add(sp);
                db.SaveChanges();
                loadData();
                addBinding();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi: " + ex.Message, "Cảnh báo");
            }
        }
        void deleteProduct()
        {
            try
            {

                DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn xoá!", "Cảnh bao", MessageBoxButtons.YesNo);
                if (re == System.Windows.Forms.DialogResult.Yes)
                {
                    int idSpXoa = Convert.ToInt32(dataSanPham.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                    Product spXoa = db.Products.Where(q => q.productID == idSpXoa).SingleOrDefault();
                    List< StockIn> stXoa = db.StockIns.Where(q => q.productID == idSpXoa).ToList();
                    
                    if (stXoa != null)
                        {
                        foreach (StockIn i in stXoa)
                        {
                            db.StockIns.Remove(i);
                        }
                    }
                    db.Products.Remove(spXoa);
                    db.SaveChanges();
                }
                loadData();
                addBinding();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi: " + ex.Message, "Cảnh báo");
            }
            
        }
        void updateProduct()
        {
            try
            {

                int idSpSua = Convert.ToInt32(dataSanPham.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                Product spSua = db.Products.Find(idSpSua);

                spSua.name = txtTen.Text;
                spSua.stockOnHand = Convert.ToInt32(txtSoLuong.Text);
                spSua.price = long.Parse(txtDonGia.Text);
                spSua.categoryID = Convert.ToInt32(cbLoai.SelectedValue);

                spSua.updatedAt = DateTime.Now;
                db.SaveChanges();
                loadData();
                addBinding();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi: " + ex.Message, "Cảnh báo");
            }

        }
        void findProduct()
        {
            var result = from c in db.Products
                         where c.name==txtTen.Text
                         select new { ID = c.productID, tensp = c.name, loai = c.Category.name, soluong = c.stockOnHand, dongia = c.price, ngaytao = c.createdAt, ngaycapnhat = c.updatedAt };
            dataSanPham.DataSource = result.ToList();
            dataSanPham.Columns[0].HeaderText = "ID";
            dataSanPham.Columns[0].Width = 50;
            dataSanPham.Columns[1].HeaderText = "Tên hàng";
            dataSanPham.Columns[2].HeaderText = "Loại hàng";
            dataSanPham.Columns[3].HeaderText = "Số lượng";
            dataSanPham.Columns[4].HeaderText = "Đơn giá";
            dataSanPham.Columns[5].HeaderText = "Ngày nhập";
            dataSanPham.Columns[5].Width = 150;
            dataSanPham.Columns[6].HeaderText = "Ngày cập nhật";
            dataSanPham.Columns[6].Width = 150;
            addBinding();
        }
        #endregion
        #region Events
        private void frmManagementProduct_Load(object sender, EventArgs e)
        {
            //loadData();
            var resultLoai = from c in db.Categories select c;
            cbLoai.DataSource = resultLoai.ToList();
            cbLoai.DisplayMember = "name";
            cbLoai.ValueMember = "categoryID";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            addProduct();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            deleteProduct();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            updateProduct();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            findProduct();
        }
        #endregion
    }
}
