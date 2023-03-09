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

namespace Sayac_Proje
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();

        public int urun;
        public decimal alacak, odeme, kalan;

        private void BtnListele_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(bgl.Adres);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select MUSTERIID,MUSTERIAD,TOPLAMALACAK,SonOdemeTarihi,TELEFON,Aciklama,MAIL from Tbl_Musteri ORDER BY MUSTERIID ASC ", conn);
                conn.Open();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Gerekli alanları doldurunuz...");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                TxtMusteriID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                TxtBorcAlacak.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
                MskTel.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
                txtAciklama.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
                TxtMail.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("Gerekli alanları doldurunuz...");
            }
            

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection conn = new SqlConnection(bgl.Adres);
                conn.Open();
                SqlCommand komut = new SqlCommand("update Tbl_Musteri set MUSTERIAD=@p1,TOPLAMALACAK=@p2,SonOdemeTarihi=@p3,TELEFON=@p4,MAIL=@p5,Aciklama=@p6 where MUSTERIID=@p7", conn);
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", Convert.ToDecimal(TxtBorcAlacak.Text));
                komut.Parameters.AddWithValue("@p3", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@p4", MskTel.Text);
                komut.Parameters.AddWithValue("@p5", TxtMail.Text);
                komut.Parameters.AddWithValue("@p6", txtAciklama.Text);
                
                komut.Parameters.AddWithValue("@p7", TxtMusteriID.Text);
                komut.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Güncellendi");
            }
            catch (Exception)
            {

                MessageBox.Show("Gerekli alanları doldurunuz...");
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection conn = new SqlConnection(bgl.Adres);
                //conn.Open();
                //SqlCommand komut = new SqlCommand("delete from Tbl_Musteri where MUSTERIID=@p1", conn);
                //komut.Parameters.AddWithValue("@p1", TxtMusteriID.Text);
                //komut.ExecuteNonQuery();
                //conn.Close();
                //MessageBox.Show("Silindi");
                TxtMusteriID.Text = "";
                txtAciklama.Text = "";
                TxtAd.Text = "";
                MskTel.Text = "";
                TxtMail.Text = "";
                TxtBorcAlacak.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Gerekli alanları doldurunuz...");
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            YakitKasasiRaporlar.CariGunlukRaporlar(dataGridView1);
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection conn = new SqlConnection(bgl.Adres);
                conn.Open();
                SqlCommand komut = new SqlCommand("insert into Tbl_Musteri(MUSTERIAD,TOPLAMALACAK,SonOdemeTarihi,TELEFON,MAIL,Aciklama) VALUES(@p1,@p2,@p3,@p4,@p5,@p6)", conn);
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtBorcAlacak.Text);
                komut.Parameters.AddWithValue("@p3", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@p4", MskTel.Text);
                komut.Parameters.AddWithValue("@p5", txtAciklama.Text);
                komut.Parameters.AddWithValue("@p6", TxtMail.Text);
                
                komut.ExecuteNonQuery();
                conn.Close();



                MessageBox.Show("Eklendi");
            }
            catch (Exception)
            {

                MessageBox.Show("Gerekli alanları doldurunuz...");
            }
        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(bgl.Adres);
                conn.Open();
                SqlCommand komut = new SqlCommand("select URUNID,URUNAD from Tbl_Urunn", conn);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Gerekli alanları doldurunuz...");
            }
        }
    }
}
