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
    public partial class FrmYakitKasasiListele : Form
    {

        public FrmYakitKasasiListele()
        {
            InitializeComponent();
        }

        Baglanti bgl = new Baglanti();

        double acik, fazla, fark, kartToplam, nakitToplam, veresiyeToplam, toplam;

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnGorListele_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection conn = new SqlConnection(bgl.Adres);
                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();
                DataTable dt3 = new DataTable();
                DataTable dt4 = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select id,tarih,pompaci,muhasebeci,zRaporu,otomasyon,halkPos1,halkPos2,ziraatPos1,ziraatPos2,kart from Tbl_YakitKasasi ORDER BY id DESC ", conn);
                SqlDataAdapter da2 = new SqlDataAdapter("select id,nakit,veresiye,pompacidanAlinan,gider,fisNo,giderAciklama,toplam,acik,fazla from Tbl_YakitKasasi ORDER BY id DESC ", conn);
                SqlDataAdapter da3 = new SqlDataAdapter("select id,gelir,gelirFisNo,gelirAciklama,tahsilat,tahsilatFisNo,tahsilatAciklama,benzin,motorin,lpg,yakitLitre,yakitTutar from Tbl_YakitKasasi ORDER BY id DESC ", conn);
                SqlDataAdapter da4 = new SqlDataAdapter("select * from Tbl_YakitKasasi ORDER BY id DESC ", conn);
                /*from Tbl_Satis INNER JOIN Tbl_Musteri ON Tbl_Satis.SATISMUSTERI=Tbl_Musteri.MUSTERIID INNER JOIN Tbl_Urunn ON Tbl_Satis.YAKITCINSI = Tbl_Urunn.URUNID*/
                //da.SelectCommand.Parameters.Add("@p1", SqlDbType.Date).Value = DateTime.Now;
                conn.Open();
                da.Fill(dt);
                da2.Fill(dt2);
                da3.Fill(dt3);
                da4.Fill(dt4);
                dataGridView1.DataSource = dt;
                dataGridView2.DataSource = dt2;
                dataGridView3.DataSource = dt3;
                dataGridView4.DataSource = dt4;



                SqlCommand komut2 = new SqlCommand("select sum(kart), sum(nakit), sum(veresiye), sum(tahsilat), sum(gider), sum(benzin), sum(motorin), sum(lpg), sum(yakitLitre), sum(acik), sum(fazla), sum(gelir), sum(yakitTutar) from Tbl_YakitKasasi", conn);
                //komut2.Parameters.Add("@p1", SqlDbType.Date).Value = DateTime.Now;
                SqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    lblKartToplam.Text = dr2[0].ToString();
                    lblNakitToplam.Text = dr2[1].ToString();
                    lblVeresiyeToplam.Text = dr2[2].ToString();
                    lblTahsilatToplam.Text = dr2[3].ToString() + " TL";
                    lblGiderToplam.Text = dr2[4].ToString() + " TL";
                    lblBenzinToplam.Text = dr2[5].ToString() + " Litre";
                    lblMotorinToplam.Text = dr2[6].ToString() + " Litre";
                    lblLpgToplam.Text = dr2[7].ToString() + " Litre";
                    lblYakitLitreGenelToplam.Text = dr2[8].ToString();
                    lblAcik.Text = dr2[9].ToString();
                    lblFazla.Text = dr2[10].ToString();
                    lblGelirToplam.Text = dr2[11].ToString() + " TL";
                    lblGenelToplam.Text = dr2[12].ToString() + " TL";

                }

                acik = Convert.ToDouble(lblAcik.Text);
                fazla = Convert.ToDouble(lblFazla.Text);
                fark = fazla - acik;
                lblFark.Text = fark.ToString("C2");
                lblYakitLitreGenelToplam.Text = toplam.ToString();
                //lblKartToplam.Text = $"kartToplam: {kartToplam} ₺";
                conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu");
            }
            
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(bgl.Adres);
                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();
                DataTable dt3 = new DataTable();
                DataTable dt4 = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select id,tarih,pompaci,muhasebeci,zRaporu,otomasyon,halkPos1,halkPos2,ziraatPos1,ziraatPos2,kart from Tbl_YakitKasasi where tarih between @p1 and @p2 ORDER BY id DESC ", conn);
                SqlDataAdapter da2 = new SqlDataAdapter("select id,nakit,veresiye,pompacidanAlinan,gider,fisNo,giderAciklama,toplam,acik,fazla from Tbl_YakitKasasi where tarih between @p1 and @p2 ORDER BY id DESC ", conn);
                SqlDataAdapter da3 = new SqlDataAdapter("select id,gelir,gelirFisNo,gelirAciklama,tahsilat,tahsilatFisNo,tahsilatAciklama,benzin,motorin,lpg,yakitLitre,yakitTutar from Tbl_YakitKasasi where tarih between @p1 and @p2 ORDER BY id DESC ", conn);
                SqlDataAdapter da4 = new SqlDataAdapter("select * from Tbl_YakitKasasi where tarih between @p1 and @p2 ORDER BY id DESC ", conn);
                /*from Tbl_Satis INNER JOIN Tbl_Musteri ON Tbl_Satis.SATISMUSTERI=Tbl_Musteri.MUSTERIID INNER JOIN Tbl_Urunn ON Tbl_Satis.YAKITCINSI = Tbl_Urunn.URUNID*/
                //da.SelectCommand.Parameters.Add("@p1", SqlDbType.Date).Value = DateTime.Now;
                da.SelectCommand.Parameters.AddWithValue("@p1", SqlDbType.Date).Value = dateTimePicker1.Value;
                da.SelectCommand.Parameters.AddWithValue("@p2", SqlDbType.Date).Value = dateTimePicker2.Value;
                da2.SelectCommand.Parameters.AddWithValue("@p1", SqlDbType.Date).Value = dateTimePicker1.Value;
                da2.SelectCommand.Parameters.AddWithValue("@p2", SqlDbType.Date).Value = dateTimePicker2.Value;
                da3.SelectCommand.Parameters.AddWithValue("@p1", SqlDbType.Date).Value = dateTimePicker1.Value;
                da3.SelectCommand.Parameters.AddWithValue("@p2", SqlDbType.Date).Value = dateTimePicker2.Value;
                da4.SelectCommand.Parameters.AddWithValue("@p1", SqlDbType.Date).Value = dateTimePicker1.Value;
                da4.SelectCommand.Parameters.AddWithValue("@p2", SqlDbType.Date).Value = dateTimePicker2.Value;
                conn.Open();
                da.Fill(dt);
                da2.Fill(dt2);
                da3.Fill(dt3);
                da4.Fill(dt4);
                dataGridView1.DataSource = dt;
                dataGridView2.DataSource = dt2;
                dataGridView3.DataSource = dt3;
                dataGridView4.DataSource = dt4;



                SqlCommand komut2 = new SqlCommand("select sum(kart), sum(nakit), sum(veresiye),  sum(tahsilat), sum(gider), sum(benzin), sum(motorin), sum(lpg), sum(yakitLitre), sum(acik), sum(fazla), sum(gelir), sum(yakitTutar) from Tbl_YakitKasasi where tarih between @p1 and @p2", conn);
                komut2.Parameters.Add("@p1", SqlDbType.Date).Value = dateTimePicker1.Value;
                komut2.Parameters.Add("@p2", SqlDbType.Date).Value = dateTimePicker2.Value;
                SqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    lblKartToplam.Text = dr2[0].ToString();
                    lblNakitToplam.Text = dr2[1].ToString();
                    lblVeresiyeToplam.Text = dr2[2].ToString();
                    lblTahsilatToplam.Text = dr2[3].ToString() + " TL";
                    lblGiderToplam.Text = dr2[4].ToString() + " TL";
                    lblBenzinToplam.Text = dr2[5].ToString() + " Litre";
                    lblMotorinToplam.Text = dr2[6].ToString() + " Litre";
                    lblLpgToplam.Text = dr2[7].ToString() + " Litre";
                    lblYakitLitreGenelToplam.Text = dr2[8].ToString();
                    lblAcik.Text = dr2[9].ToString();
                    lblFazla.Text = dr2[10].ToString();
                    lblGelirToplam.Text = dr2[11].ToString() + " TL";
                    lblGenelToplam.Text = dr2[12].ToString() + " TL";

                }

                acik = Convert.ToDouble(lblAcik.Text);
                fazla = Convert.ToDouble(lblFazla.Text);
                fark = fazla - acik;
                lblFark.Text = fark.ToString("C2");

                //lblKartToplam.Text = $"kartToplam: {kartToplam} ₺";
                conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Tarih aralığınızı kontrol ediniz");
            }
        }

        //Db_SayacEntities2 db = new Db_SayacEntities2();
        private void btnGununRaporu_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnOnizle_Click(object sender, EventArgs e)
        {
            //YakitKasasiRaporlar.tarih = dtYakitKasaTarih.Value.ToShortDateString();
            //YakitKasasiRaporlar.pompaci = cmbPompaci.Text;
            //YakitKasasiRaporlar.muhasebeci = cmbPompaci.Text;
            YakitKasasiRaporlar.YakitKasasıRaporlarTumu(dataGridView4);
        }
    }
}
