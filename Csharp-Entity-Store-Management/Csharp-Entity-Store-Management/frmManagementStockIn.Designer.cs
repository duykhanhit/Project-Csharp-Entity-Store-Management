
namespace Csharp_Entity_Store_Management
{
    partial class frmManagementStockIn
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
            this.dataNhapKho = new System.Windows.Forms.DataGridView();
            this.btnNhap = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNCC = new System.Windows.Forms.ComboBox();
            this.cbTen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataNhapKho)).BeginInit();
            this.SuspendLayout();
            // 
            // dataNhapKho
            // 
            this.dataNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNhapKho.Location = new System.Drawing.Point(131, 244);
            this.dataNhapKho.Name = "dataNhapKho";
            this.dataNhapKho.Size = new System.Drawing.Size(679, 215);
            this.dataNhapKho.TabIndex = 15;
            this.dataNhapKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNhapKho_CellClick);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(730, 64);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(120, 51);
            this.btnNhap.TabIndex = 14;
            this.btnNhap.Text = "Nhập kho";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(517, 64);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(116, 22);
            this.txtSoLuong.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nhà cung cấp";
            // 
            // cbNCC
            // 
            this.cbNCC.FormattingEnabled = true;
            this.cbNCC.Location = new System.Drawing.Point(190, 142);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(199, 23);
            this.cbNCC.TabIndex = 10;
            // 
            // cbTen
            // 
            this.cbTen.FormattingEnabled = true;
            this.cbTen.Location = new System.Drawing.Point(190, 60);
            this.cbTen.Name = "cbTen";
            this.cbTen.Size = new System.Drawing.Size(140, 23);
            this.cbTen.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mặt hàng";
            // 
            // frmManagementStockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.dataNhapKho);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbNCC);
            this.Controls.Add(this.cbTen);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmManagementStockIn";
            this.Text = "frmManagementStockIn";
            this.Load += new System.EventHandler(this.frmManagementStockIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataNhapKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataNhapKho;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNCC;
        private System.Windows.Forms.ComboBox cbTen;
        private System.Windows.Forms.Label label1;
    }
}