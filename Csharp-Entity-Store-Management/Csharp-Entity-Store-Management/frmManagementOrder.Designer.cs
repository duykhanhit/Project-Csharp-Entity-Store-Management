
namespace Csharp_Entity_Store_Management
{
    partial class frmManagementOrder
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
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.btnShowAOrder = new System.Windows.Forms.Button();
            this.btnDeleteAOrder = new System.Windows.Forms.Button();
            this.OrderManagement = new System.Windows.Forms.GroupBox();
            this.lbUserID = new System.Windows.Forms.Label();
            this.lbCusID = new System.Windows.Forms.Label();
            this.lbCreateAt = new System.Windows.Forms.Label();
            this.lbOrderID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.OrderManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(50, 155);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.Size = new System.Drawing.Size(430, 192);
            this.dgvOrder.TabIndex = 0;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClickItem);
            // 
            // btnShowAOrder
            // 
            this.btnShowAOrder.Location = new System.Drawing.Point(576, 155);
            this.btnShowAOrder.Name = "btnShowAOrder";
            this.btnShowAOrder.Size = new System.Drawing.Size(96, 23);
            this.btnShowAOrder.TabIndex = 1;
            this.btnShowAOrder.Text = "Xem đơn hàng";
            this.btnShowAOrder.UseVisualStyleBackColor = true;
            this.btnShowAOrder.Click += new System.EventHandler(this.btnShowAOrder_Click);
            // 
            // btnDeleteAOrder
            // 
            this.btnDeleteAOrder.Location = new System.Drawing.Point(576, 252);
            this.btnDeleteAOrder.Name = "btnDeleteAOrder";
            this.btnDeleteAOrder.Size = new System.Drawing.Size(96, 23);
            this.btnDeleteAOrder.TabIndex = 2;
            this.btnDeleteAOrder.Text = "Xóa đơn hàng";
            this.btnDeleteAOrder.UseVisualStyleBackColor = true;
            this.btnDeleteAOrder.Click += new System.EventHandler(this.btnDeleteAOrder_Click);
            // 
            // OrderManagement
            // 
            this.OrderManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderManagement.Controls.Add(this.lbUserID);
            this.OrderManagement.Controls.Add(this.lbCusID);
            this.OrderManagement.Controls.Add(this.lbCreateAt);
            this.OrderManagement.Controls.Add(this.lbOrderID);
            this.OrderManagement.Controls.Add(this.btnShowAOrder);
            this.OrderManagement.Controls.Add(this.dgvOrder);
            this.OrderManagement.Controls.Add(this.btnDeleteAOrder);
            this.OrderManagement.Location = new System.Drawing.Point(10, 11);
            this.OrderManagement.Name = "OrderManagement";
            this.OrderManagement.Size = new System.Drawing.Size(781, 429);
            this.OrderManagement.TabIndex = 3;
            this.OrderManagement.TabStop = false;
            this.OrderManagement.Text = "Quản lí đơn hàng";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Location = new System.Drawing.Point(258, 81);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(75, 13);
            this.lbUserID.TabIndex = 6;
            this.lbUserID.Text = "Mã nhân viên:";
            // 
            // lbCusID
            // 
            this.lbCusID.AutoSize = true;
            this.lbCusID.Location = new System.Drawing.Point(58, 82);
            this.lbCusID.Name = "lbCusID";
            this.lbCusID.Size = new System.Drawing.Size(88, 13);
            this.lbCusID.TabIndex = 5;
            this.lbCusID.Text = "Mã khách hàng: ";
            // 
            // lbCreateAt
            // 
            this.lbCreateAt.AutoSize = true;
            this.lbCreateAt.Location = new System.Drawing.Point(255, 42);
            this.lbCreateAt.Name = "lbCreateAt";
            this.lbCreateAt.Size = new System.Drawing.Size(52, 13);
            this.lbCreateAt.TabIndex = 4;
            this.lbCreateAt.Text = "Ngày lập:";
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(58, 42);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(71, 13);
            this.lbOrderID.TabIndex = 3;
            this.lbOrderID.Text = "Mã hóa đơn: ";
            // 
            // frmManagementOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrderManagement);
            this.Name = "frmManagementOrder";
            this.Text = "frmManagementOrder";
            this.Load += new System.EventHandler(this.frmManagementOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.OrderManagement.ResumeLayout(false);
            this.OrderManagement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button btnShowAOrder;
        private System.Windows.Forms.Button btnDeleteAOrder;
        private System.Windows.Forms.GroupBox OrderManagement;
        private System.Windows.Forms.Label lbCreateAt;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Label lbCusID;
        private System.Windows.Forms.Label lbUserID;
    }
}