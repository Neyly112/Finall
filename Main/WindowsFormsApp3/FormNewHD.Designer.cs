﻿namespace WindowsFormsApp3
{
    partial class FormNewHD
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
            this.labelLHD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txTen = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSNG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerNL = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNKT = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelLHD
            // 
            this.labelLHD.AutoSize = true;
            this.labelLHD.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labelLHD.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelLHD.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelLHD.Location = new System.Drawing.Point(411, 55);
            this.labelLHD.Name = "labelLHD";
            this.labelLHD.Size = new System.Drawing.Size(281, 49);
            this.labelLHD.TabIndex = 2;
            this.labelLHD.Text = "Lập Hợp Đồng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(127, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên người thuê";
            // 
            // txTen
            // 
            this.txTen.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txTen.Location = new System.Drawing.Point(400, 135);
            this.txTen.Multiline = true;
            this.txTen.Name = "txTen";
            this.txTen.Size = new System.Drawing.Size(612, 38);
            this.txTen.TabIndex = 4;
            // 
            // tbSDT
            // 
            this.tbSDT.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.tbSDT.Location = new System.Drawing.Point(400, 194);
            this.tbSDT.Multiline = true;
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(612, 38);
            this.tbSDT.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(127, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số điện thoại";
            // 
            // tbDC
            // 
            this.tbDC.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.tbDC.Location = new System.Drawing.Point(400, 259);
            this.tbDC.Multiline = true;
            this.tbDC.Name = "tbDC";
            this.tbDC.Size = new System.Drawing.Size(612, 38);
            this.tbDC.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(127, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Địa chỉ";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.tbEmail.Location = new System.Drawing.Point(400, 327);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(612, 38);
            this.tbEmail.TabIndex = 10;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(127, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 37);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            // 
            // tbSNG
            // 
            this.tbSNG.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.tbSNG.Location = new System.Drawing.Point(400, 398);
            this.tbSNG.Multiline = true;
            this.tbSNG.Name = "tbSNG";
            this.tbSNG.Size = new System.Drawing.Size(612, 38);
            this.tbSNG.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(127, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số người ở";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(127, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 37);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tên phòng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(133, 535);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 37);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ngày lập";
            // 
            // dateTimePickerNL
            // 
            this.dateTimePickerNL.Checked = false;
            this.dateTimePickerNL.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerNL.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerNL.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNL.Location = new System.Drawing.Point(400, 535);
            this.dateTimePickerNL.MinDate = new System.DateTime(2024, 5, 4, 0, 0, 0, 0);
            this.dateTimePickerNL.Name = "dateTimePickerNL";
            this.dateTimePickerNL.Size = new System.Drawing.Size(612, 45);
            this.dateTimePickerNL.TabIndex = 16;
            this.dateTimePickerNL.Value = new System.DateTime(2024, 5, 25, 23, 59, 59, 0);
            this.dateTimePickerNL.ValueChanged += new System.EventHandler(this.dateTimePickerNL_ValueChanged);
            // 
            // dateTimePickerNKT
            // 
            this.dateTimePickerNKT.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerNKT.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerNKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNKT.Location = new System.Drawing.Point(400, 609);
            this.dateTimePickerNKT.MinDate = new System.DateTime(2024, 5, 4, 0, 0, 0, 0);
            this.dateTimePickerNKT.Name = "dateTimePickerNKT";
            this.dateTimePickerNKT.Size = new System.Drawing.Size(612, 45);
            this.dateTimePickerNKT.TabIndex = 18;
            this.dateTimePickerNKT.ValueChanged += new System.EventHandler(this.dateTimePickerNKT_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(133, 609);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 37);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ngày kết thúc";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(262, 688);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 57);
            this.button1.TabIndex = 19;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Location = new System.Drawing.Point(590, 688);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 57);
            this.button2.TabIndex = 20;
            this.button2.Text = "Xác nhận";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1258, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(400, 462);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(612, 39);
            this.comboBox1.TabIndex = 22;
            // 
            // FormNewHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1258, 777);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePickerNKT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePickerNL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbSNG);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLHD);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormNewHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNewHD";
            this.Load += new System.EventHandler(this.FormNewHD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txTen;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSNG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerNL;
        private System.Windows.Forms.DateTimePicker dateTimePickerNKT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}