using DTO;
using System.Data;

namespace DAL
{
    public class SuaTaiKhoanDAL
    {
        private DatabaseHelper csdl = new DatabaseHelper();
        public DataTable getData()
        {
            string sql = "SELECT * FROM TaiKhoan";
            return csdl.GetData(sql);
        }
        public bool Doi(TaiKhoanDTO tk)
        {
            string query = string.Format("UPDATE TaiKhoan SET MatKhau = '{0}', Email = N'{1}', SDT = '{2}' WHERE TaiKhoan = '{3}'", tk.Matkhau, tk.Email, tk.SDT, tk.Taikhoan);
            csdl.Chaycodesql(query);
            return true;
        }
    }

}
