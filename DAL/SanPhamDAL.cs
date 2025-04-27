using DTO;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class SanPhamDAL
    {
        DatabaseHelper csdl = new DatabaseHelper();
        public string connectionString = @"Data Source=localhost,1433;Initial Catalog=da1;User ID=sa;Password=MsSQL2022@;";
        public DataTable getData()
        {
            string sql = "Select Masp, Tensp, Mancc, Gia, MoTa, SoLuong, Hinhanh from SanPham";
            return csdl.GetData(sql);
        }
        public DataTable Lay()
        {
            string sql = "Select Masp, Tensp, Mancc, Gia, MoTa, SoLuong, Hinhanh from SanPham";
            return csdl.GetData(sql);
        }

        public DataTable getData1()
        {
            string sql = "SELECT * FROM NhaCungCap";
            return csdl.GetData(sql);
        }

        public DataTable LayDanhSachMaVaTenSanPham()
        {
            string sql = "SELECT Masp, Tensp, SoLuong, Gia FROM SanPham";
            return csdl.GetData(sql);
        }

        public int LayMaSanPhamTiepTheo()
        {
            string sql = "SELECT MAX(CAST (Masp AS INT)) FROM SanPham";
            int maSanPhamHienTai = csdl.LayGiaTri(sql);
            int maSanPhamMoi = maSanPhamHienTai + 1;
            return maSanPhamMoi;
        }

        public int kiemtramatrung(string ma)
        {
            string sql = "Select count(*) from SanPham where Masp='" + ma.Trim() + "'";
            return csdl.KiemTraMaTrung(ma, sql);
        }

        public bool Themsp(SanPhamDTO sp)
        {
            int maSanPhamMoi = LayMaSanPhamTiepTheo();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"INSERT INTO SanPham (Masp, Tensp, Gia, MoTa, Mancc, SoLuong, Hinhanh) 
                   VALUES (@Masp, @Tensp, @Gia, @MoTa, @Mancc, @SoLuong, @Hinhanh)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Masp", maSanPhamMoi);
                    cmd.Parameters.AddWithValue("@Tensp", sp.Tensp);
                    cmd.Parameters.AddWithValue("@Gia", sp.Gia);
                    cmd.Parameters.AddWithValue("@MoTa", sp.Mota);
                    cmd.Parameters.AddWithValue("@Mancc", sp.Mancc);
                    cmd.Parameters.AddWithValue("@SoLuong", sp.SoLuong);
                    cmd.Parameters.AddWithValue("@Hinhanh", sp.Hinhanh);
                    cmd.ExecuteNonQuery();
                }
            }
            return true;
        }

        public bool Suasp(SanPhamDTO sp)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"UPDATE SanPham 
                       SET Tensp = @Tensp, 
                           Gia = @Gia, 
                           MoTa = @MoTa, 
                           Mancc = @Mancc, 
                           SoLuong = @SoLuong, 
                           Hinhanh = @Hinhanh 
                       WHERE Masp = @Masp";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Tensp", sp.Tensp);
                    cmd.Parameters.AddWithValue("@Gia", sp.Gia);
                    cmd.Parameters.AddWithValue("@MoTa", sp.Mota);
                    cmd.Parameters.AddWithValue("@Mancc", sp.Mancc);
                    cmd.Parameters.AddWithValue("@SoLuong", sp.SoLuong);
                    cmd.Parameters.AddWithValue("@Hinhanh", sp.Hinhanh);
                    cmd.Parameters.AddWithValue("@Masp", sp.Masp);
                    cmd.ExecuteNonQuery();
                }
            }
            return true;
        }


        public bool Xoanv(SanPhamDTO sp)
        {
            string sql = string.Format("Delete from SanPham Where Masp = '{0}'", sp.Masp);
            csdl.Chaycodesql(sql);
            return true;
        }

        public DataTable TimKiemSP(string keyword)
        {
            string sql = string.Format("Select * from SanPham Where Masp like '%{0}%' OR Tensp like '%{0}%'", keyword);
            return csdl.GetData(sql);
        }
        public bool Suasoluong(int olodo, int olodo1)
        {
            string sql1 = string.Format("UPDATE SanPham SET SoLuong =  {0} WHERE Masp = '{1}'", olodo1, olodo);
            csdl.Chaycodesql(sql1);
            return true;
        }
    }
}
