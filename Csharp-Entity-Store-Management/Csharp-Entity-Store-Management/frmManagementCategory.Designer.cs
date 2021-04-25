
namespace Csharp_Entity_Store_Management
{
    partial class frmManagementCategory
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
            this.lblMaDM = new System.Windows.Forms.Label();
            this.lblTenDM = new System.Windows.Forms.Label();
            this.txtMaDM = new System.Windows.Forms.TextBox();
            this.txtTenDM = new System.Windows.Forms.TextBox();
            this.dataGridViewCategory = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaDM
            // 
            this.lblMaDM.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMaDM.AutoSize = true;
            this.lblMaDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblMaDM.Location = new System.Drawing.Point(4, 126);
            this.lblMaDM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaDM.Name = "lblMaDM";
            this.lblMaDM.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.lblMaDM.Size = new System.Drawing.Size(199, 25);
            this.lblMaDM.TabIndex = 7;
            this.lblMaDM.Text = "Mã danh mục:";
            // 
            // lblTenDM
            // 
            this.lblTenDM.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTenDM.AutoSize = true;
            this.lblTenDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblTenDM.Location = new System.Drawing.Point(4, 204);
            this.lblTenDM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenDM.Name = "lblTenDM";
            this.lblTenDM.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.lblTenDM.Size = new System.Drawing.Size(207, 25);
            this.lblTenDM.TabIndex = 8;
            this.lblTenDM.Text = "Tên danh mục:";
            // 
            // txtMaDM
            // 
            this.txtMaDM.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMaDM.Location = new System.Drawing.Point(305, 123);
            this.txtMaDM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaDM.Name = "txtMaDM";
            this.txtMaDM.Size = new System.Drawing.Size(208, 30);
            this.txtMaDM.TabIndex = 9;
            // 
            // txtTenDM
            // 
            this.txtTenDM.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTenDM.Location = new System.Drawing.Point(305, 202);
            this.txtTenDM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenDM.Name = "txtTenDM";
            this.txtTenDM.Size = new System.Drawing.Size(208, 30);
            this.txtTenDM.TabIndex = 0;
            // 
            // dataGridViewCategory
            // 
            this.dataGridViewCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewCategory, 4);
            this.dataGridViewCategory.Location = new System.Drawing.Point(4, 262);
            this.dataGridViewCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewCategory.Name = "dataGridViewCategory";
            this.dataGridViewCategory.RowHeadersVisible = false;
            this.dataGridViewCategory.RowHeadersWidth = 10;
            this.dataGridViewCategory.Size = new System.Drawing.Size(1196, 436);
            this.dataGridViewCategory.TabIndex = 6;
            this.dataGridViewCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategory_CellClick);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(695, 120);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 37);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelCategory
            // 
            this.btnDelCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelCategory.BackColor = System.Drawing.Color.Red;
            this.btnDelCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelCategory.ForeColor = System.Drawing.Color.White;
            this.btnDelCategory.Location = new System.Drawing.Point(695, 198);
            this.btnDelCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelCategory.Name = "btnDelCategory";
            this.btnDelCategory.Size = new System.Drawing.Size(115, 37);
            this.btnDelCategory.TabIndex = 2;
            this.btnDelCategory.Text = "Xóa";
            this.btnDelCategory.UseVisualStyleBackColor = false;
            this.btnDelCategory.Click += new System.EventHandler(this.btnDelCategory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditCategory.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCategory.ForeColor = System.Drawing.Color.White;
            this.btnEditCategory.Location = new System.Drawing.Point(991, 198);
            this.btnEditCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(124, 37);
            this.btnEditCategory.TabIndex = 3;
            this.btnEditCategory.Text = "Cập nhật";
            this.btnEditCategory.UseVisualStyleBackColor = false;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCategory.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Location = new System.Drawing.Point(994, 120);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(118, 37);
            this.btnAddCategory.TabIndex = 1;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblMaDM, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewCategory, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnEditCategory, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDelCategory, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtMaDM, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTenDM, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAddCategory, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTenDM, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.22475F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.95306F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.3798F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.15789F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1204, 703);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 4);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "QUẢN LÝ DANH MỤC";
            // 
            // frmManagementCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 727);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmManagementCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManagementCategory";
            this.Load += new System.EventHandler(this.frmManagementCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMaDM;
        private System.Windows.Forms.Label lblTenDM;
        private System.Windows.Forms.TextBox txtMaDM;
        private System.Windows.Forms.TextBox txtTenDM;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnDelCategory;
        private System.Windows.Forms.DataGridView dataGridViewCategory;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
    }
}