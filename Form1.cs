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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        int acilis, kapanis, satilan;
        double tutar,b_fiyat;
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtSayacID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            CmbUrun.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            CmbPompa.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbBFiyati.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtAcilis.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtKapanis.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtSatilanLitre.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            TxtTutar.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            
        }
        public int urun;
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            acilis = int.Parse(TxtAcilis.Text);
            kapanis = int.Parse(TxtKapanis.Text);
            b_fiyat = Convert.ToDouble(CmbBFiyati.Text);
            satilan = kapanis - acilis;
            tutar = b_fiyat * satilan;
            urun = int.Parse(CmbUrun.SelectedValue.ToString());
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut = new SqlCommand("update Tbl_Sayac set URUN=@p1,POMPA=@p2,BRMFIYATI=@p3,ACILIS=@p4,KAPANIS=@p5,SATILANLITRE=@p6,TUTAR=@p7,TARIH=@p8 where SAYACID=@p9", conn);
            komut.Parameters.AddWithValue("@p1", urun);
            komut.Parameters.AddWithValue("@p2", CmbPompa.Text);
            komut.Parameters.AddWithValue("@p3", Convert.ToDecimal( CmbBFiyati.Text));
            komut.Parameters.AddWithValue("@p4", TxtAcilis.Text);
            komut.Parameters.AddWithValue("@p5", TxtKapanis.Text);
            komut.Parameters.AddWithValue("@p6", satilan.ToString());
            komut.Parameters.AddWithValue("@p7", tutar);
            komut.Parameters.AddWithValue("@p8", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@p9", TxtSayacID.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Güncellendi");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut = new SqlCommand("delete from Tbl_Sayac where SAYACID=@p1",conn);
            komut.Parameters.AddWithValue("@p1", TxtSayacID.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Silindi");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAcilis.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            TxtSayacID.Text = "";
            TxtAcilis.Text = "";
            TxtKapanis.Text = "";
            TxtSatilanLitre.Text = "";
            TxtToplamLitre.Text = "";
            TxtToplamTutar.Text = "";
            TxtTutar.Text = "";
            CmbUrun.Text = "";
            CmbStok.Text = "";
            CmbPompa.Text = "";
            CmbBFiyati.Text = "";

        }

        private void BtnAlis_Click(object sender, EventArgs e)
        {
            FrmAlis frm = new FrmAlis();
            frm.Show();
        }

        private void BtnUrunler_Click(object sender, EventArgs e)
        {
            FrmUrun frm = new FrmUrun();
            frm.Show();
        }

        private void BtnTedarikciler_Click(object sender, EventArgs e)
        {
            FrmTedarikci frm = new FrmTedarikci();
            frm.Show();
        }

        private void BtnMusteriler_Click(object sender, EventArgs e)
        {
            FrmMusteriler frm = new FrmMusteriler();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmPersonel frm = new FrmPersonel();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut = new SqlCommand("select URUNID,URUNAD from Tbl_Urunn", conn);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbUrun.DisplayMember = "URUNAD";
            CmbUrun.ValueMember = "URUNID";
            CmbUrun.DataSource = dt;
            conn.Close();
            //
            CmbPompa.Items.Clear();

            conn.Open();
            SqlCommand komut4 = new SqlCommand("select POPPAID,POMPANO from Tbl_Pompa order by POMPANO asc", conn);
            SqlDataAdapter da4 = new SqlDataAdapter(komut4);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            CmbPompa.DisplayMember = "POMPANO";
            CmbPompa.ValueMember = "POPPAID";
            CmbPompa.DataSource = dt4;
            conn.Close();


        }

        private void CmbBFiyati_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbStok.Items.Clear();
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut3 = new SqlCommand("select STOK from Tbl_Urunn where URUNAD=@p1", conn);
            komut3.Parameters.AddWithValue("@p1", CmbUrun.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbStok.Items.Add(dr3[0]);
            }
            conn.Close();

            
        }

        private void CmbUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbBFiyati.Items.Clear();
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut3 = new SqlCommand("select BIRIMFIYATI from Tbl_Urunn where URUNAD=@p1", conn);
            komut3.Parameters.AddWithValue("@p1", CmbUrun.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbBFiyati.Items.Add(dr3[0]);
            }
            conn.Close();

            
        }

        private void BtnFiltrele_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(bgl.Adres);
            DataTable dt = new DataTable();
            string sql = "select SAYACID,URUNAD,POMPA,BRMFIYATI,ACILIS,KAPANIS,SATILANLITRE,TUTAR,TARIH from Tbl_Sayac INNER JOIN Tbl_Urunn ON Tbl_Sayac.URUN=Tbl_Urunn.URUNID where TARIH between @p1 and @p2";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@p1", SqlDbType.Date).Value= dateTimePicker1.Value;
            da.SelectCommand.Parameters.AddWithValue("@p2", SqlDbType.Date).Value= dateTimePicker2.Value;
            conn.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int satir = dataGridView1.Rows.Count -1;
            int satir2= dataGridView1.Rows.Count - 1;
            decimal tutar=0;
            int litre = 0;
            for (int i = 0; i < satir; i++)
            {
                tutar += decimal.Parse(dataGridView1.Rows[i].Cells["tutar"].Value.ToString());
                litre += int.Parse(dataGridView1.Rows[i].Cells["SATILANLITRE"].Value.ToString());
            }
            dataGridView1.Rows[satir].Cells["tutar"].Value ="Toplam = "+ string.Format("{0:C2}",tutar);
            dataGridView1.Rows[satir2].Cells["SATILANLITRE"].Value ="Toplam = "+ litre;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            //FrmPrint frm = new FrmPrint();
            // frm.Show();
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Font font = new Font("Georgia", 14);
                SolidBrush firca = new SolidBrush(Color.Black);
                //Pen kalem = new Pen(Color.Black);
                e.Graphics.DrawString($"Tarih={DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")}", font, firca, 50, 25);

                font = new Font("Georgia", 14);
                e.Graphics.DrawString("ID", font, firca, 60, 170);
                e.Graphics.DrawString("Ürün", font, firca, 120, 170);
                e.Graphics.DrawString("Pompa", font, firca, 200, 170);
                e.Graphics.DrawString("B. Fiyatı", font, firca, 280, 170);
                e.Graphics.DrawString("Açılış", font, firca, 360, 170);
                e.Graphics.DrawString("Kapanış", font, firca, 440, 170);
                e.Graphics.DrawString("S. Litre", font, firca, 520, 170);
                e.Graphics.DrawString("Tutar", font, firca, 600, 170);
                e.Graphics.DrawString("*****************************************************************************", font, firca, 60, 750);
                e.Graphics.DrawString("Toplam Litre = ", font, firca, 60, 800);
                e.Graphics.DrawString(TxtToplamLitre.Text, font, firca, 220, 800);
                e.Graphics.DrawString("Toplam Tutar = ", font, firca, 60, 850);
                e.Graphics.DrawString(TxtToplamTutar.Text, font, firca, 220, 850);
                e.Graphics.DrawString("Benzin Toplam Litre = ", font, firca, 380, 800);
                e.Graphics.DrawString(LblBenzinTopLitre.Text, font, firca, 600, 800);
                e.Graphics.DrawString("Benzin Toplam Tutar = ", font, firca, 380, 850);
                e.Graphics.DrawString(LblBenzinTopTutar.Text, font, firca, 600, 850);
                e.Graphics.DrawString("Motorin Toplam Litre = ", font, firca, 380, 900);
                e.Graphics.DrawString(LblMotorinTopLitre.Text, font, firca, 600, 900);
                e.Graphics.DrawString("Motorin Toplam Tutar = ", font, firca, 380, 950);
                e.Graphics.DrawString(LblMotorinTopTutar.Text, font, firca, 600, 950);
                e.Graphics.DrawString("LPG Toplam Litre = ", font, firca, 380, 1000);
                e.Graphics.DrawString(LblLpgTopLitre.Text, font, firca, 600, 1000);
                e.Graphics.DrawString("LPG Toplam Tutar = ", font, firca, 380, 1050);
                e.Graphics.DrawString(LblLpgTopTutar.Text, font, firca, 600, 1050);

                int i = 0;
                int y = 210;
                while (i<=dataGridView1.Rows.Count - 2)
                {
                    font = new Font("Georgia", 14);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), font, firca, 60, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), font, firca, 120, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), font, firca, 200, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), font, firca, 280, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].Value.ToString(), font, firca, 360, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[5].Value.ToString(), font, firca, 440, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[6].Value.ToString(), font, firca, 520, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[7].Value.ToString(), font, firca, 600, y);
                    y = y + 40;
                    i++;
                    
                }

                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void BtnPrintt_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void BtnPompa_Click(object sender, EventArgs e)
        {
            FrmPompa frm = new FrmPompa();
            frm.Show();
        }

        private void BtnFaturalar_Click(object sender, EventArgs e)
        {
            FrmFatura frm = new FrmFatura();
            frm.Show();
        }

        private void BtnKurlar_Click(object sender, EventArgs e)
        {
            FrmKurlar frm = new FrmKurlar();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGelir frm = new FrmGelir();
            frm.Show();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            


            SqlConnection conn = new SqlConnection(bgl.Adres);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select top(12) SAYACID,URUNAD,POMPA,BRMFIYATI,ACILIS,KAPANIS,SATILANLITRE,TUTAR,TARIH from Tbl_Sayac INNER JOIN Tbl_Urunn ON Tbl_Sayac.URUN=Tbl_Urunn.URUNID WHERE TARIH=@p1", conn);
            da.SelectCommand.Parameters.Add("@p1", SqlDbType.Date).Value = DateTime.Now;
            conn.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

            //
            decimal toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value);
            }
            TxtToplamTutar.Text = toplam.ToString();

            //
            decimal toplamLitre = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplamLitre += Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value);
            }
            TxtToplamLitre.Text = toplamLitre.ToString();
            //
            conn.Open();
            SqlCommand komut = new SqlCommand("select sum(TTUTAR) from Tbl_BenzinSatis WHERE BTARIH=@p1", conn);
            komut.Parameters.Add("@p1", SqlDbType.Date).Value = DateTime.Now;
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblBenzinTopTutar.Text = dr[0].ToString();
            }
            conn.Close();
            //
            conn.Open();
            SqlCommand komut2 = new SqlCommand("select sum(TLITRE) from Tbl_BenzinSatis WHERE BTARIH=@p1", conn);
            komut2.Parameters.Add("@p1", SqlDbType.Date).Value = DateTime.Now;
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblBenzinTopLitre.Text = dr2[0].ToString();
            }
            conn.Close();
            //
            conn.Open();
            SqlCommand komut3 = new SqlCommand("select sum(LTLITRE) from Tbl_LpgSatis WHERE LTARIH=@p1", conn);
            komut3.Parameters.Add("@p1", SqlDbType.Date).Value = DateTime.Now;
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblLpgTopLitre.Text = dr3[0].ToString();
            }
            conn.Close();
            //
            conn.Open();
            SqlCommand komut4 = new SqlCommand("select sum(LTTUTAR) from Tbl_LpgSatis WHERE LTARIH=@p1", conn);
            komut4.Parameters.Add("@p1", SqlDbType.Date).Value = DateTime.Now;
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblLpgTopTutar.Text = dr4[0].ToString();
            }
            conn.Close();
            //
            conn.Open();
            SqlCommand komut5 = new SqlCommand("select sum(MTTUTAR) from Tbl_MotorinSatis WHERE MTARIH=@p1", conn);
            komut5.Parameters.Add("@p1", SqlDbType.Date).Value = DateTime.Now;
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                LblMotorinTopTutar.Text = dr5[0].ToString();
            }
            conn.Close();
            //
            conn.Open();
            SqlCommand komut6 = new SqlCommand("select sum(MTLITRE) from Tbl_MotorinSatis WHERE MTARIH=@p1", conn);
            komut6.Parameters.Add("@p1", SqlDbType.Date).Value = DateTime.Now;
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                LblMotorinTopLitre.Text = dr6[0].ToString();
            }
            conn.Close();

            //
            conn.Open();
            SqlCommand komut7 = new SqlCommand("select sum(GELIRTUTAR) from Tbl_Gelir", conn);
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                LblGelir.Text = dr7[0].ToString();
            }
            conn.Close();

        }
        public decimal stok, t_stok;
        private void BtnEkle_Click(object sender, EventArgs e)
        {
           
            acilis =int.Parse( TxtAcilis.Text);
            kapanis =int.Parse( TxtKapanis.Text);
            b_fiyat = Convert.ToDouble ( CmbBFiyati.Text);
            satilan = kapanis - acilis;
            stok = Convert.ToDecimal(CmbStok.Text);

            t_stok = stok - satilan;
            tutar = b_fiyat * satilan;
            urun = int.Parse(CmbUrun.SelectedValue.ToString());
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Sayac(URUN,POMPA,BRMFIYATI,ACILIS,KAPANIS,SATILANLITRE,TUTAR,TARIH) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", conn);
            komut.Parameters.AddWithValue("@p1", urun);
            komut.Parameters.AddWithValue("@p2", CmbPompa.Text);
            komut.Parameters.AddWithValue("@p3", Convert.ToDecimal(CmbBFiyati.Text));
            komut.Parameters.AddWithValue("@p4", TxtAcilis.Text);
            komut.Parameters.AddWithValue("@p5", TxtKapanis.Text);
            komut.Parameters.AddWithValue("@p6", satilan.ToString());
            komut.Parameters.AddWithValue("@p7", tutar);
            komut.Parameters.AddWithValue("@p8", dateTimePicker1.Value);
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
            if (urun==2)
            {
                
                conn.Open();
                SqlCommand komut3 = new SqlCommand("insert into Tbl_BenzinSatis(TLITRE,TTUTAR,BTARIH) values(@p1,@p2,@p3)", conn);
                komut3.Parameters.AddWithValue("@p1", satilan.ToString());
                komut3.Parameters.AddWithValue("@p2", tutar);
                komut3.Parameters.AddWithValue("@p3", dateTimePicker1.Value);

                komut3.ExecuteNonQuery();
                conn.Close();
            }
            if (urun==3)
            {
                conn.Open();
                SqlCommand komut4 = new SqlCommand("insert into Tbl_MotorinSatis(MTLITRE,MTTUTAR,MTARIH) values(@p1,@p2,@p3)", conn);
                komut4.Parameters.AddWithValue("@p1", satilan.ToString());
                komut4.Parameters.AddWithValue("@p2", tutar);
                komut4.Parameters.AddWithValue("@p3", dateTimePicker1.Value);
                komut4.ExecuteNonQuery();
                conn.Close();
            }
            if (urun==4)
            {
                conn.Open();
                SqlCommand komut5 = new SqlCommand("insert into Tbl_LpgSatis(LTLITRE,LTTUTAR,LTARIH) values(@p1,@p2,@p3)", conn);
                komut5.Parameters.AddWithValue("@p1", satilan.ToString());
                komut5.Parameters.AddWithValue("@p2", tutar);
                komut5.Parameters.AddWithValue("@p3", dateTimePicker1.Value);
                komut5.ExecuteNonQuery();
                conn.Close();
            }

            //
            
            conn.Open();
            SqlCommand komut6 = new SqlCommand("insert into Tbl_Gelir(YAKIT,GELIRTUTAR,GELIRTARIH) VALUES(@p1,@p2,@p3)", conn);
            komut6.Parameters.AddWithValue("@p1", urun);
            komut6.Parameters.AddWithValue("@p2", tutar);
            komut6.Parameters.AddWithValue("@p3", dateTimePicker1.Value);
            komut6.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Eklendi");

        }
    }
}
