using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class QuenMatKhauBUS
    {
        QuenMatKhauDAL quenMatKhauDAL = new QuenMatKhauDAL();
        public DataTable getData()
        {
            return quenMatKhauDAL.getData();
        }
        public bool KiemTraTonTai(string tenDangNhap, string email)
        {
            return quenMatKhauDAL.KiemTraTonTai(tenDangNhap, email);
        }
        public string KiemTraTaiKhoan(TaiKhoanDTO taiKhoan)
        {
            if (KiemTraTonTai(taiKhoan.Taikhoan, taiKhoan.Email))
            {
                return "Xác thực thành công";
            }
            else
            {
                return "Tài khoản không tồn tại hoặc thông tin không chính xác";
            }
        }
        public string SuaTaiKhoan(TaiKhoanDTO tk)
        {
            bool result = quenMatKhauDAL.Sua(tk);
            if (result)
            {
                return "Sửa tài khoản thành công";
            }
            else
            {
                return "Sửa tài khoản không thành công";
            }
        }
    }
}
