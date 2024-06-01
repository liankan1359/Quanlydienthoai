namespace QuanLyDienThoai
{
    partial class frmmain
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pcBheader = new System.Windows.Forms.PictureBox();
            this.btnmathang = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnhoadon = new System.Windows.Forms.Button();
            this.btnphieunhap = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBheader)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.Controls.Add(this.pcBheader);
            this.flowLayoutPanel1.Controls.Add(this.btnmathang);
            this.flowLayoutPanel1.Controls.Add(this.btnNhanVien);
            this.flowLayoutPanel1.Controls.Add(this.btnhoadon);
            this.flowLayoutPanel1.Controls.Add(this.btnphieunhap);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 739);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pcBheader
            // 
            this.pcBheader.Location = new System.Drawing.Point(3, 3);
            this.pcBheader.Name = "pcBheader";
            this.pcBheader.Size = new System.Drawing.Size(230, 230);
            this.pcBheader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBheader.TabIndex = 1;
            this.pcBheader.TabStop = false;
            // 
            // btnmathang
            // 
            this.btnmathang.FlatAppearance.BorderSize = 0;
            this.btnmathang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmathang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmathang.ForeColor = System.Drawing.Color.White;
            this.btnmathang.Image = global::QuanLyDienThoai.Properties.Resources.ad_product_24px;
            this.btnmathang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmathang.Location = new System.Drawing.Point(0, 236);
            this.btnmathang.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnmathang.Name = "btnmathang";
            this.btnmathang.Size = new System.Drawing.Size(253, 50);
            this.btnmathang.TabIndex = 1;
            this.btnmathang.Text = "Mặt Hàng";
            this.btnmathang.UseVisualStyleBackColor = true;
            this.btnmathang.Click += new System.EventHandler(this.btnmathang_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Image = global::QuanLyDienThoai.Properties.Resources.people_24px;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 286);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(250, 50);
            this.btnNhanVien.TabIndex = 2;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnhoadon
            // 
            this.btnhoadon.FlatAppearance.BorderSize = 0;
            this.btnhoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhoadon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhoadon.ForeColor = System.Drawing.Color.White;
            this.btnhoadon.Image = global::QuanLyDienThoai.Properties.Resources.bill_24px;
            this.btnhoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhoadon.Location = new System.Drawing.Point(0, 339);
            this.btnhoadon.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnhoadon.Name = "btnhoadon";
            this.btnhoadon.Size = new System.Drawing.Size(250, 50);
            this.btnhoadon.TabIndex = 2;
            this.btnhoadon.Text = "Hóa đơn";
            this.btnhoadon.UseVisualStyleBackColor = true;
            this.btnhoadon.Click += new System.EventHandler(this.btnhoadon_Click);
            // 
            // btnphieunhap
            // 
            this.btnphieunhap.FlatAppearance.BorderSize = 0;
            this.btnphieunhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnphieunhap.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnphieunhap.ForeColor = System.Drawing.Color.White;
            this.btnphieunhap.Image = global::QuanLyDienThoai.Properties.Resources.pn_24px;
            this.btnphieunhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnphieunhap.Location = new System.Drawing.Point(0, 392);
            this.btnphieunhap.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnphieunhap.Name = "btnphieunhap";
            this.btnphieunhap.Size = new System.Drawing.Size(250, 50);
            this.btnphieunhap.TabIndex = 2;
            this.btnphieunhap.Text = "Phiếu Nhập";
            this.btnphieunhap.UseVisualStyleBackColor = true;
            this.btnphieunhap.Click += new System.EventHandler(this.btnohieunhap_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(250, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(992, 739);
            this.mainpanel.TabIndex = 1;
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 739);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmmain";
            this.Text = "Quản lý cửa hàng điện thoại di động";
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcBheader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pcBheader;
        private System.Windows.Forms.Button btnmathang;
        private System.Windows.Forms.Button btnphieunhap;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnhoadon;
        private System.Windows.Forms.Panel mainpanel;
    }
}

