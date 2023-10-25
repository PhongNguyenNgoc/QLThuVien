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
    public partial class TraSach : Form
    {
        public TraSach()
        {
            InitializeComponent();
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-7IUBU0N\\SQLEXPRESS; database=QLTV;integrated security= True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM MuonSach where MSSV="+txtMSSV.Text+" and ngayTra is null";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
                MessageBox.Show("Sai mã số sinh viên hoặc sinh viên đó chưa mượn sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        String tenSach;
        String Ngay;
        Int64 rowID;
        private void TraSach_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            txtMSSV.Clear();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowID = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                tenSach = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                Ngay = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

            }
            txtTuaSach.Text = tenSach;
            txtNgayMuon.Text = Ngay;

        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-7IUBU0N\\SQLEXPRESS; database=QLTV;integrated security= True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "update MuonSach set ngayTra ='"+dtpNgayTra.Text+"' where MSSV="+txtMSSV.Text+" and id="+rowID+"";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Trả sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TraSach_Load(this, null);
        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {
            if (txtMSSV.Text == "")
            {
                panel2.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

      
    }
}
