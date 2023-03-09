using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayac_Proje
{
    public class RestaurantKasasi
    {
        public int id { get; set; }
        public double nakit { get; set; }
        public double kart { get; set; }
        public double veresiye { get; set; }
        public double gider { get; set; }
        public double gelir { get; set; }
        public double toplam { get; set; }
        public double tahsilat { get; set; }
        public string giderAciklama { get; set; }
        public string gelirAciklama { get; set; }
        public string TahsilatAciklama { get; set; }
        public string Aciklama { get; set; }
        public string kasiyer { get; set; }
        public string muhasebeci { get; set; }
        public DateTime tarih { get; set; }
    }
}
