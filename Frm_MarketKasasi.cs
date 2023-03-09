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
    public partial class Frm_MarketKasasi : Form
    {
        public Frm_MarketKasasi()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_MarketKasasi_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut2 = new SqlCommand("select PERID,PERAD from Tbl_Personel", conn);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cmbKasiyer.DisplayMember = "PERAD";
            cmbKasiyer.ValueMember = "PERID";
            cmbKasiyer.DataSource = dt2;

            SqlCommand komut5 = new SqlCommand("select PERID,PERAD from Tbl_Personel", conn);
            SqlDataAdapter da5 = new SqlDataAdapter(komut5);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            cmbMuhasebeci.DisplayMember = "PERAD";
            cmbMuhasebeci.ValueMember = "PERID";
            cmbMuhasebeci.DataSource = dt5;
            conn.Close();

            //
            SqlConnection con = new SqlConnection(bgl.Adres);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Get_LastMarketKasasiId";
            cmd.Connection = con;
            con.Open();
            object obj = cmd.ExecuteScalar();
            label24.Text = obj.ToString();
            con.Close();

            //

            SqlConnection connn = new SqlConnection(bgl.Adres);
            DataTable dt22 = new DataTable();
            DataTable dt23 = new DataTable();
            DataTable dt24 = new DataTable();
            DataTable dt25 = new DataTable();
            DataTable dt26 = new DataTable();
            DataTable dt27 = new DataTable();
            DataTable dt28 = new DataTable();
            DataTable dt29 = new DataTable();
            DataTable dt30 = new DataTable();
            DataTable dt31 = new DataTable();
            DataTable dt32 = new DataTable();
            SqlDataAdapter da22 = new SqlDataAdapter("select id,tarih,kasiyer,muhasebeci from Tbl_MarketKasasi where Tbl_MarketKasasi.id = @id", connn);
            SqlDataAdapter da23 = new SqlDataAdapter("select zRaporu,otomasyonToplam,gunSonu1,gunSonu2 from Tbl_MarketKasasi where Tbl_MarketKasasi.id = @id", connn);
            SqlDataAdapter da24 = new SqlDataAdapter("select kartToplam,nakit,veresiyeToplam,muhasebeTeslim from Tbl_MarketKasasi where Tbl_MarketKasasi.id = @id", connn);
            SqlDataAdapter da25 = new SqlDataAdapter("select gider,giderFisNo,giderAciklama from Tbl_MarketKasasi where Tbl_MarketKasasi.id = @id", connn);
            SqlDataAdapter da26 = new SqlDataAdapter("select gelir,gelirFisNo,gelirAciklama from Tbl_MarketKasasi where Tbl_MarketKasasi.id = @id", connn);
            SqlDataAdapter da27 = new SqlDataAdapter("select toplam,acik,fazla from Tbl_MarketKasasi where Tbl_MarketKasasi.id = @id", connn);
            SqlDataAdapter da28 = new SqlDataAdapter("select tahsilat,tahsilatFisNo,tahsilatAciklama from Tbl_MarketKasasi where Tbl_MarketKasasi.id = @id", connn);
            SqlDataAdapter da29 = new SqlDataAdapter("select vardiyaNotu from Tbl_MarketKasasi where Tbl_MarketKasasi.id = @id", connn);
            //SqlDataAdapter da30 = new SqlDataAdapter("select yakitLitre,yakitTutar from Tbl_MarketKasasi where Tbl_MarketKasasi.id = @id", connn);
            //SqlDataAdapter da31 = new SqlDataAdapter("select benzinStok,motorinStok,lpgStok from Tbl_MarketKasasi where Tbl_MarketKasasi.id = @id", connn);
            SqlDataAdapter da32 = new SqlDataAdapter("select * from Tbl_MarketKasasi where Tbl_MarketKasasi.id = @id", connn);

            da22.SelectCommand.Parameters.Add("@id", obj);
            da23.SelectCommand.Parameters.Add("@id", obj);
            da24.SelectCommand.Parameters.Add("@id", obj);
            da25.SelectCommand.Parameters.Add("@id", obj);
            da26.SelectCommand.Parameters.Add("@id", obj);
            da27.SelectCommand.Parameters.Add("@id", obj);
            da28.SelectCommand.Parameters.Add("@id", obj);
            da29.SelectCommand.Parameters.Add("@id", obj);
            //da30.SelectCommand.Parameters.Add("@id", obj);
            //da31.SelectCommand.Parameters.Add("@id", obj);
            da32.SelectCommand.Parameters.Add("@id", obj);
            connn.Open();
            da22.Fill(dt22);
            da23.Fill(dt23);
            da24.Fill(dt24);
            da25.Fill(dt25);
            da26.Fill(dt26);
            da27.Fill(dt27);
            da28.Fill(dt28);
            da29.Fill(dt29);
            //da30.Fill(dt30);
            //da31.Fill(dt31);
            da32.Fill(dt32);
            dataGridView1.DataSource = dt22;
            dataGridView2.DataSource = dt23;
            dataGridView3.DataSource = dt24;
            dataGridView4.DataSource = dt25;
            dataGridView5.DataSource = dt26;
            dataGridView6.DataSource = dt27;
            dataGridView7.DataSource = dt28;
            dataGridView8.DataSource = dt29;
            //dataGridView9.DataSource = dt30;
            //dataGridView10.DataSource = dt31;
            dataGridView9.DataSource = dt32;
            connn.Close();


        }

        double gunSonu1, gunSonu2, kartToplam, tahsilatTutar, acik, fazla, zRaporu;

        private void btnGorListele_Click(object sender, EventArgs e)
        {
            FrmMarketTumunuListele frm = new FrmMarketTumunuListele();
            frm.ShowDialog();
        }

        private void btnOnizle_Click(object sender, EventArgs e)
        {
            YakitKasasiRaporlar.MarketKAsasiGunlukRaporlar(dataGridView9);
        }

        double nakit, veresiye, kasaTeslim, otomasyon, acikFazla, genelToplam, gider, gelir;
        string kasiyer, muhasebeci;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                tahsilatTutar = Convert.ToDouble(txtTahsilat.Text);
                zRaporu = Convert.ToDouble(txtZraporu.Text);
                kasiyer = cmbKasiyer.Text;
                muhasebeci = cmbMuhasebeci.Text;

                //
                gunSonu1 = Convert.ToDouble(txtpos1.Text);
                gunSonu2 = Convert.ToDouble(txtpos2.Text);
                kartToplam = gunSonu1 + gunSonu2;

                //
                nakit = Convert.ToDouble(txtNakit.Text);
                gelir = Convert.ToDouble(txtGelir.Text);
                veresiye = Convert.ToDouble(txtVeresiye.Text);
                kasaTeslim = Convert.ToDouble(txtKasaTeslim.Text);
                otomasyon = Convert.ToDouble(txtOtomasyon.Text);
                gider = Convert.ToDouble(txtGiderTutar.Text);

                genelToplam = nakit + veresiye + kasaTeslim + kartToplam + gider;
                acikFazla = otomasyon - genelToplam;
            }
            catch (Exception)
            {

                MessageBox.Show("Eksik alanları doldurunuz");
            }
            

            if (genelToplam < otomasyon)
            {
                acik = Math.Round(acikFazla, 2);
            }
            else if (genelToplam > otomasyon)
            {
                fazla = Math.Round(acikFazla, 2);
            }
            else
            {
                acik = 0;
                fazla = 0;
            }
            try
            {
                SqlConnection conn = new SqlConnection(bgl.Adres);
                conn.Open();
                SqlCommand komut = new SqlCommand("insert into Tbl_MarketKasasi(zRaporu,otomasyonToplam,gunSonu1,gunSonu2,kartToplam,nakit,veresiyeToplam,muhasebeTeslim,gider,giderFisNo,giderAciklama,gelir,gelirFisNo,gelirAciklama,toplam,acik,fazla,tahsilat,tahsilatFisNo,tahsilatAciklama,kasiyer,muhasebeci,vardiyaNotu,tarih) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18,@p19,@p20,@p21,@p22,@p23,@p24)", conn);
                komut.Parameters.AddWithValue("@p1", zRaporu);
                komut.Parameters.AddWithValue("@p2", otomasyon);
                komut.Parameters.AddWithValue("@p3", gunSonu1);
                komut.Parameters.AddWithValue("@p4", gunSonu2);
                komut.Parameters.AddWithValue("@p5", kartToplam);
                komut.Parameters.AddWithValue("@p6", nakit);
                komut.Parameters.AddWithValue("@p7", veresiye);
                komut.Parameters.AddWithValue("@p8", kasaTeslim);
                komut.Parameters.AddWithValue("@p9", gider);
                komut.Parameters.AddWithValue("@p10", txtGiderFisNo.Text);
                komut.Parameters.AddWithValue("@p11", txtGiderAciklama.Text);
                komut.Parameters.AddWithValue("@p12", gelir);
                komut.Parameters.AddWithValue("@p13", txtGelirFisNo.Text);
                komut.Parameters.AddWithValue("@p14", txtGelirAciklama.Text);
                komut.Parameters.AddWithValue("@p15", genelToplam);
                komut.Parameters.AddWithValue("@p16", acik);
                komut.Parameters.AddWithValue("@p17", fazla);
                komut.Parameters.AddWithValue("@p18", tahsilatTutar);
                komut.Parameters.AddWithValue("@p19", txtTahsilatFisNo.Text);
                komut.Parameters.AddWithValue("@p20", txtTahsilatAciklama.Text);
                komut.Parameters.AddWithValue("@p21", kasiyer);
                komut.Parameters.AddWithValue("@p22", muhasebeci);
                komut.Parameters.AddWithValue("@p23", txtVardiyaNotu.Text);
                komut.Parameters.AddWithValue("@p24", dtYakitKasaTarih.Value);
                komut.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Kaydedildi");
            }
            catch (Exception)
            {

                MessageBox.Show("Eksik alanları doldurunuz");
            }
            
        }

      
        private void btnGenelToplamHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                nakit = Convert.ToDouble(txtNakit.Text);
                veresiye = Convert.ToDouble(txtVeresiye.Text);
                kasaTeslim = Convert.ToDouble(txtKasaTeslim.Text);
                otomasyon = Convert.ToDouble(txtOtomasyon.Text);
                gider = Convert.ToDouble(txtGiderTutar.Text);
                kartToplam = gunSonu1 + gunSonu2;
                genelToplam = nakit + veresiye + kasaTeslim + kartToplam + gider;
                txtGenelToplam.Text = genelToplam.ToString("C2");
                acikFazla = otomasyon - genelToplam;
                txtAcikFazla.Text = acikFazla.ToString("C2");
            }
            catch (Exception)
            {

                MessageBox.Show("Eksik alanları doldurunuz");
            }
            
        }

        private void btnKartHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                gunSonu1 = Convert.ToDouble(txtpos1.Text);
                gunSonu2 = Convert.ToDouble(txtpos2.Text);
                kartToplam = gunSonu1 + gunSonu2;
                txtKrediKarti.Text = kartToplam.ToString("C2");
            }
            catch (Exception)
            {

                MessageBox.Show("Eksik alanları doldurunuz");
            }
        }
    }
}
