
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
            this.dataGridViewAccount = new System.Windows.Forms.DataGridView();
            this.cbxQuyen = new System.Windows.Forms.ComboBox();
            this.txtAccountID = new System.Windows.Forms.TextBox();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.txtSearchKeyword = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.lblFilterQuyen = new System.Windows.Forms.Label();
            this.cbxAddress = new System.Windows.Forms.ComboBox();
            this.lblFilterDC = new System.Windows.Forms.Label();
            this.lblFilterVitri = new System.Windows.Forms.Label();
            this.cbxPosition = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenTK
            // 
            this.lblTenTK.AutoSize = true;
            this.lblTenTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTK.Location = new System.Drawing.Point(36, 69);
            this.lblTenTK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenTK.Name = "lblTenTK";
            this.lblTenTK.Size = new System.Drawing.Size(123, 20);
            this.lblTenTK.TabIndex = 15;
            this.lblTenTK.Text = "Tên tài khoản:";
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMK.Location = new System.Drawing.Point(36, 122);
            this.lblMK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(88, 20);
            this.lblMK.TabIndex = 16;
            this.lblMK.Text = "Mật khẩu:";
            // 
            // lblQuyen
            // 
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuyen.Location = new System.Drawing.Point(508, 168);
            this.lblQuyen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(65, 20);
            this.lblQuyen.TabIndex = 17;
            this.lblQuyen.Text = "Quyền:";
            // 
            // lblHoVaTen
            // 
            this.lblHoVaTen.AutoSize = true;
            this.lblHoVaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoVaTen.Location = new System.Drawing.Point(36, 170);
            this.lblHoVaTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.Size = new System.Drawing.Size(91, 20);
            this.lblHoVaTen.TabIndex = 18;
            this.lblHoVaTen.Text = "Họ và tên:";
            // 
            // lblDC
            // 
            this.lblDC.AutoSize = true;
            this.lblDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDC.Location = new System.Drawing.Point(508, 26);
            this.lblDC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(69, 20);
            this.lblDC.TabIndex = 19;
            this.lblDC.Text = "Địa chỉ:";
            // 
            // lblViTri
            // 
            this.lblViTri.AutoSize = true;
            this.lblViTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViTri.Location = new System.Drawing.Point(508, 77);
            this.lblViTri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViTri.Name = "lblViTri";
            this.lblViTri.Size = new System.Drawing.Size(51, 20);
            this.lblViTri.TabIndex = 20;
            this.lblViTri.Text = "Vị trí:";
            // 
            // lblDT
            // 
            this.lblDT.AutoSize = true;
            this.lblDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDT.Location = new System.Drawing.Point(508, 124);
            this.lblDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(96, 20);
            this.lblDT.TabIndex = 21;
            this.lblDT.Text = "Điện thoại:";
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(168, 69);
            this.txtTenTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(219, 26);
            this.txtTenTK.TabIndex = 0;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(168, 116);
            this.txtMK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(219, 26);
            this.txtMK.TabIndex = 1;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(168, 164);
            this.txtHoVaTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(219, 26);
            this.txtHoVaTen.TabIndex = 2;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(618, 20);
            this.txtDC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(235, 26);
            this.txtDC.TabIndex = 3;
            // 
            // txtViTri
            // 
            this.txtViTri.Location = new System.Drawing.Point(618, 69);
            this.txtViTri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(235, 26);
            this.txtViTri.TabIndex = 4;
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(618, 114);
            this.txtDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(235, 26);
            this.txtDT.TabIndex = 5;
            // 
            // dataGridViewAccount
            // 
            this.dataGridViewAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccount.Location = new System.Drawing.Point(40, 335);
            this.dataGridViewAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewAccount.Name = "dataGridViewAccount";
            this.dataGridViewAccount.RowHeadersVisible = false;
            this.dataGridViewAccount.RowHeadersWidth = 78;
            this.dataGridViewAccount.Size = new System.Drawing.Size(813, 218);
            this.dataGridViewAccount.TabIndex = 13;
            this.dataGridViewAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAccount_CellClick);
            // 
            // cbxQuyen
            // 
            this.cbxQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQuyen.FormattingEnabled = true;
            this.cbxQuyen.Location = new System.Drawing.Point(618, 160);
            this.cbxQuyen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxQuyen.Name = "cbxQuyen";
            this.cbxQuyen.Size = new System.Drawing.Size(235, 28);
            this.cbxQuyen.TabIndex = 23;
            // 
            // txtAccountID
            // 
            this.txtAccountID.Location = new System.Drawing.Point(168, 25);
            this.txtAccountID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.Size = new System.Drawing.Size(219, 26);
            this.txtAccountID.TabIndex = 22;
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountID.Location = new System.Drawing.Point(36, 24);
            this.lblAccountID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(117, 20);
            this.lblAccountID.TabIndex = 14;
            this.lblAccountID.Text = "Mã tài khoản:";
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.Color.White;
            this.btnViewAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewAll.Location = new System.Drawing.Point(497, 574);
            this.btnViewAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(113, 37);
            this.btnViewAll.TabIndex = 11;
            this.btnViewAll.Text = "Xem tất cả";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(645, 235);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 37);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelAccount
            // 
            this.btnDelAccount.BackColor = System.Drawing.Color.Red;
            this.btnDelAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelAccount.ForeColor = System.Drawing.Color.White;
            this.btnDelAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelAccount.Location = new System.Drawing.Point(618, 575);
            this.btnDelAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelAccount.Name = "btnDelAccount";
            this.btnDelAccount.Size = new System.Drawing.Size(98, 37);
            this.btnDelAccount.TabIndex = 9;
            this.btnDelAccount.Text = "Xóa";
            this.btnDelAccount.UseVisualStyleBackColor = false;
            this.btnDelAccount.Click += new System.EventHandler(this.btnDelAccount_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAccount.ForeColor = System.Drawing.Color.White;
            this.btnEditAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditAccount.Location = new System.Drawing.Point(728, 576);
            this.btnEditAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(98, 35);
            this.btnEditAccount.TabIndex = 7;
            this.btnEditAccount.Text = "Cập nhật";
            this.btnEditAccount.UseVisualStyleBackColor = false;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.ForeColor = System.Drawing.Color.White;
            this.btnAddAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAccount.Location = new System.Drawing.Point(755, 235);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(98, 37);
            this.btnAddAccount.TabIndex = 10;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // txtSearchKeyword
            // 
            this.txtSearchKeyword.ForeColor = System.Drawing.Color.Silver;
            this.txtSearchKeyword.Location = new System.Drawing.Point(107, 235);
            this.txtSearchKeyword.Name = "txtSearchKeyword";
            this.txtSearchKeyword.Size = new System.Drawing.Size(157, 26);
            this.txtSearchKeyword.TabIndex = 26;
            this.txtSearchKeyword.Text = "Nhập tên tài khoản";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(281, 235);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 26);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // cbxRole
            // 
            this.cbxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Location = new System.Drawing.Point(107, 283);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(71, 28);
            this.cbxRole.TabIndex = 28;
            this.cbxRole.SelectedValueChanged += new System.EventHandler(this.cbxRole_SelectedValueChanged);
            // 
            // lblFilterQuyen
            // 
            this.lblFilterQuyen.AutoSize = true;
            this.lblFilterQuyen.Location = new System.Drawing.Point(36, 291);
            this.lblFilterQuyen.Name = "lblFilterQuyen";
            this.lblFilterQuyen.Size = new System.Drawing.Size(59, 20);
            this.lblFilterQuyen.TabIndex = 29;
            this.lblFilterQuyen.Text = "Quyền:";
            // 
            // cbxAddress
            // 
            this.cbxAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAddress.FormattingEnabled = true;
            this.cbxAddress.Location = new System.Drawing.Point(479, 283);
            this.cbxAddress.Name = "cbxAddress";
            this.cbxAddress.Size = new System.Drawing.Size(128, 28);
            this.cbxAddress.TabIndex = 30;
            this.cbxAddress.SelectedValueChanged += new System.EventHandler(this.cbxAddress_SelectedValueChanged);
            // 
            // lblFilterDC
            // 
            this.lblFilterDC.AutoSize = true;
            this.lblFilterDC.Location = new System.Drawing.Point(412, 291);
            this.lblFilterDC.Name = "lblFilterDC";
            this.lblFilterDC.Size = new System.Drawing.Size(61, 20);
            this.lblFilterDC.TabIndex = 31;
            this.lblFilterDC.Text = "Địa chỉ:";
            // 
            // lblFilterVitri
            // 
            this.lblFilterVitri.AutoSize = true;
            this.lblFilterVitri.Location = new System.Drawing.Point(213, 291);
            this.lblFilterVitri.Name = "lblFilterVitri";
            this.lblFilterVitri.Size = new System.Drawing.Size(48, 20);
            this.lblFilterVitri.TabIndex = 32;
            this.lblFilterVitri.Text = "Vị trí: ";
            // 
            // cbxPosition
            // 
            this.cbxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPosition.FormattingEnabled = true;
            this.cbxPosition.Location = new System.Drawing.Point(281, 283);
            this.cbxPosition.Name = "cbxPosition";
            this.cbxPosition.Size = new System.Drawing.Size(106, 28);
            this.cbxPosition.TabIndex = 33;
            this.cbxPosition.SelectedValueChanged += new System.EventHandler(this.cbxPosition_SelectedValueChanged);
            // 
            // frmManagementAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 625);
            this.Controls.Add(this.cbxPosition);
            this.Controls.Add(this.lblFilterVitri);
            this.Controls.Add(this.lblFilterDC);
            this.Controls.Add(this.cbxAddress);
            this.Controls.Add(this.lblFilterQuyen);
            this.Controls.Add(this.cbxRole);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchKeyword);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.lblAccountID);
            this.Controls.Add(this.txtAccountID);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cbxQuyen);
            this.Controls.Add(this.dataGridViewAccount);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmManagementAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManagementAccount";
            this.Load += new System.EventHandler(this.frmManagementAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewAccount;
        private System.Windows.Forms.ComboBox cbxQuyen;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtAccountID;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.TextBox txtSearchKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.Label lblFilterQuyen;
        private System.Windows.Forms.ComboBox cbxAddress;
        private System.Windows.Forms.Label lblFilterDC;
        private System.Windows.Forms.Label lblFilterVitri;
        private System.Windows.Forms.ComboBox cbxPosition;
    }
}