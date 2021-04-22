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
    public partial class frmManagementAccount : Form
    {
        StoreEntities StoreEntities;
        static List<string> Roles;
        public frmManagementAccount()
        {
            InitializeComponent();
            StoreEntities = new StoreEntities();
            Roles = new List<string>() { "admin", "user" };
            
        }
        private void LoadData()
        {
            dataGridViewAccount.DataSource = StoreEntities.Users.Select(u => new
            {
                AccountID = u.userID,
                Username = u.username,
                Password = u.password,
                Role = u.role,
                FullName = u.fullname,
                Address = u.address,
                Position = u.position,
                Phone = u.phone,
                CreatedAt = u.createdAt,
                UpdatedAt = u.updatedAt
            }).ToList();
        }

        private void dataGridViewAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtAccountID.Text = dataGridViewAccount.Rows[row].Cells[0].Value + "";
            txtTenTK.Text = dataGridViewAccount.Rows[row].Cells[1].Value + "";
            txtMK.Text = dataGridViewAccount.Rows[row].Cells[2].Value + "";
            cbxQuyen.Text = dataGridViewAccount.Rows[row].Cells[3].Value + "";
            txtHoVaTen.Text = dataGridViewAccount.Rows[row].Cells[4].Value + "";
            txtDC.Text = dataGridViewAccount.Rows[row].Cells[5].Value + "";
            txtViTri.Text = dataGridViewAccount.Rows[row].Cells[6].Value + "";
            txtDT.Text = dataGridViewAccount.Rows[row].Cells[7].Value + "";
        }

        private void frmManagementAccount_Load(object sender, EventArgs e)
        {
            cbxQuyen.DataSource = Roles;
            LoadData();
            SetWidth();
            txtAccountID.ReadOnly = true;
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.username = txtTenTK.Text;
            user.password = txtMK.Text;
            user.role = cbxQuyen.SelectedValue + "";
            user.fullname = txtHoVaTen.Text;
            user.address = txtDC.Text;
            user.position = txtViTri.Text;
            user.phone = txtDT.Text;

            User usr = StoreEntities.Users.FirstOrDefault(u => u.username.Equals(user.username));
            if(usr == null)
            {
                StoreEntities.Users.Add(user);
                StoreEntities.SaveChanges();
                txtAccountID.Text = user.userID + "";
                LoadData();
            } else
            {
                MessageBox.Show("Username đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ClearTextBoxes()
        {
            txtAccountID.Text = "";
            txtTenTK.Text = "";
            txtMK.Text = "";
            txtHoVaTen.Text = "";
            txtDC.Text = "";
            txtViTri.Text = "";
            txtDT.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void btnDelAccount_Click(object sender, EventArgs e)
        {
            int removeID = int.Parse(txtAccountID.Text);
            User user = StoreEntities.Users.
                SingleOrDefault(u => u.userID == removeID);
            StoreEntities.Entry(user).State = System.Data.Entity.EntityState.Deleted;

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Cảnh báo", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialogResult.Equals(DialogResult.Yes))
            {
                StoreEntities.SaveChanges();
                ClearTextBoxes();
                LoadData();
            }
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            int updateID = int.Parse(txtAccountID.Text);
            User user = StoreEntities.Users.
                SingleOrDefault(u => u.userID == updateID);

            user.username = txtTenTK.Text;
            user.password = txtMK.Text;
            user.role = cbxQuyen.SelectedValue + "";
            user.fullname = txtHoVaTen.Text;
            user.address = txtDC.Text;
            user.position = txtViTri.Text;
            user.phone = txtDT.Text;

            StoreEntities.SaveChanges();
            ClearTextBoxes();
            LoadData();
        }
        private void SetWidth()
        {
            dataGridViewAccount.Columns[0].Width = 70;
            dataGridViewAccount.Columns[1].Width = 70;
            dataGridViewAccount.Columns[2].Width = 70;
            dataGridViewAccount.Columns[3].Width = 50;
            dataGridViewAccount.Columns[4].Width = 120;
            dataGridViewAccount.Columns[5].Width = 80;
            dataGridViewAccount.Columns[6].Width = 70;
            dataGridViewAccount.Columns[7].Width = 80;
            dataGridViewAccount.Columns[8].Width = 120;
            dataGridViewAccount.Columns[9].Width = 120;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string userName = txtTenTK.Text;
            dataGridViewAccount.DataSource = StoreEntities.Users.
                Where(u=>u.username.Equals(userName)).Select(u => new
            {
                AccountID = u.userID,
                Username = u.username,
                Password = u.password,
                Role = u.role,
                FullName = u.fullname,
                Address = u.address,
                Position = u.position,
                Phone = u.phone,
                CreatedAt = u.createdAt,
                UpdatedAt = u.updatedAt
            }).ToList();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtTenTK_Validating(object sender, CancelEventArgs e)
        {
            Validate(errTenTK, txtTenTK, e);
        }
        private void Validate(ErrorProvider errorProvider, TextBox textBox, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Focus();
                errorProvider.SetError(textBox, "Chưa nhập dữ liệu");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox, "");
            }
        }

        private void txtMK_Validating(object sender, CancelEventArgs e)
        {
            Validate(errMK, txtMK, e);
        }

        private void txtHoVaTen_Validating(object sender, CancelEventArgs e)
        {
            Validate(errFullname, txtHoVaTen, e);
        }

        private void txtDC_Validating(object sender, CancelEventArgs e)
        {
            Validate(errDC, txtDC, e);
        }

        private void txtViTri_Validating(object sender, CancelEventArgs e)
        {
            Validate(errViTri, txtViTri, e);
        }

        private void txtDT_Validating(object sender, CancelEventArgs e)
        {
            Validate(errDT, txtDT, e);
        }
    }
}
