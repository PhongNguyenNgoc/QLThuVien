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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Xu ly su kien nut dang nhap
        private void txtLogIN_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString="data source = DESKTOP-7IUBU0N\\SQLEXPRESS; database=QLTV;integrated security= True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM DangNhap WHERE username='"+txtUser.Text+"'and pass='"+txtPass.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            //Kiem tra ten dang nhap va mk da trung khop => neu dung
            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Dashboard das = new Dashboard();
                das.Show();

            }
                //Neu sai
            else
            {
               
               MessageBox.Show("Sai tài khoản hoặc pass lỗi, vui lòng nhấn (Không đăng nhập được) để được hỗ trợ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }

        }
        //Sự kiện nút thoát
        private void lbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Sự kiện nhấn nút support
        private void lbSupport_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://fb.com/phong23alpha");
        }

      
    }
}
