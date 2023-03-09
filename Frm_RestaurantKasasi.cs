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
    public partial class Frm_RestaurantKasasi : Form
    {
        public Frm_RestaurantKasasi()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        private void btnTemizle_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }

        private void btnGenelToplamHesapla_Click(object sender, EventArgs e)
        {

        }

        private void txtTahsilat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtGelir_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void txtGenelToplam_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Frm_RestaurantKasasi_Load(object sender, EventArgs e)
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
            cmd.CommandText = "Get_RestaurantId";
            cmd.Connection = con;
            con.Open();
            object obj = cmd.ExecuteScalar();
            label24.Text = obj.ToString();
            con.Close();

            SqlConnection connn = new SqlConnection(bgl.Adres);
            DataTable dt22 = new DataTable();
            DataTable dt23 = new DataTable();
            DataTable dt24 = new DataTable();
            DataTable dt25 = new DataTable();
            DataTable dt26 = new DataTable();
            DataTable dt27 = new DataTable();

            SqlDataAdapter da22 = new SqlDataAdapter("select id,tarih,kasiyer,muhasebeci from Tbl_RestaurantKasasi where Tbl_RestaurantKasasi.id = @id", connn);
            SqlDataAdapter da23 = new SqlDataAdapter("select nakit,veresiye,kart,gider from Tbl_RestaurantKasasi where Tbl_RestaurantKasasi.id = @id", connn);
            SqlDataAdapter da24 = new SqlDataAdapter("select gelir,tahsilat,toplam from Tbl_RestaurantKasasi where Tbl_RestaurantKasasi.id = @id", connn);
            SqlDataAdapter da25 = new SqlDataAdapter("select gider,giderAciklama,gelir,gelirAciklama from Tbl_RestaurantKasasi where Tbl_RestaurantKasasi.id = @id", connn);
            SqlDataAdapter da26 = new SqlDataAdapter("select tahsilat,tahsilatAciklama,Aciklama from Tbl_RestaurantKasasi where Tbl_RestaurantKasasi.id = @id", connn);
            SqlDataAdapter da27 = new SqlDataAdapter("select * from Tbl_RestaurantKasasi where Tbl_RestaurantKasasi.id = @id", connn);


            da22.SelectCommand.Parameters.Add("@id", obj);
            da23.SelectCommand.Parameters.Add("@id", obj);
            da24.SelectCommand.Parameters.Add("@id", obj);
            da25.SelectCommand.Parameters.Add("@id", obj);
            da26.SelectCommand.Parameters.Add("@id", obj);
            da27.SelectCommand.Parameters.Add("@id", obj);

            connn.Open();
            da22.Fill(dt22);
            da23.Fill(dt23);
            da24.Fill(dt24);
            da25.Fill(dt25);
            da26.Fill(dt26);
            da27.Fill(dt27);

            dataGridView1.DataSource = dt22;
            dataGridView2.DataSource = dt23;
            dataGridView3.DataSource = dt24;
            dataGridView4.DataSource = dt25;
            dataGridView5.DataSource = dt26;
            dataGridView6.DataSource = dt27;

            connn.Close();
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            try
            {
                tahsilatTutar = Convert.ToDouble(txtTahsilat.Text);
                kasiyer = cmbKasiyer.Text;
                muhasebeci = cmbMuhasebeci.Text;

                //
                nakit = Convert.ToDouble(txtNakit.Text);
                veresiye = Convert.ToDouble(txtVeresiye.Text);
                gelir = Convert.ToDouble(txtGelir.Text);
                gider = Convert.ToDouble(txtGiderTutar.Text);

                genelToplam = nakit + veresiye + gelir + kartToplam + gider + tahsilatTutar;
            }
            catch (Exception)
            {

                MessageBox.Show("Eksik bilgileri doldurunuz");
            }
            try
            {
                SqlConnection conn = new SqlConnection(bgl.Adres);
                SqlCommand komut = new SqlCommand("insert into Tbl_RestaurantKasasi(kart,nakit,veresiye,gider,gelir,toplam,giderAciklama,gelirAciklama,tahsilat,tahsilatAciklama,Aciklama,kasiyer,muhasebeci,tarih) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14)", conn);

                conn.Open();
                komut.Parameters.AddWithValue("@p1", kartToplam);
                komut.Parameters.AddWithValue("@p2", nakit);
                komut.Parameters.AddWithValue("@p3", veresiye);
                komut.Parameters.AddWithValue("@p4", gider);
                komut.Parameters.AddWithValue("@p5", gelir);
                komut.Parameters.AddWithValue("@p6", genelToplam);
                komut.Parameters.AddWithValue("@p7", txtGiderAciklama.Text);
                komut.Parameters.AddWithValue("@p8", txtGelirAciklama.Text);
                komut.Parameters.AddWithValue("@p9", tahsilatTutar);
                komut.Parameters.AddWithValue("@p10", txtTahsilatAciklama.Text);
                komut.Parameters.AddWithValue("@p11", txtVardiyaNotu.Text);
                komut.Parameters.AddWithValue("@p12", kasiyer);
                komut.Parameters.AddWithValue("@p13", muhasebeci);
                komut.Parameters.AddWithValue("@p14", dtYakitKasaTarih.Value);
                komut.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Kaydedildi");
            }
            catch (Exception)
            {

                MessageBox.Show("Eksik bilgileri doldurunuz");
            }
           
        }

        double kartToplam, tahsilatTutar;
        double nakit, veresiye, kasaTeslim, genelToplam, gider,gelir;

        private void btnGorListele_Click(object sender, EventArgs e)
        {
            Frm_RestaurantKasasiTumunuListele frm = new Frm_RestaurantKasasiTumunuListele();
            frm.ShowDialog();
        }

        private void btnOnizle_Click(object sender, EventArgs e)
        {
            YakitKasasiRaporlar.RestaurantKasasiGunlukRaporlar(dataGridView6);
        }

        private void btnTemizle_Click_1(object sender, EventArgs e)
        {
            TxtID.Text = "";
            txtGelir.Text = "";
            txtGelirAciklama.Text = "";
            txtGenelToplam.Text = "";
            txtGiderAciklama.Text = "";
            txtGiderTutar.Text = "";
            txtTahsilat.Text = "";
            txtTahsilatAciklama.Text = "";
            txtNakit.Text = "";
            txtKart.Text = "";
            txtVeresiye.Text = "";
            txtVardiyaNotu.Text = "";
            cmbKasiyer.Text = "";
            cmbMuhasebeci.Text = "";
        }

        string kasiyer, muhasebeci;
        private void btnGenelToplamHesapla_Click_1(object sender, EventArgs e)
        {
            try
            {
                nakit = Convert.ToDouble(txtNakit.Text);
                veresiye = Convert.ToDouble(txtVeresiye.Text);
                gelir = Convert.ToDouble(txtGelir.Text);
                gider = Convert.ToDouble(txtGiderTutar.Text);
                kartToplam = Convert.ToDouble(txtKart.Text);
                tahsilatTutar = Convert.ToDouble(txtTahsilat.Text);
                genelToplam = nakit + veresiye + gelir + kartToplam + gider + tahsilatTutar;
                txtGenelToplam.Text = genelToplam.ToString("C2");
            }
            catch (Exception)
            {

                MessageBox.Show("Eksik bilgileri doldurunuz");
            }
            
        }
    }
}
