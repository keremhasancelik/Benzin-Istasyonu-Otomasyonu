using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayac_Proje
{
    public partial class FrmYakitKasasi : Form
    {
        public FrmYakitKasasi()
        {
            InitializeComponent();
        }

        Baglanti bgl = new Baglanti();
        Db_SayacEntities2 db = new Db_SayacEntities2();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        double tahsilatTutar, zRaporu, gelir, acik, fazla, benzinStok, motorinStok, lpgStok, benzinNetStok, motorinNetStok, lpgNetStok;
        string pompaci, muhasebeci;
        int benzin, motorin, lpg;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                tahsilatTutar = Convert.ToDouble(txtTahsilatTutar.Text);
                zRaporu = Convert.ToDouble(TxtZraporu.Text);
                pompaci = cmbPompaci.Text;
                muhasebeci = cmbMuhasebeci.Text;

                //

                benzinLitre = Convert.ToDouble(txtBenzinLitre.Text);
                motorinLitre = Convert.ToDouble(txtMotorinLitre.Text);
                lpgLitre = Convert.ToDouble(txtLpgLitre.Text);

                //

                benzin = Convert.ToInt32(cmbBenzin.SelectedValue.ToString());
                motorin = Convert.ToInt32(cmbMotorin.SelectedValue.ToString());
                lpg = Convert.ToInt32(cmbLpg.SelectedValue.ToString());

                //

                halkPos1 = Convert.ToDouble(txtHpos1.Text);
                halkPos2 = Convert.ToDouble(txtHpos2.Text);
                ziraatPos1 = Convert.ToDouble(txtZpos1.Text);
                ziraatPos2 = Convert.ToDouble(txtZpos2.Text);
                kartToplam = halkPos1 + halkPos2 + ziraatPos1 + ziraatPos2;

                //

                nakit = Convert.ToDouble(txtNakit.Text);
                veresiye = Convert.ToDouble(txtVeresiye.Text);
                kasaTeslim = Convert.ToDouble(txtKasaTeslim.Text);
                otomasyon = Convert.ToDouble(txtOtomasyon.Text);
                gider = Convert.ToDouble(txtGiderTutar.Text);
                gelir = Convert.ToDouble(txtGelir.Text);
                kartToplam = halkPos1 + halkPos2 + ziraatPos1 + ziraatPos2;
                genelToplam = nakit + veresiye + kasaTeslim + kartToplam + gider;

                acikFazla = genelToplam - otomasyon;

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

                //




                benzinBirimFiyat = Convert.ToDouble(cmbBenzinBirimFiyat.Text);
                motorinBirimFiyat = Convert.ToDouble(cmbMotorinBirimFiyat.Text);
                lpgBirimFiyat = Convert.ToDouble(cmbLpgBirimFiyat.Text);

                benzinStok = Convert.ToDouble(cmbBenzinStok.Text);
                motorinStok = Convert.ToDouble(cmbMotorinStok.Text);
                lpgStok = Convert.ToDouble(cmbLpgStok.Text);

                BenzinToplamTutar = benzinLitre * benzinBirimFiyat;
                MotorinToplamTutar = motorinLitre * motorinBirimFiyat;
                LpgToplamTutar = lpgLitre * lpgBirimFiyat;

                Toplamlitre = Math.Round(benzinLitre + motorinLitre + lpgLitre, 2);
                ToplamTutar = Math.Round(BenzinToplamTutar + MotorinToplamTutar + LpgToplamTutar, 2);


                //

                benzinNetStok = benzinStok - benzinLitre;
                motorinNetStok = motorinStok - motorinLitre;
                lpgNetStok = lpgStok - lpgLitre;
            }
            catch (Exception)
            {

                MessageBox.Show("Eksik alanları doldurunuz");
            }
            



            try
            {
                SqlConnection conn = new SqlConnection(bgl.Adres);
                conn.Open();
                SqlCommand komut = new SqlCommand("insert into Tbl_YakitKasasi(zRaporu,otomasyon,halkPos1,halkPos2,ziraatPos1,ziraatPos2,kart,nakit,veresiye,pompacidanAlinan,gider,fisNo,giderAciklama,toplam,gelir,gelirFisNo,gelirAciklama,acik,fazla,tahsilat,tahsilatFisNo,tahsilatAciklama,benzin,motorin,lpg,yakitLitre,yakitTutar,benzinStok,motorinStok,lpgStok,pompaci,muhasebeci,tarih) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18,@p19,@p20,@p21,@p22,@p23,@p24,@p25,@p26,@p27,@p28,@p29,@p30,@p31,@p32,@p33)", conn);
                komut.Parameters.AddWithValue("@p1", zRaporu);
                komut.Parameters.AddWithValue("@p2", otomasyon);
                komut.Parameters.AddWithValue("@p3", halkPos1);
                komut.Parameters.AddWithValue("@p4", halkPos2);
                komut.Parameters.AddWithValue("@p5", ziraatPos1);
                komut.Parameters.AddWithValue("@p6", ziraatPos2);
                komut.Parameters.AddWithValue("@p7", kartToplam);
                komut.Parameters.AddWithValue("@p8", nakit);
                komut.Parameters.AddWithValue("@p9", veresiye);
                komut.Parameters.AddWithValue("@p10", kasaTeslim);
                komut.Parameters.AddWithValue("@p11", gider);
                komut.Parameters.AddWithValue("@p12", txtFisNo.Text);
                komut.Parameters.AddWithValue("@p13", rchGiderAciklama.Text);
                komut.Parameters.AddWithValue("@p14", genelToplam);
                komut.Parameters.AddWithValue("@p15", gelir);
                komut.Parameters.AddWithValue("@p16", txtGelirFisNo.Text);
                komut.Parameters.AddWithValue("@p17", rchGelirAciklama.Text);
                komut.Parameters.AddWithValue("@p18", acik);
                komut.Parameters.AddWithValue("@p19", fazla);
                komut.Parameters.AddWithValue("@p20", tahsilatTutar);
                komut.Parameters.AddWithValue("@p21", txtTahsilatFisNo.Text);
                komut.Parameters.AddWithValue("@p22", rchTahsilatAciklama.Text);
                komut.Parameters.AddWithValue("@p23", benzinLitre);
                komut.Parameters.AddWithValue("@p24", motorinLitre);
                komut.Parameters.AddWithValue("@p25", lpgLitre);
                komut.Parameters.AddWithValue("@p26", Toplamlitre);
                komut.Parameters.AddWithValue("@p27", ToplamTutar);
                komut.Parameters.AddWithValue("@p28", Convert.ToDouble(lblBenzinStok.Text));
                komut.Parameters.AddWithValue("@p29", Convert.ToDouble(lblMotorinStok.Text));
                komut.Parameters.AddWithValue("@p30", Convert.ToDouble(lblLpgStok.Text));
                komut.Parameters.AddWithValue("@p31", pompaci);
                komut.Parameters.AddWithValue("@p32", muhasebeci);
                komut.Parameters.AddWithValue("@p33", dtYakitKasaTarih.Value);
                komut.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Kaydedildi");

                conn.Open();
                SqlCommand komut2 = new SqlCommand("update Tbl_Urunn set STOK=@p1 where URUNID=@p2", conn);
                komut2.Parameters.AddWithValue("@p1", benzinNetStok);
                komut2.Parameters.AddWithValue("@p2", benzin);
                komut2.ExecuteNonQuery();
                conn.Close();
                //
                conn.Open();
                SqlCommand komut7 = new SqlCommand("update Tbl_Urunn set STOK=@p1 where URUNID=@p2", conn);
                komut7.Parameters.AddWithValue("@p1", motorinNetStok);
                komut7.Parameters.AddWithValue("@p2", motorin);
                komut7.ExecuteNonQuery();
                conn.Close();
                //
                conn.Open();
                SqlCommand komut4 = new SqlCommand("update Tbl_Urunn set STOK=@p1 where URUNID=@p2", conn);
                komut4.Parameters.AddWithValue("@p1", lpgNetStok);
                komut4.Parameters.AddWithValue("@p2", lpg);
                komut4.ExecuteNonQuery();
                conn.Close();
                //
                if (benzin == 2)
                {

                    conn.Open();
                    SqlCommand komut3 = new SqlCommand("insert into Tbl_BenzinSatis(TLITRE,TTUTAR,BTARIH) values(@p1,@p2,@p3)", conn);
                    komut3.Parameters.AddWithValue("@p1", benzinLitre);
                    komut3.Parameters.AddWithValue("@p2", BenzinToplamTutar);
                    komut3.Parameters.AddWithValue("@p3", dtYakitKasaTarih.Value);

                    komut3.ExecuteNonQuery();
                    conn.Close();
                }
                if (motorin == 3)
                {
                    conn.Open();
                    SqlCommand komut8 = new SqlCommand("insert into Tbl_MotorinSatis(MTLITRE,MTTUTAR,MTARIH) values(@p1,@p2,@p3)", conn);
                    komut8.Parameters.AddWithValue("@p1", motorinLitre);
                    komut8.Parameters.AddWithValue("@p2", MotorinToplamTutar);
                    komut8.Parameters.AddWithValue("@p3", dtYakitKasaTarih.Value);
                    komut8.ExecuteNonQuery();
                    conn.Close();
                }
                if (lpg == 4)
                {
                    conn.Open();
                    SqlCommand komut5 = new SqlCommand("insert into Tbl_LpgSatis(LTLITRE,LTTUTAR,LTARIH) values(@p1,@p2,@p3)", conn);
                    komut5.Parameters.AddWithValue("@p1", lpgLitre);
                    komut5.Parameters.AddWithValue("@p2", LpgToplamTutar);
                    komut5.Parameters.AddWithValue("@p3", dtYakitKasaTarih.Value);
                    komut5.ExecuteNonQuery();
                    conn.Close();
                }



                //

                conn.Open();
                SqlCommand komut6 = new SqlCommand("insert into Tbl_Gelir(YAKIT,GELIRTUTAR,GELIRTARIH) VALUES(@p1,@p2,@p3)", conn);
                komut6.Parameters.AddWithValue("@p1", benzin);
                komut6.Parameters.AddWithValue("@p2", BenzinToplamTutar);
                komut6.Parameters.AddWithValue("@p3", dtYakitKasaTarih.Value);
                komut6.ExecuteNonQuery();
                conn.Close();

                //
                conn.Open();
                SqlCommand komut10 = new SqlCommand("insert into Tbl_Gelir(YAKIT,GELIRTUTAR,GELIRTARIH) VALUES(@p1,@p2,@p3)", conn);
                komut10.Parameters.AddWithValue("@p1", motorin);
                komut10.Parameters.AddWithValue("@p2", MotorinToplamTutar);
                komut10.Parameters.AddWithValue("@p3", dtYakitKasaTarih.Value);
                komut10.ExecuteNonQuery();
                conn.Close();


                //
                conn.Open();
                SqlCommand komut11 = new SqlCommand("insert into Tbl_Gelir(YAKIT,GELIRTUTAR,GELIRTARIH) VALUES(@p1,@p2,@p3)", conn);
                komut11.Parameters.AddWithValue("@p1", lpg);
                komut11.Parameters.AddWithValue("@p2", LpgToplamTutar);
                komut11.Parameters.AddWithValue("@p3", dtYakitKasaTarih.Value);
                komut11.ExecuteNonQuery();
                conn.Close();



            }
            catch (Exception)
            {

                MessageBox.Show("Eksik alanları doldurunuz");
            }


        }


        private void FrmYakitKasasi_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            SqlCommand komut = new SqlCommand("select URUNID,URUNAD from Tbl_Urunn", conn);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);
            cmbBenzin.DisplayMember = "URUNAD";
            cmbBenzin.ValueMember = "URUNID";
            cmbBenzin.DataSource = dt;
            conn.Close();

            SqlCommand komut3 = new SqlCommand("select URUNID,URUNAD from Tbl_Urunn", conn);
            SqlDataAdapter da3 = new SqlDataAdapter(komut3);
            DataTable dt3 = new DataTable();
            conn.Open();
            da.Fill(dt3);
            cmbMotorin.DisplayMember = "URUNAD";
            cmbMotorin.ValueMember = "URUNID";
            cmbMotorin.DataSource = dt3;
            conn.Close();

            SqlCommand komut4 = new SqlCommand("select URUNID,URUNAD from Tbl_Urunn", conn);
            SqlDataAdapter da4 = new SqlDataAdapter(komut4);
            DataTable dt4 = new DataTable();
            conn.Open();
            da.Fill(dt4);
            cmbLpg.DisplayMember = "URUNAD";
            cmbLpg.ValueMember = "URUNID";
            cmbLpg.DataSource = dt4;
            conn.Close();


            //
            SqlCommand komut2 = new SqlCommand("select PERID,PERAD from Tbl_Personel", conn);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            conn.Open();
            da2.Fill(dt2);
            cmbPompaci.DisplayMember = "PERAD";
            cmbPompaci.ValueMember = "PERID";
            cmbPompaci.DataSource = dt2;
            conn.Close();

            SqlCommand komut5 = new SqlCommand("select PERID,PERAD from Tbl_Personel", conn);
            SqlDataAdapter da5 = new SqlDataAdapter(komut5);
            DataTable dt5 = new DataTable();
            conn.Open();
            da5.Fill(dt5);
            cmbMuhasebeci.DisplayMember = "PERAD";
            cmbMuhasebeci.ValueMember = "PERID";
            cmbMuhasebeci.DataSource = dt5;
            conn.Close();


            // Son ID'yi bulma
            SqlConnection con = new SqlConnection(bgl.Adres);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Get_LastProfId";
            cmd.Connection = con;
            con.Open();
            object obj = cmd.ExecuteScalar();
            label24.Text = obj.ToString();
            con.Close();


            // Son ID'ye göre listeleme
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
            DataTable dt33 = new DataTable();
            SqlDataAdapter da22 = new SqlDataAdapter("select id,tarih,pompaci,muhasebeci from Tbl_YakitKasasi where Tbl_YakitKasasi.id = @id", connn);
            SqlDataAdapter da23 = new SqlDataAdapter("select zRaporu,otomasyon,halkPos1,halkPos2 from Tbl_YakitKasasi where Tbl_YakitKasasi.id = @id", connn);
            SqlDataAdapter da24 = new SqlDataAdapter("select ziraatPos1,ziraatPos2,kart,nakit from Tbl_YakitKasasi where Tbl_YakitKasasi.id = @id", connn);
            SqlDataAdapter da25 = new SqlDataAdapter("select veresiye,pompacidanAlinan,gider,gelir from Tbl_YakitKasasi where Tbl_YakitKasasi.id = @id", connn);
            SqlDataAdapter da26 = new SqlDataAdapter("select tahsilat,tahsilatFisNo,tahsilatAciklama from Tbl_YakitKasasi where Tbl_YakitKasasi.id = @id", connn);
            SqlDataAdapter da27 = new SqlDataAdapter("select toplam,acik,fazla from Tbl_YakitKasasi where Tbl_YakitKasasi.id = @id", connn);
            SqlDataAdapter da28 = new SqlDataAdapter("select gider,fisNo,giderAciklama from Tbl_YakitKasasi where Tbl_YakitKasasi.id = @id", connn);
            SqlDataAdapter da33 = new SqlDataAdapter("select gelir,gelirFisNo,gelirAciklama from Tbl_YakitKasasi where Tbl_YakitKasasi.id = @id", connn);
            SqlDataAdapter da29 = new SqlDataAdapter("select benzin,motorin,lpg from Tbl_YakitKasasi where Tbl_YakitKasasi.id = @id", connn);
            SqlDataAdapter da30 = new SqlDataAdapter("select yakitLitre,yakitTutar from Tbl_YakitKasasi where Tbl_YakitKasasi.id = @id", connn);
            SqlDataAdapter da31 = new SqlDataAdapter("select benzinStok,motorinStok,lpgStok from Tbl_YakitKasasi where Tbl_YakitKasasi.id = @id", connn);
            SqlDataAdapter da32 = new SqlDataAdapter("select * from Tbl_YakitKasasi where Tbl_YakitKasasi.id = @id", connn);




            da22.SelectCommand.Parameters.Add("@id", obj);
            da23.SelectCommand.Parameters.Add("@id", obj);
            da24.SelectCommand.Parameters.Add("@id", obj);
            da25.SelectCommand.Parameters.Add("@id", obj);
            da26.SelectCommand.Parameters.Add("@id", obj);
            da27.SelectCommand.Parameters.Add("@id", obj);
            da28.SelectCommand.Parameters.Add("@id", obj);
            da29.SelectCommand.Parameters.Add("@id", obj);
            da30.SelectCommand.Parameters.Add("@id", obj);
            da31.SelectCommand.Parameters.Add("@id", obj);
            da32.SelectCommand.Parameters.Add("@id", obj);
            da33.SelectCommand.Parameters.Add("@id", obj);
            connn.Open();
            da22.Fill(dt22);
            da23.Fill(dt23);
            da24.Fill(dt24);
            da25.Fill(dt25);
            da26.Fill(dt26);
            da27.Fill(dt27);
            da28.Fill(dt28);
            da29.Fill(dt29);
            da30.Fill(dt30);
            da31.Fill(dt31);
            da32.Fill(dt32);
            da33.Fill(dt33);
            dataGridView1.DataSource = dt22;
            dataGridView2.DataSource = dt23;
            dataGridView3.DataSource = dt24;
            dataGridView4.DataSource = dt25;
            dataGridView5.DataSource = dt26;
            dataGridView6.DataSource = dt27;
            dataGridView7.DataSource = dt28;
            dataGridView8.DataSource = dt29;
            dataGridView9.DataSource = dt30;
            dataGridView10.DataSource = dt31;
            dataGridView11.DataSource = dt32;
            dataGridView12.DataSource = dt33;
            connn.Close();

            
        }

        private void cmbBenzin_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBenzinBirimFiyat.Items.Clear();
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut3 = new SqlCommand("select BIRIMFIYATI from Tbl_Urunn where URUNAD=@p1", conn);
            komut3.Parameters.AddWithValue("@p1", cmbBenzin.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbBenzinBirimFiyat.Items.Add(dr3[0]);
            }
            conn.Close();
        }

        private void cmbMotorin_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMotorinBirimFiyat.Items.Clear();
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut3 = new SqlCommand("select BIRIMFIYATI from Tbl_Urunn where URUNAD=@p1", conn);
            komut3.Parameters.AddWithValue("@p1", cmbMotorin.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbMotorinBirimFiyat.Items.Add(dr3[0]);
            }
            conn.Close();
        }

        int id;
        //Db_SayacEntities2 db = new Db_SayacEntities2();
        //private void btnListele_Click(object sender, EventArgs e)
        //{
        //    //var values = db.Tbl_YakitKasasi.ToList();
        //    //dataGridView1.DataSource = values;

        //    SqlConnection conn = new SqlConnection(bgl.Adres);
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter("select id,zRaporu,otomasyon,halkPos1,halkPos2,ziraatPos1,ziraatPos2,kart,nakit,veresiye,pompacidanAlinan,gider,giderAciklama,toplam,acik,fazla,tahsilat,tahsilatAciklama,benzin,motorin,lpg,yakitLitre,yakitTutar,pompaci,muhasebeci,tarih from Tbl_YakitKasasi ORDER BY id DESC ", conn);
        //    /*from Tbl_Satis INNER JOIN Tbl_Musteri ON Tbl_Satis.SATISMUSTERI=Tbl_Musteri.MUSTERIID INNER JOIN Tbl_Urunn ON Tbl_Satis.YAKITCINSI = Tbl_Urunn.URUNID*/
        //    //da.SelectCommand.Parameters.Add("@p1", SqlDbType.Date).Value = DateTime.Now;
        //    conn.Open();
        //    da.Fill(dt);
        //    dataGridView1.DataSource = dt;
        //    conn.Close();
        //}

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            TxtID.Text = "";
            cmbPompaci.Text = "";
            cmbMuhasebeci.Text = "";
            TxtZraporu.Text = "";
            txtOtomasyon.Text = "";
            txtTahsilatTutar.Text = "";
            txtHpos1.Text = "";
            txtHpos2.Text = "";
            txtZpos1.Text = "";
            txtZpos2.Text = "";
            txtKrediKarti.Text = "";
            txtNakit.Text = "";
            txtVeresiye.Text = "";
            txtGiderTutar.Text = "";
            txtKasaTeslim.Text = "";
            txtGenelToplam.Text = "";
            txtAcikFazla.Text = "";
            cmbBenzin.Text = "";
            cmbMotorin.Text = "";
            cmbLpg.Text = "";
            cmbBenzinBirimFiyat.Text = "";
            cmbMotorinBirimFiyat.Text = "";
            cmbLpgBirimFiyat.Text = "";
            cmbBenzinStok.Text = "";
            cmbMotorinStok.Text = "";
            cmbLpgStok.Text = "";
            txtBenzinLitre.Text = "";
            txtMotorinLitre.Text = "";
            txtLpgLitre.Text = "";
            txtBenzinTutar.Text = "";
            txtMotorinTutar.Text = "";
            txtLpgTutar.Text = "";
            lblLitreToplam.Text = "";
            lblTutarToplam.Text = "";
            lblBenzinStok.Text = "";
            lblMotorinStok.Text = "";
            lblLpgStok.Text = "";
            rchGiderAciklama.Text = "";
            rchTahsilatAciklama.Text = "";
            txtFisNo.Text = "";
            rchGelirAciklama.Text = "";
            txtGelir.Text = "";
            txtGelirFisNo.Text = "";
            txtTahsilatFisNo.Text = "";
        }
        private void btnGorListele_Click(object sender, EventArgs e)
        {
            FrmYakitKasasiListele frm = new FrmYakitKasasiListele();
            frm.ShowDialog();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void txtBenzinLitre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOnizle_Click(object sender, EventArgs e)
        {
            YakitKasasiRaporlar.tarih = dtYakitKasaTarih.Value.ToShortDateString();
            YakitKasasiRaporlar.pompaci = cmbPompaci.Text;
            YakitKasasiRaporlar.muhasebeci = cmbPompaci.Text;
            YakitKasasiRaporlar.YakitKasasıGunlukRaporlar(dataGridView11);
        }



        private void cmbLpg_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLpgBirimFiyat.Items.Clear();
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut3 = new SqlCommand("select BIRIMFIYATI from Tbl_Urunn where URUNAD=@p1", conn);
            komut3.Parameters.AddWithValue("@p1", cmbLpg.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbLpgBirimFiyat.Items.Add(dr3[0]);
            }
            conn.Close();
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }



        double nakit, veresiye, kasaTeslim, otomasyon, acikFazla, genelToplam, gider;

        private void cmbLpgBirimFiyat_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLpgStok.Items.Clear();
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut3 = new SqlCommand("select STOK from Tbl_Urunn where URUNAD=@p1", conn);
            komut3.Parameters.AddWithValue("@p1", cmbLpg.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbLpgStok.Items.Add(dr3[0]);
            }
            conn.Close();
        }

        private void cmbMotorinBirimFiyat_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMotorinStok.Items.Clear();
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut3 = new SqlCommand("select STOK from Tbl_Urunn where URUNAD=@p1", conn);
            komut3.Parameters.AddWithValue("@p1", cmbMotorin.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbMotorinStok.Items.Add(dr3[0]);
            }
            conn.Close();
        }

        private void cmbBenzinBirimFiyat_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBenzinStok.Items.Clear();
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut3 = new SqlCommand("select STOK from Tbl_Urunn where URUNAD=@p1", conn);
            komut3.Parameters.AddWithValue("@p1", cmbBenzin.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbBenzinStok.Items.Add(dr3[0]);
            }
            conn.Close();
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
                kartToplam = halkPos1 + halkPos2 + ziraatPos1 + ziraatPos2;
                genelToplam = nakit + veresiye + kasaTeslim + kartToplam + gider;
                txtGenelToplam.Text = genelToplam.ToString("C2");
                acikFazla = otomasyon - genelToplam;
                txtAcikFazla.Text = acikFazla.ToString("C2");
            }
            catch (Exception)
            {

                MessageBox.Show("İlgili alanları doldurunuz");
            }
        }

        double halkPos1, halkPos2, ziraatPos1, ziraatPos2, kartToplam;
        private void btnKartHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                halkPos1 = Convert.ToDouble(txtHpos1.Text);
                halkPos2 = Convert.ToDouble(txtHpos2.Text);
                ziraatPos1 = Convert.ToDouble(txtZpos1.Text);
                ziraatPos2 = Convert.ToDouble(txtZpos2.Text);
                kartToplam = halkPos1 + halkPos2 + ziraatPos1 + ziraatPos2;
                txtKrediKarti.Text = kartToplam.ToString("C2");
            }
            catch (Exception)
            {

                MessageBox.Show("İlgili alanları doldurunuz");
            }
        }

        double Toplamlitre, benzinLitre, motorinLitre, lpgLitre;
        double ToplamTutar, BenzinToplamTutar, MotorinToplamTutar, LpgToplamTutar, benzinBirimFiyat, motorinBirimFiyat, lpgBirimFiyat;
        private void btnYakitHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                benzinLitre = Convert.ToDouble(txtBenzinLitre.Text);
                motorinLitre = Convert.ToDouble(txtMotorinLitre.Text);
                lpgLitre = Convert.ToDouble(txtLpgLitre.Text);

                benzinBirimFiyat = Convert.ToDouble(cmbBenzinBirimFiyat.Text);
                motorinBirimFiyat = Convert.ToDouble(cmbMotorinBirimFiyat.Text);
                lpgBirimFiyat = Convert.ToDouble(cmbLpgBirimFiyat.Text);

                benzinStok = Convert.ToDouble(cmbBenzinStok.Text);
                motorinStok = Convert.ToDouble(cmbMotorinStok.Text);
                lpgStok = Convert.ToDouble(cmbLpgStok.Text);

                BenzinToplamTutar = benzinLitre * benzinBirimFiyat;
                MotorinToplamTutar = motorinLitre * motorinBirimFiyat;
                LpgToplamTutar = lpgLitre * lpgBirimFiyat;

                benzinNetStok = benzinStok - benzinLitre;
                motorinNetStok = motorinStok - motorinLitre;
                lpgNetStok = lpgStok - lpgLitre;

                Toplamlitre = benzinLitre + motorinLitre + lpgLitre;
                ToplamTutar = BenzinToplamTutar + MotorinToplamTutar + LpgToplamTutar;

                lblBenzinStok.Text = benzinNetStok.ToString();
                lblMotorinStok.Text = motorinNetStok.ToString();
                lblLpgStok.Text = lpgNetStok.ToString();

                txtBenzinTutar.Text = BenzinToplamTutar.ToString();
                txtMotorinTutar.Text = MotorinToplamTutar.ToString();
                txtLpgTutar.Text = LpgToplamTutar.ToString();

                lblLitreToplam.Text = Toplamlitre.ToString();
                lblTutarToplam.Text = ToplamTutar.ToString("C2");
            }
            catch (Exception)
            {

                MessageBox.Show("İlgili alanları doldurunuz");
            }
        }
    }
}
