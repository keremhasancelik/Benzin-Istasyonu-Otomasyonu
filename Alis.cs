using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayac_Proje
{
    public class Alis
    {
        public int alisid { get; set; }
        public DateTime tarih { get; set; }
        public double birimFiyatı { get; set; }
        public double miktar { get; set; }
        public double stok { get; set; }
        public double faturaBedeli { get; set; }
        public double odeme { get; set; }
        public double kalanBakiye { get; set; }
        public virtual Tedarikci Tedarikci { get; set; }
        public virtual Urun Urun { get; set; }
        public int tedarikciId { get; set; }
        public string TedarikciAd { get; set; }
        public string UrunAd { get; set; }
        public int UrunId { get; set; }
        

    }
}
