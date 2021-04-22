
namespace Csharp_Entity_Store_Management
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.grbFeature = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSuppilerManagement = new System.Windows.Forms.Button();
            this.btnStockInManagement = new System.Windows.Forms.Button();
            this.btnCategoryManagement = new System.Windows.Forms.Button();
            this.btnOrderManagement = new System.Windows.Forms.Button();
            this.btnProductManagement = new System.Windows.Forms.Button();
            this.btnAccountManagement = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grbFeature.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.panel, 2);
            this.panel.Location = new System.Drawing.Point(3, 145);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1448, 570);
            this.panel.TabIndex = 0;
            // 
            // grbFeature
            // 
            this.grbFeature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.grbFeature, 2);
            this.grbFeature.Controls.Add(this.tableLayoutPanel2);
            this.grbFeature.Location = new System.Drawing.Point(3, 3);
            this.grbFeature.Name = "grbFeature";
            this.grbFeature.Size = new System.Drawing.Size(1448, 136);
            this.grbFeature.TabIndex = 1;
            this.grbFeature.TabStop = false;
            this.grbFeature.Text = "Danh sách chức năng";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(1268, 15);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(15);
            this.btnLogout.Name = "btnLogout";
            this.tableLayoutPanel2.SetRowSpan(this.btnLogout, 2);
            this.btnLogout.Size = new System.Drawing.Size(150, 70);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSuppilerManagement
            // 
            this.btnSuppilerManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuppilerManagement.Location = new System.Drawing.Point(1089, 15);
            this.btnSuppilerManagement.Margin = new System.Windows.Forms.Padding(15);
            this.btnSuppilerManagement.Name = "btnSuppilerManagement";
            this.tableLayoutPanel2.SetRowSpan(this.btnSuppilerManagement, 2);
            this.btnSuppilerManagement.Size = new System.Drawing.Size(149, 70);
            this.btnSuppilerManagement.TabIndex = 0;
            this.btnSuppilerManagement.Text = "Quản lý nhà cung cấp";
            this.btnSuppilerManagement.UseVisualStyleBackColor = true;
            this.btnSuppilerManagement.Click += new System.EventHandler(this.btnSuppilerManagement_Click);
            // 
            // btnStockInManagement
            // 
            this.btnStockInManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStockInManagement.Location = new System.Drawing.Point(910, 15);
            this.btnStockInManagement.Margin = new System.Windows.Forms.Padding(15);
            this.btnStockInManagement.Name = "btnStockInManagement";
            this.tableLayoutPanel2.SetRowSpan(this.btnStockInManagement, 2);
            this.btnStockInManagement.Size = new System.Drawing.Size(149, 70);
            this.btnStockInManagement.TabIndex = 0;
            this.btnStockInManagement.Text = "Quản lý nhập kho";
            this.btnStockInManagement.UseVisualStyleBackColor = true;
            this.btnStockInManagement.Click += new System.EventHandler(this.btnStockInManagement_Click);
            // 
            // btnCategoryManagement
            // 
            this.btnCategoryManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCategoryManagement.Location = new System.Drawing.Point(731, 15);
            this.btnCategoryManagement.Margin = new System.Windows.Forms.Padding(15);
            this.btnCategoryManagement.Name = "btnCategoryManagement";
            this.tableLayoutPanel2.SetRowSpan(this.btnCategoryManagement, 2);
            this.btnCategoryManagement.Size = new System.Drawing.Size(149, 70);
            this.btnCategoryManagement.TabIndex = 0;
            this.btnCategoryManagement.Text = "Quản lý danh mục";
            this.btnCategoryManagement.UseVisualStyleBackColor = true;
            this.btnCategoryManagement.Click += new System.EventHandler(this.btnCategoryManagement_Click);
            // 
            // btnOrderManagement
            // 
            this.btnOrderManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrderManagement.Location = new System.Drawing.Point(373, 15);
            this.btnOrderManagement.Margin = new System.Windows.Forms.Padding(15);
            this.btnOrderManagement.Name = "btnOrderManagement";
            this.tableLayoutPanel2.SetRowSpan(this.btnOrderManagement, 2);
            this.btnOrderManagement.Size = new System.Drawing.Size(149, 70);
            this.btnOrderManagement.TabIndex = 0;
            this.btnOrderManagement.Text = "Quản lý hoá đơn";
            this.btnOrderManagement.UseVisualStyleBackColor = true;
            this.btnOrderManagement.Click += new System.EventHandler(this.btnOrderManagement_Click);
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductManagement.Location = new System.Drawing.Point(194, 15);
            this.btnProductManagement.Margin = new System.Windows.Forms.Padding(15);
            this.btnProductManagement.Name = "btnProductManagement";
            this.tableLayoutPanel2.SetRowSpan(this.btnProductManagement, 2);
            this.btnProductManagement.Size = new System.Drawing.Size(149, 70);
            this.btnProductManagement.TabIndex = 0;
            this.btnProductManagement.Text = "Quản lý sản phẩm";
            this.btnProductManagement.UseVisualStyleBackColor = true;
            this.btnProductManagement.Click += new System.EventHandler(this.btnProductManagement_Click);
            // 
            // btnAccountManagement
            // 
            this.btnAccountManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccountManagement.Location = new System.Drawing.Point(552, 15);
            this.btnAccountManagement.Margin = new System.Windows.Forms.Padding(15);
            this.btnAccountManagement.Name = "btnAccountManagement";
            this.tableLayoutPanel2.SetRowSpan(this.btnAccountManagement, 2);
            this.btnAccountManagement.Size = new System.Drawing.Size(149, 70);
            this.btnAccountManagement.TabIndex = 0;
            this.btnAccountManagement.Text = "Quản lý tài khoản";
            this.btnAccountManagement.UseVisualStyleBackColor = true;
            this.btnAccountManagement.Click += new System.EventHandler(this.btnAccountManagement_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashboard.Location = new System.Drawing.Point(15, 15);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(15);
            this.btnDashboard.Name = "btnDashboard";
            this.tableLayoutPanel2.SetRowSpan(this.btnDashboard, 2);
            this.btnDashboard.Size = new System.Drawing.Size(149, 70);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grbFeature, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.80474F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.19526F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1454, 718);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Controls.Add(this.btnDashboard, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLogout, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnProductManagement, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSuppilerManagement, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnOrderManagement, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnStockInManagement, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAccountManagement, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCategoryManagement, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 29);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1433, 100);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 742);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.grbFeature.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox grbFeature;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSuppilerManagement;
        private System.Windows.Forms.Button btnStockInManagement;
        private System.Windows.Forms.Button btnCategoryManagement;
        private System.Windows.Forms.Button btnOrderManagement;
        private System.Windows.Forms.Button btnProductManagement;
        private System.Windows.Forms.Button btnAccountManagement;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}