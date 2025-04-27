using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace Doan1
{
    public partial class DangNhap : Form
    {
        readonly BUS_DangNhap bUS_DangNhap = new BUS_DangNhap();
        TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO();
        public static string TenDangNhapGlobal;
        public DangNhap()
        {
            InitializeComponent();
        }

        public void DangNhap_Load(object sender, EventArgs e)
        {
            this.btdangnhap.KeyDown += new KeyEventHandler(this.DangNhap_KeyDown);
            toolTip1.SetToolTip(this.btdangnhap, "Click or Nhấn Enter để đăng nhập");
            toolTip1.SetToolTip(this.linkLabel1, "Click or Nhấn Ctrl + N để đăng ký");
            toolTip1.SetToolTip(this.llb1, "Click or Nhấn Ctrl + Q để quên mật khẩu");
            toolTip1.SetToolTip(this.ptb2, "Click or Nhấn Alt+ f4 để tắt phần mềm");
        }

        public void Btdangnhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = tbtendangnhap.Text;
            string matKhau = tbmk.Text;
            taiKhoanDTO = new TaiKhoanDTO { Taikhoan = taiKhoan, Matkhau = matKhau };
            string ketQua = bUS_DangNhap.KiemTraDangNhap(taiKhoanDTO);
            if (ketQua == "Đăng nhập thành công.")
            {
                taiKhoanDTO.Taikhoan = tbtendangnhap.Text;
                this.Hide();
                TenDangNhapGlobal = tbtendangnhap.Text;
                LoadDangNhap menu = new LoadDangNhap(taiKhoanDTO);
                menu.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show(ketQua, "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Phide_Click(object sender, EventArgs e)
        {
            if (tbmk.PasswordChar == '*')
            {
                pshow.BringToFront();
                tbmk.PasswordChar = '\0';
            }
        }

        private void Pshow_Click(object sender, EventArgs e)
        {
            if (tbmk.PasswordChar == '\0')
            {
                Phide.BringToFront();
                tbmk.PasswordChar = '*';
            }
        }

        private void Ptb2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Thunho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Xoatat_Click(object sender, EventArgs e)
        {
            tbtendangnhap.Text = string.Empty;
        }

        private void Xoatat2_Click(object sender, EventArgs e)
        {
            tbmk.Text = string.Empty;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DangKy dk = new DangKy();
            dk.ShowDialog();
        }

        private void Llb1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            QuenMatKhau qmk = new QuenMatKhau();
            qmk.ShowDialog();
        }

        private void DangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btdangnhap_Click(sender, e);
                e.Handled = true;
            }
            if (e.Control && e.KeyCode == Keys.N)
            {
                LinkLabel1_LinkClicked(this, null);
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.Q)
            {
                Llb1_LinkClicked(this, null);
                e.Handled = true;
            }
        }
    }
}
