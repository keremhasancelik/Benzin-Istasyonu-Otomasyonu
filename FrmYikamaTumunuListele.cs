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
    public partial class FrmYikamaTumunuListele : Form
    {
        public FrmYikamaTumunuListele()
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
                SqlDataAdapter da = new SqlDataAdapter("select id,tarih,yikamaci,muhasebeci,nakit,veresiye,kart,kasaTeslim,toplam from Tbl_YikamaKasasi ORDER BY id DESC ", conn);
                SqlDataAdapter da2 = new SqlDataAdapter("select gider,giderFisNo,giderAciklama,tahsilat,tahsilatFisNo,tahsilatAciklama,Aciklama from Tbl_YikamaKasasi ORDER BY id DESC ", conn);
                conn.Open();
                da.Fill(dt);
                da2.Fill(dt2);
                dataGridView1.DataSource = dt;
                dataGridView2.DataSource = dt2;

                SqlCommand komut2 = new SqlCommand("select sum(nakit), sum(kart), sum(veresiye), sum(tahsilat), sum(gider), sum(toplam) from Tbl_YikamaKasasi", conn);
                SqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    lblNakitToplam.Text = dr2[0].ToString();
                    lblKartToplam.Text = dr2[1].ToString();
                    lblVeresiyeToplam.Text = dr2[2].ToString();
                    lblTahsilatToplam.Text = dr2[3].ToString();
                    lblGiderToplam.Text = dr2[4].ToString();
                    lblGenelToplam.Text = dr2[5].ToString();


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
                SqlDataAdapter da = new SqlDataAdapter("select id,tarih,yikamaci,muhasebeci,nakit,veresiye,kart,kasaTeslim,toplam from Tbl_YikamaKasasi where tarih between @p1 and @p2 ORDER BY id DESC ", conn);
                SqlDataAdapter da2 = new SqlDataAdapter("select gider,giderFisNo,giderAciklama,tahsilat,tahsilatFisNo,tahsilatAciklama,Aciklama from Tbl_YikamaKasasi where tarih between @p1 and @p2 ORDER BY id DESC ", conn);
                da.SelectCommand.Parameters.AddWithValue("@p1", SqlDbType.Date).Value = dateTimePicker1.Value;
                da.SelectCommand.Parameters.AddWithValue("@p2", SqlDbType.Date).Value = dateTimePicker2.Value;
                da2.SelectCommand.Parameters.AddWithValue("@p1", SqlDbType.Date).Value = dateTimePicker1.Value;
                da2.SelectCommand.Parameters.AddWithValue("@p2", SqlDbType.Date).Value = dateTimePicker2.Value;
                conn.Open();
                da.Fill(dt);
                da2.Fill(dt2);
                dataGridView1.DataSource = dt;
                dataGridView2.DataSource = dt2;

                SqlCommand komut2 = new SqlCommand("select sum(nakit), sum(kart), sum(veresiye), sum(tahsilat), sum(gider), sum(toplam) from Tbl_YikamaKasasi where tarih between @p1 and @p2", conn);
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
                    lblGenelToplam.Text = dr2[5].ToString();


                }
            }
            catch (Exception)
            {

                MessageBox.Show("Tarih aralığınızı kontrol ediniz");
            }
        }
    }
}
