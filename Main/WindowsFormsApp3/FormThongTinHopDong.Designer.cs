﻿namespace WindowsFormsApp3
{
    partial class FormThongTinHopDong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTenPhong = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTenPhong = new System.Windows.Forms.Label();
            this.tbTenNguoiThue = new WindowsFormsApp3.UI.UserControlBTN();
            this.tbSoNg = new WindowsFormsApp3.UI.UserControlBTN();
            this.dateTimePicker1 = new WindowsFormsApp3.UI.DatePicker();
            this.dateTimePicker2 = new WindowsFormsApp3.UI.DatePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTenPhong
            // 
            this.lbTenPhong.AutoSize = true;
            this.lbTenPhong.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenPhong.Location = new System.Drawing.Point(140, 126);
            this.lbTenPhong.Name = "lbTenPhong";
            this.lbTenPhong.Size = new System.Drawing.Size(165, 37);
            this.lbTenPhong.TabIndex = 0;
            this.lbTenPhong.Text = "Tên phòng:";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Gold;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.Location = new System.Drawing.Point(122, 449);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(118, 54);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(140, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên người thuê:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(140, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày lập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(140, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày kết thúc:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(285, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 54);
            this.button1.TabIndex = 7;
            this.button1.Text = "Hủy hợp đồng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button2.Location = new System.Drawing.Point(537, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 54);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sửa thông tin";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(140, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 37);
            this.label2.TabIndex = 15;
            this.label2.Text = "Số người ở:";
            // 
            // tbTenPhong
            // 
            this.tbTenPhong.AutoSize = true;
            this.tbTenPhong.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTenPhong.Location = new System.Drawing.Point(428, 130);
            this.tbTenPhong.Name = "tbTenPhong";
            this.tbTenPhong.Size = new System.Drawing.Size(83, 33);
            this.tbTenPhong.TabIndex = 16;
            this.tbTenPhong.Text = "label5";
            // 
            // tbTenNguoiThue
            // 
            this.tbTenNguoiThue.BackColor = System.Drawing.SystemColors.Window;
            this.tbTenNguoiThue.BorderColor = System.Drawing.Color.DarkKhaki;
            this.tbTenNguoiThue.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbTenNguoiThue.BorderSize = 5;
            this.tbTenNguoiThue.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTenNguoiThue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbTenNguoiThue.Location = new System.Drawing.Point(434, 184);
            this.tbTenNguoiThue.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenNguoiThue.Multiline = false;
            this.tbTenNguoiThue.Name = "tbTenNguoiThue";
            this.tbTenNguoiThue.Padding = new System.Windows.Forms.Padding(7);
            this.tbTenNguoiThue.PasswordChar = false;
            this.tbTenNguoiThue.Size = new System.Drawing.Size(309, 41);
            this.tbTenNguoiThue.TabIndex = 1;
            this.tbTenNguoiThue.Texts = "";
            this.tbTenNguoiThue.UnderlinedStyle = true;
            // 
            // tbSoNg
            // 
            this.tbSoNg.BackColor = System.Drawing.SystemColors.Window;
            this.tbSoNg.BorderColor = System.Drawing.Color.DarkKhaki;
            this.tbSoNg.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbSoNg.BorderSize = 5;
            this.tbSoNg.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSoNg.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbSoNg.Location = new System.Drawing.Point(434, 248);
            this.tbSoNg.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoNg.Multiline = false;
            this.tbSoNg.Name = "tbSoNg";
            this.tbSoNg.Padding = new System.Windows.Forms.Padding(7);
            this.tbSoNg.PasswordChar = false;
            this.tbSoNg.Size = new System.Drawing.Size(309, 41);
            this.tbSoNg.TabIndex = 2;
            this.tbSoNg.Texts = "";
            this.tbSoNg.UnderlinedStyle = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.BorderColor = System.Drawing.Color.DarkKhaki;
            this.dateTimePicker1.BorderSize = 2;
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Times New Roman", 16.2F);
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(434, 312);
            this.dateTimePicker1.MinDate = new System.DateTime(2024, 5, 22, 0, 0, 0, 0);
            this.dateTimePicker1.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 39);
            this.dateTimePicker1.SkinColor = System.Drawing.SystemColors.ControlLight;
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.TextColor = System.Drawing.SystemColors.WindowText;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.BorderColor = System.Drawing.Color.DarkKhaki;
            this.dateTimePicker2.BorderSize = 2;
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Times New Roman", 16.2F);
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(434, 375);
            this.dateTimePicker2.MinDate = new System.DateTime(2024, 5, 22, 0, 0, 0, 0);
            this.dateTimePicker2.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(300, 39);
            this.dateTimePicker2.SkinColor = System.Drawing.SystemColors.ControlLight;
            this.dateTimePicker2.TabIndex = 4;
            this.dateTimePicker2.TextColor = System.Drawing.SystemColors.WindowText;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 22.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(11, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 46);
            this.label5.TabIndex = 65;
            this.label5.Text = "Amana";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Image = global::WindowsFormsApp3.Properties.Resources.logo3;
            this.pictureBox2.Location = new System.Drawing.Point(1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            // 
            // FormThongTinHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(838, 545);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbSoNg);
            this.Controls.Add(this.tbTenNguoiThue);
            this.Controls.Add(this.tbTenPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lbTenPhong);
            this.Name = "FormThongTinHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThongTinHopDong";
            this.Load += new System.EventHandler(this.FormHuyHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTenPhong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tbTenPhong;
        private UI.UserControlBTN tbTenNguoiThue;
        private UI.UserControlBTN tbSoNg;
        private UI.DatePicker dateTimePicker1;
        private UI.DatePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}