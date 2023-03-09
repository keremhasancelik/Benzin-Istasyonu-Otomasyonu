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
    public partial class Frm_YikamaKasasi : Form
    {
        public Frm_YikamaKasasi()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        private void Frm_YikamaKasasi_Load(object sender, EventArgs e)
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
            cmd.CommandText = "Get_LastYikamaId";
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

            DataTable dt32 = new DataTable();
            SqlDataAdapter da22 = new SqlDataAdapter("select id,tarih,yikamaci,muhasebeci from Tbl_YikamaKasasi where Tbl_YikamaKasasi.id = @id", connn);
            SqlDataAdapter da23 = new SqlDataAdapter("select nakit,veresiye,kart,gider from Tbl_YikamaKasasi where Tbl_YikamaKasasi.id = @id", connn);
            SqlDataAdapter da24 = new SqlDataAdapter("select kasaTeslim,toplam from Tbl_YikamaKasasi where Tbl_YikamaKasasi.id = @id", connn);
            SqlDataAdapter da25 = new SqlDataAdapter("select gider,giderFisNo,giderAciklama from Tbl_YikamaKasasi where Tbl_YikamaKasasi.id = @id", connn);
            SqlDataAdapter da26 = new SqlDataAdapter("select tahsilat,tahsilatFisNo,tahsilatAciklama from Tbl_YikamaKasasi where Tbl_YikamaKasasi.id = @id", connn);
            SqlDataAdapter da27 = new SqlDataAdapter("select Aciklama from Tbl_YikamaKasasi where Tbl_YikamaKasasi.id = @id", connn);

            SqlDataAdapter da32 = new SqlDataAdapter("select * from Tbl_YikamaKasasi where Tbl_YikamaKasasi.id = @id", connn);

            da22.SelectCommand.Parameters.Add("@id", obj);
            da23.SelectCommand.Parameters.Add("@id", obj);
            da24.SelectCommand.Parameters.Add("@id", obj);
            da25.SelectCommand.Parameters.Add("@id", obj);
            da26.SelectCommand.Parameters.Add("@id", obj);
            da27.SelectCommand.Parameters.Add("@id", obj);

            da32.SelectCommand.Parameters.Add("@id", obj);
            connn.Open();
            da22.Fill(dt22);
            da23.Fill(dt23);
            da24.Fill(dt24);
            da25.Fill(dt25);
            da26.Fill(dt26);
            da27.Fill(dt27);

            da32.Fill(dt32);
            dataGridView1.DataSource = dt22;
            dataGridView2.DataSource = dt23;
            dataGridView3.DataSource = dt24;
            dataGridView4.DataSource = dt25;
            dataGridView5.DataSource = dt26;
            dataGridView6.DataSource = dt27;

            dataGridView7.DataSource = dt32;
            connn.Close();
        }

        double kartToplam, tahsilatTutar;
        double nakit, veresiye, kasaTeslim, genelToplam, gider;

        private void btnOnizle_Click(object sender, EventArgs e)
        {
            YakitKasasiRaporlar.YikamaKasasiGunlukRaporlar(dataGridView7);
        }

        private void btnGorListele_Click(object sender, EventArgs e)
        {
            FrmYikamaTumunuListele frm = new FrmYikamaTumunuListele();
            frm.ShowDialog();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            TxtID.Text = "";
            cmbKasiyer.Text = "";
            cmbMuhasebeci.Text = "";
            txtNakit.Text = "";
            txtVeresiye.Text = "";
            txtKart.Text = "";
            txtGiderTutar.Text = "";
            txtKasaTeslim.Text = "";
            txtGenelToplam.Text = "";
            txtTahsilat.Text = "";
            txtGiderFisNo.Text = "";
            txtGiderAciklama.Text = "";
            txtTahsilatFisNo.Text = "";
            txtTahsilatAciklama.Text = "";
            txtVardiyaNotu.Text = "";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                tahsilatTutar = Convert.ToDouble(txtTahsilat.Text);
                kasiyer = cmbKasiyer.Text;
                muhasebeci = cmbMuhasebeci.Text;

                //
                nakit = Convert.ToDouble(txtNakit.Text);
                veresiye = Convert.ToDouble(txtVeresiye.Text);
                kasaTeslim = Convert.ToDouble(txtKasaTeslim.Text);
                gider = Convert.ToDouble(txtGiderTutar.Text);

                genelToplam = nakit + veresiye + kasaTeslim + kartToplam + gider;
            }
            catch (Exception)
            {

                MessageBox.Show("Eksik bilgileri doldurunuz");
            }
            

            

            try
            {
                SqlConnection conn = new SqlConnection(bgl.Adres);
                SqlCommand komut = new SqlCommand("insert into Tbl_YikamaKasasi(kart,nakit,veresiye,kasaTeslim,gider,toplam,giderFisNo,giderAciklama,tahsilat,tahsilatFisNo,tahsilatAciklama,Aciklama,yikamaci,muhasebeci,tarih) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15)", conn);

                conn.Open();
                komut.Parameters.AddWithValue("@p1", kartToplam);
                komut.Parameters.AddWithValue("@p2", nakit);
                komut.Parameters.AddWithValue("@p3", veresiye);
                komut.Parameters.AddWithValue("@p4", kasaTeslim);
                komut.Parameters.AddWithValue("@p5", gider);
                komut.Parameters.AddWithValue("@p6", genelToplam);
                komut.Parameters.AddWithValue("@p7", txtGiderFisNo.Text);
                komut.Parameters.AddWithValue("@p8", txtGiderAciklama.Text);
                komut.Parameters.AddWithValue("@p9", tahsilatTutar);
                komut.Parameters.AddWithValue("@p10", txtTahsilatFisNo.Text);
                komut.Parameters.AddWithValue("@p11", txtTahsilatAciklama.Text);
                komut.Parameters.AddWithValue("@p12", txtVardiyaNotu.Text);
                komut.Parameters.AddWithValue("@p13", kasiyer);
                komut.Parameters.AddWithValue("@p14", muhasebeci);
                komut.Parameters.AddWithValue("@p15", dtYakitKasaTarih.Value);
                komut.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Kaydedildi");
            }
            catch (Exception)
            {

                MessageBox.Show("Eksik bilgileri doldurunuz");
            }

        }

        string kasiyer, muhasebeci;
        private void btnGenelToplamHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                nakit = Convert.ToDouble(txtNakit.Text);
                veresiye = Convert.ToDouble(txtVeresiye.Text);
                kasaTeslim = Convert.ToDouble(txtKasaTeslim.Text);
                gider = Convert.ToDouble(txtGiderTutar.Text);
                kartToplam = Convert.ToDouble(txtKart.Text);
                genelToplam = nakit + veresiye + kasaTeslim + kartToplam + gider;
                txtGenelToplam.Text = genelToplam.ToString("C2");
            }
            catch (Exception)
            {

                MessageBox.Show("Eksik bilgileri doldurunuz");
            }
            
        }
    }
}
