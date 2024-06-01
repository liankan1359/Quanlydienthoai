namespace QuanLyDienThoai
{
    partial class LookHoaDon
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
            this.btnlammoihd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxhoadon = new System.Windows.Forms.ComboBox();
            this.btnlookhd = new System.Windows.Forms.Button();
            this.inputnhanvien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvtkhd = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtkhd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlammoihd
            // 
            this.btnlammoihd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlammoihd.Location = new System.Drawing.Point(943, 39);
            this.btnlammoihd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnlammoihd.Name = "btnlammoihd";
            this.btnlammoihd.Size = new System.Drawing.Size(110, 40);
            this.btnlammoihd.TabIndex = 41;
            this.btnlammoihd.Text = "Làm mới";
            this.btnlammoihd.UseVisualStyleBackColor = true;
            this.btnlammoihd.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(442, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 41;
            this.label3.Text = "Nhập từ khóa:";
            // 
            // cbxhoadon
            // 
            this.cbxhoadon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxhoadon.FormattingEnabled = true;
            this.cbxhoadon.Items.AddRange(new object[] {
            "Mã hóa đơn",
            "Mã nhân viên",
            "Tên khách hàng",
            "Ngày",
            "Tổng tiền",
            "Mã hóa đơn",
            "Mã mặt hàng",
            "Số lượng",
            "Ghi chú"});
            this.cbxhoadon.Location = new System.Drawing.Point(234, 45);
            this.cbxhoadon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxhoadon.Name = "cbxhoadon";
            this.cbxhoadon.Size = new System.Drawing.Size(176, 31);
            this.cbxhoadon.TabIndex = 36;
            // 
            // btnlookhd
            // 
            this.btnlookhd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlookhd.Location = new System.Drawing.Point(801, 39);
            this.btnlookhd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnlookhd.Name = "btnlookhd";
            this.btnlookhd.Size = new System.Drawing.Size(110, 40);
            this.btnlookhd.TabIndex = 37;
            this.btnlookhd.Text = "Tìm kiếm";
            this.btnlookhd.UseVisualStyleBackColor = true;
            this.btnlookhd.Click += new System.EventHandler(this.btnlookhd_Click);
            // 
            // inputnhanvien
            // 
            this.inputnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputnhanvien.Location = new System.Drawing.Point(567, 49);
            this.inputnhanvien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputnhanvien.Name = "inputnhanvien";
            this.inputnhanvien.Size = new System.Drawing.Size(176, 27);
            this.inputnhanvien.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 23);
            this.label8.TabIndex = 35;
            this.label8.Text = "Chọn loại cần tìm kiếm:";
            // 
            // dgvtkhd
            // 
            this.dgvtkhd.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvtkhd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtkhd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvtkhd.Location = new System.Drawing.Point(33, 146);
            this.dgvtkhd.Name = "dgvtkhd";
            this.dgvtkhd.RowHeadersWidth = 51;
            this.dgvtkhd.RowTemplate.Height = 24;
            this.dgvtkhd.Size = new System.Drawing.Size(1051, 266);
            this.dgvtkhd.TabIndex = 42;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHoaDon";
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaNhanVien";
            this.Column2.HeaderText = "Mã nhân viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenKhachHang";
            this.Column3.HeaderText = "Tên khách hàng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Ngay";
            this.Column4.HeaderText = "Ngày";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TongTien";
            this.Column5.HeaderText = "Tổng tiền";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MaMatHang";
            this.Column6.HeaderText = "Mã mặt hàng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "SoLuong";
            this.Column7.HeaderText = "Số lượng";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "GhiChu";
            this.Column8.HeaderText = "Ghi chú";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // LookHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 481);
            this.Controls.Add(this.dgvtkhd);
            this.Controls.Add(this.btnlookhd);
            this.Controls.Add(this.btnlammoihd);
            this.Controls.Add(this.cbxhoadon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputnhanvien);
            this.Controls.Add(this.label8);
            this.Name = "LookHoaDon";
            this.Text = "Tìm kiếm hóa đơn";
            this.Load += new System.EventHandler(this.LookHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtkhd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnlammoihd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxhoadon;
        private System.Windows.Forms.Button btnlookhd;
        private System.Windows.Forms.TextBox inputnhanvien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvtkhd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}