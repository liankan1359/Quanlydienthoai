using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDienThoai
{
    public partial class LookHoaDon : Form
    {
        public LookHoaDon()
        {
            InitializeComponent();
        }
        SqlConnection con_timkiem;

        SqlDataAdapter adapter = new SqlDataAdapter();
        private void LookHoaDon_Load(object sender, EventArgs e)
        {
            btnlammoihd.Enabled = false;
            string constring = ConfigurationManager.ConnectionStrings["QLDienThoai"].ConnectionString;
            con_timkiem = new SqlConnection(constring);
            try
            {
                cbxhoadon.SelectedIndex = 0;
                con_timkiem.Open();
                Hienthi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        public void Hienthi()
        {
            string sqlSelect = "SELECT hd.MaHoaDon,hd.MaNhanVien,hd.TenKhachHang,hd.Ngay,hd.TongTien,cthd.MaMatHang,cthd.SoLuong,cthd.GhiChu FROM HoaDon hd JOIN ChiTietHoaDon cthd ON hd.MaHoaDon = cthd.MaHoaDon;";
            SqlCommand cmd = new SqlCommand(sqlSelect, con_timkiem);
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dgvtkhd.DataSource = dt;
            dgvtkhd.AutoResizeColumns();
        }

        private void btnlookhd_Click(object sender, EventArgs e)
        {
            btnlammoihd.Enabled = true;
            string searchField = "";
            switch (cbxhoadon.SelectedItem.ToString())
            {
                case "Mã hóa đơn":
                    searchField = "hd.MaHoaDon";
                    break;
                case "Mã nhân viên":
                    searchField = "MaNhanVien";
                    break;
                case "Tên khách hàng":
                    searchField = "TenKhachHang";
                    break;
                case "Ngày":
                    searchField = "Ngay";
                    break;
                case "Tổng tiền":
                    searchField = "TongTien";
                    break;
                case "Mã mặt hàng":
                    searchField = "MaMatHang";
                    break;
                case "Số lượng":
                    searchField = "SoLuong";
                    break;
                case "Ghi chú":
                    searchField = "GhiChu";
                    break;
            }
            string sqlSelect = "SELECT hd.MaHoaDon, hd.MaNhanVien, hd.TenKhachHang, hd.Ngay, hd.TongTien, cthd.MaMatHang, cthd.SoLuong, cthd.GhiChu FROM HoaDon hd JOIN ChiTietHoaDon cthd ON hd.MaHoaDon = cthd.MaHoaDon";
            string sqlSearch = sqlSelect + " WHERE " + searchField + " LIKE @value";
            SqlCommand cmd = new SqlCommand(sqlSearch, con_timkiem);
            cmd.Parameters.AddWithValue("@value", "%" + inputnhanvien.Text + "%");
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dgvtkhd.DataSource = dt;
        }
    }
}
