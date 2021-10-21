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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private SqlConnection conn = new SqlConnection(Program.BaglantiCumlesi);
        public int dt;

        public void GridiGuncelle()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sorgu = "Select * From tbl_saha";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, conn);

            DataTable tbl = new DataTable();
            da.Fill(tbl);
            grid.DataSource = tbl;

            conn.Close();
        }
       
       
        private void Form5_Load(object sender, EventArgs e)
        {
            GridiGuncelle();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count > 0)
            {
                try
                {
                    DialogResult cvp = MessageBox.Show(grid.CurrentRow.Cells["saha_Adi"].Value.ToString() + " isimli sahayı silmek istediniz. Emin misiniz?", "Silme Onayı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (cvp == System.Windows.Forms.DialogResult.OK)
                    {
                        if (conn.State == ConnectionState.Closed)
                            conn.Open();

                        string sorgu = "Delete From tbl_saha Where saha_id=@saha_id";
                        SqlCommand komut = new SqlCommand(sorgu, conn);
                        komut.Parameters.AddWithValue("@saha_id", Convert.ToInt32(txt_id.Text));
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

        private void btn_gnc_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count > 0 || grid.SelectedColumns.Count> 0)
            {
                try
                {
                    DialogResult cvp = MessageBox.Show(grid.CurrentRow.Cells["saha_Adi"].Value.ToString() + " isimli sahayı güncellemek istediniz. Emin misiniz?", "Silme Onayı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    string sorgu = "Update tbl_saha Set saha_adi=@saha_adi,saha_il=@saha_il,saha_ilce=@saha_ilce Where saha_id = @saha_id";

                    SqlCommand komut = new SqlCommand(sorgu, conn);
                    komut.Parameters.AddWithValue("saha_id", Convert.ToInt32(txt_id.Text));
                    komut.Parameters.AddWithValue("@saha_adi", txt_saha.Text);
                    komut.Parameters.AddWithValue("@saha_il", txt_il.Text);
                    komut.Parameters.AddWithValue("@saha_ilce", txt_ilce.Text);
                    komut.ExecuteNonQuery();
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
            else
            {
                MessageBox.Show("Satır seçiniz(Soldaki ok işareti)","Uyarı",MessageBoxButtons.OK);
            }

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sorgu = "Insert Into tbl_saha(saha_adi,müsteri_il,müsteri_ilce) Values(saha_adi,@müsteri_il,@müsteri_ilce)";
            SqlCommand komut = new SqlCommand(sorgu, conn);
            komut.Parameters.AddWithValue("@saha_adi", txt_saha.Text);
            komut.Parameters.AddWithValue("@saha_il", txt_il.Text);
            komut.Parameters.AddWithValue("@sahai_ilce", txt_ilce.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            GridiGuncelle();
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void grid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dt = e.RowIndex;
            //txt_id.Text = grid.Rows[dt].Cells[0].Value.ToString();
            //txt_saha.Text = grid.Rows[dt].Cells[1].Value.ToString();
            //txt_il.Text = grid.Rows[dt].Cells[2].Value.ToString();
            //txt_ilce.Text = grid.Rows[dt].Cells[3].Value.ToString();
            txt_id.Text = grid.CurrentRow.Cells[0].Value.ToString();
            txt_saha.Text = grid.CurrentRow.Cells[1].Value.ToString();
            txt_il.Text = grid.CurrentRow.Cells[2].Value.ToString();
            txt_ilce.Text = grid.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
