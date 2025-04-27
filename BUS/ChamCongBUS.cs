using DAL;
using DTO;
using System;
using System.Data;

namespace BUS
{
    public class ChamCongBUS
    {
        readonly ChamCongDAL chamCongDAL = new ChamCongDAL();
        public DataTable GetData()
        {
            return chamCongDAL.getData();
        }
        public DataTable GetData1()
        {
            return chamCongDAL.getData1();
        }


        public string Themcc(ChamCongDTO dto)
        {
            chamCongDAL.ThemCC(dto);
            return "Thêm chấm công thành công!";
        }
        public string Xoacc(ChamCongDTO dto)
        {
            chamCongDAL.XoaCC(dto);
            return "Xóa chấm công thành công!";
        }

        public DataTable TimKiemCC(string maNhanVien, DateTime ngayChamCong)
        {
            return chamCongDAL.TimKiemNhanVien(maNhanVien, ngayChamCong);
        }
    }
}
