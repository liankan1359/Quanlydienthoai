using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDienThoai
{
    public partial class frmmain : Form
    {
        public Button currentActiveButton = null;
        public frmmain()
        {
            InitializeComponent();
        }

        public void ActiveButton(object senderBtn)
        {
            if(senderBtn != null)
            {
                Button btnClick = (Button)senderBtn;
                if (currentActiveButton != null)
                {
                    DisableButton(currentActiveButton);
                }
                currentActiveButton = btnClick;
                btnClick.BackColor = Color.FromArgb(208, 78, 214); //132, 112, 255 37, 36, 81
            }
        }
        public void DisableButton(Button btn)
        {
                btn.BackColor = Color.FromArgb(132, 112, 255);
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
      

        private void btnohieunhap_Click(object sender, EventArgs e)
        {
            pcBheader.Image = Properties.Resources.pn_96px;
            ActiveButton(sender);
            loadform(new phieunhapfrm());
        }

        

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            pcBheader.Image = Properties.Resources.tthd_96px;
            ActiveButton(sender);
            loadform(new hoadonfrm());
        }

        private void btnmathang_Click(object sender, EventArgs e)
        {
            pcBheader.Image = Properties.Resources.ad_product_96px;
            ActiveButton(sender);
            loadform(new mathangfrm());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            pcBheader.Image = Properties.Resources.people_96px;
            ActiveButton(sender);
            loadform(new nhanvienfrm());
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            pcBheader.Image = Properties.Resources.ad_product_96px;
            loadform(new mathangfrm());
        }
    }

}
