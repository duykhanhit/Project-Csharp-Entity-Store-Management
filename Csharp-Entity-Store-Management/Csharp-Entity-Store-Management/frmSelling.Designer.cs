
namespace Csharp_Entity_Store_Management
{
    partial class frmSelling
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbCategories = new System.Windows.Forms.ComboBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCarts = new System.Windows.Forms.DataGridView();
            this.grbProductDetail = new System.Windows.Forms.GroupBox();
            this.lblDetailPrice = new System.Windows.Forms.Label();
            this.lblDetailTotal = new System.Windows.Forms.Label();
            this.lblDetailName = new System.Windows.Forms.Label();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.txtQuantityDetail = new System.Windows.Forms.TextBox();
            this.btnIncrement = new System.Windows.Forms.Button();
            this.btnDecrement = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.grbCheckCustomer = new System.Windows.Forms.GroupBox();
            this.btnCheckPhone = new System.Windows.Forms.Button();
            this.txtCheckPhone = new System.Windows.Forms.TextBox();
            this.grbCustomerDetail = new System.Windows.Forms.GroupBox();
            this.lblCustomerCreatedAt = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grbAddCustomer = new System.Windows.Forms.GroupBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNotiCart = new System.Windows.Forms.Label();
            this.lblDetailID = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.btnApplyDiscount = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarts)).BeginInit();
            this.grbProductDetail.SuspendLayout();
            this.grbCheckCustomer.SuspendLayout();
            this.grbCustomerDetail.SuspendLayout();
            this.grbAddCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbbCategories);
            this.groupBox1.Controls.Add(this.txtKeyword);
            this.groupBox1.Controls.Add(this.dgvProducts);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1103, 312);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(709, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 25);
            this.label15.TabIndex = 7;
            this.label15.Text = "-";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(578, 55);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 30);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(734, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 30);
            this.textBox2.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(573, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 25);
            this.label14.TabIndex = 5;
            this.label14.Text = "Giá:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(878, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "Danh mục:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(359, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tìm kiếm:";
            // 
            // cbbCategories
            // 
            this.cbbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategories.FormattingEnabled = true;
            this.cbbCategories.Location = new System.Drawing.Point(883, 52);
            this.cbbCategories.Name = "cbbCategories";
            this.cbbCategories.Size = new System.Drawing.Size(174, 33);
            this.cbbCategories.TabIndex = 2;
            this.cbbCategories.SelectedIndexChanged += new System.EventHandler(this.cbbCategories_SelectedIndexChanged);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(364, 55);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(182, 30);
            this.txtKeyword.TabIndex = 1;
            this.txtKeyword.TextChanged += new System.EventHandler(this.txtKeyword_TextChanged);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(44, 91);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(1013, 199);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectedProduct);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNotiCart);
            this.groupBox2.Controls.Add(this.dgvCarts);
            this.groupBox2.Location = new System.Drawing.Point(12, 393);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1103, 389);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giỏ hàng";
            // 
            // dgvCarts
            // 
            this.dgvCarts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarts.Location = new System.Drawing.Point(44, 87);
            this.dgvCarts.Name = "dgvCarts";
            this.dgvCarts.ReadOnly = true;
            this.dgvCarts.RowHeadersWidth = 51;
            this.dgvCarts.RowTemplate.Height = 24;
            this.dgvCarts.Size = new System.Drawing.Size(1013, 267);
            this.dgvCarts.TabIndex = 0;
            this.dgvCarts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewDetailProduct);
            // 
            // grbProductDetail
            // 
            this.grbProductDetail.Controls.Add(this.label17);
            this.grbProductDetail.Controls.Add(this.label16);
            this.grbProductDetail.Controls.Add(this.btnApplyDiscount);
            this.grbProductDetail.Controls.Add(this.txtDiscount);
            this.grbProductDetail.Controls.Add(this.lblDetailID);
            this.grbProductDetail.Controls.Add(this.lblDetailPrice);
            this.grbProductDetail.Controls.Add(this.lblDetailTotal);
            this.grbProductDetail.Controls.Add(this.lblDetailName);
            this.grbProductDetail.Controls.Add(this.btnDeleteProduct);
            this.grbProductDetail.Controls.Add(this.txtQuantityDetail);
            this.grbProductDetail.Controls.Add(this.btnIncrement);
            this.grbProductDetail.Controls.Add(this.btnDecrement);
            this.grbProductDetail.Controls.Add(this.label8);
            this.grbProductDetail.Controls.Add(this.label7);
            this.grbProductDetail.Controls.Add(this.label6);
            this.grbProductDetail.Location = new System.Drawing.Point(1157, 393);
            this.grbProductDetail.Name = "grbProductDetail";
            this.grbProductDetail.Size = new System.Drawing.Size(367, 250);
            this.grbProductDetail.TabIndex = 0;
            this.grbProductDetail.TabStop = false;
            this.grbProductDetail.Text = "Chi tiết sản phẩm";
            // 
            // lblDetailPrice
            // 
            this.lblDetailPrice.AutoSize = true;
            this.lblDetailPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailPrice.Location = new System.Drawing.Point(97, 108);
            this.lblDetailPrice.Name = "lblDetailPrice";
            this.lblDetailPrice.Size = new System.Drawing.Size(96, 25);
            this.lblDetailPrice.TabIndex = 4;
            this.lblDetailPrice.Text = "1000000";
            // 
            // lblDetailTotal
            // 
            this.lblDetailTotal.AutoSize = true;
            this.lblDetailTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailTotal.Location = new System.Drawing.Point(145, 73);
            this.lblDetailTotal.Name = "lblDetailTotal";
            this.lblDetailTotal.Size = new System.Drawing.Size(48, 25);
            this.lblDetailTotal.TabIndex = 4;
            this.lblDetailTotal.Text = "100";
            // 
            // lblDetailName
            // 
            this.lblDetailName.AutoSize = true;
            this.lblDetailName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailName.Location = new System.Drawing.Point(65, 38);
            this.lblDetailName.Name = "lblDetailName";
            this.lblDetailName.Size = new System.Drawing.Size(118, 25);
            this.lblDetailName.TabIndex = 4;
            this.lblDetailName.Text = "Bánh Cosy";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(265, 144);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(73, 43);
            this.btnDeleteProduct.TabIndex = 3;
            this.btnDeleteProduct.Text = "Xoá";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // txtQuantityDetail
            // 
            this.txtQuantityDetail.Location = new System.Drawing.Point(80, 152);
            this.txtQuantityDetail.Name = "txtQuantityDetail";
            this.txtQuantityDetail.Size = new System.Drawing.Size(97, 30);
            this.txtQuantityDetail.TabIndex = 2;
            this.txtQuantityDetail.TextChanged += new System.EventHandler(this.txtQuantityDetail_TextChanged);
            // 
            // btnIncrement
            // 
            this.btnIncrement.Location = new System.Drawing.Point(202, 147);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(40, 40);
            this.btnIncrement.TabIndex = 1;
            this.btnIncrement.Text = "+";
            this.btnIncrement.UseVisualStyleBackColor = true;
            this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
            // 
            // btnDecrement
            // 
            this.btnDecrement.Location = new System.Drawing.Point(25, 147);
            this.btnDecrement.Name = "btnDecrement";
            this.btnDecrement.Size = new System.Drawing.Size(40, 40);
            this.btnDecrement.TabIndex = 1;
            this.btnDecrement.Text = "-";
            this.btnDecrement.UseVisualStyleBackColor = true;
            this.btnDecrement.Click += new System.EventHandler(this.btnDecrement_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Đơn giá:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số lượng còn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên:";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(1157, 700);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(367, 82);
            this.btnPay.TabIndex = 1;
            this.btnPay.Text = "Thanh Toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1152, 672);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thành tiền:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(1259, 672);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(75, 25);
            this.lblTotalAmount.TabIndex = 3;
            this.lblTotalAmount.Text = "0 VNĐ";
            // 
            // grbCheckCustomer
            // 
            this.grbCheckCustomer.Controls.Add(this.btnCheckPhone);
            this.grbCheckCustomer.Controls.Add(this.txtCheckPhone);
            this.grbCheckCustomer.Location = new System.Drawing.Point(1157, 50);
            this.grbCheckCustomer.Name = "grbCheckCustomer";
            this.grbCheckCustomer.Size = new System.Drawing.Size(367, 107);
            this.grbCheckCustomer.TabIndex = 0;
            this.grbCheckCustomer.TabStop = false;
            this.grbCheckCustomer.Text = "SĐT khách hàng";
            // 
            // btnCheckPhone
            // 
            this.btnCheckPhone.Location = new System.Drawing.Point(134, 65);
            this.btnCheckPhone.Name = "btnCheckPhone";
            this.btnCheckPhone.Size = new System.Drawing.Size(102, 35);
            this.btnCheckPhone.TabIndex = 1;
            this.btnCheckPhone.Text = "Kiểm Tra";
            this.btnCheckPhone.UseVisualStyleBackColor = true;
            this.btnCheckPhone.Click += new System.EventHandler(this.btnCheckPhone_Click);
            // 
            // txtCheckPhone
            // 
            this.txtCheckPhone.Location = new System.Drawing.Point(59, 29);
            this.txtCheckPhone.Name = "txtCheckPhone";
            this.txtCheckPhone.Size = new System.Drawing.Size(252, 30);
            this.txtCheckPhone.TabIndex = 0;
            // 
            // grbCustomerDetail
            // 
            this.grbCustomerDetail.Controls.Add(this.lblCustomerCreatedAt);
            this.grbCustomerDetail.Controls.Add(this.lblCustomerPhone);
            this.grbCustomerDetail.Controls.Add(this.lblCustomerAddress);
            this.grbCustomerDetail.Controls.Add(this.lblCustomerName);
            this.grbCustomerDetail.Controls.Add(this.label13);
            this.grbCustomerDetail.Controls.Add(this.label12);
            this.grbCustomerDetail.Controls.Add(this.label11);
            this.grbCustomerDetail.Controls.Add(this.label5);
            this.grbCustomerDetail.Location = new System.Drawing.Point(1157, 163);
            this.grbCustomerDetail.Name = "grbCustomerDetail";
            this.grbCustomerDetail.Size = new System.Drawing.Size(367, 199);
            this.grbCustomerDetail.TabIndex = 4;
            this.grbCustomerDetail.TabStop = false;
            this.grbCustomerDetail.Text = "Thông tin khách hàng";
            // 
            // lblCustomerCreatedAt
            // 
            this.lblCustomerCreatedAt.AutoSize = true;
            this.lblCustomerCreatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCreatedAt.Location = new System.Drawing.Point(120, 160);
            this.lblCustomerCreatedAt.Name = "lblCustomerCreatedAt";
            this.lblCustomerCreatedAt.Size = new System.Drawing.Size(122, 25);
            this.lblCustomerCreatedAt.TabIndex = 7;
            this.lblCustomerCreatedAt.Text = "22/04/2021";
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerPhone.Location = new System.Drawing.Point(120, 114);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(132, 25);
            this.lblCustomerPhone.TabIndex = 6;
            this.lblCustomerPhone.Text = "0123456789";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAddress.Location = new System.Drawing.Point(120, 75);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(77, 25);
            this.lblCustomerAddress.TabIndex = 5;
            this.lblCustomerAddress.Text = "Hà Nội";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(120, 34);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(152, 25);
            this.lblCustomerName.TabIndex = 4;
            this.lblCustomerName.Text = "Nguyễn Văn A";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 25);
            this.label13.TabIndex = 3;
            this.label13.Text = "Ngày tạo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "SĐT:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên:";
            // 
            // grbAddCustomer
            // 
            this.grbAddCustomer.Controls.Add(this.btnAddCustomer);
            this.grbAddCustomer.Controls.Add(this.txtCustomerPhone);
            this.grbAddCustomer.Controls.Add(this.txtCustomerAddress);
            this.grbAddCustomer.Controls.Add(this.txtCustomerName);
            this.grbAddCustomer.Controls.Add(this.label4);
            this.grbAddCustomer.Controls.Add(this.label3);
            this.grbAddCustomer.Controls.Add(this.label2);
            this.grbAddCustomer.Location = new System.Drawing.Point(1157, 163);
            this.grbAddCustomer.Name = "grbAddCustomer";
            this.grbAddCustomer.Size = new System.Drawing.Size(367, 199);
            this.grbAddCustomer.TabIndex = 4;
            this.grbAddCustomer.TabStop = false;
            this.grbAddCustomer.Text = "Thêm khách hàng";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(145, 151);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(94, 42);
            this.btnAddCustomer.TabIndex = 6;
            this.btnAddCustomer.Text = "Thêm";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(97, 117);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(255, 30);
            this.txtCustomerPhone.TabIndex = 5;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(97, 76);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(255, 30);
            this.txtCustomerAddress.TabIndex = 4;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(97, 35);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(255, 30);
            this.txtCustomerName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "SĐT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên:";
            // 
            // lblNotiCart
            // 
            this.lblNotiCart.AutoSize = true;
            this.lblNotiCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotiCart.Location = new System.Drawing.Point(411, 38);
            this.lblNotiCart.Name = "lblNotiCart";
            this.lblNotiCart.Size = new System.Drawing.Size(292, 36);
            this.lblNotiCart.TabIndex = 1;
            this.lblNotiCart.Text = "GIỎ HÀNG TRỐNG";
            // 
            // lblDetailID
            // 
            this.lblDetailID.AutoSize = true;
            this.lblDetailID.Location = new System.Drawing.Point(2, 155);
            this.lblDetailID.Name = "lblDetailID";
            this.lblDetailID.Size = new System.Drawing.Size(0, 25);
            this.lblDetailID.TabIndex = 5;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(107, 214);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(70, 30);
            this.txtDiscount.TabIndex = 6;
            // 
            // btnApplyDiscount
            // 
            this.btnApplyDiscount.Location = new System.Drawing.Point(235, 208);
            this.btnApplyDiscount.Name = "btnApplyDiscount";
            this.btnApplyDiscount.Size = new System.Drawing.Size(103, 36);
            this.btnApplyDiscount.TabIndex = 7;
            this.btnApplyDiscount.Text = "Áp dụng";
            this.btnApplyDiscount.UseVisualStyleBackColor = true;
            this.btnApplyDiscount.Click += new System.EventHandler(this.btnApplyDiscount_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 217);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 25);
            this.label16.TabIndex = 8;
            this.label16.Text = "Discount:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(183, 217);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 25);
            this.label17.TabIndex = 9;
            this.label17.Text = "%";
            // 
            // frmSelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 786);
            this.Controls.Add(this.grbAddCustomer);
            this.Controls.Add(this.grbCustomerDetail);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.grbProductDetail);
            this.Controls.Add(this.grbCheckCustomer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSelling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSelling";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSelling_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarts)).EndInit();
            this.grbProductDetail.ResumeLayout(false);
            this.grbProductDetail.PerformLayout();
            this.grbCheckCustomer.ResumeLayout(false);
            this.grbCheckCustomer.PerformLayout();
            this.grbCustomerDetail.ResumeLayout(false);
            this.grbCustomerDetail.PerformLayout();
            this.grbAddCustomer.ResumeLayout(false);
            this.grbAddCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grbProductDetail;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.GroupBox grbCheckCustomer;
        private System.Windows.Forms.Button btnCheckPhone;
        private System.Windows.Forms.TextBox txtCheckPhone;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.TextBox txtQuantityDetail;
        private System.Windows.Forms.Button btnIncrement;
        private System.Windows.Forms.Button btnDecrement;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbCategories;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.DataGridView dgvCarts;
        private System.Windows.Forms.Label lblDetailPrice;
        private System.Windows.Forms.Label lblDetailTotal;
        private System.Windows.Forms.Label lblDetailName;
        private System.Windows.Forms.GroupBox grbCustomerDetail;
        private System.Windows.Forms.GroupBox grbAddCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCustomerCreatedAt;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNotiCart;
        private System.Windows.Forms.Label lblDetailID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnApplyDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label17;
    }
}