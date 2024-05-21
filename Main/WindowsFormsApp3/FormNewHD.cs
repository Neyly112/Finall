﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO1;
namespace WindowsFormsApp3
{
    public partial class FormNewHD : Form
    {
        ClassConnect c = new ClassConnect();
        string strSql;
        SqlConnection sql = null;
        string ma;
        string email;
        bool checkPhongThue1 = false;
        bool checkPhong1 = false;
        string emailCH;

        public FormNewHD(string ma)
        {
            InitializeComponent();
            this.ma = ma;
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

        private void FormNewHD_Load(object sender, EventArgs e)
        {

        }
        private void getMailCH()
        {
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
            sqlCm.CommandText = "select top 1 Email from Chu_ho where MaChuHo = dbo.getTopMaCH() order by MaChuHo desc";
            sqlCm.Connection = sql;
            SqlDataReader reader = sqlCm.ExecuteReader();
            while (reader.Read())
            {
                string tmp = reader.GetString(0);
                emailCH = tmp;
            }
            reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            NguoiThue n = new NguoiThue(txTen.Text.Trim(), tbDC.Text.Trim(), tbEmail.Text.Trim(), tbSDT.Text.Trim(),  "1", "1");
            if ((tbDC.Text == "") || (tbEmail.Text == "") || (tbSDT.Text == "") || (tbSNG.Text == "") || (txTen.Text == ""))
            {
                MessageBox.Show("Không để trống ô");
                return;
            }
            if ((tbSDT.Text.Length < 10) || (tbSDT.Text.Length > 11))
            {
                MessageBox.Show("Số điện thoại không phù hợp");
                return;
            }
            HopDong h = new HopDong(dateTimePickerNL.Text.ToString(), Convert.ToInt32(tbSNG.Text), dateTimePickerNKT.Text.ToString(), tbTenPhong.Text.Trim());
            if (sql == null)
            {
                sql = new SqlConnection(strSql);
            }
            if (sql.State == ConnectionState.Closed)
            {
                sql.Open();
            }
            
            if ((checkPhong(tbTenPhong.Text.Trim()) == false) || (checkPhongDaThue(tbTenPhong.Text.Trim()) == true))
            {
                MessageBox.Show("Phòng đã cho thuê hoặc không tồn tại");
                return;
            }

            string email = n.getEmail();
            
            if (isEmail(email) == false)
            {
                MessageBox.Show("Nhap sai email");
                return;
            }
            string phone = n.getSdt().Trim();
            string name = n.getTen().Trim();
            string NL = dateTimePickerNL.Value.ToString("yyyy-MM-dd");
            string NKT = dateTimePickerNKT.Value.ToString("yyyy-MM-dd");
            int nMember = Convert.ToInt32(tbSNG.Text);
            string address = n.getDiaChi().Trim();
            funcAddKH(n.getEmail().Trim(), n.getDiaChi().Trim(), n.getSdt().Trim(), n.getTen().Trim());
            funcAddHD(h.getNgayKetThuc().Trim(), Convert.ToInt32(h.getSoNguoi()), h.getNgayLap().Trim(), h.getTenPhong());
            funcInsertPhongThueSH(h.getTenPhong());
            getMailCH();
            checkPhong(h.getTenPhong());
            MailMessage mail = new MailMessage();
            MailAddress to = new MailAddress(emailCH);
            MessageBox.Show("Hoàn thành gửi yêu cầu. Trở lại trang chủ?");
            mail.From = new MailAddress("thuanminh1390@gmail.com");
            mail.To.Add(to);
            mail.Subject = "Hợp đồng mới";
            mail.Body = "Có hợp đồng mới cần xác nhận";


            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("thuanminh1390@gmail.com", "efrn boew pxah cwhh");
            smtpClient.EnableSsl = true;
            try
            {
                smtpClient.Send(mail);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            this.Hide();
            trangchu f = new trangchu(ma);
            f.ShowDialog();
        }
        private void funcAddKH(string emailKH, string dc, string sdt, string TenKh)
        {
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
            sqlCm.CommandText = "exec insertToNguoiThue N'" + emailKH + "', N'" + dc + "','" + sdt + "', N'" + TenKh + "', '1'";
            sqlCm.Connection = sql;
            bool ok = false;
            int k = sqlCm.ExecuteNonQuery();
            if (k > 0)
            {
                ok = true;
            }
            else
            {
                ok = false;
            }
            sql.Close();
        }

        private bool checkPhong(string maPhong)
        {
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
            sqlCm.CommandText = "select * from Phong_cho_thue where MaPhong= '" + maPhong + "'";
            sqlCm.Connection = sql;
            SqlDataReader reader = sqlCm.ExecuteReader();
            int kq = 0;
            while (reader.Read())
            {
                kq = 1;
            }
            reader.Close();
            if (kq == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool checkPhongDaThue(string maPhong)
        {
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
            sqlCm.CommandText = "select * from Phong_thue_so_huu where MaPhong= '" + maPhong + "'";
            sqlCm.Connection = sql;
            SqlDataReader reader = sqlCm.ExecuteReader();
            int kq = 0;
            while ( reader.Read())
            {
                kq = 1;
            }
            reader.Close();
            if (kq == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void funcAddHD(string NKT, int songuoi, string NL, string tenPhong)
        {
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
            sqlCm.CommandText = "exec insertToHD '" + NKT + "', '" + songuoi + "', '" + NL + "', '" + tenPhong + "'";
            sqlCm.Connection = sql;
            int k = sqlCm.ExecuteNonQuery();
            if (k > 0)
            {
                MessageBox.Show("Đã gửi cho chủ hộ, vui lòng chờ xác nhận!");
            }
            else
            {
                MessageBox.Show("Chưa xác nhận");
            }

        }

        
        private void funcInsertPhongThueSH(string tenPhong)
        {
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
            sqlCm.CommandText = "insert into Phong_thue_so_huu values (dbo.getTopMaNT(), '" + tenPhong + "')";

            sqlCm.Connection = sql;
            int k = sqlCm.ExecuteNonQuery();
        }

        private void dateTimePickerNL_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerNL.Format = DateTimePickerFormat.Custom;
            dateTimePickerNL.CustomFormat = "yyyy-MM-dd";
        }

        private void dateTimePickerNKT_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerNKT.Format = DateTimePickerFormat.Custom;
            dateTimePickerNKT.CustomFormat = "yyyy-MM-dd";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDanhSachHopDong f = new FormDanhSachHopDong(ma);
            f.ShowDialog();
        }

        private void hủyHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void lựaChọnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void giaHạnHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
