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

namespace WindowsFormsApp3
{
    public partial class FormDieuChinhPhiCH : Form
    {
        string ma;
        ClassConnect c = new ClassConnect();
        string strSql;
        SqlConnection sql = null;
        

        public FormDieuChinhPhiCH(string ma)
        {
            InitializeComponent();
            this.ma = ma;
            strSql = c.SqlConect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbPhiSinhHoat.Texts == "" || tbTienDien.Texts == "" ||
               tbTienNuoc.Texts == "" || tbTienXeMay.Texts == "" ||
               tbTienXeDap.Texts == "" || tbTienXe15Tan.Texts == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if ((Convert.ToInt32(tbPhiSinhHoat.Texts) <= 0) || (Convert.ToInt32(tbTienDien.Texts) <= 0)
                || (Convert.ToInt32(tbTienNuoc.Texts) <= 0) || (Convert.ToInt32(tbTienXe15Tan.Texts) <= 0)
                || (Convert.ToInt32(tbTienXeDap.Texts) <= 0) || (Convert.ToInt32(tbTienXeMay.Texts) <= 0))
            {
                MessageBox.Show("Các số liệu không hợp lệ");
                return;
            }

            if (sql == null)
            {
                sql = new SqlConnection(strSql);
            }
            if (sql.State == ConnectionState.Closed)
            {
                sql.Open();
            }

            string tienNuoc = tbTienNuoc.Texts;
            string tienDien = tbTienDien.Texts;
            string phiSinhHoat = tbPhiSinhHoat.Texts;
            string tienXeMay = tbTienXeMay.Texts;
            string tienXeDap = tbTienXeDap.Texts;
            string tienXeDuoi15Tan = tbTienXe15Tan.Texts;
            SqlCommand sqlCm = new SqlCommand();
            sqlCm.CommandType = CommandType.Text;
            sqlCm.CommandText = "exec insertToBP '" + tienNuoc + "', '" + phiSinhHoat + "', '" +
            tienDien + "', '" + tienXeMay + "', '" + tienXeDap + "', '" + tienXeDuoi15Tan + "'";
            sqlCm.Connection = sql;
            int kq = sqlCm.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Chỉnh sửa thành công");
            }
            else
            {
                MessageBox.Show("Loi");
            }
            this.Hide();
            FormDSBP f = new FormDSBP(ma);
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSBP f = new FormDSBP(ma);
            f.ShowDialog();
        }

        private void FormDieuChinhPhiCH_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
            label6.BackColor = System.Drawing.Color.Transparent;
            label7.BackColor = System.Drawing.Color.Transparent;
            label8.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
        }
    }
}
