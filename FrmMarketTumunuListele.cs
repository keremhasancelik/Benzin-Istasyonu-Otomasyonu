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
    public partial class FrmMarketTumunuListele : Form
    {
        public FrmMarketTumunuListele()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        private void btnGorListele_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(bgl.Adres);
                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();
                DataTable dt3 = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select id,tarih,kasiyer,muhasebeci,zRaporu,otomasyonToplam,gunSonu1,gunSonu2,kartToplam from Tbl_MarketKasasi ORDER BY id DESC ", conn);
                SqlDataAdapter da2 = new SqlDataAdapter("select id,nakit,veresiyeToplam,muhasebeTeslim,gider,giderFisNo,giderAciklama,toplam,acik,fazla from Tbl_MarketKasasi ORDER BY id DESC ", conn);
                SqlDataAdapter da3 = new SqlDataAdapter("select id,gelir,gelirFisNo,gelirAciklama,tahsilat,tahsilatFisNo,tahsilatAciklama,vardiyaNotu from Tbl_MarketKasasi ORDER BY id DESC ", conn);
                conn.Open();
                da.Fill(dt);
                da2.Fill(dt2);
                da3.Fill(dt3);
                dataGridView1.DataSource = dt;
                dataGridView2.DataSource = dt2;
                dataGridView3.DataSource = dt3;

                SqlCommand komut2 = new SqlCommand("select sum(nakit), sum(kartToplam), sum(veresiyeToplam), sum(tahsilat), sum(gider), sum(gelir), sum(toplam) from Tbl_MarketKasasi", conn);
                SqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    lblNakitToplam.Text = dr2[0].ToString();
                    lblKartToplam.Text = dr2[1].ToString();
                    lblVeresiyeToplam.Text = dr2[2].ToString();
                    lblTahsilatToplam.Text = dr2[3].ToString();
                    lblGiderToplam.Text = dr2[4].ToString();
                    lblGelirToplam.Text = dr2[5].ToString();
                    lblGenelToplam.Text = dr2[6].ToString();


                }
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
                SqlDataAdapter da = new SqlDataAdapter("select id,tarih,kasiyer,muhasebeci,zRaporu,otomasyonToplam,gunSonu1,gunSonu2,kartToplam from Tbl_MarketKasasi where tarih between @p1 and @p2 ORDER BY id DESC ", conn);
                SqlDataAdapter da2 = new SqlDataAdapter("select id,nakit,veresiyeToplam,muhasebeTeslim,gider,giderFisNo,giderAciklama,toplam,acik,fazla from Tbl_MarketKasasi where tarih between @p1 and @p2 ORDER BY id DESC ", conn);
                SqlDataAdapter da3 = new SqlDataAdapter("select id,gelir,gelirFisNo,gelirAciklama,tahsilat,tahsilatFisNo,tahsilatAciklama,vardiyaNotu from Tbl_MarketKasasi where tarih between @p1 and @p2 ORDER BY id DESC ", conn);
                da.SelectCommand.Parameters.AddWithValue("@p1", SqlDbType.Date).Value = dateTimePicker1.Value;
                da.SelectCommand.Parameters.AddWithValue("@p2", SqlDbType.Date).Value = dateTimePicker2.Value;
                da2.SelectCommand.Parameters.AddWithValue("@p1", SqlDbType.Date).Value = dateTimePicker1.Value;
                da2.SelectCommand.Parameters.AddWithValue("@p2", SqlDbType.Date).Value = dateTimePicker2.Value;
                da3.SelectCommand.Parameters.AddWithValue("@p1", SqlDbType.Date).Value = dateTimePicker1.Value;
                da3.SelectCommand.Parameters.AddWithValue("@p2", SqlDbType.Date).Value = dateTimePicker2.Value;
                conn.Open();
                da.Fill(dt);
                da2.Fill(dt2);
                da3.Fill(dt3);
                dataGridView1.DataSource = dt;
                dataGridView2.DataSource = dt2;
                dataGridView3.DataSource = dt3;
                dataGridView1.DataSource = dt;
                dataGridView2.DataSource = dt2;
                dataGridView3.DataSource = dt3;

                SqlCommand komut2 = new SqlCommand("select sum(nakit), sum(kartToplam), sum(veresiyeToplam), sum(tahsilat), sum(gider), sum(gelir), sum(toplam) from Tbl_MarketKasasi where tarih between @p1 and @p2", conn);
                komut2.Parameters.Add("@p1", SqlDbType.Date).Value = dateTimePicker1.Value;
                komut2.Parameters.Add("@p2", SqlDbType.Date).Value = dateTimePicker2.Value;
                SqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    lblNakitToplam.Text = dr2[0].ToString();
                    lblKartToplam.Text = dr2[1].ToString();
                    lblVeresiyeToplam.Text = dr2[2].ToString();
                    lblTahsilatToplam.Text = dr2[3].ToString();
                    lblGiderToplam.Text = dr2[4].ToString();
                    lblGelirToplam.Text = dr2[5].ToString();
                    lblGenelToplam.Text = dr2[6].ToString();


                }
                conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Tarih aralığınızı kontrol ediniz");
            }
        }
    }
}
