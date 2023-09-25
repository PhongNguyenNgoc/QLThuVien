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
    public partial class xemThongTinSV : Form
    {
        public xemThongTinSV()
        {
            InitializeComponent();
        }

        private void txtTimSV_TextChanged(object sender, EventArgs e)
        {
            if (txtTimSV.Text != "")
            {
                //Khi text thay doi, thi se thay doi anh gif tren dau
                Image img = Image.FromFile("C:/Users/Admin/Documents/Visual Studio 2013/Projects/QLThuVien/QLThuVien/reSource/search1.gif");
                pictureBox1.Image = img;
            }
            else
            {
                Image img = Image.FromFile("C:/Users/Admin/Documents/Visual Studio 2013/Projects/QLThuVien/QLThuVien/reSource/search.gif");
                pictureBox1.Image = img;
            }
        }

    
    }
}
