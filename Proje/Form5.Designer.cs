namespace Proje
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_il = new System.Windows.Forms.TextBox();
            this.txt_ilce = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_gnc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_saha = new System.Windows.Forms.TextBox();
            this.btn_geri = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "İl :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(267, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "İlce :";
            // 
            // txt_il
            // 
            this.txt_il.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_il.Location = new System.Drawing.Point(117, 74);
            this.txt_il.Name = "txt_il";
            this.txt_il.Size = new System.Drawing.Size(113, 26);
            this.txt_il.TabIndex = 2;
            // 
            // txt_ilce
            // 
            this.txt_ilce.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ilce.Location = new System.Drawing.Point(354, 74);
            this.txt_ilce.Name = "txt_ilce";
            this.txt_ilce.Size = new System.Drawing.Size(121, 26);
            this.txt_ilce.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(-186, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 26);
            this.label8.TabIndex = 18;
            this.label8.Text = "İlçe :";
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.Transparent;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.Image = ((System.Drawing.Image)(resources.GetObject("btn_ekle.Image")));
            this.btn_ekle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ekle.Location = new System.Drawing.Point(117, 396);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(150, 57);
            this.btn_ekle.TabIndex = 21;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Transparent;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sil.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_sil.Image")));
            this.btn_sil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_sil.Location = new System.Drawing.Point(117, 463);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(5);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(150, 57);
            this.btn_sil.TabIndex = 20;
            this.btn_sil.Text = " Sil ";
            this.btn_sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_gnc
            // 
            this.btn_gnc.BackColor = System.Drawing.Color.Transparent;
            this.btn_gnc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_gnc.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gnc.ForeColor = System.Drawing.Color.White;
            this.btn_gnc.Image = ((System.Drawing.Image)(resources.GetObject("btn_gnc.Image")));
            this.btn_gnc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_gnc.Location = new System.Drawing.Point(301, 396);
            this.btn_gnc.Margin = new System.Windows.Forms.Padding(5);
            this.btn_gnc.Name = "btn_gnc";
            this.btn_gnc.Size = new System.Drawing.Size(150, 57);
            this.btn_gnc.TabIndex = 19;
            this.btn_gnc.Text = "Güncelle ";
            this.btn_gnc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_gnc.UseVisualStyleBackColor = false;
            this.btn_gnc.Click += new System.EventHandler(this.btn_gnc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(247, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Saha Adı :";
            // 
            // txt_saha
            // 
            this.txt_saha.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_saha.Location = new System.Drawing.Point(354, 26);
            this.txt_saha.Name = "txt_saha";
            this.txt_saha.Size = new System.Drawing.Size(121, 26);
            this.txt_saha.TabIndex = 22;
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.Color.Transparent;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_geri.ForeColor = System.Drawing.Color.White;
            this.btn_geri.Image = ((System.Drawing.Image)(resources.GetObject("btn_geri.Image")));
            this.btn_geri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_geri.Location = new System.Drawing.Point(301, 463);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(150, 57);
            this.btn_geri.TabIndex = 24;
            this.btn_geri.Text = "Geri Dön";
            this.btn_geri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(35, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "İd :";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(117, 22);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(113, 30);
            this.txt_id.TabIndex = 26;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(12, 138);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(541, 228);
            this.grid.TabIndex = 27;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick_1);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(577, 572);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.txt_saha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_gnc);
            this.Controls.Add(this.txt_ilce);
            this.Controls.Add(this.txt_il);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form5";
            this.Text = "Sahalar";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_il;
        private System.Windows.Forms.TextBox txt_ilce;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_gnc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_saha;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DataGridView grid;
    }
}