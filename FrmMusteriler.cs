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
            SqlConnection conn = new SqlConnection(bgl.Adres);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select MUSTERIID,MUSTERIAD,URUNAD,MIKTAR,PLAKA,YAPTIGIODEME,KALANBORCU,TOPLAMALACAK,TELEFON,MAIL from Tbl_Musteri INNER JOIN Tbl_Urunn ON Tbl_Musteri.URNADI=Tbl_Urunn.URUNID ORDER BY MUSTERIID DESC ", conn);
            conn.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtMusteriID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            CmbUrunAdi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtMiktar.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtAlacak.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtOdeme.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            TxtBorcAlacak.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            TxtPlaka.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            MskTel.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            TxtMail.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            alacak = Convert.ToDecimal(TxtAlacak.Text);
            odeme = Convert.ToDecimal(TxtOdeme.Text);
            kalan = alacak - odeme;
            urun = int.Parse(CmbUrunAdi.SelectedValue.ToString());
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut = new SqlCommand("update Tbl_Musteri set MUSTERIAD=@p1,URNADI=@p2,MIKTAR=@p3,PLAKA=@p4,YAPTIGIODEME=@p5,KALANBORCU=@p6,TOPLAMALACAK=@p7,TELEFON=@p8,MAIL=@p9 where MUSTERIID=@p10", conn);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", urun);
            komut.Parameters.AddWithValue("@p3", Convert.ToDecimal(TxtMiktar.Text));
            komut.Parameters.AddWithValue("@p4", TxtPlaka.Text);
            komut.Parameters.AddWithValue("@p5", Convert.ToDecimal(TxtAlacak.Text));
            komut.Parameters.AddWithValue("@p6", Convert.ToDecimal(TxtOdeme.Text));
            komut.Parameters.AddWithValue("@p7", kalan);
            komut.Parameters.AddWithValue("@p8", MskTel.Text);
            komut.Parameters.AddWithValue("@p9", TxtMail.Text);
            komut.Parameters.AddWithValue("@p10", TxtMusteriID.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Güncellendi");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut = new SqlCommand("delete from Tbl_Musteri where MUSTERIID=@p1", conn);
            komut.Parameters.AddWithValue("@p1", TxtMusteriID.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Silindi");
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            alacak = Convert.ToDecimal(TxtAlacak.Text);
            odeme = Convert.ToDecimal(TxtOdeme.Text);
            kalan = alacak - odeme;
            urun = int.Parse(CmbUrunAdi.SelectedValue.ToString());
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Musteri(MUSTERIAD,URNADI,MIKTAR,PLAKA,YAPTIGIODEME,KALANBORCU,TOPLAMALACAK,TELEFON,MAIL) VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", conn);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", urun);
            komut.Parameters.AddWithValue("@p3", TxtMiktar.Text);
            komut.Parameters.AddWithValue("@p4", TxtPlaka.Text);
            komut.Parameters.AddWithValue("@p5", TxtAlacak.Text);
            komut.Parameters.AddWithValue("@p6", TxtOdeme.Text);
            komut.Parameters.AddWithValue("@p7", kalan);
            komut.Parameters.AddWithValue("@p8", MskTel.Text);
            komut.Parameters.AddWithValue("@p9", TxtMail.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Eklendi");
        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut = new SqlCommand("select URUNID,URUNAD from Tbl_Urunn", conn);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbUrunAdi.DisplayMember = "URUNAD";
            CmbUrunAdi.ValueMember = "URUNID";
            CmbUrunAdi.DataSource = dt;
            conn.Close();
        }
    }
}
