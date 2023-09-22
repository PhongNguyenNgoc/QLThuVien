using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class themSach : Form
    {
        public themSach()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtGia.Text != "" && txtNXB.Text != "" && txtSoLuong.Text != "" && txtTacGia.Text != "" && txtTuaDe.Text != "" && txtTheLoai.Text != "")
            {
                String bName = txtTuaDe.Text;
                String bCate = txtTheLoai.Text;
                String bAuth = txtTacGia.Text;
                String bPubl = txtNXB.Text;
                String bDate = dtpNgayNhap.Text;
                Int64 price = Int64.Parse(txtGia.Text);
                Int64 quan = Int64.Parse(txtSoLuong.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-7IUBU0N\\SQLEXPRESS; database=QLTV;integrated security= True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "INSERT INTO SachMoi(bTua,bTheLoai,bTacGia,bNXB,bNgayNhap,bGia,bSoLuong) VALUES (N'" + bName + "',N'" + bCate + "',N'" + bAuth + "',N'" + bPubl + "','" + bDate + "','" + price + "','" + quan + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Dữ liệu đã được lưu!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Làm trống trường sau khi đã lưu xong
                txtTuaDe.Clear();
                txtTheLoai.Clear();
                txtTacGia.Clear();
                txtNXB.Clear();

                txtGia.Clear();
                txtSoLuong.Clear();
            }
            else
                MessageBox.Show("Phải điền đầy đủ vào các trường", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          
        }

        private void btnBo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dữ liệu trong các trường dữ liệu sẽ KHÔNG ĐƯỢC LƯU và BỊ XÓA", "Chắc chắn chưa?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                this.Close();
        }

      
     
    }
}
