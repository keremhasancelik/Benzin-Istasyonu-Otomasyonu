using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayac_Proje
{
    public class YakitKasasi
    {
        public int id { get; set; }
        public DateTime tarih { get; set; }
        public string pompaci { get; set; }
        public string muhasebeci { get; set; }
        public double zRaporu { get; set; }
        public double otomasyon { get; set; }
        public double halkPos1 { get; set; }
        public double halkPos2 { get; set; }
        public double ziraatPos1 { get; set; }
        public double ziraatPos2 { get; set; }
        public double kart { get; set; }
        public double nakit { get; set; }
        public double veresiye { get; set; }
        public double pompacidanAlinan { get; set; }
        public double gider { get; set; }
        public string fisNo { get; set; }
        public string giderAciklama { get; set; }
        public double gelir { get; set; }
        public string gelirFisNo { get; set; }
        public string gelirAciklama { get; set; }
        public double toplam { get; set; }
        public double acik  { get; set; }
        public double fazla  { get; set; }
        public double tahsilat  { get; set; }
        public string tahsilatFisNo { get; set; }
        public string tahsilatAciklama { get; set; }
        public double benzin { get; set; }
        public double motorin { get; set; }
        public double lpg { get; set; }
        public double yakitLitre { get; set; }
        public double yakitTutar { get; set; }
        public double benzinStok { get; set; }
        public double motorinStok { get; set; }
        public double lpgStok { get; set; }
    }
}
