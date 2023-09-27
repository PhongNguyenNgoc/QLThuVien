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
        //Đoạn code chạy đồng hồ theo thời gian thực------------------------------
        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        
        //-------------------------------------------------------

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muonSach ms = new muonSach();
            ms.Show();
        }
       
    }
}
