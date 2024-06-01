using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDienThoai
{
    public partial class nhanvienfrm : Form
    {
        public nhanvienfrm()
        {
            InitializeComponent();
        }
        SqlConnection con_nhanvien;

        SqlDataAdapter adapter = new SqlDataAdapter();
        private void nhanvienfrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanHangDataSet1.NhanVien' table. You can move, or remove it, as needed.
            cbxnhanvien.SelectedIndex = 0;
            cbxgioitinh.SelectedIndex = 0;
            string constring = ConfigurationManager.ConnectionStrings["QLDienThoai"].ConnectionString.ToString();
            con_nhanvien = new SqlConnection(constring);
            con_nhanvien.Open();
            Hienthi();
        }
        public bool kiemTraRong()
        {
            if (txtmanv.Text.Trim() == "") return false;
            if (txttennv.Text.Trim() == "") return false;
            if (dtpns.Text.Trim() == "") return false;
            if (cbxgioitinh.Text.Trim() == "") return false;
            if (txtdcnv.Text.Trim() == "") return false;
            if (txtsdtnv.Text.Trim() == "") return false;
            if (txtemail.Text.Trim() == "") return false;
            return true;
        }
        public void clearText()
        {
            txtmanv.Text = "";
            txttennv.Text = "";
            dtpns.Text = "";
            cbxgioitinh.Text = "";
            txtdcnv.Text = "";
            txtsdtnv.Text = "";
            txtemail.Text = "";
        }
        public void Hienthi()
        {
            string sqlSelect = "select * from NhanVien";
            SqlCommand cmd = new SqlCommand(sqlSelect, con_nhanvien);
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dgvnhanvien.DataSource = dt;
            dgvnhanvien.AutoResizeColumns();
        }
        
        private void btnthemnv_Click(object sender, EventArgs e)
        {
            if (!kiemTraRong())
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            string sqlCheck = "SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien = @MaNhanVien";
            SqlCommand cmdCheck = new SqlCommand(sqlCheck, con_nhanvien);
            cmdCheck.Parameters.AddWithValue("MaNhanVien", txtmanv.Text);
            int count = (int)cmdCheck.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }
            string sqlAdd = "INSERT INTO NhanVien VALUES (@MaNhanVien , @TenNhanVien,@NgaySinhNhanVien, @GioiTinh, @DiaChi, @SoDienThoai, @Email)";
            SqlCommand cmd = new SqlCommand(sqlAdd, con_nhanvien);
            cmd.Parameters.AddWithValue("MaNhanVien", txtmanv.Text);
            cmd.Parameters.AddWithValue("TenNhanVien", txttennv.Text);
            cmd.Parameters.AddWithValue("NgaySinhNhanVien", dtpns.Text);
            cmd.Parameters.AddWithValue("GioiTinh", cbxgioitinh.Text);
            cmd.Parameters.AddWithValue("DiaChi", txtdcnv.Text);
            cmd.Parameters.AddWithValue("SoDienThoai", txtsdtnv.Text);
            cmd.Parameters.AddWithValue("Email", txtemail.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btnxoanv_Click(object sender, EventArgs e)
        {
            if(txtmanv.Text.Trim() != "")
            {
                if(MessageBox.Show("Có chắc chắn xóa không?","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string sqlDELETE = "DELETE FROM NhanVien where MaNhanVien =@MaNhanVien";
                    SqlCommand cmd = new SqlCommand(sqlDELETE, con_nhanvien);
                    cmd.Parameters.AddWithValue("@MaNhanVien", txtmanv.Text);
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

        private void btnsuanv_Click(object sender, EventArgs e)
        {
            if(txtmanv.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn nhân viên cần sửa");
                return;
            }
            // doan code can them chuc nang check xem ma nhan vien co ton tai khong
            string sqlCheck = "SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien = @MaNhanVien";
            SqlCommand cmdCheck = new SqlCommand(sqlCheck, con_nhanvien);
            cmdCheck.Parameters.AddWithValue("MaNhanVien", txtmanv.Text);
            int count = (int)cmdCheck.ExecuteScalar();

            if (count == 0)
            {
                MessageBox.Show("Mã nhân viên không tồn tại!");
                return;
            }
            pnltimkiem.Visible = false;
            pnl_boqua.Visible = true;
            pnl_crud.Visible = false;
            txtmanv.Enabled = false;
            btnsuanv.Enabled = false;
        }

        private void btnlammoinv_Click(object sender, EventArgs e)
        {
            Hienthi();
            btnlammoinv.Visible = false;
        }

        

        private void dgvnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int i;
            if (e.RowIndex >= 0)
            {
                i = e.RowIndex;
                txtmanv.Text = dgvnhanvien.Rows[i].Cells[0].Value.ToString();
                txttennv.Text = dgvnhanvien.Rows[i].Cells[1].Value.ToString();
                dtpns.Text = dgvnhanvien.Rows[i].Cells[2].Value.ToString();
                cbxgioitinh.Text = dgvnhanvien.Rows[i].Cells[3].Value.ToString();
                txtdcnv.Text = dgvnhanvien.Rows[i].Cells[4].Value.ToString();
                txtsdtnv.Text = dgvnhanvien.Rows[i].Cells[5].Value.ToString();
                txtemail.Text = dgvnhanvien.Rows[i].Cells[6].Value.ToString();
                
            }
        }

        private void nhanvienfrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            con_nhanvien.Close();
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            pnltimkiem.Visible = true;
            pnl_boqua.Visible = false;
            pnl_crud.Visible = true;
            txtmanv.Enabled = true;
            btnsuanv.Enabled = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (!kiemTraRong())
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            string sqlEDIT = "UPDATE NhanVien SET TenNhanVien = @TenNhanVien,NgaySinhNhanVien = @NgaySinhNhanVien,GioiTinh =@GioiTinh,DiaChi = @DiaChi,SoDienThoai = @SoDienThoai,Email =@Email where MaNhanVien =@MaNhanVien";
            SqlCommand cmd = new SqlCommand(sqlEDIT, con_nhanvien);
            cmd.Parameters.AddWithValue("MaNhanVien", txtmanv.Text);
            cmd.Parameters.AddWithValue("TenNhanVien", txttennv.Text);
            cmd.Parameters.AddWithValue("NgaySinhNhanVien", dtpns.Text);
            cmd.Parameters.AddWithValue("GioiTinh", cbxgioitinh.Text);
            cmd.Parameters.AddWithValue("DiaChi", txtdcnv.Text);
            cmd.Parameters.AddWithValue("SoDienThoai", txtsdtnv.Text);
            cmd.Parameters.AddWithValue("Email", txtemail.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
            btnsuanv.Enabled = false;
            MessageBox.Show("Đã sửa thông tin nhân viên có mã nhân viên là: "+txtmanv.Text);

        }

        private void btnlooknv_Click(object sender, EventArgs e)
        {
            btnlammoinv.Visible = true;
            string searchField = "";
            switch (cbxnhanvien.SelectedItem.ToString())
            {
                case "Mã nhân viên":
                    searchField = "MaNhanVien";
                    break;
                case "Tên nhân viên":
                    searchField = "TenNhanVien";
                    break;
                case "Ngày sinh":
                    searchField = "NgaySinhNhanVien";
                    break;
                case "Giới tính":
                    searchField = "GioiTinh";
                    break;
                case "Địa chỉ":
                    searchField = "DiaChi";
                    break;
                case "Số điện thoại":
                    searchField = "SoDienThoai";
                    break;
                case "Email":
                    searchField = "Email";
                    break;
            }
            string sqlSearch = "select * from NhanVien where " + searchField + " LIKE @value ";
            SqlCommand cmd = new SqlCommand(sqlSearch, con_nhanvien);
            cmd.Parameters.AddWithValue("@value", "%" + inputnhanvien.Text + "%");
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dgvnhanvien.DataSource = dt;
        }
    }
}
