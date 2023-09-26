using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-7IUBU0N\\SQLEXPRESS; database=QLTV;integrated security= True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT * FROM SV WHERE MSSV LIKE '" + txtTimSV.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                Image img1 = Image.FromFile("C:/Users/Admin/Documents/Visual Studio 2013/Projects/QLThuVien/QLThuVien/reSource/search.gif");
                pictureBox1.Image = img1;
            }
        }

        private void xemThongTinSV_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-7IUBU0N\\SQLEXPRESS; database=QLTV;integrated security= True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM SV";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        Int64 bid;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid =Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-7IUBU0N\\SQLEXPRESS; database=QLTV;integrated security= True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM SV where MSSV=" + bid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            //Anh xa
            txtMSSV.Text = rowid.ToString();
            txtHoTen.Text = ds.Tables[0].Rows[0][1].ToString();
            txtNS.Text = ds.Tables[0].Rows[0][2].ToString();
            txtLop.Text = ds.Tables[0].Rows[0][3].ToString();
            txtKhoa.Text = ds.Tables[0].Rows[0][4].ToString();
            txtNganh.Text = ds.Tables[0].Rows[0][5].ToString();
           
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dữ liệu sẽ được cập nhật, tiếp tục?", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Int64 mssv=  Int64.Parse(txtMSSV.Text);
                String hoten = txtHoTen.Text;
                String ns = txtNS.Text;
                String lop = txtLop.Text;
                String khoa = txtKhoa.Text;
                String nganh = txtNganh.Text;
               

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-7IUBU0N\\SQLEXPRESS; database=QLTV;integrated security= True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update SV set HoTen=N'" + hoten + "',NgaySinh=N'" + ns + "',Lop='" + lop + "',KhoaHoc='" + khoa + "',Nganh='" + nganh + "' where MSSV='" + mssv + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                xemThongTinSV_Load(this, null); //Load lai form sau khi da update
            }
        }

     

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dữ liệu sẽ bị xóa vĩnh viễn, tiếp tục?", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-7IUBU0N\\SQLEXPRESS; database=QLTV;integrated security= True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "DELETE FROM SV WHERE MSSV='" + rowid + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                xemThongTinSV_Load(this, null);

            }
        }

        private void txtBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            xemThongTinSV_Load(this, null);
        }

      

       

    
    }
}
