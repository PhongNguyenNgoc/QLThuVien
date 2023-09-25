using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void thêmSáchMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            themSach tsm = new themSach();
            tsm.Show();
        }

        private void xemSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xemSach xs = new xemSach();
            xs.Show();
        }

        private void thêmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            themSinhVien tsv = new themSinhVien();
            tsv.Show();
        }

        private void xemThôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xemThongTinSV xSV = new xemThongTinSV();
            xSV.Show();
        }

       
    }
}
