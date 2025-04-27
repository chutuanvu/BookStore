using Doan1.chucnang;
using DTO;
using System;
using System.Windows.Forms;

namespace Doan1
{
    public partial class Menu : Form
    {
        private TaiKhoanDTO taiKhoanDTO;
        NhaCungCap nhaCungCap = new NhaCungCap();
        public Menu(TaiKhoanDTO taiKhoanDTO1)
        {
            InitializeComponent();
            taiKhoanDTO = taiKhoanDTO1;
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.btnThongtin, "Click or Nhấn  Ctrl + T để Quản Lý Tài Khoản");
            toolTip1.SetToolTip(this.btnNhanvien, "Click or Nhấn Ctrl + N để Quản Lý Nhân Viên");
            toolTip1.SetToolTip(this.guna2Button2, "Click or Nhấn Ctrl + S để Quản Lý Khách Hàng");
            toolTip1.SetToolTip(this.guna2Button9, "Click or Nhấn CTRL+ D để Quản Lý Sản Phẩm");
            toolTip1.SetToolTip(this.btnNhacungcap, "Click or Nhấn CTRL + E để Quản Lý Nhà Cung Cấp");
            toolTip1.SetToolTip(this.btnMua, "Click or Nhấn Ctrl + F để Mua");
            toolTip1.SetToolTip(this.btnThongke, "Click or Nhấn Ctrl + G để Thống Kê-Báo Cáo");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString("ddd, dd/MM/yyyy HH:mm:ss");
        }

        private void ptb2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void thunho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            VeUngDungNay dg = new VeUngDungNay();
            dg.ShowDialog();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            labeltieude.Text = "Nhân Viên";
            NhanVien nv = new NhanVien();
            if (panelmenu.Controls.Count == 0)
            {
                panelmenu.Controls.Add(nv);
            }
            else
            {
                panelmenu.Controls.Clear();

            }
            pictureBox4.Visible = false;
        }

        private void btnThongtin_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan thongtin = new ThongTinCaNhan(taiKhoanDTO);
            if (panelmenu.Controls.Count == 0)
            {
                panelmenu.Controls.Add(thongtin);
            }
            else
            {
                panelmenu.Controls.Clear();
            }
            labeltieude.Text = "Thông tin cá nhân";
            pictureBox4.Visible = false;

        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            ThongKe nv = new ThongKe();
            if (panelmenu.Controls.Count == 0)
            {
                panelmenu.Controls.Add(nv);
            }
            else
            {
                panelmenu.Controls.Clear();
            }
            labeltieude.Text = "Thống Kê-Báo Cáo";
            pictureBox4.Visible = false;

        }

        private void guna2Button9_Click_1(object sender, EventArgs e)
        {
            labeltieude.Text = "Sản Phẩm";
            SanPham sp = new SanPham();
            if (panelmenu.Controls.Count == 0)
            {
                panelmenu.Controls.Add(sp);
            }
            else
            {
                panelmenu.Controls.Clear();
            }
            pictureBox4.Visible = false;
        }

        private void btnNhacungcap_Click_1(object sender, EventArgs e)
        {
            labeltieude.Text = "Nhà Cung Cấp";
            if (panelmenu.Controls.Count == 0)
            {
                panelmenu.Controls.Add(nhaCungCap);
            }
            else
            {
                panelmenu.Controls.Clear();
            }
            pictureBox4.Visible = false;

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            labeltieude.Text = "Khách Hàng";
            KhachHang sp = new KhachHang();
            if (panelmenu.Controls.Count == 0)
            {
                panelmenu.Controls.Add(sp);
            }
            else
            {
                panelmenu.Controls.Clear();
            }
        }

        private void btnMua_Click(object sender, EventArgs e)
        {
            labeltieude.Text = "MUA HÀNG";

            Mua sp = new Mua();
            if (panelmenu.Controls.Count == 0)
            {
                panelmenu.Controls.Add(sp);
            }
            else
            {
                panelmenu.Controls.Clear();
            }
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.T:
                        btnThongtin.PerformClick();
                        break;
                    case Keys.N:
                        btnNhanvien.PerformClick();
                        break;
                    case Keys.S:
                        guna2Button2.PerformClick();
                        break;
                    case Keys.D:
                        guna2Button9.PerformClick();
                        break;
                    case Keys.E:
                        btnNhacungcap.PerformClick();
                        break;
                    case Keys.F:
                        btnMua.PerformClick();
                        break;
                    case Keys.G:
                        btnThongke.PerformClick();
                        break;
                }
            }
        }
    }
}
