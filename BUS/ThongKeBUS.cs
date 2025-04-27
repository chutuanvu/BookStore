using DAL;
using System;
using System.Data;


namespace BUS
{
    public class ThongKeBUS
    {
        private ThongKeDAL thongKeDAL = new ThongKeDAL();
        public int getMaxMaKhachHang()
        {
            return thongKeDAL.KhachHang();
        }

        public int getMaxMaNhanVien()
        {
            return thongKeDAL.NhanVien();
        }

        public int getMaxMaSanPham()
        {
            return thongKeDAL.SanPham();
        }
        public object GetTongDoanhThu(DateTime startDate, DateTime endDate)
        {
            return thongKeDAL.GetTongDoanhThu(startDate, endDate);
        }
        public DataTable GetTopSanPhamBanChay(DateTime startDate, DateTime endDate)
        {
            return thongKeDAL.GetTopSanPhamBanChay(startDate, endDate);
        }
    }
}
