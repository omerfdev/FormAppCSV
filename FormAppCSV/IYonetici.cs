using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAppCSV
{
    internal interface IYonetici
    {
        public int UrunID { get; set; }
        public string UrunAd { get; set; }
        public double UrunFiyat { get; set; }
        public string UrunKategori { get; set; }

        public void Sil();
        public void Ekle();
        public void Kaydet();
        public void Ara();
    }
}
