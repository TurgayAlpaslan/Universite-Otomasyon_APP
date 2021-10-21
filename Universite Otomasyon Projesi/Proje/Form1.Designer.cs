namespace Proje
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_cks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_sif = new System.Windows.Forms.TextBox();
            this.btn_grs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cks
            // 
            this.btn_cks.BackColor = System.Drawing.Color.Transparent;
            this.btn_cks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cks.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cks.Image = ((System.Drawing.Image)(resources.GetObject("btn_cks.Image")));
            this.btn_cks.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cks.Location = new System.Drawing.Point(198, 146);
            this.btn_cks.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cks.Name = "btn_cks";
            this.btn_cks.Size = new System.Drawing.Size(86, 62);
            this.btn_cks.TabIndex = 1;
            this.btn_cks.Text = "Çıkış";
            this.btn_cks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cks.UseVisualStyleBackColor = false;
            this.btn_cks.Click += new System.EventHandler(this.btn_cks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(78, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(135, 220);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 62);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kayıt Ol";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(189, 36);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(111, 30);
            this.txt_ad.TabIndex = 1;
            // 
            // txt_sif
            // 
            this.txt_sif.Location = new System.Drawing.Point(189, 88);
            this.txt_sif.Name = "txt_sif";
            this.txt_sif.Size = new System.Drawing.Size(111, 30);
            this.txt_sif.TabIndex = 1;
            this.txt_sif.UseSystemPasswordChar = true;
            // 
            // btn_grs
            // 
            this.btn_grs.BackColor = System.Drawing.Color.Transparent;
            this.btn_grs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_grs.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_grs.ForeColor = System.Drawing.Color.Black;
            this.btn_grs.Image = ((System.Drawing.Image)(resources.GetObject("btn_grs.Image")));
            this.btn_grs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_grs.Location = new System.Drawing.Point(70, 146);
            this.btn_grs.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_grs.Name = "btn_grs";
            this.btn_grs.Size = new System.Drawing.Size(86, 62);
            this.btn_grs.TabIndex = 0;
            this.btn_grs.Text = "Giriş";
            this.btn_grs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_grs.UseVisualStyleBackColor = false;
            this.btn_grs.Click += new System.EventHandler(this.btn_grs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(337, 310);
            this.Controls.Add(this.txt_sif);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cks);
            this.Controls.Add(this.btn_grs);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.Text = "Halı Saha Otomasyon Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_sif;
        private System.Windows.Forms.Button btn_grs;
    }
}

