using BUS;
using DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Doan1
{
    public partial class DangKy : Form
    {
        DangKyBUS dangKyBUS = new DangKyBUS();
        public DangKy()
        {
            InitializeComponent();
        }
        private void llbdangky_Click(object sender, EventArgs e)
        {
            string taiKhoan = tbtendangnhap.Text;
            string matKhau = tbmk.Text;
            string email = tbemail.Text;
            string sdt = tbsdt.Text;
            try
            {
                TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO { Taikhoan = taiKhoan, Matkhau = matKhau, Email = email, SDT = sdt };
                string ketqua = dangKyBUS.KiemTraDangKy(taiKhoanDTO);
                if (ketqua == "Đăng kí thành công")
                {
                    MessageBox.Show("Đăng ký thành công!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    DangNhap dn = new DangNhap();
                    dn.ShowDialog();
                }
                else
                {
                    MessageBox.Show(ketqua, "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "LỖI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private void xoatat_Click(object sender, EventArgs e)
        {
            tbtendangnhap.Text = string.Empty;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tbemail.Text = string.Empty;
        }

        private void xoatat2_Click(object sender, EventArgs e)
        {
            tbxnmk.Text = string.Empty;
        }

        private void ptb7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void llb2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
        }

        private void tbtendangnhap_TextChanged(object sender, EventArgs e)
        {
            if (tbtendangnhap.Text.Length < 3)
            {
                errorProvider2.SetError(tbtendangnhap, "Tên người dùng phải dài hơn 3 kí tự");
                return;
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void tbemail_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbemail.Text))
            {
                errorProvider1.SetError(tbemail, "Vui lòng nhập địa chỉ email hợp lệ");
                return;
            }
            else if (!tbemail.Text.Contains(@"@gmail.com"))
            {
                errorProvider1.SetError(tbemail, $"Vui lòng bao gồm '@gmail.com' trong địa chỉ email. '" + tbemail.Text + "' đang thiếu một '@'");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void tbsdt_TextChanged(object sender, EventArgs e)
        {
            if (tbsdt.Text.Length != 10)
            {
                errorProvider5.SetError(tbsdt, "Số điện thoại phải có 10 chữ số");
                return;
            }
            else if (tbsdt.Text[0] != '0')
            {
                errorProvider5.SetError(tbsdt, "Số điện thoại phải bắt đầu bằng số 0");
                return;
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void tbmk_TextChanged(object sender, EventArgs e)
        {
            if (!(tbmk.Text.Length >= 8 && tbmk.Text.Any(char.IsLetter) && tbmk.Text.Any(cc => !char.IsLetter(cc))))
            {
                errorProvider3.SetError(tbmk, "Mật khẩu phải dài ít nhất 8 ký tự\n" +
                "Mật khẩu phải chứa ít nhất 1 chữ cái và một ký tự không phải chữ cái");
                return;
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void tbxnmk_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxnmk.Text))
            {
                errorProvider4.SetError(tbxnmk, "Mục này không thể để trống");
                return;
            }
            else if (tbmk.Text != tbxnmk.Text)
            {
                errorProvider4.SetError(tbxnmk, "Không khớp với trường mật khẩu.");
                return;
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void cbdieukhoan_CheckedChanged(object sender, EventArgs e)
        {
            if (cbdieukhoan.Checked)
            {
                llbdangky.Enabled = true;
            }
            else
            {
                llbdangky.Enabled = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Chúng tôi cam kết bảo vệ thông tin cá nhân của bạn và đã thiết lập các biện pháp bảo mật thích hợp để ngăn chặn truy cập trái phép, mất mát dữ liệu hoặc sử dụng thông tin cá nhân một cách sai trái. Chúng tôi duy trì các hệ thống và quy trình để đảm bảo rằng thông tin cá nhân của bạn được bảo vệ.", "THÔNG BÁO!!!");

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tbsdt.Text = string.Empty;
        }
    }
}
