using DTO;
using System.Data;


namespace DAL
{
    public class NhaCungCapDAL
    {
        DatabaseHelper csdl = new DatabaseHelper();
        public DataTable getData()
        {
            string sql = "Select * from NhaCungCap";
            return csdl.GetData(sql);
        }
        public int LayMaNhaCungCapTiepTheo()
        {
            string sql = "SELECT MAX(CAST(ManhaCC AS INT)) FROM NhaCungCap";
            int maNhaCungCapHienTai = csdl.LayGiaTri(sql);
            int maNhaCungCapMoi = maNhaCungCapHienTai + 1;
            return maNhaCungCapMoi;
        }

        public int kiemtramatrung(string ma)
        {
            string sql = "Select count(*) from NhaCungCap where ManhaCC='" + ma.Trim() + "'";
            return csdl.KiemTraMaTrung(ma, sql);
        }
        public bool Themnhacc(NhaCungCapDTO ncc)
        {
            int maNhaCungCapMoi = LayMaNhaCungCapTiepTheo();
            string sql = string.Format("INSERT INTO NhaCungCap  VALUES ('{0}', N'{1}', N'{2}', '{3}')",
                maNhaCungCapMoi, ncc.Tennhacc, ncc.Diachi, ncc.SDT);
            csdl.Chaycodesql(sql);
            return true;
        }
        public bool Suanhacc(NhaCungCapDTO ncc)
        {
            string sql = string.Format("UPDATE NhaCungCap SET Tennhacc = N'{0}', Diachi = N'{1}', SDT = '{2}' WHERE ManhaCC = '{3}'", ncc.Tennhacc, ncc.Diachi, ncc.SDT, ncc.ManhaCC);
            csdl.Chaycodesql(sql);
            return true;
        }
        public bool Xoanhacc(string ma)
        {
            string sql = string.Format("DELETE FROM NhaCungCap WHERE ManhaCC = '{0}'", ma);
            csdl.Chaycodesql(sql);
            return true;
        }
        public DataTable TimKiem(string keyword)
        {
            string sql = string.Format("SELECT * FROM NhaCungCap WHERE ManhaCC LIKE '%{0}%' OR Tennhacc LIKE '%{0}%'", keyword);
            return csdl.GetData(sql);
        }
    }
}
