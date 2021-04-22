
namespace Csharp_Entity_Store_Management
{
    partial class frmManagementAccount
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
            this.lblTenTK = new System.Windows.Forms.Label();
            this.lblMK = new System.Windows.Forms.Label();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.lblHoVaTen = new System.Windows.Forms.Label();
            this.lblDC = new System.Windows.Forms.Label();
            this.lblViTri = new System.Windows.Forms.Label();
            this.lblDT = new System.Windows.Forms.Label();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.dataGridViewAccount = new System.Windows.Forms.DataGridView();
            this.cbxQuyen = new System.Windows.Forms.ComboBox();
            this.txtAccountID = new System.Windows.Forms.TextBox();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.errTenTK = new System.Windows.Forms.ErrorProvider(this.components);
            this.errMK = new System.Windows.Forms.ErrorProvider(this.components);
            this.errFullname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDC = new System.Windows.Forms.ErrorProvider(this.components);
            this.errViTri = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDT = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errFullname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errViTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDT)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenTK
            // 
            this.lblTenTK.AutoSize = true;
            this.lblTenTK.Location = new System.Drawing.Point(45, 53);
            this.lblTenTK.Name = "lblTenTK";
            this.lblTenTK.Size = new System.Drawing.Size(73, 13);
            this.lblTenTK.TabIndex = 15;
            this.lblTenTK.Text = "Tên tài khoản";
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Location = new System.Drawing.Point(45, 92);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(52, 13);
            this.lblMK.TabIndex = 16;
            this.lblMK.Text = "Mật khẩu";
            // 
            // lblQuyen
            // 
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.Location = new System.Drawing.Point(45, 127);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(38, 13);
            this.lblQuyen.TabIndex = 17;
            this.lblQuyen.Text = "Quyền";
            // 
            // lblHoVaTen
            // 
            this.lblHoVaTen.AutoSize = true;
            this.lblHoVaTen.Location = new System.Drawing.Point(253, 21);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.Size = new System.Drawing.Size(54, 13);
            this.lblHoVaTen.TabIndex = 18;
            this.lblHoVaTen.Text = "Họ và tên";
            // 
            // lblDC
            // 
            this.lblDC.AutoSize = true;
            this.lblDC.Location = new System.Drawing.Point(253, 57);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(40, 13);
            this.lblDC.TabIndex = 19;
            this.lblDC.Text = "Địa chỉ";
            // 
            // lblViTri
            // 
            this.lblViTri.AutoSize = true;
            this.lblViTri.Location = new System.Drawing.Point(253, 96);
            this.lblViTri.Name = "lblViTri";
            this.lblViTri.Size = new System.Drawing.Size(29, 13);
            this.lblViTri.TabIndex = 20;
            this.lblViTri.Text = "Vị trí";
            // 
            // lblDT
            // 
            this.lblDT.AutoSize = true;
            this.lblDT.Location = new System.Drawing.Point(253, 131);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(55, 13);
            this.lblDT.TabIndex = 21;
            this.lblDT.Text = "Điện thoại";
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(121, 53);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(100, 20);
            this.txtTenTK.TabIndex = 0;
            this.txtTenTK.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenTK_Validating);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(121, 89);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(100, 20);
            this.txtMK.TabIndex = 1;
            this.txtMK.Validating += new System.ComponentModel.CancelEventHandler(this.txtMK_Validating);
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(329, 18);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(100, 20);
            this.txtHoVaTen.TabIndex = 2;
            this.txtHoVaTen.Validating += new System.ComponentModel.CancelEventHandler(this.txtHoVaTen_Validating);
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(329, 54);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(100, 20);
            this.txtDC.TabIndex = 3;
            this.txtDC.Validating += new System.ComponentModel.CancelEventHandler(this.txtDC_Validating);
            // 
            // txtViTri
            // 
            this.txtViTri.Location = new System.Drawing.Point(329, 89);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(100, 20);
            this.txtViTri.TabIndex = 4;
            this.txtViTri.Validating += new System.ComponentModel.CancelEventHandler(this.txtViTri_Validating);
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(329, 124);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(100, 20);
            this.txtDT.TabIndex = 5;
            this.txtDT.Validating += new System.ComponentModel.CancelEventHandler(this.txtDT_Validating);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(204, 175);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(247, 24);
            this.lblHeading.TabIndex = 3;
            this.lblHeading.Text = "DANH SÁCH TÀI KHOẢN";
            // 
            // dataGridViewAccount
            // 
            this.dataGridViewAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccount.Location = new System.Drawing.Point(35, 211);
            this.dataGridViewAccount.Name = "dataGridViewAccount";
            this.dataGridViewAccount.Size = new System.Drawing.Size(606, 201);
            this.dataGridViewAccount.TabIndex = 13;
            this.dataGridViewAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAccount_CellClick);
            // 
            // cbxQuyen
            // 
            this.cbxQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQuyen.FormattingEnabled = true;
            this.cbxQuyen.Location = new System.Drawing.Point(121, 123);
            this.cbxQuyen.Name = "cbxQuyen";
            this.cbxQuyen.Size = new System.Drawing.Size(100, 21);
            this.cbxQuyen.TabIndex = 23;
            // 
            // txtAccountID
            // 
            this.txtAccountID.Location = new System.Drawing.Point(121, 18);
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.Size = new System.Drawing.Size(100, 20);
            this.txtAccountID.TabIndex = 22;
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.Location = new System.Drawing.Point(48, 21);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(69, 13);
            this.lblAccountID.TabIndex = 14;
            this.lblAccountID.Text = "Mã tài khoản";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Csharp_Entity_Store_Management.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(520, 160);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 39);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Đóng";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errTenTK
            // 
            this.errTenTK.ContainerControl = this;
            // 
            // errMK
            // 
            this.errMK.ContainerControl = this;
            // 
            // errFullname
            // 
            this.errFullname.ContainerControl = this;
            // 
            // errDC
            // 
            this.errDC.ContainerControl = this;
            // 
            // errViTri
            // 
            this.errViTri.ContainerControl = this;
            // 
            // errDT
            // 
            this.errDT.ContainerControl = this;
            // 
            // btnViewAll
            // 
            this.btnViewAll.Image = global::Csharp_Entity_Store_Management.Properties.Resources.view_all;
            this.btnViewAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewAll.Location = new System.Drawing.Point(547, 115);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(105, 39);
            this.btnViewAll.TabIndex = 11;
            this.btnViewAll.Text = "Xem tất cả";
            this.btnViewAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = global::Csharp_Entity_Store_Management.Properties.Resources.clear;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(465, 115);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 39);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Csharp_Entity_Store_Management.Properties.Resources.search_user;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(465, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 38);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelAccount
            // 
            this.btnDelAccount.Image = global::Csharp_Entity_Store_Management.Properties.Resources.delete_user;
            this.btnDelAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelAccount.Location = new System.Drawing.Point(566, 12);
            this.btnDelAccount.Name = "btnDelAccount";
            this.btnDelAccount.Size = new System.Drawing.Size(86, 39);
            this.btnDelAccount.TabIndex = 9;
            this.btnDelAccount.Text = "Xóa";
            this.btnDelAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelAccount.UseVisualStyleBackColor = true;
            this.btnDelAccount.Click += new System.EventHandler(this.btnDelAccount_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Image = global::Csharp_Entity_Store_Management.Properties.Resources.edit_user;
            this.btnEditAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditAccount.Location = new System.Drawing.Point(465, 67);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(95, 38);
            this.btnEditAccount.TabIndex = 7;
            this.btnEditAccount.Text = "Cập nhật";
            this.btnEditAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Image = global::Csharp_Entity_Store_Management.Properties.Resources.user_add;
            this.btnAddAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAccount.Location = new System.Drawing.Point(566, 70);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(86, 39);
            this.btnAddAccount.TabIndex = 10;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // frmManagementAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 438);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.lblAccountID);
            this.Controls.Add(this.txtAccountID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cbxQuyen);
            this.Controls.Add(this.dataGridViewAccount);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelAccount);
            this.Controls.Add(this.btnEditAccount);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.txtViTri);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.txtHoVaTen);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTenTK);
            this.Controls.Add(this.lblDT);
            this.Controls.Add(this.lblViTri);
            this.Controls.Add(this.lblDC);
            this.Controls.Add(this.lblHoVaTen);
            this.Controls.Add(this.lblQuyen);
            this.Controls.Add(this.lblMK);
            this.Controls.Add(this.lblTenTK);
            this.Name = "frmManagementAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManagementAccount";
            this.Load += new System.EventHandler(this.frmManagementAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errFullname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errViTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenTK;
        private System.Windows.Forms.Label lblMK;
        private System.Windows.Forms.Label lblQuyen;
        private System.Windows.Forms.Label lblHoVaTen;
        private System.Windows.Forms.Label lblDC;
        private System.Windows.Forms.Label lblViTri;
        private System.Windows.Forms.Label lblDT;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnDelAccount;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.DataGridView dataGridViewAccount;
        private System.Windows.Forms.ComboBox cbxQuyen;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtAccountID;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.ErrorProvider errTenTK;
        private System.Windows.Forms.ErrorProvider errMK;
        private System.Windows.Forms.ErrorProvider errFullname;
        private System.Windows.Forms.ErrorProvider errDC;
        private System.Windows.Forms.ErrorProvider errViTri;
        private System.Windows.Forms.ErrorProvider errDT;
    }
}