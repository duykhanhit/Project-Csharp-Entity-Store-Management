
namespace Csharp_Entity_Store_Management
{
    partial class frmOrderDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.lbCustomerAddress = new System.Windows.Forms.Label();
            this.lbCustomerPhone = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.dgvListProduct = new System.Windows.Forms.DataGridView();
            this.lbTotalMoney = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi tiết hóa đơn";
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(816, 41);
            this.lbOrderID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(91, 17);
            this.lbOrderID.TabIndex = 1;
            this.lbOrderID.Text = "Mã hóa đơn: ";
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Location = new System.Drawing.Point(100, 117);
            this.lbCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(119, 17);
            this.lbCustomerName.TabIndex = 2;
            this.lbCustomerName.Text = "Tên khách hàng: ";
            // 
            // lbCustomerAddress
            // 
            this.lbCustomerAddress.AutoSize = true;
            this.lbCustomerAddress.Location = new System.Drawing.Point(100, 149);
            this.lbCustomerAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCustomerAddress.Name = "lbCustomerAddress";
            this.lbCustomerAddress.Size = new System.Drawing.Size(59, 17);
            this.lbCustomerAddress.TabIndex = 3;
            this.lbCustomerAddress.Text = "Địa chỉ: ";
            // 
            // lbCustomerPhone
            // 
            this.lbCustomerPhone.AutoSize = true;
            this.lbCustomerPhone.Location = new System.Drawing.Point(100, 181);
            this.lbCustomerPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCustomerPhone.Name = "lbCustomerPhone";
            this.lbCustomerPhone.Size = new System.Drawing.Size(99, 17);
            this.lbCustomerPhone.TabIndex = 4;
            this.lbCustomerPhone.Text = "Số điện thoại: ";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Location = new System.Drawing.Point(641, 117);
            this.lbUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(101, 17);
            this.lbUserID.TabIndex = 5;
            this.lbUserID.Text = "Mã nhân viên: ";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(636, 149);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(107, 17);
            this.lbUsername.TabIndex = 6;
            this.lbUsername.Text = "Tên nhân viên: ";
            // 
            // dgvListProduct
            // 
            this.dgvListProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListProduct.Location = new System.Drawing.Point(140, 239);
            this.dgvListProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListProduct.Name = "dgvListProduct";
            this.dgvListProduct.RowHeadersVisible = false;
            this.dgvListProduct.RowHeadersWidth = 51;
            this.dgvListProduct.Size = new System.Drawing.Size(887, 199);
            this.dgvListProduct.TabIndex = 7;
            // 
            // lbTotalMoney
            // 
            this.lbTotalMoney.AutoSize = true;
            this.lbTotalMoney.Location = new System.Drawing.Point(833, 487);
            this.lbTotalMoney.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalMoney.Name = "lbTotalMoney";
            this.lbTotalMoney.Size = new System.Drawing.Size(76, 17);
            this.lbTotalMoney.TabIndex = 8;
            this.lbTotalMoney.Text = "Tổng tiền: ";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(71, 41);
            this.lbDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(77, 17);
            this.lbDate.TabIndex = 9;
            this.lbDate.Text = "Ngày bán: ";
            // 
            // frmOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 554);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbTotalMoney);
            this.Controls.Add(this.dgvListProduct);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbUserID);
            this.Controls.Add(this.lbCustomerPhone);
            this.Controls.Add(this.lbCustomerAddress);
            this.Controls.Add(this.lbCustomerName);
            this.Controls.Add(this.lbOrderID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmOrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrderDetail";
            this.Load += new System.EventHandler(this.frmOrderDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Label lbCustomerAddress;
        private System.Windows.Forms.Label lbCustomerPhone;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.DataGridView dgvListProduct;
        private System.Windows.Forms.Label lbTotalMoney;
        private System.Windows.Forms.Label lbDate;
    }
}