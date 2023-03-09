using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayac_Proje
{
    public class MarketKasasi
    {
        public int id { get; set; }
        public DateTime tarih { get; set; }
        public string kasiyer { get; set; }
        public string muhasebeci { get; set; }
        public double zRaporu { get; set; }
        public double otomasyonToplam { get; set; }
        public double gunSonu1 { get; set; }
        public double gunSonu2 { get; set; }
        public double kartToplam { get; set; }
        public double nakit { get; set; }
        public double veresiyeToplam { get; set; }
        public double muhasebeTeslim { get; set; }
        public double gider { get; set; }
        public string giderFisNo { get; set; }
        public string giderAciklama { get; set; }
        public double gelir { get; set; }
        public string gelirFisNo { get; set; }
        public string gelirAciklama { get; set; }
        public double toplam { get; set; }
        public double acik { get; set; }
        public double fazla { get; set; }
        public double tahsilat { get; set; }
        public string tahsilatFisNo { get; set; }
        public string tahsilatAciklama { get; set; }
        public string vardiyaNotu { get; set; }
    }
}
