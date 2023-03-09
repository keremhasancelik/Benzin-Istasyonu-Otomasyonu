using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayac_Proje
{
    public class YikamaKasasi
    {
        public int id { get; set; }
        public double kart { get; set; }
        public double nakit { get; set; }
        public double veresiye { get; set; }
        public double kasaTeslim { get; set; }
        public double gider { get; set; }
        public double toplam { get; set; }
        public string giderFisNo { get; set; }
        public string giderAciklama { get; set; }
        public double tahsilat { get; set; }
        public string tahsilatFisNo { get; set; }
        public string tahsilatAciklama { get; set; }
        public string Aciklama { get; set; }
        public string yikamaci { get; set; }
        public string muhasebeci { get; set; }
        public DateTime tarih { get; set; }
    }
}
