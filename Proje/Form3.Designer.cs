namespace Proje
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_telno = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_ipt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_saha = new System.Windows.Forms.ComboBox();
            this.cmb_saat = new System.Windows.Forms.ComboBox();
            this.dtp_tarih = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_tur = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ilce = new System.Windows.Forms.TextBox();
            this.txt_il = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Telefon :";
            // 
            // txt_telno
            // 
            this.txt_telno.Location = new System.Drawing.Point(155, 146);
            this.txt_telno.MaxLength = 11;
            this.txt_telno.Name = "txt_telno";
            this.txt_telno.Size = new System.Drawing.Size(100, 30);
            this.txt_telno.TabIndex = 5;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(155, 95);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(100, 30);
            this.txt_soyad.TabIndex = 6;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(155, 43);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 30);
            this.txt_ad.TabIndex = 7;
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.Transparent;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ekle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.Image = ((System.Drawing.Image)(resources.GetObject("btn_ekle.Image")));
            this.btn_ekle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ekle.Location = new System.Drawing.Point(235, 290);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 64);
            this.btn_ekle.TabIndex = 12;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_ipt
            // 
            this.btn_ipt.BackColor = System.Drawing.Color.Transparent;
            this.btn_ipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ipt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ipt.Image = ((System.Drawing.Image)(resources.GetObject("btn_ipt.Image")));
            this.btn_ipt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ipt.Location = new System.Drawing.Point(343, 290);
            this.btn_ipt.Name = "btn_ipt";
            this.btn_ipt.Size = new System.Drawing.Size(75, 64);
            this.btn_ipt.TabIndex = 13;
            this.btn_ipt.Text = "İptal";
            this.btn_ipt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ipt.UseVisualStyleBackColor = false;
            this.btn_ipt.Click += new System.EventHandler(this.btn_ipt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmb_saha);
            this.groupBox1.Controls.Add(this.btn_ipt);
            this.groupBox1.Controls.Add(this.cmb_saat);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.dtp_tarih);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmb_tur);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_ilce);
            this.groupBox1.Controls.Add(this.txt_il);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_telno);
            this.groupBox1.Controls.Add(this.txt_soyad);
            this.groupBox1.Controls.Add(this.txt_ad);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 408);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiralama Bilgileri";
            // 
            // cmb_saha
            // 
            this.cmb_saha.FormattingEnabled = true;
            this.cmb_saha.Location = new System.Drawing.Point(415, 197);
            this.cmb_saha.Name = "cmb_saha";
            this.cmb_saha.Size = new System.Drawing.Size(121, 31);
            this.cmb_saha.TabIndex = 23;
            // 
            // cmb_saat
            // 
            this.cmb_saat.FormattingEnabled = true;
            this.cmb_saat.Items.AddRange(new object[] {
            "08-09",
            "09-10",
            "10-11",
            "11-12",
            "12-13",
            "13-14",
            "14-15",
            "15-16",
            "16-17",
            "17-18",
            "18-19",
            "19-20",
            "20-21",
            "21-22",
            "22-23",
            "23-00",
            "00-01",
            "01-02",
            "02-03",
            "03-04",
            "04-05"});
            this.cmb_saat.Location = new System.Drawing.Point(415, 94);
            this.cmb_saat.Name = "cmb_saat";
            this.cmb_saat.Size = new System.Drawing.Size(121, 31);
            this.cmb_saat.TabIndex = 22;
            // 
            // dtp_tarih
            // 
            this.dtp_tarih.Location = new System.Drawing.Point(415, 45);
            this.dtp_tarih.Name = "dtp_tarih";
            this.dtp_tarih.Size = new System.Drawing.Size(234, 30);
            this.dtp_tarih.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(317, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Gün :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(317, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 26);
            this.label5.TabIndex = 17;
            this.label5.Text = "Saat :";
            // 
            // cmb_tur
            // 
            this.cmb_tur.FormattingEnabled = true;
            this.cmb_tur.Items.AddRange(new object[] {
            "Abone",
            "Normal Kayıt"});
            this.cmb_tur.Location = new System.Drawing.Point(415, 148);
            this.cmb_tur.Name = "cmb_tur";
            this.cmb_tur.Size = new System.Drawing.Size(121, 31);
            this.cmb_tur.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(315, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 26);
            this.label9.TabIndex = 19;
            this.label9.Text = "Saha :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(280, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 26);
            this.label6.TabIndex = 20;
            this.label6.Text = "Saha Kayıt :";
            // 
            // txt_ilce
            // 
            this.txt_ilce.Location = new System.Drawing.Point(155, 247);
            this.txt_ilce.Name = "txt_ilce";
            this.txt_ilce.Size = new System.Drawing.Size(100, 30);
            this.txt_ilce.TabIndex = 9;
            // 
            // txt_il
            // 
            this.txt_il.Location = new System.Drawing.Point(155, 193);
            this.txt_il.Name = "txt_il";
            this.txt_il.Size = new System.Drawing.Size(100, 30);
            this.txt_il.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(68, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 26);
            this.label8.TabIndex = 1;
            this.label8.Text = "İlçe :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(75, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "İl :";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(707, 468);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form3";
            this.Text = "Müşteri Kayıt Sistemi";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_telno;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_ipt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_ilce;
        private System.Windows.Forms.TextBox txt_il;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_saha;
        private System.Windows.Forms.ComboBox cmb_saat;
        private System.Windows.Forms.DateTimePicker dtp_tarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_tur;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
    }
}