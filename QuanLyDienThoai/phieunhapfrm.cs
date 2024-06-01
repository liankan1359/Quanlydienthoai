using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyDienThoai
{
    public partial class phieunhapfrm : Form
    {
        public phieunhapfrm()
        {
            InitializeComponent();
        }

        SqlConnection con_phieunhap;

        SqlDataAdapter adapter = new SqlDataAdapter();

        private void phieunhapfrm_Load(object sender, EventArgs e)
        {
            string constring = ConfigurationManager.ConnectionStrings["QLDienThoai"].ConnectionString;
            con_phieunhap = new SqlConnection(constring);
            try
            {
                con_phieunhap.Open();
                Hienthi(con_phieunhap);
                loadCbxMaNV(con_phieunhap);
                loadCbxMamh(con_phieunhap);
                if (cbxMamh.Items.Count > 0)
                    cbxMamh.SelectedIndex = 0;
                if (cbxMaNV.Items.Count > 0)
                    cbxMaNV.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }

        }

        public void Hienthi(SqlConnection con_phieunhap)
        {
            string sqlSelect = "SELECT ctpn.MaMatHang, ctpn.SoLuong,ctpn.GiaNhap,ctpn.GhiChu, mh.TenMatHang FROM ChiTietPhieuNhap ctpn JOIN MatHang mh ON ctpn.MaMatHang = mh.MaMatHang";
            using (SqlCommand cmd = new SqlCommand(sqlSelect, con_phieunhap))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvphieunhap.DataSource = dt;
                    dgvphieunhap.AutoResizeColumns();
                }
            }
        }

        public void loadCbxMaNV(SqlConnection con_phieunhap)
        {
            string sqlSelect = "Select * from NhanVien";
            using (SqlCommand cmd = new SqlCommand(sqlSelect, con_phieunhap))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    cbxMaNV.DisplayMember = "MaNhanVien";
                    cbxMaNV.DataSource = dt;
                }
            }
        }
        public void loadCbxMamh(SqlConnection con_phieunhap)
        {
            string sqlSelect = "Select * from MatHang";
            using (SqlCommand cmd = new SqlCommand(sqlSelect, con_phieunhap))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    cbxMamh.DisplayMember = "MaMatHang";
                    cbxMamh.DataSource = dt;
                }
            }
        }

        private void dgvphieunhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if (e.RowIndex >= 0)
            {
                i = e.RowIndex;
                cbxMamh.Text = dgvphieunhap.Rows[i].Cells[0].Value.ToString();
                txtctsl.Text = dgvphieunhap.Rows[i].Cells[1].Value.ToString();
                txtgn.Text = dgvphieunhap.Rows[i].Cells[2].Value.ToString();
                txtgc.Text = dgvphieunhap.Rows[i].Cells[3].Value.ToString();
                txtmh.Text = dgvphieunhap.Rows[i].Cells[4].Value.ToString();

                decimal giaBan = Convert.ToDecimal(dgvphieunhap.Rows[i].Cells[2].Value);
                int soLuong = Convert.ToInt32(dgvphieunhap.Rows[i].Cells[1].Value);
                decimal tongTien = giaBan * soLuong;

                string maMatHang = dgvphieunhap.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (con_phieunhap.State != ConnectionState.Open)
                {
                    con_phieunhap.Open();
                }
                string sqlSelect = @"
                        SELECT pn.MaPhieuNhap, pn.MaNhanVien, pn.TenNhaCungCap, pn.Ngay, pn.TongGiaTri
                        FROM PhieuNhap pn
                        JOIN ChiTietPhieuNhap ctpn ON pn.MaPhieuNhap = ctpn.MaPhieuNhap
                        WHERE ctpn.MaPhieuNhap = @MaMatHang";

                using (SqlCommand cmd = new SqlCommand(sqlSelect, con_phieunhap))
                {
                    cmd.Parameters.AddWithValue("@MaMatHang", maMatHang);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtmapn.Text = reader["MaPhieuNhap"].ToString();
                            cbxMaNV.Text = reader["MaNhanVien"].ToString();
                            txtTenncc.Text = reader["TenNhaCungCap"].ToString();
                            dtpnn.Value = Convert.ToDateTime(reader["Ngay"]);
                            txttg.Text = reader["TongGiaTri"].ToString();
                        }
                    }
                }
                txttg.Text = tongTien.ToString();
                decimal tongTienTatCaHang = 0;
                for (int j = 0; j < dgvphieunhap.Rows.Count; j++)
                {
                    decimal giaBanHang = Convert.ToDecimal(dgvphieunhap.Rows[j].Cells[2].Value);
                    int soLuongHang = Convert.ToInt32(dgvphieunhap.Rows[j].Cells[1].Value);
                    tongTienTatCaHang += giaBanHang * soLuongHang;
                }
                txtThanhtien.Text = tongTienTatCaHang.ToString();
            }
        }

        private void btnthempn_Click(object sender, EventArgs e)
        {
            string sqlInsert = @"
            INSERT INTO ChiTietPhieuNhap (MaPhieuNhap, MaMatHang, SoLuong,GiaNhap, GhiChu)
            VALUES (@MaPhieuNhap, @MaMatHang, @SoLuong,@GiaNhap, @GhiChu)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(sqlInsert, con_phieunhap))
                {
                    cmd.Parameters.AddWithValue("@MaPhieuNhap", txtmapn.Text);
                    cmd.Parameters.AddWithValue("@MaMatHang", cbxMamh.Text);
                    cmd.Parameters.AddWithValue("@SoLuong", int.Parse(txtctsl.Text));
                    cmd.Parameters.AddWithValue("@GiaNhap", int.Parse(txtgn.Text));
                    cmd.Parameters.AddWithValue("@GhiChu", txtgc.Text);

                    if (con_phieunhap.State != ConnectionState.Open)
                    {
                        con_phieunhap.Open();
                    }
                    cmd.ExecuteNonQuery();
                }
                Hienthi(con_phieunhap);
                MessageBox.Show("Thêm chi tiết phiếu nhập thành công!", "Thông Báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm chi tiết phiếu nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoapn_Click(object sender, EventArgs e)
        {
            if (txtmapn.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Mã Phiếu Nhập trước khi xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết phiếu nhập này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string sqlDelete = @"
        DELETE FROM ChiTietPhieuNhap
        WHERE MaPhieuNhap = @MaPhieuNhap AND MaMatHang = @MaMatHang";
                try
                {
                    using (SqlCommand cmd = new SqlCommand(sqlDelete, con_phieunhap))
                    {
                        cmd.Parameters.AddWithValue("@MaPhieuNhap", txtmapn.Text);
                        cmd.Parameters.AddWithValue("@MaMatHang", cbxMamh.SelectedValue.ToString());

                        if (con_phieunhap.State != ConnectionState.Open)
                        {
                            con_phieunhap.Open();
                        }
                        cmd.ExecuteNonQuery();
                    }
                    Hienthi(con_phieunhap);
                    MessageBox.Show("Xóa chi tiết phiếu nhập thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa chi tiết phiếu nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnsuapn_Click(object sender, EventArgs e)
        {
            pnl_luu_boqua.Visible = true;
            pncrud.Visible = false;
            btnsuapn.Enabled = false;
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            pnl_luu_boqua.Visible = false;
            pncrud.Visible = true;
            btnsuapn.Enabled = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa chi tiết hóa đơn này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string sqlUpdate = @"
                    UPDATE ChiTietPhieuNhap
                    SET SoLuong = @SoLuong, GiaNhap =@GiaNhap GhiChu = @GhiChu
                    WHERE MaPhieuNhap = @MaPhieuNhap AND MaMatHang = @MaMatHang";
                try
                {
                    using (SqlCommand cmd = new SqlCommand(sqlUpdate, con_phieunhap))
                    {
                        cmd.Parameters.AddWithValue("@MaPhieuNhap", txtmapn.Text);
                        cmd.Parameters.AddWithValue("@MaMatHang", cbxMamh.Text);

                        if (con_phieunhap.State != ConnectionState.Open)
                        {
                            con_phieunhap.Open();
                        }
                        cmd.ExecuteNonQuery();
                    }
                    Hienthi(con_phieunhap);
                    MessageBox.Show("Sửa chi tiết hóa đơn thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa chi tiết hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            pnl_luu_boqua.Visible = false;
            pncrud.Visible = true;
            btnsuapn.Enabled = true;
        }

        private void btnlook_Click(object sender, EventArgs e)
        {
            LookPhieuNhap look = new LookPhieuNhap();
            look.ShowDialog();
        }
    }
}
