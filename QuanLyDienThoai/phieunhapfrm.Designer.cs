namespace QuanLyDienThoai
{
    partial class phieunhapfrm
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
            this.txttg = new System.Windows.Forms.TextBox();
            this.txtTenncc = new System.Windows.Forms.TextBox();
            this.dtpnn = new System.Windows.Forms.DateTimePicker();
            this.cbxMaNV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmapn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtmh = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtgc = new System.Windows.Forms.TextBox();
            this.txtgn = new System.Windows.Forms.TextBox();
            this.txtctsl = new System.Windows.Forms.TextBox();
            this.cbxMamh = new System.Windows.Forms.ComboBox();
            this.dgvphieunhap = new System.Windows.Forms.DataGridView();
            this.MaMatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_luu_boqua = new System.Windows.Forms.Panel();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.pncrud = new System.Windows.Forms.Panel();
            this.btnxoapn = new System.Windows.Forms.Button();
            this.btnthempn = new System.Windows.Forms.Button();
            this.btnsuapn = new System.Windows.Forms.Button();
            this.btnlook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieunhap)).BeginInit();
            this.pnl_luu_boqua.SuspendLayout();
            this.pncrud.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttg);
            this.groupBox1.Controls.Add(this.txtTenncc);
            this.groupBox1.Controls.Add(this.dtpnn);
            this.groupBox1.Controls.Add(this.cbxMaNV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtmapn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1003, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txttg
            // 
            this.txttg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txttg.Location = new System.Drawing.Point(196, 107);
            this.txttg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttg.Name = "txttg";
            this.txttg.Size = new System.Drawing.Size(241, 22);
            this.txttg.TabIndex = 94;
            // 
            // txtTenncc
            // 
            this.txtTenncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtTenncc.Location = new System.Drawing.Point(196, 69);
            this.txtTenncc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenncc.Name = "txtTenncc";
            this.txtTenncc.Size = new System.Drawing.Size(241, 22);
            this.txtTenncc.TabIndex = 93;
            // 
            // dtpnn
            // 
            this.dtpnn.CustomFormat = "MM/dd/yyyy";
            this.dtpnn.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dtpnn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpnn.Location = new System.Drawing.Point(683, 84);
            this.dtpnn.Name = "dtpnn";
            this.dtpnn.Size = new System.Drawing.Size(241, 30);
            this.dtpnn.TabIndex = 91;
            // 
            // cbxMaNV
            // 
            this.cbxMaNV.DisplayMember = "MaNhanVien";
            this.cbxMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.cbxMaNV.FormattingEnabled = true;
            this.cbxMaNV.Location = new System.Drawing.Point(683, 34);
            this.cbxMaNV.Name = "cbxMaNV";
            this.cbxMaNV.Size = new System.Drawing.Size(241, 24);
            this.cbxMaNV.TabIndex = 92;
            this.cbxMaNV.ValueMember = "MaNhanVien";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 86;
            this.label4.Text = "Tổng giá trị nhập:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(568, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 23);
            this.label7.TabIndex = 88;
            this.label7.Text = "Ngày nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(548, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 89;
            this.label3.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 85;
            this.label2.Text = "Mã phiếu nhập:";
            // 
            // txtmapn
            // 
            this.txtmapn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtmapn.Location = new System.Drawing.Point(196, 31);
            this.txtmapn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmapn.Name = "txtmapn";
            this.txtmapn.Size = new System.Drawing.Size(241, 22);
            this.txtmapn.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 23);
            this.label5.TabIndex = 87;
            this.label5.Text = "Tên nhà cung cấp:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(62, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 23);
            this.label11.TabIndex = 70;
            this.label11.Text = "Mã mặt hàng:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(97, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 23);
            this.label12.TabIndex = 69;
            this.label12.Text = "Số lượng:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(583, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 23);
            this.label13.TabIndex = 68;
            this.label13.Text = "Giá nhập:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(593, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 23);
            this.label14.TabIndex = 67;
            this.label14.Text = "Ghi chú:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtmh);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Controls.Add(this.txtgc);
            this.groupBox2.Controls.Add(this.txtgn);
            this.groupBox2.Controls.Add(this.txtctsl);
            this.groupBox2.Controls.Add(this.cbxMamh);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1003, 166);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phiếu nhập";
            // 
            // txtmh
            // 
            this.txtmh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtmh.Location = new System.Drawing.Point(683, 107);
            this.txtmh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmh.Name = "txtmh";
            this.txtmh.Size = new System.Drawing.Size(241, 22);
            this.txtmh.TabIndex = 95;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(549, 107);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(119, 23);
            this.label.TabIndex = 94;
            this.label.Text = "Tên mặt hàng:";
            // 
            // txtgc
            // 
            this.txtgc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtgc.Location = new System.Drawing.Point(683, 70);
            this.txtgc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtgc.Name = "txtgc";
            this.txtgc.Size = new System.Drawing.Size(241, 22);
            this.txtgc.TabIndex = 83;
            // 
            // txtgn
            // 
            this.txtgn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtgn.Location = new System.Drawing.Point(683, 33);
            this.txtgn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtgn.Name = "txtgn";
            this.txtgn.Size = new System.Drawing.Size(241, 22);
            this.txtgn.TabIndex = 84;
            // 
            // txtctsl
            // 
            this.txtctsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtctsl.Location = new System.Drawing.Point(196, 80);
            this.txtctsl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtctsl.Name = "txtctsl";
            this.txtctsl.Size = new System.Drawing.Size(241, 22);
            this.txtctsl.TabIndex = 85;
            // 
            // cbxMamh
            // 
            this.cbxMamh.DisplayMember = "MaMatHang";
            this.cbxMamh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.cbxMamh.FormattingEnabled = true;
            this.cbxMamh.Location = new System.Drawing.Point(196, 35);
            this.cbxMamh.Name = "cbxMamh";
            this.cbxMamh.Size = new System.Drawing.Size(241, 24);
            this.cbxMamh.TabIndex = 86;
            this.cbxMamh.ValueMember = "MaMatHang";
            // 
            // dgvphieunhap
            // 
            this.dgvphieunhap.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvphieunhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphieunhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMatHang,
            this.SoLuong,
            this.Column4,
            this.Column5,
            this.Column2});
            this.dgvphieunhap.Location = new System.Drawing.Point(23, 382);
            this.dgvphieunhap.Name = "dgvphieunhap";
            this.dgvphieunhap.RowHeadersWidth = 51;
            this.dgvphieunhap.RowTemplate.Height = 24;
            this.dgvphieunhap.Size = new System.Drawing.Size(929, 189);
            this.dgvphieunhap.TabIndex = 2;
            this.dgvphieunhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvphieunhap_CellClick);
            // 
            // MaMatHang
            // 
            this.MaMatHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaMatHang.DataPropertyName = "MaMatHang";
            this.MaMatHang.HeaderText = "Mã mặt hàng";
            this.MaMatHang.MinimumWidth = 6;
            this.MaMatHang.Name = "MaMatHang";
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "GiaNhap";
            this.Column4.HeaderText = "Giá nhập";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "GhiChu";
            this.Column5.HeaderText = "Ghi chú";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TenMatHang";
            this.Column2.HeaderText = "Tên mặt hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // pnl_luu_boqua
            // 
            this.pnl_luu_boqua.Controls.Add(this.btn_luu);
            this.pnl_luu_boqua.Controls.Add(this.btn_boqua);
            this.pnl_luu_boqua.Location = new System.Drawing.Point(78, 593);
            this.pnl_luu_boqua.Name = "pnl_luu_boqua";
            this.pnl_luu_boqua.Size = new System.Drawing.Size(276, 81);
            this.pnl_luu_boqua.TabIndex = 66;
            this.pnl_luu_boqua.Visible = false;
            // 
            // btn_luu
            // 
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Location = new System.Drawing.Point(17, 20);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(110, 40);
            this.btn_luu.TabIndex = 65;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_boqua
            // 
            this.btn_boqua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_boqua.Location = new System.Drawing.Point(153, 20);
            this.btn_boqua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(110, 40);
            this.btn_boqua.TabIndex = 61;
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.UseVisualStyleBackColor = true;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
            // 
            // pncrud
            // 
            this.pncrud.Controls.Add(this.btnxoapn);
            this.pncrud.Controls.Add(this.btnthempn);
            this.pncrud.Location = new System.Drawing.Point(86, 577);
            this.pncrud.Name = "pncrud";
            this.pncrud.Size = new System.Drawing.Size(268, 74);
            this.pncrud.TabIndex = 67;
            // 
            // btnxoapn
            // 
            this.btnxoapn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoapn.Location = new System.Drawing.Point(17, 36);
            this.btnxoapn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnxoapn.Name = "btnxoapn";
            this.btnxoapn.Size = new System.Drawing.Size(110, 40);
            this.btnxoapn.TabIndex = 59;
            this.btnxoapn.Text = "Xóa";
            this.btnxoapn.UseVisualStyleBackColor = true;
            this.btnxoapn.Click += new System.EventHandler(this.btnxoapn_Click);
            // 
            // btnthempn
            // 
            this.btnthempn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthempn.Location = new System.Drawing.Point(145, 36);
            this.btnthempn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthempn.Name = "btnthempn";
            this.btnthempn.Size = new System.Drawing.Size(110, 40);
            this.btnthempn.TabIndex = 53;
            this.btnthempn.Text = "Thêm";
            this.btnthempn.UseVisualStyleBackColor = true;
            this.btnthempn.Click += new System.EventHandler(this.btnthempn_Click);
            // 
            // btnsuapn
            // 
            this.btnsuapn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuapn.Location = new System.Drawing.Point(379, 613);
            this.btnsuapn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsuapn.Name = "btnsuapn";
            this.btnsuapn.Size = new System.Drawing.Size(110, 40);
            this.btnsuapn.TabIndex = 65;
            this.btnsuapn.Text = "Sửa";
            this.btnsuapn.UseVisualStyleBackColor = true;
            this.btnsuapn.Click += new System.EventHandler(this.btnsuapn_Click);
            // 
            // btnlook
            // 
            this.btnlook.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlook.Location = new System.Drawing.Point(520, 613);
            this.btnlook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnlook.Name = "btnlook";
            this.btnlook.Size = new System.Drawing.Size(110, 40);
            this.btnlook.TabIndex = 78;
            this.btnlook.Text = "Tìm kiếm";
            this.btnlook.UseVisualStyleBackColor = true;
            this.btnlook.Click += new System.EventHandler(this.btnlook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 45);
            this.label1.TabIndex = 79;
            this.label1.Text = "PHIẾU NHẬP";
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtThanhtien.Location = new System.Drawing.Point(761, 631);
            this.txtThanhtien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.Size = new System.Drawing.Size(191, 22);
            this.txtThanhtien.TabIndex = 121;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(659, 631);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 23);
            this.label8.TabIndex = 120;
            this.label8.Text = "Thành tiền:";
            // 
            // phieunhapfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 703);
            this.Controls.Add(this.txtThanhtien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlook);
            this.Controls.Add(this.pnl_luu_boqua);
            this.Controls.Add(this.pncrud);
            this.Controls.Add(this.btnsuapn);
            this.Controls.Add(this.dgvphieunhap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "phieunhapfrm";
            this.Text = "phieunhapfrm";
            this.Load += new System.EventHandler(this.phieunhapfrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieunhap)).EndInit();
            this.pnl_luu_boqua.ResumeLayout(false);
            this.pncrud.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpnn;
        private System.Windows.Forms.ComboBox cbxMaNV;
        private System.Windows.Forms.TextBox txtmapn;
        private System.Windows.Forms.TextBox txtgc;
        private System.Windows.Forms.TextBox txtgn;
        private System.Windows.Forms.TextBox txtctsl;
        private System.Windows.Forms.ComboBox cbxMamh;
        private System.Windows.Forms.DataGridView dgvphieunhap;
        private System.Windows.Forms.Panel pnl_luu_boqua;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Panel pncrud;
        private System.Windows.Forms.Button btnxoapn;
        private System.Windows.Forms.Button btnthempn;
        private System.Windows.Forms.Button btnsuapn;
        private System.Windows.Forms.TextBox txttg;
        private System.Windows.Forms.TextBox txtTenncc;
        private System.Windows.Forms.TextBox txtmh;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnlook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox txtThanhtien;
        private System.Windows.Forms.Label label8;
    }
}