namespace R7_ZOZI
{
    partial class FrmQuảnLýSảnPhẩm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuảnLýSảnPhẩm));
            this.tabControl_HH = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Tb_DonGia = new System.Windows.Forms.TextBox();
            this.Tb_TênHH = new System.Windows.Forms.TextBox();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.Btn_Xóa = new System.Windows.Forms.Button();
            this.Btn_Sửa = new System.Windows.Forms.Button();
            this.Thêm = new System.Windows.Forms.Button();
            this.Tb_MãHH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Tb_DVT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DataHH = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Tb_TênSP = new System.Windows.Forms.TextBox();
            this.Tb_NV2 = new System.Windows.Forms.TextBox();
            this.Tb_MãSP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Tb_MãNV2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaHDBan = new System.Windows.Forms.TextBox();
            this.To_SP = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.From_SP = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.DataSP = new System.Windows.Forms.DataGridView();
            this.TG_Bán = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MãSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TênSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_TrởLại = new System.Windows.Forms.Button();
            this.tabControl_HH.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataHH)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSP)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_HH
            // 
            this.tabControl_HH.Controls.Add(this.tabPage1);
            this.tabControl_HH.Controls.Add(this.tabPage2);
            this.tabControl_HH.Location = new System.Drawing.Point(87, 51);
            this.tabControl_HH.Name = "tabControl_HH";
            this.tabControl_HH.SelectedIndex = 0;
            this.tabControl_HH.Size = new System.Drawing.Size(982, 702);
            this.tabControl_HH.TabIndex = 79;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Tb_DonGia);
            this.tabPage1.Controls.Add(this.Tb_TênHH);
            this.tabPage1.Controls.Add(this.Btn_Reset);
            this.tabPage1.Controls.Add(this.Btn_Xóa);
            this.tabPage1.Controls.Add(this.Btn_Sửa);
            this.tabPage1.Controls.Add(this.Thêm);
            this.tabPage1.Controls.Add(this.Tb_MãHH);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.Tb_DVT);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.DataHH);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(974, 673);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hàng Hóa đã Nhập";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // Tb_DonGia
            // 
            this.Tb_DonGia.Location = new System.Drawing.Point(681, 66);
            this.Tb_DonGia.Name = "Tb_DonGia";
            this.Tb_DonGia.Size = new System.Drawing.Size(246, 22);
            this.Tb_DonGia.TabIndex = 53;
            // 
            // Tb_TênHH
            // 
            this.Tb_TênHH.Location = new System.Drawing.Point(681, 15);
            this.Tb_TênHH.Name = "Tb_TênHH";
            this.Tb_TênHH.Size = new System.Drawing.Size(246, 22);
            this.Tb_TênHH.TabIndex = 52;
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Location = new System.Drawing.Point(700, 169);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(109, 45);
            this.Btn_Reset.TabIndex = 51;
            this.Btn_Reset.Text = "Reset";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Btn_Xóa
            // 
            this.Btn_Xóa.Location = new System.Drawing.Point(529, 169);
            this.Btn_Xóa.Name = "Btn_Xóa";
            this.Btn_Xóa.Size = new System.Drawing.Size(109, 45);
            this.Btn_Xóa.TabIndex = 50;
            this.Btn_Xóa.Text = "Xóa";
            this.Btn_Xóa.UseVisualStyleBackColor = true;
            this.Btn_Xóa.Click += new System.EventHandler(this.Btn_Xóa_Click);
            // 
            // Btn_Sửa
            // 
            this.Btn_Sửa.Location = new System.Drawing.Point(345, 169);
            this.Btn_Sửa.Name = "Btn_Sửa";
            this.Btn_Sửa.Size = new System.Drawing.Size(109, 45);
            this.Btn_Sửa.TabIndex = 49;
            this.Btn_Sửa.Text = "Sửa";
            this.Btn_Sửa.UseVisualStyleBackColor = true;
            this.Btn_Sửa.Click += new System.EventHandler(this.Btn_Sửa_Click);
            // 
            // Thêm
            // 
            this.Thêm.Location = new System.Drawing.Point(172, 169);
            this.Thêm.Name = "Thêm";
            this.Thêm.Size = new System.Drawing.Size(109, 45);
            this.Thêm.TabIndex = 48;
            this.Thêm.Text = "Thêm";
            this.Thêm.UseVisualStyleBackColor = true;
            this.Thêm.Click += new System.EventHandler(this.Thêm_Click);
            // 
            // Tb_MãHH
            // 
            this.Tb_MãHH.Location = new System.Drawing.Point(215, 15);
            this.Tb_MãHH.Name = "Tb_MãHH";
            this.Tb_MãHH.Size = new System.Drawing.Size(246, 22);
            this.Tb_MãHH.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "Mã Hàng Hóa";
            // 
            // Tb_DVT
            // 
            this.Tb_DVT.Location = new System.Drawing.Point(215, 66);
            this.Tb_DVT.Name = "Tb_DVT";
            this.Tb_DVT.Size = new System.Drawing.Size(246, 22);
            this.Tb_DVT.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "DVT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(538, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Tên Hàng Hóa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(537, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Đơn Giá";
            // 
            // DataHH
            // 
            this.DataHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataHH.Location = new System.Drawing.Point(22, 256);
            this.DataHH.Name = "DataHH";
            this.DataHH.RowHeadersWidth = 51;
            this.DataHH.RowTemplate.Height = 24;
            this.DataHH.Size = new System.Drawing.Size(915, 386);
            this.DataHH.TabIndex = 27;
            this.DataHH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataHH_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Tb_TênSP);
            this.tabPage2.Controls.Add(this.Tb_NV2);
            this.tabPage2.Controls.Add(this.Tb_MãSP);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.Tb_MãNV2);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtMaHDBan);
            this.tabPage2.Controls.Add(this.To_SP);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.From_SP);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.DataSP);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(974, 673);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sản Phẩm đã Bán";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Tb_TênSP
            // 
            this.Tb_TênSP.Location = new System.Drawing.Point(689, 130);
            this.Tb_TênSP.Name = "Tb_TênSP";
            this.Tb_TênSP.Size = new System.Drawing.Size(256, 22);
            this.Tb_TênSP.TabIndex = 73;
            // 
            // Tb_NV2
            // 
            this.Tb_NV2.Location = new System.Drawing.Point(687, 80);
            this.Tb_NV2.Name = "Tb_NV2";
            this.Tb_NV2.Size = new System.Drawing.Size(256, 22);
            this.Tb_NV2.TabIndex = 72;
            // 
            // Tb_MãSP
            // 
            this.Tb_MãSP.Location = new System.Drawing.Point(225, 130);
            this.Tb_MãSP.Name = "Tb_MãSP";
            this.Tb_MãSP.Size = new System.Drawing.Size(256, 22);
            this.Tb_MãSP.TabIndex = 69;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(71, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 20);
            this.label10.TabIndex = 68;
            this.label10.Text = "Mã Sản Phẩm";
            // 
            // Tb_MãNV2
            // 
            this.Tb_MãNV2.Location = new System.Drawing.Point(225, 80);
            this.Tb_MãNV2.Name = "Tb_MãNV2";
            this.Tb_MãNV2.Size = new System.Drawing.Size(256, 22);
            this.Tb_MãNV2.TabIndex = 67;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(71, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 20);
            this.label11.TabIndex = 66;
            this.label11.Text = "Mã Nhân Viên";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(520, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 20);
            this.label12.TabIndex = 63;
            this.label12.Text = "Tên Sản Phẩm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(522, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 20);
            this.label13.TabIndex = 59;
            this.label13.Text = "Tên Nhân Viên";
            // 
            // txtMaHDBan
            // 
            this.txtMaHDBan.Location = new System.Drawing.Point(225, 184);
            this.txtMaHDBan.Name = "txtMaHDBan";
            this.txtMaHDBan.Size = new System.Drawing.Size(256, 22);
            this.txtMaHDBan.TabIndex = 56;
            // 
            // To_SP
            // 
            this.To_SP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To_SP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.To_SP.Location = new System.Drawing.Point(687, 32);
            this.To_SP.Name = "To_SP";
            this.To_SP.Size = new System.Drawing.Size(256, 27);
            this.To_SP.TabIndex = 54;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(535, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 20);
            this.label15.TabIndex = 53;
            this.label15.Text = "Đến Ngày";
            // 
            // From_SP
            // 
            this.From_SP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From_SP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.From_SP.Location = new System.Drawing.Point(225, 30);
            this.From_SP.Name = "From_SP";
            this.From_SP.Size = new System.Drawing.Size(269, 27);
            this.From_SP.TabIndex = 52;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(58, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 20);
            this.label16.TabIndex = 51;
            this.label16.Text = "Từ Ngày";
            // 
            // DataSP
            // 
            this.DataSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TG_Bán,
            this.MãSP,
            this.TênSP});
            this.DataSP.Location = new System.Drawing.Point(30, 241);
            this.DataSP.Name = "DataSP";
            this.DataSP.RowHeadersWidth = 51;
            this.DataSP.RowTemplate.Height = 24;
            this.DataSP.Size = new System.Drawing.Size(915, 404);
            this.DataSP.TabIndex = 50;
            // 
            // TG_Bán
            // 
            this.TG_Bán.HeaderText = "TG_Bán";
            this.TG_Bán.MinimumWidth = 6;
            this.TG_Bán.Name = "TG_Bán";
            this.TG_Bán.Width = 125;
            // 
            // MãSP
            // 
            this.MãSP.HeaderText = "MãSP";
            this.MãSP.MinimumWidth = 6;
            this.MãSP.Name = "MãSP";
            this.MãSP.Width = 125;
            // 
            // TênSP
            // 
            this.TênSP.HeaderText = "TênSP";
            this.TênSP.MinimumWidth = 6;
            this.TênSP.Name = "TênSP";
            this.TênSP.Width = 125;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(82, 186);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 20);
            this.label17.TabIndex = 48;
            this.label17.Text = "Mã Hóa Đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 78;
            this.label1.Text = "Quản Lý Sản Phẩm";
            // 
            // Btn_TrởLại
            // 
            this.Btn_TrởLại.Location = new System.Drawing.Point(1043, 18);
            this.Btn_TrởLại.Name = "Btn_TrởLại";
            this.Btn_TrởLại.Size = new System.Drawing.Size(75, 23);
            this.Btn_TrởLại.TabIndex = 77;
            this.Btn_TrởLại.Text = "Trở lại";
            this.Btn_TrởLại.UseVisualStyleBackColor = true;
            this.Btn_TrởLại.Click += new System.EventHandler(this.Btn_TrởLại_Click);
            // 
            // FrmQuảnLýSảnPhẩm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1204, 771);
            this.Controls.Add(this.tabControl_HH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_TrởLại);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmQuảnLýSảnPhẩm";
            this.Text = "Quản Lý Sản Phẩm";
            this.Load += new System.EventHandler(this.FrmQuảnLýSảnPhẩm_Load);
            this.tabControl_HH.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataHH)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_HH;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox Tb_MãHH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Tb_DVT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox Tb_MãSP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Tb_MãNV2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaHDBan;
        private System.Windows.Forms.DateTimePicker To_SP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker From_SP;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView DataSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TG_Bán;
        private System.Windows.Forms.DataGridViewTextBoxColumn MãSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TênSP;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_TrởLại;
        private System.Windows.Forms.TextBox Tb_TênSP;
        private System.Windows.Forms.TextBox Tb_NV2;
        private System.Windows.Forms.DataGridView DataHH;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Button Btn_Xóa;
        private System.Windows.Forms.Button Btn_Sửa;
        private System.Windows.Forms.Button Thêm;
        private System.Windows.Forms.TextBox Tb_DonGia;
        private System.Windows.Forms.TextBox Tb_TênHH;
    }
}