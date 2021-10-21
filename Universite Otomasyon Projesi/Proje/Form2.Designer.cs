namespace Proje
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_sif = new System.Windows.Forms.TextBox();
            this.txt_sif2 = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tur = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_ad
            // 
            this.txt_ad.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.Location = new System.Drawing.Point(194, 38);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(111, 26);
            this.txt_ad.TabIndex = 1;
            // 
            // txt_sif
            // 
            this.txt_sif.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sif.Location = new System.Drawing.Point(194, 89);
            this.txt_sif.Name = "txt_sif";
            this.txt_sif.Size = new System.Drawing.Size(111, 26);
            this.txt_sif.TabIndex = 2;
            this.txt_sif.UseSystemPasswordChar = true;
            // 
            // txt_sif2
            // 
            this.txt_sif2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sif2.Location = new System.Drawing.Point(194, 146);
            this.txt_sif2.Name = "txt_sif2";
            this.txt_sif2.Size = new System.Drawing.Size(111, 26);
            this.txt_sif2.TabIndex = 3;
            this.txt_sif2.UseSystemPasswordChar = true;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.Transparent;
            this.btn_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.Image")));
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_kaydet.Location = new System.Drawing.Point(68, 249);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(86, 62);
            this.btn_kaydet.TabIndex = 4;
            this.btn_kaydet.Text = "Kayıt Ol";
            this.btn_kaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.Color.Transparent;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_geri.Image = ((System.Drawing.Image)(resources.GetObject("btn_geri.Image")));
            this.btn_geri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_geri.Location = new System.Drawing.Point(194, 249);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(86, 62);
            this.btn_geri.TabIndex = 5;
            this.btn_geri.Text = "Geri Dön";
            this.btn_geri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(41, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Şifre Tekrarı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(41, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kullanıcı Türü:";
            // 
            // txt_tur
            // 
            this.txt_tur.Enabled = false;
            this.txt_tur.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tur.Location = new System.Drawing.Point(194, 199);
            this.txt_tur.Name = "txt_tur";
            this.txt_tur.Size = new System.Drawing.Size(111, 26);
            this.txt_tur.TabIndex = 6;
            this.txt_tur.Text = "Müşteri";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(347, 336);
            this.Controls.Add(this.txt_tur);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_sif2);
            this.Controls.Add(this.txt_sif);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form2";
            this.Text = "Kayıt Ol";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_sif;
        private System.Windows.Forms.TextBox txt_sif2;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tur;
    }
}