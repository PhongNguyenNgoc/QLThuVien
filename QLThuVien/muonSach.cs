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
    
    public partial class muonSach : Form
    {
        int dem;
        public muonSach()
        {
            InitializeComponent();
        }

        private void muonSach_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-7IUBU0N\\SQLEXPRESS; database=QLTV;integrated security= True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            //Do du lieu sach vao combo box--------------------------
            con.Open();
            cmd = new SqlCommand("SELECT bTua FROM SachMoi", con);
            SqlDataReader Sdr = cmd.ExecuteReader();

            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    cbSachMuon.Items.Add(Sdr.GetString(i));
                }
            }
            Sdr.Close();
            con.Close();
            //------------------------------
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtMSSV.Text != "")
            {
                Int64 mssv = Int64.Parse(txtMSSV.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-7IUBU0N\\SQLEXPRESS; database=QLTV;integrated security= True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;


                //Code dem so sach duoc muon boi sinh vien
                cmd.CommandText = "SELECT COUNT(MSSV) FROM dbo.MuonSach WHERE MSSV="+mssv+" and ngayTra is null";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
                DataSet DS1 = new DataSet();
                DA1.Fill(DS1);

                dem = int.Parse(DS1.Tables[0].Rows[0][0].ToString());
                //------------------------

                cmd.CommandText = "SELECT * FROM dbo.SV WHERE MSSV=" + mssv + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                if (DS.Tables[0].Rows.Count != 0)
                {
                    txtHoTen.Text = DS.Tables[0].Rows[0][1].ToString();
                    txtLop.Text = DS.Tables[0].Rows[0][3].ToString();
                    txtKhoaHoc.Text = DS.Tables[0].Rows[0][4].ToString();
                    txtNganh.Text = DS.Tables[0].Rows[0][5].ToString();
                }
                else
                {
                    txtHoTen.Clear();
                    txtLop.Clear();
                    txtKhoaHoc.Clear();
                    txtNganh.Clear();

                    MessageBox.Show("Mã số sinh viên không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

             
            }
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text != "")
            {
                if (cbSachMuon.SelectedIndex != -1 && dem <= 2)
                {
                    Int64 mssv = Int64.Parse(txtMSSV.Text);
                    String HoTen = txtHoTen.Text;
                    String Lop = txtLop.Text;
                    String KhoaHoc = txtKhoaHoc.Text;
                    String Nganh = txtNganh.Text;
                    String sachMuon = cbSachMuon.Text;
                 
                    //lay ngay hien tai lam ngay muon
                    DateTime homNay = DateTime.Now;
                    String ngayMuon = homNay.ToLongDateString();
                   


                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-7IUBU0N\\SQLEXPRESS; database=QLTV;integrated security= True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    con.Open();
                    cmd.CommandText = "INSERT INTO dbo.MuonSach(MSSV,HoTen,Lop,KhoaHoc,Nganh,SachMuon,ngayMuon) VALUES  ( "+mssv+",N'"+HoTen+"','"+Lop+"','"+KhoaHoc+"' , N'"+Nganh+"' ,N'"+sachMuon+"', '"+ngayMuon+"')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Mượn sách thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Vui lòng chọn đầu sách hoặc đã vượt quá số lượng mượn tối đa!", "Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Vui lòng kiểm tra lại mã số sinh viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMSSV.Clear();
            txtHoTen.Clear();
            txtKhoaHoc.Clear();
            txtLop.Clear();
            txtNganh.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

       
    }
}
