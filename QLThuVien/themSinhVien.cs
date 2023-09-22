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
    public partial class themSinhVien : Form
    {
        public themSinhVien()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtMSSV.Clear();
            txtHT.Clear();
            txtLop.Clear();
            txtKhoaHoc.Clear();
            txtNganh.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMSSV.Text != "" && txtHT.Text != "" && txtLop.Text != "" && txtKhoaHoc.Text != "" && txtNganh.Text != "")
            {
                String mssv = txtMSSV.Text;
                String ht = txtHT.Text;
                String ns = dtpNgaySinh.Text;
                String lop = txtLop.Text;
                String khoaH = txtKhoaHoc.Text;
                String nganh = txtNganh.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-7IUBU0N\\SQLEXPRESS; database=QLTV;integrated security= True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "INSERT INTO SV( MSSV,HoTen,NgaySinh,Lop,KhoaHoc,Nganh) VALUES ('" + mssv + "',N'" + ht + "','" + ns + "','" + lop + "','" + khoaH + "',N'" + nganh + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Lưu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Phải điền đầy đủ vào các trường, không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

      
    }
}
