using BUS;
using DTO;
using System;
using System.Windows.Forms;
namespace Doan1
{
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        QuenMatKhauBUS quenMatKhauBUS = new QuenMatKhauBUS();
        TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO();

        private void btkt_Click(object sender, EventArgs e)
        {
            string taiKhoan = tbtendangnhap.Text;
            string emai = tbemailorsdt.Text;
            string mk = tbmk.Text;
            try
            {
                {
                    taiKhoanDTO.Taikhoan = taiKhoan;
                    taiKhoanDTO.Email = emai;
                    taiKhoanDTO.Matkhau = mk;
                }
                ;

                string kq = quenMatKhauBUS.KiemTraTaiKhoan(taiKhoanDTO);
                if (kq == "Xác thực thành công")
                {
                    MessageBox.Show("Xác thực thông tin thành công.", "Thông Báo");
                    btdoimk.Visible = true;
                    lbmk.Visible = true;
                    pbmk.Visible = true;
                    tbmk.Visible = true;
                    lbxnmk.Visible = true;
                    pbxnmk.Visible = true;
                    tbxnmk.Visible = true;
                    ptb2.Visible = true;
                    ptb3.Visible = true;
                    Phide.Visible = true;
                    pshow.Visible = true;
                    tbemailorsdt.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Thông tin không hợp lệ !", "Thông Báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btdoimk_Click(object sender, EventArgs e)
        {
            try
            {
                string matKhauMoi = tbmk.Text;
                string xacNhanMatKhau = tbxnmk.Text;
                string taiKhoan = tbtendangnhap.Text;
                TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO { Matkhau = matKhauMoi, Taikhoan = taiKhoan };
                string ketQua = quenMatKhauBUS.SuaTaiKhoan(taiKhoanDTO);
                if (string.IsNullOrWhiteSpace(matKhauMoi) || string.IsNullOrWhiteSpace(xacNhanMatKhau))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin mật khẩu mới và xác nhận mật khẩu.", "Thông Báo");
                    return;
                }
                if (ketQua == "Sửa tài khoản thành công")
                {
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông Báo");
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu không thành công", "Thông Báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dk = new DangNhap();
            dk.ShowDialog();
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
        private void QuenMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void tbtendangnhap_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbtendangnhap.Text))
            {
                errorProvider1.SetError(tbtendangnhap, "Bạn nhập thiếu mục đổi mật khẩu");


            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void tbemailorsdt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbemailorsdt.Text))
            {

                errorProvider2.SetError(tbemailorsdt, "bạn nhập thiếu phần nhận Email!");

            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void tbmk_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbmk.Text))
            {

                errorProvider3.SetError(tbmk, "bạn nhập thiếu phần Mật khẩu!");

            }
            if (tbmk.Text.Length < 8)
            {
                errorProvider3.SetError(tbmk, "Mật khẩu phải có nhất 8 ký tự!!!");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void tbxnmk_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxnmk.Text))
            {

                errorProvider4.SetError(tbxnmk, "bạn nhập thiếu phần nhận xác nhận mật khẩu !");

            }
            if (tbmk.Text != tbxnmk.Text)
            {
                errorProvider4.SetError(tbxnmk, "Mật khẩu không khớp ");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void xoatat_Click(object sender, EventArgs e)
        {
            tbtendangnhap.Text = string.Empty;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tbemailorsdt.Text = string.Empty;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tbmk.Text = string.Empty;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            tbxnmk.Text = string.Empty;
        }

        private void pshow_Click(object sender, EventArgs e)
        {
            if (tbmk.PasswordChar == '\0')
            {
                Phide.BringToFront();
                tbmk.PasswordChar = '*';
            }
        }

        private void Phide_Click(object sender, EventArgs e)
        {
            if (tbmk.PasswordChar == '*')
            {
                pshow.BringToFront();
                tbmk.PasswordChar = '\0';
            }
        }

    }
}
