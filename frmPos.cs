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
    public partial class frmPos : Form
    {
        public frmPos()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                halk = Convert.ToDouble(txtHalk.Text);
                isbank = Convert.ToDouble(txtIs.Text);
                garanti = Convert.ToDouble(txtGaranti.Text);
                qnb = Convert.ToDouble(txtQnb.Text);
                yapi = Convert.ToDouble(txtYapiKredi.Text);
                vakif = Convert.ToDouble(txtVakif.Text);
                ziraat = Convert.ToDouble(txtZiraat.Text);

                toplam = halk + isbank + garanti + qnb + yapi + vakif + ziraat;
                SqlConnection conn = new SqlConnection(bgl.Adres);
                conn.Open();
                SqlCommand komut3 = new SqlCommand("insert into Tbl_Pos(HalkBank,Isbankasi,Garanti,Qnb,YapiKredi,VakifBank,Ziraat,PosToplam,Tarih) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", conn);
                komut3.Parameters.AddWithValue("@p1", halk);
                komut3.Parameters.AddWithValue("@p2", isbank);
                komut3.Parameters.AddWithValue("@p3", garanti);
                komut3.Parameters.AddWithValue("@p4", qnb);
                komut3.Parameters.AddWithValue("@p5", yapi);
                komut3.Parameters.AddWithValue("@p6", vakif);
                komut3.Parameters.AddWithValue("@p7", ziraat);
                komut3.Parameters.AddWithValue("@p8", toplam);
                komut3.Parameters.AddWithValue("@p9", dtPosTarih.Value);

                komut3.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Kaydedildi");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        double halk, isbank, garanti, qnb, yapi, vakif, ziraat, toplam;

        private void btnTemizle_Click(object sender, EventArgs e)
        {

            lblHalkToplam.Text = "";
            lblIsToplam.Text = "";
            lblGaranti.Text = "";
            lblQnb.Text = "";
            lblYapi.Text = "";
            lblVakif.Text = "";
            lblZiraat.Text = "";
            lblToplam.Text = "";
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(bgl.Adres);

                SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Pos where tarih between @p1 and @p2 ORDER BY POSID DESC", conn);
                conn.Open();
                da.SelectCommand.Parameters.AddWithValue("@p1", SqlDbType.Date).Value = dateTimePicker1.Value;
                da.SelectCommand.Parameters.AddWithValue("@p2", SqlDbType.Date).Value = dateTimePicker2.Value;

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                SqlCommand komut3 = new SqlCommand("select sum(HalkBank), sum(Isbankasi), sum(Garanti),  sum(Qnb), sum(YapiKredi), sum(VakifBank), sum(Ziraat), sum(PosToplam)  from Tbl_Pos", conn);
                SqlDataReader dr3 = komut3.ExecuteReader();
                while (dr3.Read())
                {

                    lblHalkToplam.Text = dr3[0].ToString();
                    lblIsToplam.Text = dr3[1].ToString();
                    lblGaranti.Text = dr3[2].ToString();
                    lblQnb.Text = dr3[3].ToString();
                    lblYapi.Text = dr3[4].ToString();
                    lblVakif.Text = dr3[5].ToString();
                    lblZiraat.Text = dr3[6].ToString();
                    lblToplam.Text = dr3[7].ToString();



                }
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(bgl.Adres);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Pos", conn);
                conn.Open();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                SqlCommand komut2 = new SqlCommand("select sum(HalkBank), sum(Isbankasi), sum(Garanti),  sum(Qnb), sum(YapiKredi), sum(VakifBank), sum(Ziraat), sum(PosToplam)  from Tbl_Pos", conn);
                SqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    lblHalkToplam.Text = dr2[0].ToString();
                    lblIsToplam.Text = dr2[1].ToString();
                    lblGaranti.Text = dr2[2].ToString();
                    lblQnb.Text = dr2[3].ToString();
                    lblYapi.Text = dr2[4].ToString();
                    lblVakif.Text = dr2[5].ToString();
                    lblZiraat.Text = dr2[6].ToString();
                    lblToplam.Text = dr2[7].ToString();



                }
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                halk = Convert.ToDouble(txtHalk.Text);
                isbank = Convert.ToDouble(txtIs.Text);
                garanti = Convert.ToDouble(txtGaranti.Text);
                qnb = Convert.ToDouble(txtQnb.Text);
                yapi = Convert.ToDouble(txtYapiKredi.Text);
                vakif = Convert.ToDouble(txtVakif.Text);
                ziraat = Convert.ToDouble(txtZiraat.Text);

                toplam = halk + isbank + garanti + qnb + yapi + vakif + ziraat;

                txtPosToplam.Text = toplam.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
