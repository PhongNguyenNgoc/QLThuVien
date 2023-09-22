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
    public partial class xemSach : Form
    {
        public xemSach()
        {
            InitializeComponent();
        }

        private void xemSach_Load(object sender, EventArgs e)
        {
            panel2.Visible = false; //An phan edit di khi form dc load
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-7IUBU0N\\SQLEXPRESS; database=QLTV;integrated security= True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM SachMoi";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
        int bid;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                panel2.Visible = true; //Hien lai giao dien edit khi da nhan vao cell

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-7IUBU0N\\SQLEXPRESS; database=QLTV;integrated security= True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT * FROM SachMoi where bid="+bid+"";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

                //Anh xa
                txtTuaDe.Text = ds.Tables[0].Rows[0][1].ToString();
                txtTheLoai.Text =ds.Tables[0].Rows[0][2].ToString();
                txtTacGia.Text=ds.Tables[0].Rows[0][3].ToString();
                txtNXB.Text=ds.Tables[0].Rows[0][4].ToString();
                txtNgayNhap.Text= ds.Tables[0].Rows[0][5].ToString();
                txtGia.Text=ds.Tables[0].Rows[0][6].ToString();
                txtSL.Text = ds.Tables[0].Rows[0][7].ToString();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void txtTimSach_TextChanged(object sender, EventArgs e)
        {
            if (txtTimSach.Text != ""){
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-7IUBU0N\\SQLEXPRESS; database=QLTV;integrated security= True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT * FROM SachMoi WHERE bTua LIKE '"+txtTimSach.Text+"%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

            }
            else{
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-7IUBU0N\\SQLEXPRESS; database=QLTV;integrated security= True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT * FROM SachMoi";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

            //Lam moi du lieu trong db
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-7IUBU0N\\SQLEXPRESS; database=QLTV;integrated security= True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM SachMoi";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            //-------------------------------------

            txtTimSach.Clear();
            panel2.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dữ liệu sẽ được cập nhật, tiếp tục?", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String bName = txtTuaDe.Text;
                String bType = txtTheLoai.Text;
                String bAuthor = txtTacGia.Text;
                String bPub = txtNXB.Text;
                String bDate = txtNgayNhap.Text;
                Int64 price = Int64.Parse(txtGia.Text);
                Int64 quan = Int64.Parse(txtSL.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-7IUBU0N\\SQLEXPRESS; database=QLTV;integrated security= True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update SachMoi set bTua=N'" + bName + "',bTheLoai=N'" + bType + "',bTacGia=N'" + bAuthor + "',bNXB=N'" + bPub + "',bNgayNhap='" + bDate + "',bGia='" + price + "',bSoLuong='" + quan + "' where bID='" + rowid + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dữ liệu sẽ bị xóa vĩnh viễn, tiếp tục?", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
             

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-7IUBU0N\\SQLEXPRESS; database=QLTV;integrated security= True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "DELETE FROM SachMoi WHERE bID='"+rowid+"'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);


           
            }
        }
    }
}
