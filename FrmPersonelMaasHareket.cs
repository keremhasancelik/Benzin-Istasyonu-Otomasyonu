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

namespace Sayac_Proje
{
    public partial class FrmPersonelMaasHareket : Form
    {
        public FrmPersonelMaasHareket()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        private void FrmPersonelMaasHareket_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            SqlCommand komut2 = new SqlCommand("select PERID,PERAD from Tbl_Personel", conn);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cmbGiderPersonel.DisplayMember = "PERAD";
            cmbGiderPersonel.ValueMember = "PERID";
            cmbGiderPersonel.DataSource = dt2;
        }

        double kalanmaas, avans, kalan, toplamAlinanAvans, alinanToplamAvans, maasArttir, maasKalan;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnFiltrele_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_PersonelHareket where tarih between @p1 and @p2 ORDER BY id DESC", conn);
            conn.Open();
            da.SelectCommand.Parameters.AddWithValue("@p1", SqlDbType.Date).Value = dateTimePicker3.Value;
            da.SelectCommand.Parameters.AddWithValue("@p2", SqlDbType.Date).Value = dateTimePicker2.Value;
            
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btnUrunGrubuFiltreleme_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);

            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_PersonelHareket where PersonelAd LIKE @search ORDER BY id DESC", conn);
            conn.Open();
            da.SelectCommand.Parameters.AddWithValue("@search", "%" + txtPersonelAdiFiltre.Text + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            YakitKasasiRaporlar.PersonelMaasHareketRaporlar(dataGridView1);
        }

        int personel;

        private void btnListele_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_PersonelHareket", conn);
            conn.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand komut = new SqlCommand("select sum(PersonelAvans) from Tbl_PersonelHareket WHERE PersonelAd=@p1", conn);
            komut.Parameters.AddWithValue("@p1", cmbGiderPersonel.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtToplamAlinanAvans.Text = dr[0].ToString();
            }
            conn.Close();
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                maasArttir = Convert.ToDouble(txtMaasArttir.Text);
                personel = int.Parse(cmbGiderPersonel.SelectedValue.ToString());
                kalanmaas = Convert.ToDouble(cmbPersonelKalanMaas.Text);
                maasKalan = maasArttir + kalanmaas;
                avans = Convert.ToDouble(txtAvans.Text);
                kalan = maasKalan - avans;
                toplamAlinanAvans = Convert.ToDouble(txtToplamAlinanAvans.Text);
                alinanToplamAvans = avans + toplamAlinanAvans;
            }
            catch (Exception)
            {

                MessageBox.Show("Hata");
            }
            
            try
            {

                SqlConnection conn = new SqlConnection(bgl.Adres);
                conn.Open();
                SqlCommand komut = new SqlCommand("insert into Tbl_PersonelHareket(tarih,PersonelAd,PersonelAvans,PersonelKalanMaas,ToplamAlinanAvans,MaasArtisi,Aciklama) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", conn);
                komut.Parameters.AddWithValue("@p1", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@p2", cmbGiderPersonel.Text);
                komut.Parameters.AddWithValue("@p3", avans);
                komut.Parameters.AddWithValue("@p4", kalan);
                komut.Parameters.AddWithValue("@p5", alinanToplamAvans);
                komut.Parameters.AddWithValue("@p6", maasArttir);
                komut.Parameters.AddWithValue("@p7", txtAciklama.Text);
                komut.ExecuteNonQuery();

                conn.Close();


                conn.Open();
                SqlCommand komut7 = new SqlCommand("update Tbl_Personel set PERKALANMAAS=@p1, PERAVANS=@p2 where PERID=@p3", conn);
                komut7.Parameters.AddWithValue("@p1", kalan);
                komut7.Parameters.AddWithValue("@p2", alinanToplamAvans);
                komut7.Parameters.AddWithValue("@p3", personel);
                komut7.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Avans eklendi.");


            }
            catch (Exception)
            {

                MessageBox.Show("Personelle ilgili ilk kez veri girişi yapıyorsanız, Toplam Avans alanını boş bırakmayarak 0 yazabilirsiniz. " +
                    "İlgili alanları doldurarak işlemi yeniden deneyiniz.");
            }


        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                maasArttir = Convert.ToDouble(txtMaasArttir.Text);
                kalanmaas = Convert.ToDouble(cmbPersonelKalanMaas.Text);
                maasKalan = maasArttir + kalanmaas;
                avans = Convert.ToDouble(txtAvans.Text);
                kalan = maasKalan - avans;
                txtSonuc.Text = kalan.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Maaş arttırma işlemi yapmıyorsanız 0 yazınız, ve avans bölümünü boş bırakmayınız");
            }

        }

        private void cmbGiderPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbPersonelKalanMaas.Items.Clear();
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut123 = new SqlCommand("select PERKALANMAAS from Tbl_Personel where PERAD=@p1", conn);
            komut123.Parameters.AddWithValue("@p1", cmbGiderPersonel.Text);
            SqlDataReader dr123 = komut123.ExecuteReader();
            while (dr123.Read())
            {
                cmbPersonelKalanMaas.Items.Add(dr123[0]);
            }
            conn.Close();
        }
    }
}
