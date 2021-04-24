
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grbOrderDetail = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.OrderManagement.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grbOrderDetail.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(6, 240);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.RowHeadersWidth = 51;
            this.tableLayoutPanel2.SetRowSpan(this.dgvOrder, 2);
            this.dgvOrder.Size = new System.Drawing.Size(938, 396);
            this.dgvOrder.TabIndex = 0;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClickItem);
            // 
            // btnShowAOrder
            // 
            this.btnShowAOrder.Location = new System.Drawing.Point(956, 348);
            this.btnShowAOrder.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnShowAOrder.Name = "btnShowAOrder";
            this.btnShowAOrder.Size = new System.Drawing.Size(192, 44);
            this.btnShowAOrder.TabIndex = 1;
            this.btnShowAOrder.Text = "Xem đơn hàng";
            this.btnShowAOrder.UseVisualStyleBackColor = true;
            this.btnShowAOrder.Click += new System.EventHandler(this.btnShowAOrder_Click);
            // 
            // btnDeleteAOrder
            // 
            this.btnDeleteAOrder.Location = new System.Drawing.Point(956, 240);
            this.btnDeleteAOrder.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDeleteAOrder.Name = "btnDeleteAOrder";
            this.btnDeleteAOrder.Size = new System.Drawing.Size(192, 44);
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
            this.tableLayoutPanel1.SetColumnSpan(this.OrderManagement, 2);
            this.OrderManagement.Controls.Add(this.tableLayoutPanel2);
            this.OrderManagement.Location = new System.Drawing.Point(6, 6);
            this.OrderManagement.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.OrderManagement.Name = "OrderManagement";
            this.OrderManagement.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel1.SetRowSpan(this.OrderManagement, 2);
            this.OrderManagement.Size = new System.Drawing.Size(1407, 670);
            this.OrderManagement.TabIndex = 3;
            this.OrderManagement.TabStop = false;
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Location = new System.Drawing.Point(9, 119);
            this.lbUserID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(136, 25);
            this.lbUserID.TabIndex = 6;
            this.lbUserID.Text = "Mã nhân viên:";
            // 
            // lbCusID
            // 
            this.lbCusID.AutoSize = true;
            this.lbCusID.Location = new System.Drawing.Point(9, 88);
            this.lbCusID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCusID.Name = "lbCusID";
            this.lbCusID.Size = new System.Drawing.Size(158, 25);
            this.lbCusID.TabIndex = 5;
            this.lbCusID.Text = "Mã khách hàng: ";
            // 
            // lbCreateAt
            // 
            this.lbCreateAt.AutoSize = true;
            this.lbCreateAt.Location = new System.Drawing.Point(9, 57);
            this.lbCreateAt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCreateAt.Name = "lbCreateAt";
            this.lbCreateAt.Size = new System.Drawing.Size(95, 25);
            this.lbCreateAt.TabIndex = 4;
            this.lbCreateAt.Text = "Ngày lập:";
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(9, 26);
            this.lbOrderID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(127, 25);
            this.lbOrderID.TabIndex = 3;
            this.lbOrderID.Text = "Mã hóa đơn: ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.OrderManagement, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 19);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1419, 682);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // grbOrderDetail
            // 
            this.grbOrderDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grbOrderDetail.Controls.Add(this.lbOrderID);
            this.grbOrderDetail.Controls.Add(this.lbCusID);
            this.grbOrderDetail.Controls.Add(this.lbUserID);
            this.grbOrderDetail.Controls.Add(this.lbCreateAt);
            this.grbOrderDetail.Location = new System.Drawing.Point(953, 82);
            this.grbOrderDetail.Name = "grbOrderDetail";
            this.grbOrderDetail.Size = new System.Drawing.Size(397, 149);
            this.grbOrderDetail.TabIndex = 7;
            this.grbOrderDetail.TabStop = false;
            this.grbOrderDetail.Text = "Thông tin hoá đơn";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.39453F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.60547F));
            this.tableLayoutPanel2.Controls.Add(this.dgvOrder, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnDeleteAOrder, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnShowAOrder, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.grbOrderDetail, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.2344F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.35172F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.41388F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1389, 642);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(549, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "QUẢN LÝ HOÁ ĐƠN";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(3, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 149);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 30);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(562, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 30);
            this.textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(322, 55);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(170, 30);
            this.textBox3.TabIndex = 0;
            // 
            // frmManagementOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 720);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmManagementOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManagementOrder";
            this.Load += new System.EventHandler(this.frmManagementOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.OrderManagement.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grbOrderDetail.ResumeLayout(false);
            this.grbOrderDetail.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grbOrderDetail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}