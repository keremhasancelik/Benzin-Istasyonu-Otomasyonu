using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sayac_Proje
{
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }

        Baglanti bgl = new Baglanti();

        public string tarih, tarih2;


        private void BtnListele_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(bgl.Adres);
            DataTable dt = new DataTable();
            //
            SqlDataAdapter da = new SqlDataAdapter("select SATISID,TARIH,MUSTERIAD,FISNO,URUNAD,SATLITRE,BFIYAT,SATISTUTAR,TAHSILAT,ACIKLAMA from Tbl_Satis INNER JOIN Tbl_Musteri ON Tbl_Satis.SATISMUSTERI=Tbl_Musteri.MUSTERIID INNER JOIN Tbl_Urunn ON Tbl_Satis.YAKITCINSI = Tbl_Urunn.URUNID ORDER BY SATISID DESC ", conn);
            //da.SelectCommand.Parameters.Add("@p1", SqlDbType.Date).Value = DateTime.Now;
            conn.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            decimal tutar = 0;
            decimal tahsilat = 0;
            double litre = 0.00;
            decimal fark = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                tahsilat += Convert.ToDecimal(dataGridView1.Rows[i].Cells[8].Value);
                tutar += Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value);
                litre += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
            }
            lblTahsilat.Text = $"Tahsilat: {tahsilat} ₺";
            lblTutar.Text = $"Satış: {tutar} ₺";
            lblLitre.Text = $"Litre: {litre} ";
            fark = tutar - tahsilat;
            lblFark.Text = $"Fark: {fark} ₺";
            conn.Close();
        }

        public int cari, urun;

        private void FrmSatis_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut = new SqlCommand("select URUNID,URUNAD from Tbl_Urunn", conn);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbUrun.DisplayMember = "URUNAD";
            cmbUrun.ValueMember = "URUNID";
            cmbUrun.DataSource = dt;

            //
            SqlCommand komut2 = new SqlCommand("select MUSTERIID,MUSTERIAD from Tbl_Musteri", conn);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            CmbCariAdi.DisplayMember = "MUSTERIAD";
            CmbCariAdi.ValueMember = "MUSTERIID";
            CmbCariAdi.DataSource = dt2;



            conn.Close();


        }

        private void cmbUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbBirimFiyati.Items.Clear();
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut3 = new SqlCommand("select BIRIMFIYATI from Tbl_Urunn where URUNAD=@p1", conn);
            komut3.Parameters.AddWithValue("@p1", cmbUrun.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbBirimFiyati.Items.Add(dr3[0]);
            }
            conn.Close();
        }

        public decimal tutar, birimfiyati, litre;



        private void BtnFiltrele_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select SATISID,TARIH,MUSTERIAD,FISNO,URUNAD,SATLITRE,BFIYAT,SATISTUTAR,TAHSILAT,ACIKLAMA from Tbl_Satis INNER JOIN Tbl_Musteri ON Tbl_Satis.SATISMUSTERI=Tbl_Musteri.MUSTERIID INNER JOIN Tbl_Urunn ON Tbl_Satis.YAKITCINSI = Tbl_Urunn.URUNID where TARIH between @p1 and @p2 ORDER BY SATISID DESC", conn);


            da.SelectCommand.Parameters.AddWithValue("@p1", SqlDbType.Date).Value = dateTimePicker1.Value;
            da.SelectCommand.Parameters.AddWithValue("@p2", SqlDbType.Date).Value = dateTimePicker2.Value;
            conn.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            decimal tutar = 0;
            decimal tahsilat = 0;
            double litre = 0.00;
            decimal fark = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                tahsilat += Convert.ToDecimal(dataGridView1.Rows[i].Cells[8].Value);
                tutar += Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value);
                litre += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
            }
            lblTahsilat.Text = $"Tahsilat: {tahsilat} ₺";
            lblTutar.Text = $"Satış: {tutar} ₺";
            lblLitre.Text = $"Litre: {litre} ";
            fark = tutar - tahsilat;
            lblFark.Text = $"Fark: {fark} ₺";
            conn.Close();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {


            if (txtAra.Text.Length >= 2)
            {
                SqlConnection conn = new SqlConnection(bgl.Adres);
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter("select SATISID,TARIH,MUSTERIAD,FISNO,URUNAD,SATLITRE,BFIYAT,SATISTUTAR,TAHSILAT,ACIKLAMA from Tbl_Satis INNER JOIN Tbl_Musteri ON Tbl_Satis.SATISMUSTERI=Tbl_Musteri.MUSTERIID INNER JOIN Tbl_Urunn ON Tbl_Satis.YAKITCINSI = Tbl_Urunn.URUNID where MUSTERIAD LIKE @search ORDER BY SATISID DESC", conn);
                da.SelectCommand.Parameters.AddWithValue("@search", "%" + txtAra.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                decimal tutar = 0;
                decimal tahsilat = 0;
                double litre = 0.00;
                decimal fark = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    tahsilat += Convert.ToDecimal(dataGridView1.Rows[i].Cells[8].Value);
                    tutar += Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value);
                    litre += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                }
                lblTahsilat.Text = $"Tahsilat: {tahsilat} ₺";
                lblTutar.Text = $"Satış: {tutar} ₺";
                lblLitre.Text = $"Litre: {litre} ";
                fark = tutar - tahsilat;
                lblFark.Text = $"Fark: {fark} ₺";
                conn.Close();
            }
        }

        private void txtFisNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtSatisID.Text = "";
            CmbCariAdi.Text = "";
            cmbToplamAlacak.Text = "";
            cmbUrun.Text = "";
            TxtMiktarLT.Text = "";
            CmbBirimFiyati.Text = "";
            TxtTutar.Text = "";
            txtFisNo.Text = "";
            TxtAciklama.Text = "";
            TxtTahsilar.Text = "";
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                litre = Convert.ToDecimal(TxtMiktarLT.Text);
            birimfiyati = Convert.ToDecimal(CmbBirimFiyati.Text);
            tutar = litre * birimfiyati;
            TxtTutar.Text = Convert.ToString(tutar);
            urun = int.Parse(cmbUrun.SelectedValue.ToString());
            cari = int.Parse(CmbCariAdi.SelectedValue.ToString());
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open(); SqlCommand komut = new SqlCommand("update Tbl_Satis set TARIH=@p1,SATISMUSTERI=@p2,FISNO=@p3,YAKITCINSI=@p4,SATLITRE=@p5,BFIYAT=@p6,SATISTUTAR=@p7,TAHSILAT=@p8,ACIKLAMA=@p9 where SATISID=@p10", conn);
            komut.Parameters.AddWithValue("@p1", dtSatisTarih.Value);
            komut.Parameters.AddWithValue("@p2", cari);
            komut.Parameters.AddWithValue("@p3", txtFisNo.Text);
            komut.Parameters.AddWithValue("@p4", urun);
            komut.Parameters.AddWithValue("@p5", Convert.ToDouble(TxtMiktarLT.Text));
            komut.Parameters.AddWithValue("@p6", Convert.ToDecimal(CmbBirimFiyati.Text));
            komut.Parameters.AddWithValue("@p7", tutar);
            komut.Parameters.AddWithValue("@p8", Convert.ToDecimal(TxtTahsilar.Text));
            komut.Parameters.AddWithValue("@p9", TxtAciklama.Text);
            komut.Parameters.AddWithValue("@p10", TxtSatisID.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Güncellendi");

            cari = int.Parse(CmbCariAdi.SelectedValue.ToString());
            tahsilat = Convert.ToDecimal(TxtTahsilar.Text);
            toplamalacak = Convert.ToDecimal(cmbToplamAlacak.Text);
            sonuc3 = toplamalacak - tahsilat;
            sonuc2 = toplamalacak + tutar;


            if (tahsilat < 1)
            {
                conn.Open();
                SqlCommand komut2 = new SqlCommand("update Tbl_Musteri set TOPLAMALACAK=@p1 where MUSTERIID=@p2", conn);
                komut2.Parameters.AddWithValue("@p1", sonuc2);
                komut2.Parameters.AddWithValue("@p2", cari);
                komut2.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                conn.Open();
                SqlCommand komut2 = new SqlCommand("update Tbl_Musteri set TOPLAMALACAK=@p1 where MUSTERIID=@p2", conn);
                komut2.Parameters.AddWithValue("@p1", sonuc3);
                komut2.Parameters.AddWithValue("@p2", cari);
                komut2.ExecuteNonQuery();
                conn.Close();
            }

        }
            catch (Exception)
            {

                MessageBox.Show("Tarih, cari, fiş no ve açıklama alanlarında güncelleme yapabilirsiniz.");
            }
}

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtSatisID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            dtSatisTarih.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            CmbCariAdi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtFisNo.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cmbUrun.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtMiktarLT.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            CmbBirimFiyati.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            TxtTutar.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            TxtTahsilar.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            TxtAciklama.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();

        }


        private void BtnYazdir_Click(object sender, EventArgs e)
        {

            try
            {
                YakitKasasiRaporlar.SatisGunlukRaporlar(dataGridView1);
            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu");
            }
            
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        private void printDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //int satir = dataGridView1.Rows.Count - 1;
            //int satir2 = dataGridView1.Rows.Count - 1;
            //int satir3 = dataGridView1.Rows.Count - 1;

            //decimal tutar = 0;
            //decimal tahsilat = 0;
            //double litre = 0.00;
            //for (int i = 0; i < satir; i++)
            //{
            //    tutar += decimal.Parse(dataGridView1.Rows[i].Cells["SATISTUTAR"].Value.ToString());
            //    tahsilat += decimal.Parse(dataGridView1.Rows[i].Cells["TAHSILAT"].Value.ToString());
            //    litre += double.Parse(dataGridView1.Rows[i].Cells["SATLITRE"].Value.ToString());
            //}

            //dataGridView1.Rows[satir].Cells["SATISTUTAR"].Value = tutar;
            //dataGridView1.Rows[satir3].Cells["TAHSILAT"].Value = tahsilat;
            //dataGridView1.Rows[satir2].Cells["SATLITRE"].Value = litre;
        }

        private void btnOnIzle_Click_1(object sender, EventArgs e)
        {
           
        }

        private void lblLitre_Click(object sender, EventArgs e)
        {

        }

        private void lblTutar_Click(object sender, EventArgs e)
        {

        }

        private void lblTahsilat_Click(object sender, EventArgs e)
        {

        }

        private void btnUrunGrubuFiltreleme_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("select SATISID,TARIH,MUSTERIAD,FISNO,URUNAD,SATLITRE,BFIYAT,SATISTUTAR,TAHSILAT,ACIKLAMA from Tbl_Satis INNER JOIN Tbl_Musteri ON Tbl_Satis.SATISMUSTERI=Tbl_Musteri.MUSTERIID INNER JOIN Tbl_Urunn ON Tbl_Satis.YAKITCINSI = Tbl_Urunn.URUNID where URUNAD LIKE @search ORDER BY SATISID DESC", conn);
            da.SelectCommand.Parameters.AddWithValue("@search", "%" + txtUrunGrubuFiltre.Text + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            decimal tutar = 0;
            decimal tahsilat = 0;
            double litre = 0.00;
            decimal fark = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                tahsilat += Convert.ToDecimal(dataGridView1.Rows[i].Cells[8].Value);
                tutar += Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value);
                litre += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
            }
            lblTahsilat.Text = $"Tahsilat: {tahsilat} ₺";
            lblTutar.Text = $"Satış: {tutar} ₺";
            lblLitre.Text = $"Litre: {litre} ";
            fark = tutar - tahsilat;
            lblFark.Text = $"Fark: {fark} ₺";
            conn.Close();
        }

        private void dtSatisTarih_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnOnizle_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(bgl.Adres);
                conn.Open();
                SqlCommand komut = new SqlCommand("delete from Tbl_Satis where SATISID=@p1", conn);
                komut.Parameters.AddWithValue("@p1", TxtSatisID.Text);
                komut.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Silindi");
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }
        }

        private void CmbCariAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbToplamAlacak.Items.Clear();
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut3 = new SqlCommand("select TOPLAMALACAK from Tbl_Musteri where MUSTERIAD=@p1", conn);
            komut3.Parameters.AddWithValue("@p1", CmbCariAdi.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbToplamAlacak.Items.Add(dr3[0]);
            }
            conn.Close();

        }

        public decimal tahsilat, sonuc2, sonuc3, toplamalacak;
        public DateTime sonOdemeTarihi;

        private void BtnEkle_Click(object sender, EventArgs e)
        {

            try
            {
                litre = Convert.ToDecimal(TxtMiktarLT.Text);
                birimfiyati = Convert.ToDecimal(CmbBirimFiyati.Text);
                tutar = litre * birimfiyati;
                TxtTutar.Text = Convert.ToString(tutar);
                urun = int.Parse(cmbUrun.SelectedValue.ToString());
                cari = int.Parse(CmbCariAdi.SelectedValue.ToString());
                sonOdemeTarihi = dtSatisTarih.Value;
                SqlConnection conn = new SqlConnection(bgl.Adres);
                conn.Open(); 
                SqlCommand komut = new SqlCommand("insert into Tbl_Satis(TARIH,SATISMUSTERI,FISNO,YAKITCINSI,SATLITRE,BFIYAT,SATISTUTAR,TAHSILAT,ACIKLAMA) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", conn);
                komut.Parameters.AddWithValue("@p1", dtSatisTarih.Value);
                komut.Parameters.AddWithValue("@p2", cari);
                komut.Parameters.AddWithValue("@p3", txtFisNo.Text);
                komut.Parameters.AddWithValue("@p4", urun);
                komut.Parameters.AddWithValue("@p5", Convert.ToDouble(TxtMiktarLT.Text));
                komut.Parameters.AddWithValue("@p6", Convert.ToDecimal(CmbBirimFiyati.Text));
                komut.Parameters.AddWithValue("@p7", tutar);
                komut.Parameters.AddWithValue("@p8", Convert.ToDecimal(TxtTahsilar.Text));
                komut.Parameters.AddWithValue("@p9", TxtAciklama.Text);
                komut.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Kaydedildi");


                cari = int.Parse(CmbCariAdi.SelectedValue.ToString());
                tahsilat = Convert.ToDecimal(TxtTahsilar.Text);
                toplamalacak = Convert.ToDecimal(cmbToplamAlacak.Text);
                sonuc3 = toplamalacak - tahsilat;
                sonuc2 = toplamalacak + tutar;


                if (tahsilat < 1)
                {
                    conn.Open();
                    SqlCommand komut2 = new SqlCommand("update Tbl_Musteri set TOPLAMALACAK=@p1 where MUSTERIID=@p2", conn);
                    komut2.Parameters.AddWithValue("@p1", sonuc2);
                    komut2.Parameters.AddWithValue("@p2", cari);
                    komut2.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    conn.Open();
                    SqlCommand komut2 = new SqlCommand("update Tbl_Musteri set TOPLAMALACAK=@p1 where MUSTERIID=@p2", conn);
                    komut2.Parameters.AddWithValue("@p1", sonuc3);
                    komut2.Parameters.AddWithValue("@p2", cari);
                    komut2.ExecuteNonQuery();

                    SqlCommand komut12 = new SqlCommand("update Tbl_Musteri set SonOdemeTarihi=@p2 where MUSTERIID=@p3", conn);
                    komut12.Parameters.AddWithValue("@p2", sonOdemeTarihi);
                    komut12.Parameters.AddWithValue("@p3", cari);
                    komut12.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Tahsilat girişi yapıyorsanız, miktar alanına 0 yazınız");
            }







        }
    }
}
