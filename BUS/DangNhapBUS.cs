using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_DangNhap
    {
        DangNhapDAL dangNhapDAL = new DangNhapDAL();
        public DataTable getData(string sql)
        {
            return dangNhapDAL.GetData(sql);
        }
        //public int kiemtramatrung(string ma)
        //{
        //    return dangNhapDAL.Check(ma);
        //}

        public string KiemTraDangNhap(TaiKhoanDTO taiKhoan)
        {
            if (string.IsNullOrEmpty(taiKhoan.Taikhoan) || string.IsNullOrEmpty(taiKhoan.Matkhau))
            {
                return "Tên đăng nhập và mật khẩu không được để trống.";
            }
            else
            {
                bool isAuthenticated = dangNhapDAL.KiemTraDangNhap(taiKhoan);
                if (!isAuthenticated)
                {
                    return "Thông tin đăng nhập không chính xác!";
                }
                return "Đăng nhập thành công.";
            }
        }
    }
}