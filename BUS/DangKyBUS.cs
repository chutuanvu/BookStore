using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class DangKyBUS
    {
        DangKyDAL dangKyDAL = new DangKyDAL();
        public DataTable getData()
        {
            return dangKyDAL.getData();
        }

        public int kiemtramatrung(string ma)
        {
            return dangKyDAL.Check(ma);
        }

        public string KiemTraDangKy(TaiKhoanDTO taiKhoan)
        {
            if (string.IsNullOrEmpty(taiKhoan.Taikhoan))
            {
                return "Tài khoản không được để trống!";
            }

            if (string.IsNullOrEmpty(taiKhoan.Matkhau))
            {
                return "Mật khẩu không được để trống!";
            }

            if (string.IsNullOrEmpty(taiKhoan.Email))
            {
                return "Email không được để trống!";
            }

            if (string.IsNullOrEmpty(taiKhoan.SDT))
            {
                return "Số điện thoại không được để trống!";
            }

            if (kiemtramatrung(taiKhoan.Taikhoan) > 0)
            {
                return "Tài khoản đã tồn tại!";
            }

            if (dangKyDAL.Them(taiKhoan))
            {
                return "Đăng kí thành công";
            }
            return "Đăng kí thất bại";
        }
    }
}