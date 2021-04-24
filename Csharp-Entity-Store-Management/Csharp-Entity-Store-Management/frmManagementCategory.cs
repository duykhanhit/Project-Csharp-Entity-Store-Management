﻿using System;
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
    public partial class frmManagementCategory : Form
    {
        StoreEntities StoreEntities;
        public frmManagementCategory()
        {
            InitializeComponent();
            StoreEntities = new StoreEntities();
            dataGridViewCategory.RowTemplate.Height = 25;
        }
        private void LoadData()
        {
            dataGridViewCategory.DataSource = StoreEntities.Categories.Select(c => new
            {
                c.categoryID,
                c.name,
                c.createdAt,
                c.updatedAt
            }).ToList();
        }

        private void dataGridViewCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtMaDM.Text = dataGridViewCategory.Rows[row].Cells[0].Value + "";
            txtTenDM.Text = dataGridViewCategory.Rows[row].Cells[1].Value + "";
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string tenDanhMuc = txtTenDM.Text;
            if(string.IsNullOrEmpty(tenDanhMuc))
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin", 
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                Category category = new Category { name = tenDanhMuc };
                StoreEntities.Categories.Add(category);
                StoreEntities.SaveChanges();
                txtMaDM.Text = category.categoryID + "";
                LoadData();
                MessageBox.Show("Thêm danh mục thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            int updateID = int.Parse(txtMaDM.Text);
            Category category = StoreEntities.Categories.
                SingleOrDefault(c => c.categoryID == updateID);
            category.name = txtTenDM.Text;
            if (string.IsNullOrEmpty(category.name))
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ClearTextBoxes();
                StoreEntities.SaveChanges();
                LoadData();
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
        }

        private void btnDelCategory_Click(object sender, EventArgs e)
        {
            int removeID = int.Parse(txtMaDM.Text);
            Category category = StoreEntities.Categories.
                SingleOrDefault(c => c.categoryID == removeID);
            StoreEntities.Entry(category).State = System.Data.Entity.EntityState.Deleted;
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
            txtMaDM.Text = "";
            txtTenDM.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void frmManagementCategory_Load(object sender, EventArgs e)
        {
            LoadData();
            txtMaDM.ReadOnly = true;
            SetWidth();
        }
        private void SetWidth()
        {
            dataGridViewCategory.Columns[0].HeaderText = "Mã danh mục";
            dataGridViewCategory.Columns[1].HeaderText = "Tên danh mục";
            dataGridViewCategory.Columns[2].HeaderText = "Ngày tạo";
            dataGridViewCategory.Columns[3].HeaderText = "Ngày cập nhật";
            dataGridViewCategory.Columns[0].Width = 100;
            dataGridViewCategory.Columns[1].Width = 110;
            dataGridViewCategory.Columns[2].Width = 190;
            dataGridViewCategory.Columns[3].Width = 180;
        }
    }
}
