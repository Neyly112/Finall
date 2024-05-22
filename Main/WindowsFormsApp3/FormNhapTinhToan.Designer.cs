namespace WindowsFormsApp3
{
    partial class FormNhapTinhToan
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ngayKetThuc = new WindowsFormsApp3.UI.DatePicker();
            this.comboBox1 = new WindowsFormsApp3.UI.ClassComboBox();
            this.ngayBatDau = new WindowsFormsApp3.UI.DatePicker();
            this.tbTienNuoc = new WindowsFormsApp3.UI.UserControlBTN();
            this.tbTienDien = new WindowsFormsApp3.UI.UserControlBTN();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(238, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 37);
            this.label7.TabIndex = 35;
            this.label7.Text = "Đến ngày";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(238, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 37);
            this.label6.TabIndex = 34;
            this.label6.Text = "Từ ngày";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button2.Location = new System.Drawing.Point(487, 484);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 59);
            this.button2.TabIndex = 33;
            this.button2.Text = "Tính tổng tiền";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(295, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 59);
            this.button1.TabIndex = 32;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(238, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 37);
            this.label4.TabIndex = 26;
            this.label4.Text = "Số m3 nước";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(238, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 37);
            this.label3.TabIndex = 24;
            this.label3.Text = "Số kwh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(238, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 37);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên phòng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(370, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 49);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nhập các số liệu";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Image = global::WindowsFormsApp3.Properties.Resources.logo3;
            this.pictureBox2.Location = new System.Drawing.Point(0, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 22.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(12, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 46);
            this.label5.TabIndex = 44;
            this.label5.Text = "Amana";
            // 
            // ngayKetThuc
            // 
            this.ngayKetThuc.BorderColor = System.Drawing.Color.DarkKhaki;
            this.ngayKetThuc.BorderSize = 1;
            this.ngayKetThuc.CalendarFont = new System.Drawing.Font("Times New Roman", 16.2F);
            this.ngayKetThuc.CustomFormat = "yyyy-MM-dd";
            this.ngayKetThuc.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.ngayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngayKetThuc.Location = new System.Drawing.Point(461, 395);
            this.ngayKetThuc.MinDate = new System.DateTime(2024, 5, 22, 0, 0, 0, 0);
            this.ngayKetThuc.MinimumSize = new System.Drawing.Size(4, 35);
            this.ngayKetThuc.Name = "ngayKetThuc";
            this.ngayKetThuc.Size = new System.Drawing.Size(300, 39);
            this.ngayKetThuc.SkinColor = System.Drawing.SystemColors.ControlLight;
            this.ngayKetThuc.TabIndex = 41;
            this.ngayKetThuc.TextColor = System.Drawing.SystemColors.WindowText;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.BorderColor = System.Drawing.Color.DarkKhaki;
            this.comboBox1.BorderSize = 1;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox1.IconColor = System.Drawing.Color.Navy;
            this.comboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboBox1.ListTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox1.Location = new System.Drawing.Point(461, 162);
            this.comboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Padding = new System.Windows.Forms.Padding(1);
            this.comboBox1.Size = new System.Drawing.Size(300, 30);
            this.comboBox1.TabIndex = 40;
            this.comboBox1.Texts = "";
            // 
            // ngayBatDau
            // 
            this.ngayBatDau.BorderColor = System.Drawing.Color.DarkKhaki;
            this.ngayBatDau.BorderSize = 1;
            this.ngayBatDau.CalendarFont = new System.Drawing.Font("Times New Roman", 16.2F);
            this.ngayBatDau.CustomFormat = "yyyy-MM-dd";
            this.ngayBatDau.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.ngayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngayBatDau.Location = new System.Drawing.Point(461, 339);
            this.ngayBatDau.MinDate = new System.DateTime(2024, 5, 22, 0, 0, 0, 0);
            this.ngayBatDau.MinimumSize = new System.Drawing.Size(4, 35);
            this.ngayBatDau.Name = "ngayBatDau";
            this.ngayBatDau.Size = new System.Drawing.Size(300, 39);
            this.ngayBatDau.SkinColor = System.Drawing.SystemColors.ControlLight;
            this.ngayBatDau.TabIndex = 39;
            this.ngayBatDau.TextColor = System.Drawing.SystemColors.WindowText;
            // 
            // tbTienNuoc
            // 
            this.tbTienNuoc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbTienNuoc.BorderColor = System.Drawing.Color.DarkKhaki;
            this.tbTienNuoc.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbTienNuoc.BorderSize = 2;
            this.tbTienNuoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTienNuoc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbTienNuoc.Location = new System.Drawing.Point(461, 282);
            this.tbTienNuoc.Margin = new System.Windows.Forms.Padding(4);
            this.tbTienNuoc.Multiline = false;
            this.tbTienNuoc.Name = "tbTienNuoc";
            this.tbTienNuoc.Padding = new System.Windows.Forms.Padding(7);
            this.tbTienNuoc.PasswordChar = false;
            this.tbTienNuoc.Size = new System.Drawing.Size(300, 37);
            this.tbTienNuoc.TabIndex = 38;
            this.tbTienNuoc.Texts = "";
            this.tbTienNuoc.UnderlinedStyle = true;
            // 
            // tbTienDien
            // 
            this.tbTienDien.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbTienDien.BorderColor = System.Drawing.Color.DarkKhaki;
            this.tbTienDien.BorderFocusColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbTienDien.BorderSize = 2;
            this.tbTienDien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTienDien.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbTienDien.Location = new System.Drawing.Point(461, 219);
            this.tbTienDien.Margin = new System.Windows.Forms.Padding(4);
            this.tbTienDien.Multiline = false;
            this.tbTienDien.Name = "tbTienDien";
            this.tbTienDien.Padding = new System.Windows.Forms.Padding(7);
            this.tbTienDien.PasswordChar = false;
            this.tbTienDien.Size = new System.Drawing.Size(300, 37);
            this.tbTienDien.TabIndex = 37;
            this.tbTienDien.Texts = "";
            this.tbTienDien.UnderlinedStyle = true;
            // 
            // FormNhapTinhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(993, 597);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ngayKetThuc);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ngayBatDau);
            this.Controls.Add(this.tbTienNuoc);
            this.Controls.Add(this.tbTienDien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormNhapTinhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNhapTinhToan";
            this.Load += new System.EventHandler(this.FormNhapTinhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UI.UserControlBTN tbTienDien;
        private UI.UserControlBTN tbTienNuoc;
        private UI.DatePicker ngayBatDau;
        private UI.ClassComboBox comboBox1;
        private UI.DatePicker ngayKetThuc;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
    }
}