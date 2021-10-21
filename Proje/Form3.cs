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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private SqlConnection conn = new SqlConnection(Program.BaglantiCumlesi);

        private void sahaekleme()
        {
            string sorgu = "Select * From tbl_saha";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, conn);
            DataTable tbl = new DataTable();
            da.Fill(tbl);

            cmb_saha.DisplayMember = "saha_adi";
            cmb_saha.ValueMember = "saha_id";
            cmb_saha.DataSource = tbl;


        }

        private void Form3_Load(object sender, EventArgs e)
        {
            sahaekleme();
        }

       
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sorgu = "Insert Into tbl_müsteri(müsteri_adi,müsteri_soyadi,müsteri_telno,müsteri_il,müsteri_ilce) Values(@müsteri_adi,@müsteri_soyadi,@müsteri_telno,@müsteri_il,@müsteri_ilce)";
            SqlCommand komut = new SqlCommand(sorgu, conn);
            komut.Parameters.AddWithValue("@müsteri_adi", txt_ad.Text);
            komut.Parameters.AddWithValue("@müsteri_soyadi", txt_soyad.Text);
            komut.Parameters.AddWithValue("@telno,müsteri", txt_telno.Text);
            komut.Parameters.AddWithValue("@müsteri_il", txt_il.Text);
            komut.Parameters.AddWithValue("@müsteri_ilce", txt_ilce.Text);

            komut.ExecuteNonQuery();
            conn.Close();


            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sorgu2 = "Insert Into tbl_kiralama(müsteri_ad,müsteri_soyadi,müsteri_telno,kiralama_il,kiralama_ilce,kiralama_gün,kiralama_saat,kiralama_tür,kiralama_saha) Values(@müsteri_adi,@müsteri_soyadi,@müsteri_telno,@kiralama_il,@kiralama_ilce,@kiralama_gün,@kiralama_saat,@kiralama_tür,@kiralama_saha)";
            SqlCommand komut2 = new SqlCommand(sorgu2, conn);
            komut2.Parameters.AddWithValue("@müsteri_adi", txt_ad.Text);
            komut2.Parameters.AddWithValue("@müsteri_soyadi", txt_soyad.Text);
            komut2.Parameters.AddWithValue("@telno,müsteri", txt_telno.Text);
            komut2.Parameters.AddWithValue("@kiralama_il", txt_il.Text);
            komut2.Parameters.AddWithValue("@kiralama_ilce", txt_ilce.Text);
            komut2.Parameters.AddWithValue("@kiralama_saat", cmb_saat.Text);
            komut2.Parameters.AddWithValue("@kiralama_gün", new DateTime(dtp_tarih.Value.Year, dtp_tarih.Value.Month, dtp_tarih.Value.Day));
            komut2.Parameters.AddWithValue("@kiralama_tür", cmb_tur.SelectedText);
            komut2.Parameters.AddWithValue("@saha_adi", cmb_saha.Text);

            komut.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("İşlem Gerçekleşti.");
        }

        private void btn_ipt_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
