using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class SanPhamBUS
    {
        SanPhamDAL sanPhamDAL = new SanPhamDAL();
        public DataTable getData()
        {
            return sanPhamDAL.getData();
        }

        public DataTable Lay()
        {
            return sanPhamDAL.Lay();
        }
        public DataTable getData1()
        {
            return sanPhamDAL.getData1();
        }

        public DataTable Laydulieu()
        {
            return sanPhamDAL.LayDanhSachMaVaTenSanPham();
        }

        public int kiemtramatrung(string ma)
        {
            return sanPhamDAL.kiemtramatrung(ma);
        }
        public string Themsp(SanPhamDTO them)
        {
            if (sanPhamDAL.Themsp(them))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }
        public string Suasp(SanPhamDTO sua)
        {
            if (sanPhamDAL.Suasp(sua))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }

        public string Xoasp(SanPhamDTO xoa)
        {
            if (sanPhamDAL.Xoanv(xoa))
            {
                return "Xóa thành công";
            }
            return "Xóa thất bại";
        }
        public DataTable Timsp(string keyword)
        {
            return sanPhamDAL.TimKiemSP(keyword);
        }
        public string Suasoluong(int olodo, int olodo2)
        {
            if (sanPhamDAL.Suasoluong(olodo, olodo2))
            {
                return "Nhập kho thành công";
            }
            return "Nhập kho thất bại";
        }
    }
}
