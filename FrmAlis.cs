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
    public partial class FrmAlis : Form
    {
        public FrmAlis()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        public decimal t_stok,miktar,stok;

        private void BtnListele_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select ALISID,TARIH,URUNAD,BFIYATI,MIKTAR,STK,FATURABEDELI,ODEME,KALANBAKIYE,TEDFIRMA from Tbl_Alis INNER JOIN Tbl_Tedarikci ON Tbl_Alis.TEDARIKCI=Tbl_Tedarikci.TEDID INNER JOIN Tbl_Urunn ON Tbl_Alis.URNAD=Tbl_Urunn.URUNID ORDER BY ALISID DESC ", conn);
            conn.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            litre = 0;
            fbedeli = 0;
            odeme = 0;
            kalan = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                litre += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                fbedeli += Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value);
                odeme += Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value);
                kalan += Convert.ToDecimal(dataGridView1.Rows[i].Cells[8].Value);
            }
            lblToplamAlisLitre.Text = $"Toplam Alış (LT): {litre} ";
            lblToplamFatura.Text = $"Toplam Fatura Bedeli (TL): {fbedeli} ₺";
            lblToplamOdeme.Text = $"Toplam Ödeme (TL): {odeme} ₺";
            lblKalanToplam.Text = $"Kalan Toplam (TL): {kalan} ₺";
            conn.Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                fbedeli = Convert.ToDecimal(TxtFaturaBedeli.Text);
                odeme = Convert.ToDecimal(TxtOdeme.Text);
                kalan = fbedeli - odeme;
                stok = Convert.ToDecimal(CmbStok.Text);
                miktar = Convert.ToDecimal(TxtMiktarLT.Text);
                t_stok = miktar + stok;
                urun = int.Parse(CmbUrunAdi.SelectedValue.ToString());
                tedarikci = int.Parse(CmbTedarikci.SelectedValue.ToString());
                SqlConnection conn = new SqlConnection(bgl.Adres);
                conn.Open(); SqlCommand komut = new SqlCommand("update Tbl_Alis set URNAD=@p1,BFIYATI=@p2,MIKTAR=@p3,STK=@p4,FATURABEDELI=@p5,ODEME=@p6,KALANBAKIYE=@p7,TEDARIKCI=@p8 where ALISID=@p9", conn);
                komut.Parameters.AddWithValue("@p1", urun);
                komut.Parameters.AddWithValue("@p2", Convert.ToDecimal(CmbBirimFiyati.Text));
                komut.Parameters.AddWithValue("@p3", Convert.ToDecimal(TxtMiktarLT.Text));
                komut.Parameters.AddWithValue("@p4", Convert.ToDecimal(CmbStok.Text));
                komut.Parameters.AddWithValue("@p5", Convert.ToDecimal(TxtFaturaBedeli.Text));
                komut.Parameters.AddWithValue("@p6", Convert.ToDecimal(TxtOdeme.Text));
                komut.Parameters.AddWithValue("@p7", Convert.ToDecimal(kalan));
                komut.Parameters.AddWithValue("@p8", tedarikci);
                komut.Parameters.AddWithValue("@p9", TxtAlisID.Text);
                komut.ExecuteNonQuery();
                conn.Close();
                //
                conn.Open();
                SqlCommand komut2 = new SqlCommand("update Tbl_Urunn set STOK=@p1 where URUNID=@p2", conn);
                komut2.Parameters.AddWithValue("@p1", t_stok);
                komut2.Parameters.AddWithValue("@p2", urun);
                komut2.ExecuteNonQuery();
                conn.Close();
                //
                conn.Open();
                SqlCommand komut3 = new SqlCommand("update Tbl_Tedarikci set TEDODEME=@p1,TEDBORC=@p2,TEDBORCALACAK=@p3 where TEDID=@p4", conn);
                komut3.Parameters.AddWithValue("@p1", Convert.ToDecimal(TxtOdeme.Text));
                komut3.Parameters.AddWithValue("@p2", Convert.ToDecimal(TxtFaturaBedeli.Text));
                komut3.Parameters.AddWithValue("@p3", Convert.ToDecimal(TxtKalanBakiye.Text));
                komut3.Parameters.AddWithValue("@p4", tedarikci);
                komut3.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Güncellendi");
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAlisID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            dtAlisTarih.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            CmbUrunAdi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbBirimFiyati.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtMiktarLT.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            
            CmbStok.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtFaturaBedeli.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            TxtOdeme.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            TxtKalanBakiye.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            CmbTedarikci.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();

        }

        public int urun,tedarikci;
        decimal fbedeli,odeme,kalan,litre;
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                fbedeli = Convert.ToDecimal(TxtFaturaBedeli.Text);
                odeme = Convert.ToDecimal(TxtOdeme.Text);
                kalan = fbedeli - odeme;
                stok = Convert.ToDecimal(CmbStok.Text);
                miktar = Convert.ToDecimal(TxtMiktarLT.Text);
                t_stok = miktar + stok;
                urun = int.Parse(CmbUrunAdi.SelectedValue.ToString());
                tedarikci = int.Parse(CmbTedarikci.SelectedValue.ToString());
                SqlConnection conn = new SqlConnection(bgl.Adres);
                conn.Open(); SqlCommand komut = new SqlCommand("insert into Tbl_Alis(TARIH,URNAD,BFIYATI,MIKTAR,STK,FATURABEDELI,ODEME,KALANBAKIYE,TEDARIKCI) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", conn);
                komut.Parameters.AddWithValue("@p1", dtAlisTarih.Value);
                komut.Parameters.AddWithValue("@p2", urun);
                komut.Parameters.AddWithValue("@p3", Convert.ToDecimal(CmbBirimFiyati.Text));
                komut.Parameters.AddWithValue("@p4", Convert.ToDecimal(TxtMiktarLT.Text));
                komut.Parameters.AddWithValue("@p5", Convert.ToDecimal(CmbStok.Text));
                komut.Parameters.AddWithValue("@p6", Convert.ToDecimal(TxtFaturaBedeli.Text));
                komut.Parameters.AddWithValue("@p7", Convert.ToDecimal(TxtOdeme.Text));
                komut.Parameters.AddWithValue("@p8", kalan);
                komut.Parameters.AddWithValue("@p9", tedarikci);
                komut.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                SqlCommand komut2 = new SqlCommand("update Tbl_Urunn set STOK=@p1 where URUNID=@p2", conn);
                komut2.Parameters.AddWithValue("@p1", t_stok);
                komut2.Parameters.AddWithValue("@p2", urun);
                komut2.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                SqlCommand komut3 = new SqlCommand("update Tbl_Tedarikci set TEDODEME=@p1,TEDBORC=@p2,TEDBORCALACAK=@p3 where TEDID=@p4", conn);
                komut3.Parameters.AddWithValue("@p1", Convert.ToDecimal(TxtOdeme.Text));
                komut3.Parameters.AddWithValue("@p2", Convert.ToDecimal(TxtFaturaBedeli.Text));
                komut3.Parameters.AddWithValue("@p3", Convert.ToDecimal(TxtKalanBakiye.Text));
                komut3.Parameters.AddWithValue("@p4", tedarikci);
                komut3.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Eklendi");
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }
            
            //
            
            
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            fbedeli = Convert.ToDecimal(TxtFaturaBedeli.Text);
            odeme = Convert.ToDecimal(TxtOdeme.Text);
            kalan = fbedeli - odeme;
            TxtKalanBakiye.Text = kalan.ToString();
        }

        private void CmbStok_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnFiltrele_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("select ALISID,TARIH,URUNAD,BFIYATI,MIKTAR,STK,FATURABEDELI,ODEME,KALANBAKIYE,TEDFIRMA from Tbl_Alis INNER JOIN Tbl_Tedarikci ON Tbl_Alis.TEDARIKCI=Tbl_Tedarikci.TEDID INNER JOIN Tbl_Urunn ON Tbl_Alis.URNAD = Tbl_Urunn.URUNID where TARIH between @p1 and @p2 ORDER BY ALISID DESC", conn);
            da.SelectCommand.Parameters.AddWithValue("@p1", SqlDbType.Date).Value = dateTimePicker1.Value;
            da.SelectCommand.Parameters.AddWithValue("@p2", SqlDbType.Date).Value = dateTimePicker2.Value;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            litre = 0;
            fbedeli = 0;
            odeme = 0;
            kalan = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                litre += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                fbedeli += Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value);
                odeme += Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value);
                kalan += Convert.ToDecimal(dataGridView1.Rows[i].Cells[8].Value);
            }
            lblToplamAlisLitre.Text = $"Toplam Alış (LT): {litre} ";
            lblToplamFatura.Text = $"Toplam Fatura Bedeli (TL): {fbedeli} ₺";
            lblToplamOdeme.Text = $"Toplam Ödeme (TL): {odeme} ₺";
            lblKalanToplam.Text = $"Kalan Toplam (TL): {kalan} ₺";
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YakitKasasiRaporlar.AlisGunlukRaporlar(dataGridView1);
        }

        private void btnUrunGrubuFiltreleme_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("select ALISID,TARIH,URUNAD,BFIYATI,MIKTAR,STK,FATURABEDELI,ODEME,KALANBAKIYE,TEDFIRMA from Tbl_Alis INNER JOIN Tbl_Tedarikci ON Tbl_Alis.TEDARIKCI=Tbl_Tedarikci.TEDID INNER JOIN Tbl_Urunn ON Tbl_Alis.URNAD = Tbl_Urunn.URUNID where URUNAD LIKE @search ORDER BY ALISID DESC", conn);
            da.SelectCommand.Parameters.AddWithValue("@search", "%" + txtUrunGrubuFiltre.Text + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            litre = 0;
            fbedeli = 0;
            odeme = 0;
            kalan = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                litre += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                fbedeli += Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value);
                odeme += Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value);
                kalan += Convert.ToDecimal(dataGridView1.Rows[i].Cells[8].Value);
            }
            lblToplamAlisLitre.Text = $"Toplam Alış (LT): {litre} ";
            lblToplamFatura.Text = $"Toplam Fatura Bedeli (TL): {fbedeli} ₺";
            lblToplamOdeme.Text = $"Toplam Ödeme (TL): {odeme} ₺";
            lblKalanToplam.Text = $"Kalan Toplam (TL): {kalan} ₺";
            conn.Close();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAlisID.Text = "";
            CmbUrunAdi.Text="";
            CmbBirimFiyati.Text = "";
            TxtMiktarLT.Text = "";
            CmbTedarikci.Text = "";
            CmbStok.Text = "";
            TxtFaturaBedeli.Text = "";
            TxtOdeme.Text = "";
            TxtKalanBakiye.Text = "";
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmAlis_Load(object sender, EventArgs e)
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
            //
            SqlCommand komut2 = new SqlCommand("select TEDID,TEDFIRMA from Tbl_Tedarikci", conn);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            CmbTedarikci.DisplayMember = "TEDFIRMA";
            CmbTedarikci.ValueMember = "TEDID";
            CmbTedarikci.DataSource = dt2;
    
            conn.Close();
        }

        private void CmbUrunAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbBirimFiyati.Items.Clear();
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut3 = new SqlCommand("select BIRIMFIYATIALIS from Tbl_Urunn where URUNAD=@p1", conn);
            komut3.Parameters.AddWithValue("@p1", CmbUrunAdi.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbBirimFiyati.Items.Add(dr3[0]);
            }  
            conn.Close();
        }

        private void CmbBirimFiyati_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbStok.Items.Clear();
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut3 = new SqlCommand("select STOK from Tbl_Urunn where URUNAD=@p1", conn);
            komut3.Parameters.AddWithValue("@p1", CmbUrunAdi.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbStok.Items.Add(dr3[0]);
            }
            conn.Close();
        }
    }
}
