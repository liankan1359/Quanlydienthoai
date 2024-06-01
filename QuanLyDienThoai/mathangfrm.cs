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
    public partial class mathangfrm : Form
    {
        public mathangfrm()
        {
            InitializeComponent();
        }
        SqlConnection con_mathang;

        SqlDataAdapter adapter = new SqlDataAdapter();

        private void mathangfrm_Load(object sender, EventArgs e)
        {
            cbxmathang.SelectedIndex = 0;
            string constring = ConfigurationManager.ConnectionStrings["QLDienThoai"].ConnectionString.ToString();
            con_mathang = new SqlConnection(constring);
            con_mathang.Open();
            Hienthi();
        }

        public void Hienthi()
        {
            string sqlSelect = "select * from MatHang";
            SqlCommand cmd = new SqlCommand(sqlSelect, con_mathang);
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dgvmathang.DataSource = dt;
            dgvmathang.AutoResizeColumns();

        }
        public bool kiemTraRong()
        {
            if (txtmamh.Text.Trim() == "") return false;
            if (txttenmh.Text.Trim() == "") return false;
            if (txtdvt.Text.Trim() == "") return false;
            if (txthsx.Text.Trim() == "") return false;
            if (txtmota.Text.Trim() == "") return false;
            if (txtgiaban.Text.Trim() == "") return false;
            return true;
        }
        public void clearText()
        {
            txtmamh.Text = "";
            txttenmh.Text = "";
            txtdvt.Text = "";
            txthsx.Text = "";
            txtmota.Text = "";
            txtgiaban.Text = "";
        }
        private void btnthemmh_Click(object sender, EventArgs e)
        {
            if (!kiemTraRong())
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            string sqlCheck = "SELECT COUNT(*) FROM MatHang WHERE MaMatHang = @MaMatHang";
            SqlCommand cmdCheck = new SqlCommand(sqlCheck, con_mathang);
            cmdCheck.Parameters.AddWithValue("MaMatHang", txtmamh.Text);
            int count = (int)cmdCheck.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("Mã mặt hàng đã tồn tại!");
                return;
            }
            string sqlAdd = "INSERT INTO MatHang VALUES (@MaMatHang , @TenMatHang, @DonViTinh, @HangSanXuat, @MoTaSanPham, @GiaBan)";
            SqlCommand cmd = new SqlCommand(sqlAdd, con_mathang);
            cmd.Parameters.AddWithValue("MaMatHang", txtmamh.Text);
            cmd.Parameters.AddWithValue("TenMatHang", txttenmh.Text);
            cmd.Parameters.AddWithValue("DonViTinh", txtdvt.Text);
            cmd.Parameters.AddWithValue("HangSanXuat", txthsx.Text);
            cmd.Parameters.AddWithValue("MoTaSanPham", txtmota.Text);
            cmd.Parameters.AddWithValue("GiaBan", txtgiaban.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        

        private void btnxoamh_Click(object sender, EventArgs e)
        {
            if (txtmamh.Text.Trim() != "")
            {
                if (MessageBox.Show("Có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string sqlDELETE = "DELETE FROM MatHang where MaMatHang =@MaMatHang";
                    SqlCommand cmd = new SqlCommand(sqlDELETE, con_mathang);
                    cmd.Parameters.AddWithValue("@MaMatHang", txtmamh.Text);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        Hienthi();
                        clearText();
                        MessageBox.Show("Xóa thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa mặt hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Không thể xóa!");
            }
        }

        private void btnsuamh_Click(object sender, EventArgs e)
        {
            if (txtmamh.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn mặt hàng cần sửa");
                return;
            }
            string sqlCheck = "SELECT COUNT(*) FROM MatHang WHERE MaMatHang = @MaMatHang";
            SqlCommand cmdCheck = new SqlCommand(sqlCheck, con_mathang);
            cmdCheck.Parameters.AddWithValue("MaMatHang", txtmamh.Text);
            int count = (int)cmdCheck.ExecuteScalar();

            if (count == 0)
            {
                MessageBox.Show("Mã mặt hàng không tồn tại!");
                return;
            }
            pncrud_mathang.Visible = false;
            pnl_luu_boqua.Visible = true;
            txtmamh.Enabled = false;
            pnl_tim_kiem.Visible = false;
        }

        private void btnlammoimh_Click(object sender, EventArgs e)
        {
            Hienthi();
            btnlammoimh.Visible = false;
        }

        private void btnlookmh_Click(object sender, EventArgs e)
        {
            btnlammoimh.Visible = true;
            string searchField = "";
            switch (cbxmathang.SelectedItem.ToString())
            {
                case "Mã mặt hàng":
                    searchField = "MaMatHang";
                    break;
                case "Tên mặt hàng":
                    searchField = "TenMatHang";
                    break;
                case "Đơn vị tính":
                    searchField = "DonViTinh";
                    break;
                case "Hãng sản xuất":
                    searchField = "HangSanXuat";
                    break;
                case "Mô tả sản phẩm":
                    searchField = "MoTaSanPham";
                    break;
                case "Giá bán":
                    searchField = "GiaBan";
                    break;
            }
            string sqlSearch = "select * from MatHang where " + searchField + " LIKE @value ";
            SqlCommand cmd = new SqlCommand(sqlSearch, con_mathang);
            cmd.Parameters.AddWithValue("@value", "%" + inputmathang.Text + "%");
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dgvmathang.DataSource = dt;
        }

        private void mathangfrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            con_mathang.Close();
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            pncrud_mathang.Visible = true;
            pnl_luu_boqua.Visible = false;
            txtmamh.Enabled = true;
            pnl_tim_kiem.Visible = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (!kiemTraRong())
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            txtmamh.Enabled = true;
            string sqlEDIT = "UPDATE MatHang SET TenMatHang = @TenMatHang,DonViTinh = @DonViTinh,HangSanXuat = @HangSanXuat,MoTaSanPham =@MoTaSanPham,GiaBan =@GiaBan where MaMatHang =@MaMatHang";
            SqlCommand cmd = new SqlCommand(sqlEDIT, con_mathang);
            cmd.Parameters.AddWithValue("MaMatHang", txtmamh.Text);
            cmd.Parameters.AddWithValue("TenMatHang", txttenmh.Text);
            cmd.Parameters.AddWithValue("DonViTinh", txtdvt.Text);
            cmd.Parameters.AddWithValue("HangSanXuat", txthsx.Text);
            cmd.Parameters.AddWithValue("MoTaSanPham", txtmota.Text);
            cmd.Parameters.AddWithValue("GiaBan", txtgiaban.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
            MessageBox.Show("Đã sửa thông tin nhân viên có mã nhân viên là: " + txtmamh.Text);
        }



        private void dgvmathang_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if (e.RowIndex >= 0)
            {
                i = e.RowIndex;
                txtmamh.Text = dgvmathang.Rows[i].Cells[0].Value.ToString();
                txttenmh.Text = dgvmathang.Rows[i].Cells[1].Value.ToString();
                txtdvt.Text = dgvmathang.Rows[i].Cells[2].Value.ToString();
                txthsx.Text = dgvmathang.Rows[i].Cells[3].Value.ToString();
                txtmota.Text = dgvmathang.Rows[i].Cells[4].Value.ToString();
                txtgiaban.Text = dgvmathang.Rows[i].Cells[5].Value.ToString();
            }
        }
    }
}
