
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
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnAccountManagement = new System.Windows.Forms.Button();
            this.btnProductManagement = new System.Windows.Forms.Button();
            this.btnOrderManagement = new System.Windows.Forms.Button();
            this.btnCategoryManagement = new System.Windows.Forms.Button();
            this.btnStockInManagement = new System.Windows.Forms.Button();
            this.btnSuppilerManagement = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.grbFeature.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 146);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1506, 623);
            this.panel.TabIndex = 0;
            // 
            // grbFeature
            // 
            this.grbFeature.Controls.Add(this.btnLogout);
            this.grbFeature.Controls.Add(this.btnSuppilerManagement);
            this.grbFeature.Controls.Add(this.btnStockInManagement);
            this.grbFeature.Controls.Add(this.btnCategoryManagement);
            this.grbFeature.Controls.Add(this.btnOrderManagement);
            this.grbFeature.Controls.Add(this.btnProductManagement);
            this.grbFeature.Controls.Add(this.btnAccountManagement);
            this.grbFeature.Controls.Add(this.btnDashboard);
            this.grbFeature.Location = new System.Drawing.Point(12, 12);
            this.grbFeature.Name = "grbFeature";
            this.grbFeature.Size = new System.Drawing.Size(1506, 128);
            this.grbFeature.TabIndex = 1;
            this.grbFeature.TabStop = false;
            this.grbFeature.Text = "Danh sách chức năng";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(15, 39);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(135, 72);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnAccountManagement
            // 
            this.btnAccountManagement.Location = new System.Drawing.Point(585, 39);
            this.btnAccountManagement.Name = "btnAccountManagement";
            this.btnAccountManagement.Size = new System.Drawing.Size(135, 72);
            this.btnAccountManagement.TabIndex = 0;
            this.btnAccountManagement.Text = "Quản lý tài khoản";
            this.btnAccountManagement.UseVisualStyleBackColor = true;
            this.btnAccountManagement.Click += new System.EventHandler(this.btnAccountManagement_Click);
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.Location = new System.Drawing.Point(205, 39);
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.Size = new System.Drawing.Size(135, 72);
            this.btnProductManagement.TabIndex = 0;
            this.btnProductManagement.Text = "Quản lý sản phẩm";
            this.btnProductManagement.UseVisualStyleBackColor = true;
            this.btnProductManagement.Click += new System.EventHandler(this.btnProductManagement_Click);
            // 
            // btnOrderManagement
            // 
            this.btnOrderManagement.Location = new System.Drawing.Point(395, 39);
            this.btnOrderManagement.Name = "btnOrderManagement";
            this.btnOrderManagement.Size = new System.Drawing.Size(135, 72);
            this.btnOrderManagement.TabIndex = 0;
            this.btnOrderManagement.Text = "Quản lý hoá đơn";
            this.btnOrderManagement.UseVisualStyleBackColor = true;
            this.btnOrderManagement.Click += new System.EventHandler(this.btnOrderManagement_Click);
            // 
            // btnCategoryManagement
            // 
            this.btnCategoryManagement.Location = new System.Drawing.Point(775, 39);
            this.btnCategoryManagement.Name = "btnCategoryManagement";
            this.btnCategoryManagement.Size = new System.Drawing.Size(135, 72);
            this.btnCategoryManagement.TabIndex = 0;
            this.btnCategoryManagement.Text = "Quản lý danh mục";
            this.btnCategoryManagement.UseVisualStyleBackColor = true;
            this.btnCategoryManagement.Click += new System.EventHandler(this.btnCategoryManagement_Click);
            // 
            // btnStockInManagement
            // 
            this.btnStockInManagement.Location = new System.Drawing.Point(965, 39);
            this.btnStockInManagement.Name = "btnStockInManagement";
            this.btnStockInManagement.Size = new System.Drawing.Size(135, 72);
            this.btnStockInManagement.TabIndex = 0;
            this.btnStockInManagement.Text = "Quản lý nhập kho";
            this.btnStockInManagement.UseVisualStyleBackColor = true;
            this.btnStockInManagement.Click += new System.EventHandler(this.btnStockInManagement_Click);
            // 
            // btnSuppilerManagement
            // 
            this.btnSuppilerManagement.Location = new System.Drawing.Point(1155, 39);
            this.btnSuppilerManagement.Name = "btnSuppilerManagement";
            this.btnSuppilerManagement.Size = new System.Drawing.Size(135, 72);
            this.btnSuppilerManagement.TabIndex = 0;
            this.btnSuppilerManagement.Text = "Quản lý nhà cung cấp";
            this.btnSuppilerManagement.UseVisualStyleBackColor = true;
            this.btnSuppilerManagement.Click += new System.EventHandler(this.btnSuppilerManagement_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1345, 39);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(135, 72);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 781);
            this.Controls.Add(this.grbFeature);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.grbFeature.ResumeLayout(false);
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
    }
}