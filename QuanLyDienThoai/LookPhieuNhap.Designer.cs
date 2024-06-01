namespace QuanLyDienThoai
{
    partial class LookPhieuNhap
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
            this.dgvtkhd = new System.Windows.Forms.DataGridView();
            this.btnlookpn = new System.Windows.Forms.Button();
            this.btnlammoipn = new System.Windows.Forms.Button();
            this.cbxpn = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputpn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtkhd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtkhd
            // 
            this.dgvtkhd.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvtkhd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtkhd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column9,
            this.Column8});
            this.dgvtkhd.Location = new System.Drawing.Point(43, 161);
            this.dgvtkhd.Name = "dgvtkhd";
            this.dgvtkhd.RowHeadersWidth = 51;
            this.dgvtkhd.RowTemplate.Height = 24;
            this.dgvtkhd.Size = new System.Drawing.Size(1051, 266);
            this.dgvtkhd.TabIndex = 49;
            // 
            // btnlookpn
            // 
            this.btnlookpn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlookpn.Location = new System.Drawing.Point(811, 54);
            this.btnlookpn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnlookpn.Name = "btnlookpn";
            this.btnlookpn.Size = new System.Drawing.Size(110, 40);
            this.btnlookpn.TabIndex = 45;
            this.btnlookpn.Text = "Tìm kiếm";
            this.btnlookpn.UseVisualStyleBackColor = true;
            this.btnlookpn.Click += new System.EventHandler(this.btnlookpn_Click);
            // 
            // btnlammoipn
            // 
            this.btnlammoipn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlammoipn.Location = new System.Drawing.Point(953, 54);
            this.btnlammoipn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnlammoipn.Name = "btnlammoipn";
            this.btnlammoipn.Size = new System.Drawing.Size(110, 40);
            this.btnlammoipn.TabIndex = 47;
            this.btnlammoipn.Text = "Làm mới";
            this.btnlammoipn.UseVisualStyleBackColor = true;
            this.btnlammoipn.Visible = false;
            // 
            // cbxpn
            // 
            this.cbxpn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxpn.FormattingEnabled = true;
            this.cbxpn.Items.AddRange(new object[] {
            "Mã phiếu nhập",
            "Tên nhà cung cấp",
            "Mã nhân viên",
            "Ngày",
            "Tổng giá trị",
            "Mã mặt hàng",
            "Số lượng",
            "Giá nhập",
            "Ghi chú"});
            this.cbxpn.Location = new System.Drawing.Point(244, 60);
            this.cbxpn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxpn.Name = "cbxpn";
            this.cbxpn.Size = new System.Drawing.Size(176, 31);
            this.cbxpn.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 48;
            this.label3.Text = "Nhập từ khóa:";
            // 
            // inputpn
            // 
            this.inputpn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputpn.Location = new System.Drawing.Point(577, 64);
            this.inputpn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputpn.Name = "inputpn";
            this.inputpn.Size = new System.Drawing.Size(176, 27);
            this.inputpn.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 23);
            this.label8.TabIndex = 43;
            this.label8.Text = "Chọn loại cần tìm kiếm:";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaPhieuNhap";
            this.Column1.HeaderText = "Mã phiếu nhập";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "TenNhaCungCap";
            this.Column3.HeaderText = "Tên nhà cung cấp";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "MaNhanVien";
            this.Column2.HeaderText = "Mã nhân viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Ngay";
            this.Column4.HeaderText = "Ngày";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "TongGiaTri";
            this.Column5.HeaderText = "Tổng giá trị";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "MaMatHang";
            this.Column6.HeaderText = "Mã mặt hàng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "SoLuong";
            this.Column7.HeaderText = "Số lượng";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.DataPropertyName = "GiaNhap";
            this.Column9.HeaderText = "Giá nhập";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "GhiChu";
            this.Column8.HeaderText = "Ghi chú";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // LookPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 481);
            this.Controls.Add(this.dgvtkhd);
            this.Controls.Add(this.btnlookpn);
            this.Controls.Add(this.btnlammoipn);
            this.Controls.Add(this.cbxpn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputpn);
            this.Controls.Add(this.label8);
            this.Name = "LookPhieuNhap";
            this.Text = "Tìm kiếm phiếu nhập";
            this.Load += new System.EventHandler(this.LookPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtkhd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtkhd;
        private System.Windows.Forms.Button btnlookpn;
        private System.Windows.Forms.Button btnlammoipn;
        private System.Windows.Forms.ComboBox cbxpn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputpn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}