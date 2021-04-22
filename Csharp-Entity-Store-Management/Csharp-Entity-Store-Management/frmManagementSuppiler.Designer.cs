
namespace Csharp_Entity_Store_Management
{
    partial class frmManagementSuppiler
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
            this.components = new System.ComponentModel.Container();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.lblTenNCC = new System.Windows.Forms.Label();
            this.lblDC = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtDCNCC = new System.Windows.Forms.TextBox();
            this.dataGridViewSupplier = new System.Windows.Forms.DataGridView();
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.errTenNCC = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDC = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDelSupplier = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenNCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDC)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Location = new System.Drawing.Point(56, 27);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(47, 13);
            this.lblMaNCC.TabIndex = 3;
            this.lblMaNCC.Text = "Mã NCC";
            // 
            // lblTenNCC
            // 
            this.lblTenNCC.AutoSize = true;
            this.lblTenNCC.Location = new System.Drawing.Point(56, 65);
            this.lblTenNCC.Name = "lblTenNCC";
            this.lblTenNCC.Size = new System.Drawing.Size(51, 13);
            this.lblTenNCC.TabIndex = 4;
            this.lblTenNCC.Text = "Tên NCC";
            // 
            // lblDC
            // 
            this.lblDC.AutoSize = true;
            this.lblDC.Location = new System.Drawing.Point(56, 107);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(40, 13);
            this.lblDC.TabIndex = 5;
            this.lblDC.Text = "Địa chỉ";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(140, 27);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(181, 20);
            this.txtMaNCC.TabIndex = 2;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(140, 65);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(181, 20);
            this.txtTenNCC.TabIndex = 0;
            this.txtTenNCC.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenNCC_Validating);
            // 
            // txtDCNCC
            // 
            this.txtDCNCC.Location = new System.Drawing.Point(140, 100);
            this.txtDCNCC.Name = "txtDCNCC";
            this.txtDCNCC.Size = new System.Drawing.Size(181, 20);
            this.txtDCNCC.TabIndex = 1;
            this.txtDCNCC.Validating += new System.ComponentModel.CancelEventHandler(this.txtDCNCC_Validating);
            // 
            // dataGridViewSupplier
            // 
            this.dataGridViewSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupplier.Location = new System.Drawing.Point(49, 172);
            this.dataGridViewSupplier.Name = "dataGridViewSupplier";
            this.dataGridViewSupplier.Size = new System.Drawing.Size(559, 203);
            this.dataGridViewSupplier.TabIndex = 11;
            this.dataGridViewSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupplier_CellClick);
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.Image = global::Csharp_Entity_Store_Management.Properties.Resources.edit;
            this.btnEditSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditSupplier.Location = new System.Drawing.Point(360, 82);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(92, 38);
            this.btnEditSupplier.TabIndex = 8;
            this.btnEditSupplier.Text = "Cập nhật";
            this.btnEditSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditSupplier.UseVisualStyleBackColor = true;
            this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Csharp_Entity_Store_Management.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(413, 126);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 37);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Đóng";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = global::Csharp_Entity_Store_Management.Properties.Resources.clear;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(458, 82);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 38);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // errTenNCC
            // 
            this.errTenNCC.ContainerControl = this;
            // 
            // errDC
            // 
            this.errDC.ContainerControl = this;
            // 
            // btnDelSupplier
            // 
            this.btnDelSupplier.Image = global::Csharp_Entity_Store_Management.Properties.Resources.delete;
            this.btnDelSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelSupplier.Location = new System.Drawing.Point(458, 24);
            this.btnDelSupplier.Name = "btnDelSupplier";
            this.btnDelSupplier.Size = new System.Drawing.Size(74, 40);
            this.btnDelSupplier.TabIndex = 7;
            this.btnDelSupplier.Text = "Xóa";
            this.btnDelSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelSupplier.UseVisualStyleBackColor = true;
            this.btnDelSupplier.Click += new System.EventHandler(this.btnDelSupplier_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Image = global::Csharp_Entity_Store_Management.Properties.Resources.add;
            this.btnAddSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSupplier.Location = new System.Drawing.Point(360, 24);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(92, 40);
            this.btnAddSupplier.TabIndex = 6;
            this.btnAddSupplier.Text = "Thêm";
            this.btnAddSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // frmManagementSuppiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 387);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelSupplier);
            this.Controls.Add(this.btnEditSupplier);
            this.Controls.Add(this.btnAddSupplier);
            this.Controls.Add(this.dataGridViewSupplier);
            this.Controls.Add(this.txtDCNCC);
            this.Controls.Add(this.txtTenNCC);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.lblDC);
            this.Controls.Add(this.lblTenNCC);
            this.Controls.Add(this.lblMaNCC);
            this.Name = "frmManagementSuppiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManagementSuppiler";
            this.Load += new System.EventHandler(this.frmManagementSuppiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenNCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.Label lblTenNCC;
        private System.Windows.Forms.Label lblDC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtDCNCC;
        private System.Windows.Forms.DataGridView dataGridViewSupplier;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnEditSupplier;
        private System.Windows.Forms.Button btnDelSupplier;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ErrorProvider errTenNCC;
        private System.Windows.Forms.ErrorProvider errDC;
    }
}