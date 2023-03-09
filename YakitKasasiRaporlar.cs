using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayac_Proje
{
    static class YakitKasasiRaporlar
    {
        public static string tarih { get; set; }
        public static string pompaci { get; set; }
        public static string muhasebeci { get; set; }

        public static void YakitKasasıGunlukRaporlar(DataGridView dgv)
        {
            Cursor.Current = Cursors.WaitCursor;

            List<YakitKasasi> list = new List<YakitKasasi>();
            list.Clear();
            for(int i = 0; i < dgv.Rows.Count; i++)
            {
                list.Add(new YakitKasasi
                {
                    id = Convert.ToInt32( dgv.Rows[i].Cells["id"].Value.ToString()),
                    tarih = Convert.ToDateTime( dgv.Rows[i].Cells["tarih"].Value.ToString()),
                    pompaci = dgv.Rows[i].Cells["pompaci"].Value.ToString(),
                    muhasebeci = dgv.Rows[i].Cells["muhasebeci"].Value.ToString(),
                    zRaporu = Convert.ToDouble(dgv.Rows[i].Cells["zRaporu"].Value.ToString()),
                    otomasyon = Convert.ToDouble(dgv.Rows[i].Cells["otomasyon"].Value.ToString()),
                    halkPos1 = Convert.ToDouble(dgv.Rows[i].Cells["halkPos1"].Value.ToString()),
                    halkPos2 = Convert.ToDouble(dgv.Rows[i].Cells["halkPos2"].Value.ToString()),
                    ziraatPos1 = Convert.ToDouble(dgv.Rows[i].Cells["ziraatPos1"].Value.ToString()),
                    ziraatPos2 = Convert.ToDouble(dgv.Rows[i].Cells["ziraatPos2"].Value.ToString()),
                    kart = Convert.ToDouble(dgv.Rows[i].Cells["kart"].Value.ToString()),
                    veresiye = Convert.ToDouble(dgv.Rows[i].Cells["veresiye"].Value.ToString()),
                    nakit = Convert.ToDouble(dgv.Rows[i].Cells["nakit"].Value.ToString()),
                    pompacidanAlinan = Convert.ToDouble(dgv.Rows[i].Cells["pompacidanAlinan"].Value.ToString()),
                    gider = Convert.ToDouble(dgv.Rows[i].Cells["gider"].Value.ToString()),
                    toplam = Convert.ToDouble(dgv.Rows[i].Cells["toplam"].Value.ToString()),
                    gelir = Convert.ToDouble(dgv.Rows[i].Cells["gelir"].Value.ToString()),
                    gelirFisNo = dgv.Rows[i].Cells["gelirFisNo"].Value.ToString(),
                    gelirAciklama = dgv.Rows[i].Cells["gelirAciklama"].Value.ToString(),
                    acik = Convert.ToDouble(dgv.Rows[i].Cells["acik"].Value.ToString()),
                    fazla = Convert.ToDouble(dgv.Rows[i].Cells["fazla"].Value.ToString()),
                    tahsilat = Convert.ToDouble(dgv.Rows[i].Cells["tahsilat"].Value.ToString()),
                    tahsilatFisNo = dgv.Rows[i].Cells["tahsilatFisNo"].Value.ToString(),
                    tahsilatAciklama = dgv.Rows[i].Cells["tahsilatAciklama"].Value.ToString(),
                    fisNo = dgv.Rows[i].Cells["fisNo"].Value.ToString(),
                    giderAciklama = dgv.Rows[i].Cells["giderAciklama"].Value.ToString(),
                    benzin = Convert.ToDouble(dgv.Rows[i].Cells["yakitLitre"].Value.ToString()),
                    motorin = Convert.ToDouble(dgv.Rows[i].Cells["motorin"].Value.ToString()),
                    lpg = Convert.ToDouble(dgv.Rows[i].Cells["lpg"].Value.ToString()),
                    yakitLitre = Convert.ToDouble(dgv.Rows[i].Cells["yakitLitre"].Value.ToString()),
                    yakitTutar = Convert.ToDouble(dgv.Rows[i].Cells["yakitTutar"].Value.ToString()),
                    benzinStok = Convert.ToDouble(dgv.Rows[i].Cells["benzinStok"].Value.ToString()),
                    motorinStok = Convert.ToDouble(dgv.Rows[i].Cells["motorinStok"].Value.ToString()),
                    lpgStok = Convert.ToDouble(dgv.Rows[i].Cells["lpgStok"].Value.ToString()),
                });
            }

            ReportDataSource rs = new ReportDataSource();
            rs.Name = "DataSet2";
            rs.Value = list;
            FrmYakiKasasiRapor frm = new FrmYakiKasasiRapor();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\rprYakitKasasiRapor.rdlc";
            
            

            ReportParameter[] prm = new ReportParameter[3];
            prm[0] = new ReportParameter("tarih", tarih);
            prm[1] = new ReportParameter("pompaci", pompaci);
            prm[2] = new ReportParameter("muhasebeci", muhasebeci);
            frm.reportViewer1.LocalReport.SetParameters(prm);
            frm.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            frm.reportViewer1.ZoomMode = ZoomMode.Percent;
            frm.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        public static void MarketKAsasiGunlukRaporlar(DataGridView dgv)
        {

            Cursor.Current = Cursors.WaitCursor;

            List<MarketKasasi> list = new List<MarketKasasi>();
            list.Clear();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                list.Add(new MarketKasasi
                {
                    id = Convert.ToInt32(dgv.Rows[i].Cells["id"].Value.ToString()),
                    tarih = Convert.ToDateTime(dgv.Rows[i].Cells["tarih"].Value.ToString()),
                    kasiyer = dgv.Rows[i].Cells["kasiyer"].Value.ToString(),
                    muhasebeci = dgv.Rows[i].Cells["muhasebeci"].Value.ToString(),
                    zRaporu = Convert.ToDouble(dgv.Rows[i].Cells["zRaporu"].Value.ToString()),
                    otomasyonToplam = Convert.ToDouble(dgv.Rows[i].Cells["otomasyonToplam"].Value.ToString()),
                    gunSonu1 = Convert.ToDouble( dgv.Rows[i].Cells["gunSonu1"].Value.ToString()),
                    gunSonu2 = Convert.ToDouble( dgv.Rows[i].Cells["gunSonu2"].Value.ToString()),
                    kartToplam = Convert.ToDouble( dgv.Rows[i].Cells["kartToplam"].Value.ToString()),
                    nakit = Convert.ToDouble( dgv.Rows[i].Cells["nakit"].Value.ToString()),
                    veresiyeToplam = Convert.ToDouble( dgv.Rows[i].Cells["veresiyeToplam"].Value.ToString()),
                    muhasebeTeslim = Convert.ToDouble( dgv.Rows[i].Cells["muhasebeTeslim"].Value.ToString()),
                    gider = Convert.ToDouble( dgv.Rows[i].Cells["gider"].Value.ToString()),
                    giderFisNo = dgv.Rows[i].Cells["giderFisNo"].Value.ToString(),
                    giderAciklama = dgv.Rows[i].Cells["giderAciklama"].Value.ToString(),
                    gelir = Convert.ToDouble(dgv.Rows[i].Cells["gelir"].Value.ToString()),
                    gelirFisNo = dgv.Rows[i].Cells["gelirFisNo"].Value.ToString(),
                    gelirAciklama = dgv.Rows[i].Cells["gelirAciklama"].Value.ToString(),
                    tahsilat = Convert.ToDouble(dgv.Rows[i].Cells["tahsilat"].Value.ToString()),
                    tahsilatFisNo = dgv.Rows[i].Cells["tahsilatFisNo"].Value.ToString(),
                    tahsilatAciklama = dgv.Rows[i].Cells["tahsilatAciklama"].Value.ToString(),
                    vardiyaNotu = dgv.Rows[i].Cells["vardiyaNotu"].Value.ToString()

                });
            }

            ReportDataSource rs = new ReportDataSource();
            rs.Name = "dataSetMarketKasasi";
            rs.Value = list;
            FrmYakiKasasiRapor frm = new FrmYakiKasasiRapor();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\rpMarketKasasi.rdlc";
            frm.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            frm.reportViewer1.ZoomMode = ZoomMode.Percent;
            frm.ShowDialog();
            Cursor.Current = Cursors.Default;

        }

        public static void YakitKasasıRaporlarTumu(DataGridView dgv)
        {
            Cursor.Current = Cursors.WaitCursor;

            List<YakitKasasi> list = new List<YakitKasasi>();
            list.Clear();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                list.Add(new YakitKasasi
                {
                    id = Convert.ToInt32(dgv.Rows[i].Cells["id"].Value.ToString()),
                    tarih = Convert.ToDateTime(dgv.Rows[i].Cells["tarih"].Value.ToString()),
                    pompaci = dgv.Rows[i].Cells["pompaci"].Value.ToString(),
                    muhasebeci = dgv.Rows[i].Cells["muhasebeci"].Value.ToString(),
                    zRaporu = Convert.ToDouble(dgv.Rows[i].Cells["zRaporu"].Value.ToString()),
                    otomasyon = Convert.ToDouble(dgv.Rows[i].Cells["otomasyon"].Value.ToString()),
                    halkPos1 = Convert.ToDouble(dgv.Rows[i].Cells["halkPos1"].Value.ToString()),
                    halkPos2 = Convert.ToDouble(dgv.Rows[i].Cells["halkPos1"].Value.ToString()),
                    ziraatPos1 = Convert.ToDouble(dgv.Rows[i].Cells["ziraatPos1"].Value.ToString()),
                    ziraatPos2 = Convert.ToDouble(dgv.Rows[i].Cells["ziraatPos2"].Value.ToString()),
                    kart = Convert.ToDouble(dgv.Rows[i].Cells["kart"].Value.ToString()),
                    veresiye = Convert.ToDouble(dgv.Rows[i].Cells["veresiye"].Value.ToString()),
                    nakit = Convert.ToDouble(dgv.Rows[i].Cells["nakit"].Value.ToString()),
                    pompacidanAlinan = Convert.ToDouble(dgv.Rows[i].Cells["pompacidanAlinan"].Value.ToString()),
                    gider = Convert.ToDouble(dgv.Rows[i].Cells["gider"].Value.ToString()),
                    toplam = Convert.ToDouble(dgv.Rows[i].Cells["toplam"].Value.ToString()),
                    gelir = Convert.ToDouble(dgv.Rows[i].Cells["gelir"].Value.ToString()),
                    gelirFisNo = dgv.Rows[i].Cells["gelirFisNo"].Value.ToString(),
                    gelirAciklama = dgv.Rows[i].Cells["gelirAciklama"].Value.ToString(),
                    acik = Convert.ToDouble(dgv.Rows[i].Cells["acik"].Value.ToString()),
                    fazla = Convert.ToDouble(dgv.Rows[i].Cells["fazla"].Value.ToString()),
                    tahsilat = Convert.ToDouble(dgv.Rows[i].Cells["tahsilat"].Value.ToString()),
                    tahsilatFisNo = dgv.Rows[i].Cells["tahsilatFisNo"].Value.ToString(),
                    tahsilatAciklama = dgv.Rows[i].Cells["tahsilatAciklama"].Value.ToString(),
                    fisNo = dgv.Rows[i].Cells["fisNo"].Value.ToString(),
                    giderAciklama = dgv.Rows[i].Cells["giderAciklama"].Value.ToString(),
                    benzin = Convert.ToDouble(dgv.Rows[i].Cells["yakitLitre"].Value.ToString()),
                    motorin = Convert.ToDouble(dgv.Rows[i].Cells["motorin"].Value.ToString()),
                    lpg = Convert.ToDouble(dgv.Rows[i].Cells["lpg"].Value.ToString()),
                    yakitLitre = Convert.ToDouble(dgv.Rows[i].Cells["yakitLitre"].Value.ToString()),
                    yakitTutar = Convert.ToDouble(dgv.Rows[i].Cells["yakitTutar"].Value.ToString()),
                    benzinStok = Convert.ToDouble(dgv.Rows[i].Cells["benzinStok"].Value.ToString()),
                    motorinStok = Convert.ToDouble(dgv.Rows[i].Cells["motorinStok"].Value.ToString()),
                    lpgStok = Convert.ToDouble(dgv.Rows[i].Cells["lpgStok"].Value.ToString()),
                });
            }

            ReportDataSource rs = new ReportDataSource();
            rs.Name = "DataSet2";
            rs.Value = list;
            FrmYakiKasasiRapor frm = new FrmYakiKasasiRapor();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\rpYakitKasasiTumu.rdlc";



            ReportParameter[] prm = new ReportParameter[3];
            prm[0] = new ReportParameter("tarih", tarih);
            prm[1] = new ReportParameter("pompaci", pompaci);
            prm[2] = new ReportParameter("muhasebeci", muhasebeci);
            frm.reportViewer1.LocalReport.SetParameters(prm);
            frm.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            frm.reportViewer1.ZoomMode = ZoomMode.Percent;
            frm.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        public static void YikamaKasasiGunlukRaporlar(DataGridView dgv)
        {

            Cursor.Current = Cursors.WaitCursor;

            List<YikamaKasasi> list = new List<YikamaKasasi>();
            list.Clear();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                list.Add(new YikamaKasasi
                {
                    id = Convert.ToInt32(dgv.Rows[i].Cells["id"].Value.ToString()),
                    tarih = Convert.ToDateTime(dgv.Rows[i].Cells["tarih"].Value.ToString()),
                    yikamaci = dgv.Rows[i].Cells["yikamaci"].Value.ToString(),
                    muhasebeci = dgv.Rows[i].Cells["muhasebeci"].Value.ToString(),
                    kart = Convert.ToDouble(dgv.Rows[i].Cells["kart"].Value.ToString()),
                    nakit = Convert.ToDouble(dgv.Rows[i].Cells["nakit"].Value.ToString()),
                    veresiye = Convert.ToDouble(dgv.Rows[i].Cells["veresiye"].Value.ToString()),
                    kasaTeslim = Convert.ToDouble(dgv.Rows[i].Cells["kasaTeslim"].Value.ToString()),
                    gider = Convert.ToDouble(dgv.Rows[i].Cells["gider"].Value.ToString()),
                    toplam = Convert.ToDouble(dgv.Rows[i].Cells["toplam"].Value.ToString()),
                    giderFisNo = dgv.Rows[i].Cells["giderFisNo"].Value.ToString(),
                    giderAciklama = dgv.Rows[i].Cells["giderAciklama"].Value.ToString(),
                    tahsilat = Convert.ToDouble(dgv.Rows[i].Cells["tahsilat"].Value.ToString()),
                    tahsilatFisNo = dgv.Rows[i].Cells["tahsilatFisNo"].Value.ToString(),
                    tahsilatAciklama = dgv.Rows[i].Cells["tahsilatAciklama"].Value.ToString(),
                    Aciklama = dgv.Rows[i].Cells["Aciklama"].Value.ToString(),



                });
            }

            ReportDataSource rs = new ReportDataSource();
            rs.Name = "DataSetYikamaKasasi";
            rs.Value = list;
            FrmYakiKasasiRapor frm = new FrmYakiKasasiRapor();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\rpYikamaKasasi.rdlc";
            frm.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            frm.reportViewer1.ZoomMode = ZoomMode.Percent;
            frm.ShowDialog();
            Cursor.Current = Cursors.Default;

        }

        public static void RestaurantKasasiGunlukRaporlar(DataGridView dgv)
        {

            Cursor.Current = Cursors.WaitCursor;

            List<RestaurantKasasi> list = new List<RestaurantKasasi>();
            list.Clear();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                list.Add(new RestaurantKasasi
                {
                    id = Convert.ToInt32(dgv.Rows[i].Cells["id"].Value.ToString()),
                    tarih = Convert.ToDateTime(dgv.Rows[i].Cells["tarih"].Value.ToString()),
                    kasiyer = dgv.Rows[i].Cells["kasiyer"].Value.ToString(),
                    muhasebeci = dgv.Rows[i].Cells["muhasebeci"].Value.ToString(),
                    kart = Convert.ToDouble(dgv.Rows[i].Cells["kart"].Value.ToString()),
                    nakit = Convert.ToDouble(dgv.Rows[i].Cells["nakit"].Value.ToString()),
                    veresiye = Convert.ToDouble(dgv.Rows[i].Cells["veresiye"].Value.ToString()),
                    gelir = Convert.ToDouble(dgv.Rows[i].Cells["gelir"].Value.ToString()),
                    gider = Convert.ToDouble(dgv.Rows[i].Cells["gider"].Value.ToString()),
                    toplam = Convert.ToDouble(dgv.Rows[i].Cells["toplam"].Value.ToString()),
                    tahsilat = Convert.ToDouble(dgv.Rows[i].Cells["tahsilat"].Value.ToString()),
                    gelirAciklama = dgv.Rows[i].Cells["gelirAciklama"].Value.ToString(),
                    giderAciklama = dgv.Rows[i].Cells["giderAciklama"].Value.ToString(),
                    TahsilatAciklama = dgv.Rows[i].Cells["TahsilatAciklama"].Value.ToString(),
                    Aciklama = dgv.Rows[i].Cells["Aciklama"].Value.ToString(),



                });
            }

            ReportDataSource rs = new ReportDataSource();
            rs.Name = "DataSetRestaurantKasasi";
            rs.Value = list;
            FrmYakiKasasiRapor frm = new FrmYakiKasasiRapor();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\rpRestaurantKasasi.rdlc";
            frm.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            frm.reportViewer1.ZoomMode = ZoomMode.Percent;
            frm.ShowDialog();
            Cursor.Current = Cursors.Default;

        }

        public static void SatisGunlukRaporlar(DataGridView dgv)
        {

            Cursor.Current = Cursors.WaitCursor;

            List<Satis> list = new List<Satis>();
            list.Clear();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                list.Add(new Satis
                {
                    SATISID = Convert.ToInt32(dgv.Rows[i].Cells["SATISID"].Value.ToString()),
                    TARIH = Convert.ToDateTime(dgv.Rows[i].Cells["TARIH"].Value.ToString()),
                    SATISMUSTER =dgv.Rows[i].Cells["MUSTERIAD"].Value.ToString(),
                    FISNO = dgv.Rows[i].Cells["FISNO"].Value.ToString(),
                    URUN = dgv.Rows[i].Cells["URUNAD"].Value.ToString(),
                    SATLITRE = Convert.ToDouble(dgv.Rows[i].Cells["SATLITRE"].Value.ToString()),
                    BFIYAT = Convert.ToDouble(dgv.Rows[i].Cells["BFIYAT"].Value.ToString()),
                    SATISTUTAR = Convert.ToDouble(dgv.Rows[i].Cells["SATISTUTAR"].Value.ToString()),
                    TAHSILAT = Convert.ToDouble(dgv.Rows[i].Cells["TAHSILAT"].Value.ToString()),
                    ACIKLAMA = dgv.Rows[i].Cells["ACIKLAMA"].Value.ToString(),



                });
            }


            ReportDataSource rs = new ReportDataSource();
            rs.Name = "DataSetSatis";
            rs.Value = list;
            FrmYakiKasasiRapor frm = new FrmYakiKasasiRapor();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\rpSatis.rdlc";
            frm.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            frm.reportViewer1.ZoomMode = ZoomMode.Percent;
            frm.ShowDialog();
            Cursor.Current = Cursors.Default;

        }

        public static void AlisGunlukRaporlar(DataGridView dgv)
        {

            Cursor.Current = Cursors.WaitCursor;

            List<Alis> list = new List<Alis>();
            list.Clear();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                list.Add(new Alis
                {
                    alisid = Convert.ToInt32(dgv.Rows[i].Cells["ALISID"].Value.ToString()),
                    tarih = Convert.ToDateTime(dgv.Rows[i].Cells["TARIH"].Value.ToString()),
                    birimFiyatı = Convert.ToDouble(dgv.Rows[i].Cells["BFIYATI"].Value.ToString()),
                    UrunAd = dgv.Rows[i].Cells["URUNAD"].Value.ToString(),
                    miktar = Convert.ToDouble(dgv.Rows[i].Cells["MIKTAR"].Value.ToString()),
                    stok = Convert.ToDouble(dgv.Rows[i].Cells["STK"].Value.ToString()),
                    faturaBedeli = Convert.ToDouble(dgv.Rows[i].Cells["FATURABEDELI"].Value.ToString()),
                    odeme = Convert.ToDouble(dgv.Rows[i].Cells["ODEME"].Value.ToString()),
                    kalanBakiye = Convert.ToDouble(dgv.Rows[i].Cells["KALANBAKIYE"].Value.ToString()),
                    TedarikciAd = dgv.Rows[i].Cells["TEDFIRMA"].Value.ToString()

                });
            }


            ReportDataSource rs = new ReportDataSource();
            rs.Name = "DataSetAlis";
            rs.Value = list;
            FrmYakiKasasiRapor frm = new FrmYakiKasasiRapor();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\rpAlis.rdlc";

            
            frm.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            frm.reportViewer1.ZoomMode = ZoomMode.Percent;
            frm.ShowDialog();
            Cursor.Current = Cursors.Default;

        }

        public static void CariGunlukRaporlar(DataGridView dgv)
        {

            Cursor.Current = Cursors.WaitCursor;

            List<Musteri> list = new List<Musteri>();
            list.Clear();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                list.Add(new Musteri
                {
                    MUSTERIID = Convert.ToInt32(dgv.Rows[i].Cells["MUSTERIID"].Value.ToString()),
                    MUSTERIAD = dgv.Rows[i].Cells["MUSTERIAD"].Value.ToString(),
                    toplamAlacak = Convert.ToDecimal(dgv.Rows[i].Cells["TOPLAMALACAK"].Value.ToString()),
                    sonOdeme = Convert.ToDateTime(dgv.Rows[i].Cells["SonOdemeTarihi"].Value.ToString()),
                    telefon = dgv.Rows[i].Cells["TELEFON"].Value.ToString(),
                    aciklama = dgv.Rows[i].Cells["Aciklama"].Value.ToString(),
                    mail = dgv.Rows[i].Cells["MAIL"].Value.ToString(),
                   
                });
            }


            ReportDataSource rs = new ReportDataSource();
            rs.Name = "DataSetCari";
            rs.Value = list;
            FrmYakiKasasiRapor frm = new FrmYakiKasasiRapor();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\rpCari.rdlc";
            frm.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            frm.reportViewer1.ZoomMode = ZoomMode.Percent;
            frm.ShowDialog();
            Cursor.Current = Cursors.Default;

        }

        public static void PersonelRaporlar(DataGridView dgv)
        {

            Cursor.Current = Cursors.WaitCursor;

            List<personel> list = new List<personel>();
            list.Clear();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                list.Add(new personel
                {
                    
                    personelAd = dgv.Rows[i].Cells["PERAD"].Value.ToString(),
                    personelMaas = Convert.ToDouble(dgv.Rows[i].Cells["PERMAAS"].Value.ToString()),
                    personelKalanMaas = Convert.ToDouble(dgv.Rows[i].Cells["PERKALANMAAS"].Value.ToString()),
                });
            }


            ReportDataSource rs = new ReportDataSource();
            rs.Name = "DataSetPersonel";
            rs.Value = list;
            FrmYakiKasasiRapor frm = new FrmYakiKasasiRapor();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\rpPersonel.rdlc";
            frm.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            frm.reportViewer1.ZoomMode = ZoomMode.Percent;
            frm.ShowDialog();
            Cursor.Current = Cursors.Default;

        }

        public static void PersonelMaasHareketRaporlar(DataGridView dgv)
        {

            Cursor.Current = Cursors.WaitCursor;

            List<personelMaasHareket> list = new List<personelMaasHareket>();
            list.Clear();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                list.Add(new personelMaasHareket
                {

                    personelAd = dgv.Rows[i].Cells["PersonelAd"].Value.ToString(),
                    Avans = Convert.ToDouble(dgv.Rows[i].Cells["PersonelAvans"].Value.ToString()),
                    personelKalanMaas = Convert.ToDouble(dgv.Rows[i].Cells["PersonelKalanMaas"].Value.ToString()),
                    AvansToplam = Convert.ToDouble(dgv.Rows[i].Cells["ToplamAlinanAvans"].Value.ToString()),
                    MaasArtisi = Convert.ToDouble(dgv.Rows[i].Cells["MaasArtisi"].Value.ToString()),
                    Aciklama = dgv.Rows[i].Cells["Aciklama"].Value.ToString(),
                    Tarih = Convert.ToDateTime(dgv.Rows[i].Cells["tarih"].Value.ToString()),
                });
            }


            ReportDataSource rs = new ReportDataSource();
            rs.Name = "DataSetPersonelMaasHareket";
            rs.Value = list;
            FrmYakiKasasiRapor frm = new FrmYakiKasasiRapor();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\rpPersonelMaasHareket.rdlc";
            frm.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            frm.reportViewer1.ZoomMode = ZoomMode.Percent;
            frm.ShowDialog();
            Cursor.Current = Cursors.Default;

        }

        public static void GiderRaporlar(DataGridView dgv)
        {

            Cursor.Current = Cursors.WaitCursor;

            List<gider> list = new List<gider>();
            list.Clear();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                list.Add(new gider
                {

                    giderBaslik = dgv.Rows[i].Cells["GiderBaslik"].Value.ToString(),
                    giderAciklama = dgv.Rows[i].Cells["GiderAciklama"].Value.ToString(),
                    giderTutar = Convert.ToDouble(dgv.Rows[i].Cells["GiderTutar"].Value.ToString()),
                    giderTarih = Convert.ToDateTime(dgv.Rows[i].Cells["GiderTarih"].Value.ToString()),
                });
            }


            ReportDataSource rs = new ReportDataSource();
            rs.Name = "DataSetGider";
            rs.Value = list;
            FrmYakiKasasiRapor frm = new FrmYakiKasasiRapor();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\rpGider.rdlc";
            frm.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            frm.reportViewer1.ZoomMode = ZoomMode.Percent;
            frm.ShowDialog();
            Cursor.Current = Cursors.Default;

        }

    }
}
