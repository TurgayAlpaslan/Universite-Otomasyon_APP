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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlCommand cmd;
        SqlDataReader dr;
        Boolean bln = false;
        private SqlConnection conn = new SqlConnection(Program.BaglantiCumlesi);
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btn_grs_Click(object sender, EventArgs e)
        {

            Boolean kont = false;
            cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM tbl_kullanici where kullanici_adi='" + txt_ad.Text + "' AND kullanici_sifre='" + txt_sif.Text + "'";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
                if (txt_ad.Text != "admin")
                {
                    kont = true;
                    MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız");
                    Form3 frm3 = new Form3();
                    frm3.Show();
                    this.Hide();
                   
                }
                if (txt_ad.Text == "admin" && bln==false) 
                {
                    kont = true;
                    MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız");
                    Form4 frm4 = new Form4();
                    frm4.Show();         
                    this.Hide();
                    
                }
            }
            if (kont != true)
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
                txt_ad.Text = "";
                txt_sif.Text = "";
            }
            conn.Close();




        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void btn_cks_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Projeyi Kapatmak İstiyor Musunuz", "Çıkış Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
                Application.Exit();
        }
    }
}
