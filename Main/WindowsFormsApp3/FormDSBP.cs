﻿using System;
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
    public partial class FormDSBP : Form
    {
        string ma;
        ClassConnect c = new ClassConnect();
        string strSql;
        public FormDSBP(string ma)
        {
            InitializeComponent();
            this.ma = ma;
            strSql = c.SqlConect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDieuChinhPhiCH f= new FormDieuChinhPhiCH(ma);
            f.ShowDialog();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormDSBP_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getAllHopDong().Tables[0];
            DataSet getAllHopDong()
            {
                DataSet dataSet = new DataSet();
                string querry = "select * from Bang_phi";
                using (SqlConnection connection = new SqlConnection(strSql))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(querry, connection);
                    adapter.Fill(dataSet);
                    connection.Close();
                }
                return dataSet;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            trangchu3 t = new trangchu3(ma);
            t.ShowDialog();
            
        }
    }
}