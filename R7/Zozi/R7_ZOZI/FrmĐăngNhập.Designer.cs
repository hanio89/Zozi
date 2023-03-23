namespace R7_ZOZI
{
    partial class FrmĐăngNhập
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmĐăngNhập));
            this.label3 = new System.Windows.Forms.Label();
            this.Tb_mk = new System.Windows.Forms.TextBox();
            this.Tb_tk = new System.Windows.Forms.TextBox();
            this.Btn_qmk = new System.Windows.Forms.Button();
            this.Btn_xacnhan = new System.Windows.Forms.Button();
            this.Rbtn_NV = new System.Windows.Forms.RadioButton();
            this.Rbtn_QL = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pb_eye = new System.Windows.Forms.PictureBox();
            this.Pb_Hide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_eye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Hide)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Đăng Nhập";
            // 
            // Tb_mk
            // 
            this.Tb_mk.Location = new System.Drawing.Point(281, 212);
            this.Tb_mk.Name = "Tb_mk";
            this.Tb_mk.PasswordChar = '*';
            this.Tb_mk.Size = new System.Drawing.Size(333, 22);
            this.Tb_mk.TabIndex = 2;
            this.Tb_mk.Tag = "";
            // 
            // Tb_tk
            // 
            this.Tb_tk.Location = new System.Drawing.Point(281, 160);
            this.Tb_tk.Name = "Tb_tk";
            this.Tb_tk.Size = new System.Drawing.Size(333, 22);
            this.Tb_tk.TabIndex = 1;
            // 
            // Btn_qmk
            // 
            this.Btn_qmk.Location = new System.Drawing.Point(463, 298);
            this.Btn_qmk.Name = "Btn_qmk";
            this.Btn_qmk.Size = new System.Drawing.Size(151, 23);
            this.Btn_qmk.TabIndex = 14;
            this.Btn_qmk.Text = "Quên mật khẩu";
            this.Btn_qmk.UseVisualStyleBackColor = true;
            // 
            // Btn_xacnhan
            // 
            this.Btn_xacnhan.Location = new System.Drawing.Point(190, 298);
            this.Btn_xacnhan.Name = "Btn_xacnhan";
            this.Btn_xacnhan.Size = new System.Drawing.Size(138, 23);
            this.Btn_xacnhan.TabIndex = 13;
            this.Btn_xacnhan.Text = "Xác nhận";
            this.Btn_xacnhan.UseVisualStyleBackColor = true;
            this.Btn_xacnhan.Click += new System.EventHandler(this.Btn_xacnhan_Click);
            // 
            // Rbtn_NV
            // 
            this.Rbtn_NV.AutoSize = true;
            this.Rbtn_NV.Location = new System.Drawing.Point(448, 258);
            this.Rbtn_NV.Name = "Rbtn_NV";
            this.Rbtn_NV.Size = new System.Drawing.Size(90, 20);
            this.Rbtn_NV.TabIndex = 12;
            this.Rbtn_NV.TabStop = true;
            this.Rbtn_NV.Text = "Nhân Viên";
            this.Rbtn_NV.UseVisualStyleBackColor = true;
            // 
            // Rbtn_QL
            // 
            this.Rbtn_QL.AutoSize = true;
            this.Rbtn_QL.Location = new System.Drawing.Point(251, 258);
            this.Rbtn_QL.Name = "Rbtn_QL";
            this.Rbtn_QL.Size = new System.Drawing.Size(77, 20);
            this.Rbtn_QL.TabIndex = 11;
            this.Rbtn_QL.TabStop = true;
            this.Rbtn_QL.Text = "Quản Lý";
            this.Rbtn_QL.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tài Khoản";
            // 
            // Pb_eye
            // 
            this.Pb_eye.Image = ((System.Drawing.Image)(resources.GetObject("Pb_eye.Image")));
            this.Pb_eye.Location = new System.Drawing.Point(620, 212);
            this.Pb_eye.Name = "Pb_eye";
            this.Pb_eye.Size = new System.Drawing.Size(43, 32);
            this.Pb_eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_eye.TabIndex = 18;
            this.Pb_eye.TabStop = false;
            this.Pb_eye.Click += new System.EventHandler(this.Pb_eye_Click);
            // 
            // Pb_Hide
            // 
            this.Pb_Hide.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Pb_Hide.ErrorImage")));
            this.Pb_Hide.Image = ((System.Drawing.Image)(resources.GetObject("Pb_Hide.Image")));
            this.Pb_Hide.InitialImage = ((System.Drawing.Image)(resources.GetObject("Pb_Hide.InitialImage")));
            this.Pb_Hide.Location = new System.Drawing.Point(620, 212);
            this.Pb_Hide.Name = "Pb_Hide";
            this.Pb_Hide.Size = new System.Drawing.Size(43, 32);
            this.Pb_Hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_Hide.TabIndex = 19;
            this.Pb_Hide.TabStop = false;
            this.Pb_Hide.Click += new System.EventHandler(this.Pb_Hide_Click);
            // 
            // FrmĐăngNhập
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pb_Hide);
            this.Controls.Add(this.Pb_eye);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tb_mk);
            this.Controls.Add(this.Tb_tk);
            this.Controls.Add(this.Btn_qmk);
            this.Controls.Add(this.Btn_xacnhan);
            this.Controls.Add(this.Rbtn_NV);
            this.Controls.Add(this.Rbtn_QL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmĐăngNhập";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.FrmĐăngNhập_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_eye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Hide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tb_mk;
        private System.Windows.Forms.TextBox Tb_tk;
        private System.Windows.Forms.Button Btn_qmk;
        private System.Windows.Forms.Button Btn_xacnhan;
        private System.Windows.Forms.RadioButton Rbtn_NV;
        private System.Windows.Forms.RadioButton Rbtn_QL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Pb_eye;
        private System.Windows.Forms.PictureBox Pb_Hide;
    }
}

