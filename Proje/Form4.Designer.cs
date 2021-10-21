namespace Proje
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.grid = new System.Windows.Forms.DataGridView();
            this.btn_gnc = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_saha = new System.Windows.Forms.Button();
            this.cmb_saat = new System.Windows.Forms.ComboBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.cmb_saha = new System.Windows.Forms.ComboBox();
            this.txt_il = new System.Windows.Forms.TextBox();
            this.txt_ilce = new System.Windows.Forms.TextBox();
            this.dtp_tarih = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_tur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_telno = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.btn_geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.grid.Location = new System.Drawing.Point(12, 381);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(863, 215);
            this.grid.TabIndex = 0;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            // 
            // btn_gnc
            // 
            this.btn_gnc.BackColor = System.Drawing.Color.Transparent;
            this.btn_gnc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_gnc.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gnc.Image = ((System.Drawing.Image)(resources.GetObject("btn_gnc.Image")));
            this.btn_gnc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_gnc.Location = new System.Drawing.Point(725, 119);
            this.btn_gnc.Name = "btn_gnc";
            this.btn_gnc.Size = new System.Drawing.Size(108, 62);
            this.btn_gnc.TabIndex = 1;
            this.btn_gnc.Text = "Güncelle ";
            this.btn_gnc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_gnc.UseVisualStyleBackColor = false;
            this.btn_gnc.Click += new System.EventHandler(this.btn_gnc_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Transparent;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sil.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_sil.Image")));
            this.btn_sil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_sil.Location = new System.Drawing.Point(725, 213);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(108, 62);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = " Sil ";
            this.btn_sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.Transparent;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ekle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.Image = ((System.Drawing.Image)(resources.GetObject("btn_ekle.Image")));
            this.btn_ekle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ekle.Location = new System.Drawing.Point(725, 28);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(108, 62);
            this.btn_ekle.TabIndex = 17;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_saha);
            this.groupBox1.Controls.Add(this.cmb_saat);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.cmb_saha);
            this.groupBox1.Controls.Add(this.txt_il);
            this.groupBox1.Controls.Add(this.txt_ilce);
            this.groupBox1.Controls.Add(this.dtp_tarih);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_tur);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_telno);
            this.groupBox1.Controls.Add(this.txt_soyad);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_ad);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(37, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(667, 350);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiralama Bilgileri";
            // 
            // btn_saha
            // 
            this.btn_saha.BackColor = System.Drawing.Color.Transparent;
            this.btn_saha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_saha.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_saha.ForeColor = System.Drawing.Color.Black;
            this.btn_saha.Image = ((System.Drawing.Image)(resources.GetObject("btn_saha.Image")));
            this.btn_saha.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_saha.Location = new System.Drawing.Point(555, 282);
            this.btn_saha.Margin = new System.Windows.Forms.Padding(2);
            this.btn_saha.Name = "btn_saha";
            this.btn_saha.Size = new System.Drawing.Size(108, 62);
            this.btn_saha.TabIndex = 20;
            this.btn_saha.Text = "Saha Ekranı";
            this.btn_saha.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_saha.UseVisualStyleBackColor = false;
            this.btn_saha.Click += new System.EventHandler(this.btn_saha_Click);
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
            this.cmb_saat.Location = new System.Drawing.Point(430, 97);
            this.cmb_saat.Name = "cmb_saat";
            this.cmb_saat.Size = new System.Drawing.Size(121, 31);
            this.cmb_saat.TabIndex = 24;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(159, 45);
            this.txt_id.Margin = new System.Windows.Forms.Padding(2);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(114, 30);
            this.txt_id.TabIndex = 10;
            // 
            // cmb_saha
            // 
            this.cmb_saha.FormattingEnabled = true;
            this.cmb_saha.Location = new System.Drawing.Point(430, 189);
            this.cmb_saha.Name = "cmb_saha";
            this.cmb_saha.Size = new System.Drawing.Size(121, 31);
            this.cmb_saha.TabIndex = 23;
            // 
            // txt_il
            // 
            this.txt_il.Location = new System.Drawing.Point(159, 234);
            this.txt_il.Margin = new System.Windows.Forms.Padding(2);
            this.txt_il.Name = "txt_il";
            this.txt_il.Size = new System.Drawing.Size(114, 30);
            this.txt_il.TabIndex = 8;
            // 
            // txt_ilce
            // 
            this.txt_ilce.Location = new System.Drawing.Point(159, 282);
            this.txt_ilce.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ilce.Name = "txt_ilce";
            this.txt_ilce.Size = new System.Drawing.Size(114, 30);
            this.txt_ilce.TabIndex = 9;
            // 
            // dtp_tarih
            // 
            this.dtp_tarih.Location = new System.Drawing.Point(429, 45);
            this.dtp_tarih.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_tarih.Name = "dtp_tarih";
            this.dtp_tarih.Size = new System.Drawing.Size(226, 30);
            this.dtp_tarih.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(54, 49);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 26);
            this.label10.TabIndex = 0;
            this.label10.Text = "Id :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(322, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gün :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(314, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Saat :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // cmb_tur
            // 
            this.cmb_tur.FormattingEnabled = true;
            this.cmb_tur.Items.AddRange(new object[] {
            "Abone",
            "Normal Kayıt"});
            this.cmb_tur.Location = new System.Drawing.Point(430, 143);
            this.cmb_tur.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_tur.Name = "cmb_tur";
            this.cmb_tur.Size = new System.Drawing.Size(146, 31);
            this.cmb_tur.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(322, 190);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 26);
            this.label9.TabIndex = 10;
            this.label9.Text = "Saha :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Telefon :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(299, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Saha Kayıt:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(53, 286);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 26);
            this.label12.TabIndex = 1;
            this.label12.Text = "İlçe :";
            // 
            // txt_telno
            // 
            this.txt_telno.Location = new System.Drawing.Point(159, 189);
            this.txt_telno.Margin = new System.Windows.Forms.Padding(2);
            this.txt_telno.MaxLength = 11;
            this.txt_telno.Name = "txt_telno";
            this.txt_telno.Size = new System.Drawing.Size(114, 30);
            this.txt_telno.TabIndex = 5;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(159, 142);
            this.txt_soyad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(114, 30);
            this.txt_soyad.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(73, 238);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 26);
            this.label11.TabIndex = 1;
            this.label11.Text = "İl :";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(159, 98);
            this.txt_ad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(114, 30);
            this.txt_ad.TabIndex = 7;
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.Color.Transparent;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_geri.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.ForeColor = System.Drawing.Color.Black;
            this.btn_geri.Image = ((System.Drawing.Image)(resources.GetObject("btn_geri.Image")));
            this.btn_geri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_geri.Location = new System.Drawing.Point(725, 293);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(108, 62);
            this.btn_geri.TabIndex = 25;
            this.btn_geri.Text = "Geri Dön";
            this.btn_geri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(905, 618);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_gnc);
            this.Controls.Add(this.grid);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button btn_gnc;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_ilce;
        private System.Windows.Forms.TextBox txt_il;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_telno;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_tur;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_saha;
        private System.Windows.Forms.DateTimePicker dtp_tarih;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_saha;
        private System.Windows.Forms.ComboBox cmb_saat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_geri;
    }
}