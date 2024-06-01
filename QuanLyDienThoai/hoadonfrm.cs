using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDienThoai
{
    public partial class hoadonfrm : Form
    {
        public hoadonfrm()
        {
            InitializeComponent();
        }
        SqlConnection con_hoadon;

        SqlDataAdapter adapter = new SqlDataAdapter();
        private void hoadonfrm_Load(object sender, EventArgs e)
        {
            string constring = ConfigurationManager.ConnectionStrings["QLDienThoai"].ConnectionString;
            con_hoadon = new SqlConnection(constring);
            try
            {
                con_hoadon.Open();
                Hienthi(con_hoadon);
                loadCbxMaNV(con_hoadon);
                loadCbxMamh(con_hoadon);
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

        public void Hienthi(SqlConnection con_hoadon)
        {
            string sqlSelect = "SELECT cthd.MaMatHang, cthd.SoLuong, cthd.GhiChu, mh.TenMatHang, mh.GiaBan FROM ChiTietHoaDon cthd JOIN MatHang mh ON cthd.MaMatHang = mh.MaMatHang";
            using (SqlCommand cmd = new SqlCommand(sqlSelect, con_hoadon))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvhoadon.DataSource = dt;
                    dgvhoadon.AutoResizeColumns();
                }
            }
        }

        public void loadCbxMaNV(SqlConnection con_hoadon)
        {
            string sqlSelect = "Select * from NhanVien";
            using (SqlCommand cmd = new SqlCommand(sqlSelect, con_hoadon))
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
        public void loadCbxMamh(SqlConnection con_hoadon)
        {
            string sqlSelect = "Select * from MatHang";
            using (SqlCommand cmd = new SqlCommand(sqlSelect, con_hoadon))
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
        private void dgvhoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if (e.RowIndex >= 0)
            {
                i = e.RowIndex;
                cbxMamh.Text = dgvhoadon.Rows[i].Cells[0].Value.ToString();
                txtctsl.Text = dgvhoadon.Rows[i].Cells[1].Value.ToString();
                txtctgc.Text = dgvhoadon.Rows[i].Cells[2].Value.ToString();
                txtmh.Text = dgvhoadon.Rows[i].Cells[3].Value.ToString();
                txtgb.Text = dgvhoadon.Rows[i].Cells[4].Value.ToString();

                decimal giaBan = Convert.ToDecimal(dgvhoadon.Rows[i].Cells[4].Value);
                int soLuong = Convert.ToInt32(dgvhoadon.Rows[i].Cells[1].Value);
                decimal tongTien = giaBan * soLuong;

                string maMatHang = dgvhoadon.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (con_hoadon.State != ConnectionState.Open)
                {
                    con_hoadon.Open();
                }
                string sqlSelect = @"
            SELECT hd.MaHoaDon, hd.MaNhanVien, hd.TenKhachHang, hd.Ngay, hd.TongTien
            FROM HoaDon hd
            JOIN ChiTietHoaDon cthd ON hd.MaHoaDon = cthd.MaHoaDon
            WHERE cthd.MaMatHang = @MaMatHang";

                using (SqlCommand cmd = new SqlCommand(sqlSelect, con_hoadon))
                {
                    cmd.Parameters.AddWithValue("@MaMatHang", maMatHang);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtttmahd.Text = reader["MaHoaDon"].ToString();
                            cbxMaNV.Text = reader["MaNhanVien"].ToString();
                            txttenkh.Text = reader["TenKhachHang"].ToString();
                            dtpttngay.Value = Convert.ToDateTime(reader["Ngay"]);
                            txttttongtien.Text = reader["TongTien"].ToString();
                        }
                    }
                }
                txttttongtien.Text = tongTien.ToString();
                decimal tongTienTatCaHang = 0;
                for (int j = 0; j < dgvhoadon.Rows.Count; j++)
                {
                    decimal giaBanHang = Convert.ToDecimal(dgvhoadon.Rows[j].Cells[4].Value);
                    int soLuongHang = Convert.ToInt32(dgvhoadon.Rows[j].Cells[1].Value);
                    tongTienTatCaHang += giaBanHang * soLuongHang;
                }
                txtThanhtien.Text = tongTienTatCaHang.ToString();
            }
        }

        private void btnthemhd_Click(object sender, EventArgs e)
        {
            string sqlInsert = @"
            INSERT INTO ChiTietHoaDon (MaHoaDon, MaMatHang, SoLuong, GhiChu)
            VALUES (@MaHoaDon, @MaMatHang, @SoLuong, @GhiChu)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(sqlInsert, con_hoadon))
                {
                    cmd.Parameters.AddWithValue("@MaHoaDon", txtttmahd.Text);
                    cmd.Parameters.AddWithValue("@MaMatHang", cbxMamh.Text);
                    cmd.Parameters.AddWithValue("@SoLuong", int.Parse(txtctsl.Text));
                    cmd.Parameters.AddWithValue("@GhiChu", txtctgc.Text);

                    if (con_hoadon.State != ConnectionState.Open)
                    {
                        con_hoadon.Open();
                    }
                    cmd.ExecuteNonQuery();
                }
                Hienthi(con_hoadon);
                MessageBox.Show("Thêm chi tiết hóa đơn thành công!", "Thông Báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm chi tiết hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoahd_Click(object sender, EventArgs e)
        {
            if (txtttmahd.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn trước khi xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết hóa đơn này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string sqlDelete = @"
            DELETE FROM ChiTietHoaDon
            WHERE MaHoaDon = @MaHoaDon AND MaMatHang = @MaMatHang";
                try
                {
                    using (SqlCommand cmd = new SqlCommand(sqlDelete, con_hoadon))
                    {
                        cmd.Parameters.AddWithValue("@MaHoaDon", txtttmahd.Text);
                        cmd.Parameters.AddWithValue("@MaMatHang", cbxMamh.SelectedValue);

                        if (con_hoadon.State != ConnectionState.Open)
                        {
                            con_hoadon.Open();
                        }
                        cmd.ExecuteNonQuery();
                    }
                    Hienthi(con_hoadon);
                    MessageBox.Show("Xóa chi tiết hóa đơn thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa chi tiết hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnsuahd_Click(object sender, EventArgs e)
        {
            pnl_luu_boqua.Visible = true;
            pncrud_hoadon.Visible = false;
            btnsuahd.Enabled = false;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa chi tiết hóa đơn này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string sqlUpdate = @"
                    UPDATE ChiTietHoaDon
                    SET SoLuong = @SoLuong, GhiChu = @GhiChu
                    WHERE MaHoaDon = @MaHoaDon AND MaMatHang = @MaMatHang";
                try
                {
                    using (SqlCommand cmd = new SqlCommand(sqlUpdate, con_hoadon))
                    {
                        cmd.Parameters.AddWithValue("@MaHoaDon", txtttmahd.Text);
                        cmd.Parameters.AddWithValue("@MaMatHang", cbxMamh.Text);

                        if (con_hoadon.State != ConnectionState.Open)
                        {
                            con_hoadon.Open();
                        }
                        cmd.ExecuteNonQuery();
                    }
                    Hienthi(con_hoadon);
                    MessageBox.Show("Sửa chi tiết hóa đơn thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa chi tiết hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            pnl_luu_boqua.Visible = false;
            pncrud_hoadon.Visible = true;
            btnsuahd.Enabled = true;
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            pnl_luu_boqua.Visible = false;
            pncrud_hoadon.Visible = true;
            btnsuahd.Enabled = true;
        }

        private void btnlook_Click(object sender, EventArgs e)
        {
            LookHoaDon lookHoaDon = new LookHoaDon();
            lookHoaDon.ShowDialog();
        }

        
    }
}
