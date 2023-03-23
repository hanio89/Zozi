namespace R7_ZOZI
{
    partial class FrmQuảnLýKháchHàng
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
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.BtnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.DataKhachHang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_TrởLại = new System.Windows.Forms.Button();
            this.TxtTimKiem = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(972, 416);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(97, 38);
            this.BtnReset.TabIndex = 27;
            this.BtnReset.Text = "Điền Lại";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click_1);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Location = new System.Drawing.Point(816, 416);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(97, 38);
            this.BtnXoa.TabIndex = 26;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.Location = new System.Drawing.Point(668, 416);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(97, 38);
            this.BtnSua.TabIndex = 25;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.Location = new System.Drawing.Point(511, 416);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(97, 38);
            this.BtnThem.TabIndex = 24;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(151, 472);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 161);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chi Tiết";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(511, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tên Khách Hàng";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(665, 56);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(207, 27);
            this.txtTenKH.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã Khách Hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(179, 57);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(207, 27);
            this.txtMaKH.TabIndex = 10;
            // 
            // DataKhachHang
            // 
            this.DataKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataKhachHang.Location = new System.Drawing.Point(151, 198);
            this.DataKhachHang.Name = "DataKhachHang";
            this.DataKhachHang.RowHeadersWidth = 51;
            this.DataKhachHang.RowTemplate.Height = 24;
            this.DataKhachHang.Size = new System.Drawing.Size(918, 194);
            this.DataKhachHang.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(525, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Quản Lý Khách Hàng";
            // 
            // Btn_TrởLại
            // 
            this.Btn_TrởLại.Location = new System.Drawing.Point(994, 124);
            this.Btn_TrởLại.Name = "Btn_TrởLại";
            this.Btn_TrởLại.Size = new System.Drawing.Size(75, 23);
            this.Btn_TrởLại.TabIndex = 20;
            this.Btn_TrởLại.Text = "Trở lại";
            this.Btn_TrởLại.UseVisualStyleBackColor = true;
            this.Btn_TrởLại.Click += new System.EventHandler(this.Btn_TrởLại_Click);
            // 
            // TxtTimKiem
            // 
            this.TxtTimKiem.Location = new System.Drawing.Point(229, 144);
            this.TxtTimKiem.Name = "TxtTimKiem";
            this.TxtTimKiem.Size = new System.Drawing.Size(166, 22);
            this.TxtTimKiem.TabIndex = 29;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(142, 142);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(81, 23);
            this.Button1.TabIndex = 30;
            this.Button1.Text = "Tìm Kiếm";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FrmQuảnLýKháchHàng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1220, 753);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TxtTimKiem);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnSua);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DataKhachHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_TrởLại);
            this.Name = "FrmQuảnLýKháchHàng";
            this.Text = "Frm_QuảnLýKháchHàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmQuảnLýKháchHàng_FormClosing);
            this.Load += new System.EventHandler(this.FrmQuảnLýKháchHàng_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.DataGridView DataKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_TrởLại;
        private System.Windows.Forms.TextBox TxtTimKiem;
        private System.Windows.Forms.Button Button1;
    }
}