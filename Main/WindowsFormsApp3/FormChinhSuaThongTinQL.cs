﻿using System;
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
    public partial class FormChinhSuaThongTinQL : Form
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
        public FormChinhSuaThongTinQL(string ma, string ten, string diaChi, string email, string sDT, string matKhau)
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void tbTen_TextChanged(object sender, EventArgs e)
        {

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
            
        }

        private void FormChinhSuaThongTinQL_Load(object sender, EventArgs e)
        {
            tbSdt.Texts = sDT;
            tbEmail.Texts = email;
            tbDiaChi.Texts = diaChi;
            tbTen.Texts = ten;
            
            label1.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
            label6.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;

        }

        

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide(); 
            FormDMKQL f = new FormDMKQL(ma);
            f.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (tbSdt.Texts.Length != 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return;
            }
            if (isEmail(tbEmail.Texts.Trim()) == false)
            {
                MessageBox.Show("Email không hợp lệ");
                return;
            }
            
            if ((tbEmail.Texts == "") || (tbDiaChi.Texts == "") || (tbSdt.Texts == "") || (tbTen.Texts == ""))
            {
                MessageBox.Show("Vui lòng không để trống thông tin");
                return;
            }
            string ten = tbTen.Texts.Trim();
            string Sdt = tbSdt.Texts.Trim();
            string email = tbEmail.Texts.Trim();
            string diaChi = tbDiaChi.Texts.Trim();

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinQuanLy f = new FormThongTinQuanLy(ma);
            f.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
