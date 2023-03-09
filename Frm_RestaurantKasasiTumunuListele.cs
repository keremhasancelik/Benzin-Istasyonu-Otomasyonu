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
    public partial class Frm_RestaurantKasasiTumunuListele : Form
    {
        public Frm_RestaurantKasasiTumunuListele()
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
                DataTable dt3 = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select id,tarih,kasiyer,muhasebeci,nakit,kart,veresiye,gider,gelir,tahsilat,toplam from Tbl_RestaurantKasasi ORDER BY id DESC ", conn);
                SqlDataAdapter da3 = new SqlDataAdapter("select id,giderAciklama,gelirAciklama,tahsilatAciklama,Aciklama from Tbl_RestaurantKasasi ORDER BY id DESC ", conn);
                conn.Open();
                da.Fill(dt);
                da3.Fill(dt3);
                dataGridView1.DataSource = dt;
                dataGridView3.DataSource = dt3;
                SqlCommand komut2 = new SqlCommand("select sum(nakit), sum(kart), sum(veresiye), sum(tahsilat), sum(gider), sum(gelir), sum(toplam) from Tbl_RestaurantKasasi", conn);
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

                MessageBox.Show("Beklenmedik bir hata oluştu");
            }


        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(bgl.Adres);
                DataTable dt = new DataTable();
                DataTable dt3 = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select id,tarih,kasiyer,muhasebeci,nakit,kart,veresiye,gider,gelir,tahsilat,toplam from Tbl_RestaurantKasasi where tarih between @p1 and @p2 ORDER BY id DESC ", conn);
                SqlDataAdapter da3 = new SqlDataAdapter("select id,giderAciklama,gelirAciklama,tahsilatAciklama,Aciklama from Tbl_RestaurantKasasi where tarih between @p1 and @p2 ORDER BY id DESC ", conn);
                da.SelectCommand.Parameters.AddWithValue("@p1", SqlDbType.Date).Value = dateTimePicker1.Value;
                da.SelectCommand.Parameters.AddWithValue("@p2", SqlDbType.Date).Value = dateTimePicker2.Value;
                da3.SelectCommand.Parameters.AddWithValue("@p1", SqlDbType.Date).Value = dateTimePicker1.Value;
                da3.SelectCommand.Parameters.AddWithValue("@p2", SqlDbType.Date).Value = dateTimePicker2.Value;
                conn.Open();
                da.Fill(dt);
                da3.Fill(dt3);
                dataGridView1.DataSource = dt;
                dataGridView3.DataSource = dt3;

                SqlCommand komut2 = new SqlCommand("select sum(nakit), sum(kart), sum(veresiye), sum(tahsilat), sum(gider), sum(gelir), sum(toplam) from Tbl_RestaurantKasasi where tarih between @p1 and @p2", conn);
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
