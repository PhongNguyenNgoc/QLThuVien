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
    public partial class lichSu : Form
    {
        public lichSu()
        {
            InitializeComponent();
        }

        private void lichSu_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-7IUBU0N\\SQLEXPRESS; database=QLTV;integrated security= True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM MuonSach where ngayTra is null";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataMuon.DataSource = ds.Tables[0];


            cmd.CommandText = "SELECT * FROM MuonSach where ngayTra is not null";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataTra.DataSource = ds1.Tables[0];
        }
    }
}
