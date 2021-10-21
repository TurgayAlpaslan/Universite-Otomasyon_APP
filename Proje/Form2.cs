using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Proje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       private SqlConnection conn = new SqlConnection(Program.BaglantiCumlesi);

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_ad.Text == "" || txt_sif.Text == "" || txt_sif2.Text == "")
            {
                MessageBox.Show("Giriş bilgilerinizde eksiklik var");
                txt_ad.Clear();
                txt_sif.Clear();
                txt_sif2.Clear();
                txt_ad.Focus();
            }

            else if (txt_sif.Text != txt_sif2.Text)
            {
                MessageBox.Show("Girdiğiniz Şifreler Aynı Olmalı","Uyarı");
                txt_sif.Clear();
                txt_sif2.Clear();
                txt_sif.Focus();
}
            else
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    string sorgu = "Insert Into tbl_kullanici(kullanici_adi,kullanici_sifre,kullanici_türü) Values(@kullanici_adi,@kullanici_sifre,@kullanici_türü)";
                    SqlCommand komut = new SqlCommand(sorgu, conn);
                    komut.Parameters.AddWithValue("@kullanici_adi", txt_ad.Text);
                    komut.Parameters.AddWithValue("@kullanici_sifre", txt_sif.Text);         
                    komut.Parameters.AddWithValue("@kullanici_türü", txt_tur.Text);
                    komut.ExecuteNonQuery();
                    conn.Close();   
                    MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");

                    this.Close();
                    Form1 frm1 = new Form1();
                    frm1.Show();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
