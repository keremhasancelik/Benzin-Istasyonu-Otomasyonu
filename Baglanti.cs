using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sayac_Proje
{
    class Baglanti
    {
        public string Adres = System.IO.File.ReadAllText(@"C:\sayac.txt");
    }
}
