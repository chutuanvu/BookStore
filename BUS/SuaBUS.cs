using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class SuaBUS
    {
        SuaTaiKhoanDAL suaTaiKhoanDAL = new SuaTaiKhoanDAL();
        public DataTable getData()
        {
            return suaTaiKhoanDAL.getData();
        }
        public string DoiTaiKhoan(TaiKhoanDTO tk)
        {
            bool result = suaTaiKhoanDAL.Doi(tk);
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
