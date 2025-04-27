using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class LuongBUS
    {
        LuongDAL luongDAL = new LuongDAL();
        public DataTable getData()
        {
            return luongDAL.getData();
        }
        public DataTable getData1()
        {
            return luongDAL.getData1();
        }
        public string Themnv(NhanVienDTO nv)
        {
            if (luongDAL.ThemLuong(nv))
            {
                return "1";
            }
            return "2";
        }
        public string XoaLuong(NhanVienDTO nv)
        {
            if (luongDAL.XoaLuong(nv))
            {
                return "1";
            }
            else
            {
                return "2";
            }
        }
        public string SuaLuong(NhanVienDTO nv)
        {
            if (luongDAL.SuaLuong(nv))
            {
                return "1";
            }
            else
            {
                return "2";
            }
        }
        public DataTable TimKiemLuong(string keyword)
        {
            return luongDAL.TimKiemLuong(keyword);
        }
    }
}
