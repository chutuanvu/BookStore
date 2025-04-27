using BUS;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Doan1
{
    public partial class ThongKe : UserControl
    {
        readonly Random random = new Random();
        public ThongKe()
        {
            InitializeComponent();
        }

        private readonly ThongKeBUS BUS = new ThongKeBUS();

        private void ThongKe_Load(object sender, EventArgs e)
        {
            label1.Text = BUS.getMaxMaKhachHang().ToString();
            label2.Text = BUS.getMaxMaNhanVien().ToString();
            label3.Text = BUS.getMaxMaSanPham().ToString();
            lb.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular);

            for (int i = 1; i <= 6; i++)
            {
                string label = $"Tháng {i}";
                int doanhThu = random.Next(0, 101);
                int loiNhuan = random.Next(0, 101);
                BieuDoCot.Series["Doanh thu"].Points.AddXY(label, doanhThu);
                BieuDoCot.Series["Lợi nhuận"].Points.AddXY(label, loiNhuan);
            }
        }
    }
}