namespace R7_ZOZI
{
    partial class FrmTrangChủNhânViên
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrangChủNhânViên));
            this.Btn_NhàCungCấp = new System.Windows.Forms.Button();
            this.Btn_HàngHóa = new System.Windows.Forms.Button();
            this.Btn_Nhập = new System.Windows.Forms.Button();
            this.Btn_Bán = new System.Windows.Forms.Button();
            this.Btn_ĐăngXuất = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_NhàCungCấp
            // 
            this.Btn_NhàCungCấp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_NhàCungCấp.BackgroundImage")));
            this.Btn_NhàCungCấp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_NhàCungCấp.Location = new System.Drawing.Point(346, 228);
            this.Btn_NhàCungCấp.Name = "Btn_NhàCungCấp";
            this.Btn_NhàCungCấp.Size = new System.Drawing.Size(209, 164);
            this.Btn_NhàCungCấp.TabIndex = 9;
            this.Btn_NhàCungCấp.Text = "Nhà Cung Cấp";
            this.Btn_NhàCungCấp.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Btn_NhàCungCấp.UseVisualStyleBackColor = true;
            // 
            // Btn_HàngHóa
            // 
            this.Btn_HàngHóa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_HàngHóa.BackgroundImage")));
            this.Btn_HàngHóa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_HàngHóa.Location = new System.Drawing.Point(78, 228);
            this.Btn_HàngHóa.Name = "Btn_HàngHóa";
            this.Btn_HàngHóa.Size = new System.Drawing.Size(210, 164);
            this.Btn_HàngHóa.TabIndex = 8;
            this.Btn_HàngHóa.Text = "Hàng Hóa";
            this.Btn_HàngHóa.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Btn_HàngHóa.UseVisualStyleBackColor = true;
            // 
            // Btn_Nhập
            // 
            this.Btn_Nhập.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Nhập.BackgroundImage")));
            this.Btn_Nhập.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Nhập.Location = new System.Drawing.Point(346, 55);
            this.Btn_Nhập.Name = "Btn_Nhập";
            this.Btn_Nhập.Size = new System.Drawing.Size(210, 146);
            this.Btn_Nhập.TabIndex = 7;
            this.Btn_Nhập.Text = "Nhập";
            this.Btn_Nhập.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Btn_Nhập.UseVisualStyleBackColor = true;
            this.Btn_Nhập.Click += new System.EventHandler(this.Btn_Nhập_Click);
            // 
            // Btn_Bán
            // 
            this.Btn_Bán.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Bán.BackgroundImage")));
            this.Btn_Bán.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Bán.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Bán.Location = new System.Drawing.Point(78, 55);
            this.Btn_Bán.Name = "Btn_Bán";
            this.Btn_Bán.Size = new System.Drawing.Size(210, 146);
            this.Btn_Bán.TabIndex = 6;
            this.Btn_Bán.Text = "Bán";
            this.Btn_Bán.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Btn_Bán.UseVisualStyleBackColor = true;
            this.Btn_Bán.Click += new System.EventHandler(this.Btn_Bán_Click);
            // 
            // Btn_ĐăngXuất
            // 
            this.Btn_ĐăngXuất.Location = new System.Drawing.Point(611, 68);
            this.Btn_ĐăngXuất.Name = "Btn_ĐăngXuất";
            this.Btn_ĐăngXuất.Size = new System.Drawing.Size(122, 40);
            this.Btn_ĐăngXuất.TabIndex = 5;
            this.Btn_ĐăngXuất.Text = "Đăng xuất";
            this.Btn_ĐăngXuất.UseVisualStyleBackColor = true;
            this.Btn_ĐăngXuất.Click += new System.EventHandler(this.Btn_ĐăngXuất_Click_1);
            // 
            // FrmTrangChủNhânViên
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_NhàCungCấp);
            this.Controls.Add(this.Btn_HàngHóa);
            this.Controls.Add(this.Btn_Nhập);
            this.Controls.Add(this.Btn_Bán);
            this.Controls.Add(this.Btn_ĐăngXuất);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTrangChủNhânViên";
            this.Text = "Trang Chủ Nhân Viên";
            this.Load += new System.EventHandler(this.FrmTrangChủNhânViên_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_NhàCungCấp;
        private System.Windows.Forms.Button Btn_HàngHóa;
        private System.Windows.Forms.Button Btn_Nhập;
        private System.Windows.Forms.Button Btn_Bán;
        private System.Windows.Forms.Button Btn_ĐăngXuất;
    }
}