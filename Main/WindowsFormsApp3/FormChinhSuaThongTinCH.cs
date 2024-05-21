using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormChinhSuaThongTinCH : Form
    {
        ClassConnect c = new ClassConnect();
        string strSql;
        SqlConnection sql = null;
        string ma;
        string ten;
        string diaChi;
        string sDT;
        string email;
        string matKhau;
        public FormChinhSuaThongTinCH(string ma, string ten, string diaChi, string email, string sDT, string matKhau)
        {
            InitializeComponent();
            this.ma = ma;
            this.matKhau = matKhau;
            this.diaChi = diaChi;
            this.sDT = sDT;
            this.email = email;
            this.ten = ten;
            strSql = c.SqlConect();
        }
        private bool isEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            string strRegex = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            Regex regex = new Regex(strRegex);
            return regex.IsMatch(email);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (isEmail(tbEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ");
                return;
            }
            if (tbSdt.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return;
            }
            string ten = tbTen.Text.Trim();
            string Sdt = tbSdt.Text.Trim();
            string email = tbEmail.Text.Trim();
            string diaChi = tbDiaChi.Text.Trim();

            if (sql == null)
            {
                sql = new SqlConnection(strSql);
            }
            if (sql.State == ConnectionState.Closed)
            {
                sql.Open();
            }
            SqlCommand sqlCm = new SqlCommand();
            sqlCm.CommandType = CommandType.Text;
            sqlCm.CommandText = "Update Quan_li set DiaChi=N'" + diaChi + "', SoDienThoai='" + Sdt + "', Email='" + email + "', Ten= N'" + ten + "', MatKhau= N'" + matKhau + "' where MaQuanLi= '" + ma + "'";
            sqlCm.Connection = sql;
            int kq = sqlCm.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Đã sửa thông tin");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
            this.Hide();
            FormThongTinQuanLy f = new FormThongTinQuanLy(ma);
            f.ShowDialog();
        }

        private void FormChinhSuaThongTinCH_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormDMKCH f = new FormDMKCH(ma);
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinChuHo f = new FormThongTinChuHo(ma);
            f.ShowDialog();
        }
    }
}
