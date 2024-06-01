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
    public partial class LookPhieuNhap : Form
    {
        public LookPhieuNhap()
        {
            InitializeComponent();
        }
        SqlConnection con_timkiem;

        SqlDataAdapter adapter = new SqlDataAdapter();

        private void LookPhieuNhap_Load(object sender, EventArgs e)
        {
            btnlammoipn.Enabled = false;
            string constring = ConfigurationManager.ConnectionStrings["QLDienThoai"].ConnectionString;
            con_timkiem = new SqlConnection(constring);
            try
            {
                cbxpn.SelectedIndex = 0;
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
            string sqlSelect = "SELECT pn.MaPhieuNhap,pn.TenNhaCungCap,pn.MaNhanVien,pn.Ngay,pn.TongGiaTri,ctpn.MaMatHang,ctpn.SoLuong,ctpn.GiaNhap,ctpn.GhiChu FROM PhieuNhap pn JOIN ChiTietPhieuNhap ctpn ON pn.MaPhieuNhap = ctpn.MaPhieuNhap";
            SqlCommand cmd = new SqlCommand(sqlSelect, con_timkiem);
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dgvtkhd.DataSource = dt;
            dgvtkhd.AutoResizeColumns();
        }

        private void btnlookpn_Click(object sender, EventArgs e)
        {
                btnlammoipn.Enabled = true;
            string searchField = "";
            switch (cbxpn.SelectedItem.ToString())
            {
                case "Mã phiếu nhập":
                    searchField = "pn.MaPhieuNhap";
                    break;
                case "Tên nhà cung cấp":
                    searchField = "TenNhaCungCap";
                    break;
                case "Mã nhân viên":
                    searchField = "MaNhanVien";
                    break;
                case "Ngày":
                    searchField = "Ngay";
                    break;
                case "Tổng giá trị":
                    searchField = "TongGiaTri";
                    break;
                case "Mã mặt hàng":
                    searchField = "MaMatHang";
                    break;
                case "Số lượng":
                    searchField = "SoLuong";
                    break;
                case "Giá nhập":
                    searchField = "GiaNhap";
                    break;
                case "Ghi chú":
                    searchField = "GhiChu";
                    break;
            }
            string sqlSelect = "SELECT pn.MaPhieuNhap,pn.TenNhaCungCap,pn.MaNhanVien,pn.Ngay,pn.TongGiaTri,ctpn.MaMatHang,ctpn.SoLuong,ctpn.GiaNhap,ctpn.GhiChu FROM PhieuNhap pn JOIN ChiTietPhieuNhap ctpn ON pn.MaPhieuNhap = ctpn.MaPhieuNhap";
            string sqlSearch = sqlSelect + " WHERE " + searchField + " LIKE @value";
            SqlCommand cmd = new SqlCommand(sqlSearch, con_timkiem);
            cmd.Parameters.AddWithValue("@value", "%" + inputpn.Text + "%");
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dgvtkhd.DataSource = dt;
        }
    }
}
