using System;
using System.Windows.Forms;

namespace Doan1
{
    public partial class VeUngDungNay : Form
    {
        public VeUngDungNay()
        {
            InitializeComponent();
        }
        private void ptb2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbfb_Click(object sender, EventArgs e)
        {
            string fb = "https://www.facebook.com/";
            System.Diagnostics.Process.Start(fb);
        }

        private void pbemail_Click(object sender, EventArgs e)
        {
            string diachiemail = "@gmail.com";
            System.Diagnostics.ProcessStartInfo mo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "mailto:" + diachiemail,
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(mo);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string ut = "https://www.youtube.com/";
            System.Diagnostics.Process.Start(ut);
        }
    }
}
