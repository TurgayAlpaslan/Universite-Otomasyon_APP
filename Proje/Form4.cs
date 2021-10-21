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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private SqlConnection conn = new SqlConnection(Program.BaglantiCumlesi);
        DataSet ds = new DataSet();
        public int dt;

        public void GridiGuncelle()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sorgu = "Select * From tbl_kiralama";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, conn);

            DataTable tbl = new DataTable();
            da.Fill(tbl);
            grid.DataSource = tbl;

            conn.Close();
        }

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

        private void Form4_Load(object sender, EventArgs e)
        {
            sahaekleme();
            GridiGuncelle();

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sorgu = "Insert Into tbl_müsteri(müsteri_adi,müsteri_soyadi,müsteri_telno,müsteri_il,müsteri_ilce) Values(@müsteri_adi,@müsteri_soyadi,@müsteri_telno,@müsteri_il,@müsteri_ilce)";
            SqlCommand komut = new SqlCommand(sorgu, conn);
            komut.Parameters.AddWithValue("@müsteri_adi", txt_ad.Text);
            komut.Parameters.AddWithValue("@müsteri_soyadi", txt_soyad.Text);
            komut.Parameters.AddWithValue("@müsteri_telno", txt_telno.Text);
            komut.Parameters.AddWithValue("@müsteri_il", txt_il.Text);
            komut.Parameters.AddWithValue("@müsteri_ilce", txt_ilce.Text);

            komut.ExecuteNonQuery();
            conn.Close();


            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sorgu2 = "Insert Into tbl_kiralama(müsteri_ad,müsteri_soyad,müsteri_telno,kiralama_il,kiralama_ilce,kiralama_gün,kiralama_saat,kiralama_tür,kiralama_saha) Values(@müsteri_ad,@müsteri_soyad,@müsteri_telno,@kiralama_il,@kiralama_ilce,@kiralama_gün,@kiralama_saat,@kiralama_tür,@kiralama_saha)";
            SqlCommand komut2 = new SqlCommand(sorgu2, conn);
            komut2.Parameters.AddWithValue("@müsteri_ad", txt_ad.Text);
            komut2.Parameters.AddWithValue("@müsteri_soyad", txt_soyad.Text);
            komut2.Parameters.AddWithValue("@müsteri_telno", txt_telno.Text);
            komut2.Parameters.AddWithValue("@kiralama_il", txt_il.Text);
            komut2.Parameters.AddWithValue("@kiralama_ilce", txt_ilce.Text);
            komut2.Parameters.AddWithValue("@kiralama_saat", cmb_saat.Text);
            komut2.Parameters.AddWithValue("@kiralama_gün", new DateTime(dtp_tarih.Value.Year, dtp_tarih.Value.Month, dtp_tarih.Value.Day));
            komut2.Parameters.AddWithValue("@kiralama_tür", cmb_tur.Text);
            komut2.Parameters.AddWithValue("@kiralama_saha", cmb_saha.Text);

            komut2.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("İşlem Gerçekleşti.");
            GridiGuncelle();
        }

        private void btn_saha_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }

        private void btn_gnc_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count > 0)
            {
                try
                {
                    DialogResult cvp = MessageBox.Show(grid.CurrentRow.Cells["müsteri_ad"].Value.ToString() + " isimli kişinin kayıt bilgilerini güncellemek istediniz. Emin misiniz?", "Silme Onayı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    string sorgu3 = "Update tbl_kiralama Set müsteri_ad=@müsteri_ad, müsteri_soyad = @müsteri_soyad, müsteri_telno = @müsteri_telno,kiralama_il=@kiralama_il,kiralama_ilce=@kiralama_ilce,kiralama_saat=@kiralama_saat,kiralama_gün=@kiralama_gün,kiralama_tür=@kiralama_tür,kiralama_saha=@kiralama_saha Where kiralama_id = @kiralama_id";

                    SqlCommand komut3 = new SqlCommand(sorgu3, conn);
                    komut3.Parameters.AddWithValue("kiralama_id", Convert.ToInt32(txt_id.Text));
                    komut3.Parameters.AddWithValue("@müsteri_ad", txt_ad.Text);
                    komut3.Parameters.AddWithValue("@müsteri_soyad", txt_soyad.Text);
                    komut3.Parameters.AddWithValue("@müsteri_telno", txt_telno.Text);
                    komut3.Parameters.AddWithValue("@kiralama_il", txt_il.Text);
                    komut3.Parameters.AddWithValue("@kiralama_ilce", txt_ilce.Text);
                    komut3.Parameters.AddWithValue("@kiralama_saat", cmb_saat.Text);
                    komut3.Parameters.AddWithValue("@kiralama_gün", new DateTime(dtp_tarih.Value.Year, dtp_tarih.Value.Month, dtp_tarih.Value.Day));
                    komut3.Parameters.AddWithValue("@kiralama_tür", cmb_tur.Text);
                    komut3.Parameters.AddWithValue("@kiralama_saha", cmb_saha.Text);

                    komut3.ExecuteNonQuery();
                    conn.Close();

                    GridiGuncelle();



                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Hata Oluştu");
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }




        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count > 0)
            {
                try
                {
                    DialogResult cvp = MessageBox.Show(grid.CurrentRow.Cells["müsteri_ad"].Value.ToString() + " isimli müşteri kayıdını silmek istediniz. Emin misiniz?", "Silme Onayı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (cvp == System.Windows.Forms.DialogResult.OK)
                    {
                        if (conn.State == ConnectionState.Closed)
                            conn.Open();

                        string sorgu = "Delete From tbl_kiralama Where kiralama_id=@kiralama_id";
                        SqlCommand komut = new SqlCommand(sorgu, conn);
                        komut.Parameters.AddWithValue("@kiralama_id", Convert.ToInt32(txt_id.Text));
                        komut.ExecuteNonQuery();
                        conn.Close();
                        GridiGuncelle();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Hata Oluştu");
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }

        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dt = e.RowIndex;
            txt_id.Text = grid.Rows[dt].Cells[0].Value.ToString();
            txt_ad.Text = grid.Rows[dt].Cells[1].Value.ToString();
            txt_soyad.Text = grid.Rows[dt].Cells[2].Value.ToString();
            txt_telno.Text = grid.Rows[dt].Cells[3].Value.ToString();
            txt_il.Text = grid.Rows[dt].Cells[4].Value.ToString();
            txt_ilce.Text = grid.Rows[dt].Cells[5].Value.ToString();
            dtp_tarih.Text = grid.Rows[dt].Cells[6].Value.ToString();
            cmb_saat.Text = grid.Rows[dt].Cells[7].Value.ToString();
            cmb_tur.Text = grid.Rows[dt].Cells[8].Value.ToString();
            cmb_saha.Text = grid.Rows[dt].Cells[9].Value.ToString();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}

