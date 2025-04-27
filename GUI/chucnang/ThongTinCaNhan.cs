using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Doan1.chucnang
{
    public partial class ThongTinCaNhan : UserControl
    {
        private TaiKhoanDTO olodo4;
        public ThongTinCaNhan(TaiKhoanDTO olodo)
        {
            InitializeComponent();
            olodo4 = olodo;
        }
        SuaBUS sua = new SuaBUS();

        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            tbtaikhoan.Text = olodo4.Taikhoan;
        }

        private void tbdoi_Click(object sender, EventArgs e)
        {
            try
            {
                string matKhau = tbmk.Text;
                string email = tbemail.Text;
                string sdt = tbsdt.Text;
                string taiKhoan = tbtaikhoan.Text;
                List<string> truongBoTrong = new List<string>();
                if (string.IsNullOrWhiteSpace(matKhau))
                {
                    truongBoTrong.Add("Mật khẩu");
                }
                if (string.IsNullOrWhiteSpace(email))
                {
                    truongBoTrong.Add("Email");
                }
                if (string.IsNullOrWhiteSpace(sdt))
                {
                    truongBoTrong.Add("Số điện thoại");
                }
                if (truongBoTrong.Count > 0)
                {
                    string thongBaoLoi = "Vui lòng nhập thông tin cho các trường sau:\n" + string.Join(", ", truongBoTrong);
                    MessageBox.Show(thongBaoLoi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO { Matkhau = matKhau, Email = email, SDT = sdt, Taikhoan = taiKhoan };
                string ketQua = sua.DoiTaiKhoan(taiKhoanDTO);

                if (ketQua == "Sửa tài khoản thành công")
                {
                    MessageBox.Show("Cập nhật thông tin thành công", "Thông Báo");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin không thành công", "Thông Báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void tbmk_TextChanged(object sender, EventArgs e)
        {
            string mk = tbmk.Text;

            if (Regex.IsMatch(mk, @"^(?=.*[a-zA-Z])(?=.*\d).{8,}$"))
            {
                errorProvider1.SetError(tbmk, "");
            }
            else
            {
                errorProvider1.SetError(tbmk, "Mật khẩu phải có ít nhất 8 ký tự và chứa ít nhất một chữ cái.");
            }
        }

        private void tbemail_TextChanged(object sender, EventArgs e)
        {
            string email = tbemail.Text;

            errorProvider2.SetError(tbemail, IsValidEmail(email) ? "" : "Địa chỉ email không hợp lệ hoặc không phải là email @gmail.com.");
        }
        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@gmail.com$");
        }

        private void tbsdt_TextChanged(object sender, EventArgs e)
        {
            string sdt = tbsdt.Text;

            if (IsValidPhoneNumber(sdt))
            {
                errorProvider3.SetError(tbsdt, "");
            }
            else
            {
                errorProvider3.SetError(tbsdt, "Số điện thoại phải có 10 số và bắt đầu bằng số 0.");
            }
        }
        private bool IsValidPhoneNumber(string sdt)
        {
            return Regex.IsMatch(sdt, @"^0\d{9}$");
        }
    }
}
