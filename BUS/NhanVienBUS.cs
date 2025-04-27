using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class NhanVienBUS
    {
        NhanvienDAL nhanvienDAL = new NhanvienDAL();
        public DataTable getData()
        {
            return nhanvienDAL.getData();
        }
        public int kiemtramatrung(string ma)
        {
            return nhanvienDAL.kiemtramatrung(ma);
        }
        public int LayMaNhanVienTiepTheo()
        {
            return nhanvienDAL.LayMaNhanVienTiepTheo();
        }
        public string Themnv(NhanVienDTO nv)
        {
            if (nhanvienDAL.Themnv(nv))
            {
                return "Đăng kí thành công";
            }
            return "Đăng kí thất bại";
        }
        public string Xoanv(string ma)
        {
            if (nhanvienDAL.Xoanv(ma))
            {
                return "Xóa nhân viên thành công";
            }
            else
            {
                return "Xóa nhân viên thất bại";
            }
        }

        public string Suanv(NhanVienDTO nv)
        {
            if (nhanvienDAL.Suanv(nv))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }
        public DataTable TimKiemNhanVien(string keyword)
        {
            return nhanvienDAL.TimKiemNhanVien(keyword);
        }
    }
}
