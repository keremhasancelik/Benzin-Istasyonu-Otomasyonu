using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayac_Proje
{
    public class personelMaasHareket
    {
        public int personelId { get; set; }
        public string personelAd { get; set; }
        public double personelKalanMaas { get; set; }
        public double Avans { get; set; }
        public double AvansToplam { get; set; }
        public double MaasArtisi { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
    }
}
