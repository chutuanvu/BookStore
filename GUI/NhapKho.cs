using BUS;
using ClosedXML.Excel;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Doan1
{
    public partial class NhapKho : Form
    {
        SanPhamBUS sanPhamBUS = new SanPhamBUS();
        private int soluonghientai = 0;
        private string tensp;
        public NhapKho()
        {
            InitializeComponent();
        }
        void loaddgv()
        {
            dgvSanpham.DataSource = sanPhamBUS.getData();
            dgvSanpham.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10);
        }
        private void NhapKho_Load(object sender, EventArgs e)
        {
            loaddgv();
        }

        private void dgvSanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSanpham.Rows.Count)
            {
                int i = e.RowIndex;
                tbMa.Text = dgvSanpham[0, i].Value.ToString();
                //tbSoluomg.Text = dgvSanpham[6, i].Value.ToString();
                soluonghientai = Convert.ToInt32(dgvSanpham[5, i].Value.ToString());
                tensp = dgvSanpham[2, i].Value.ToString();
            }
        }

        private void btNhap_Click(object sender, EventArgs e)
        {
            int olodo3 = Convert.ToInt32(soluonghientai + Convert.ToInt32(tbSoluomg.Text));
            string result = this.sanPhamBUS.Suasoluong(Convert.ToInt32(tbMa.Text), olodo3);
            if (string.IsNullOrWhiteSpace(tbSoluomg.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (result == "Nhập kho thành công")
            {
                MessageBox.Show("Sửa thông tin Sản Phẩn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvSanpham.DataSource = sanPhamBUS.getData();
                loaddgv();
            }
            else
            {
                MessageBox.Show("Sửa thông tin Sản Phẩm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SanPham nv = new SanPham();
            nv.Show();
        }
        private void ptb2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            DataTable dataTable = sanPhamBUS.getData();
                            workbook.Worksheets.Add(dataTable, "SanPham");
                            workbook.SaveAs(saveFileDialog.FileName);
                        }
                        MessageBox.Show("Lưu thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occurred: " + ex.Message);
                    }
                }
            }
        }
    }
}
