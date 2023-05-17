using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAppCSV
{
    internal class Urun : IYonetici
    {   
        
        public int UrunID { get ; set ; }
        public string UrunAd { get; set ; }
        public double UrunFiyat { get; set; }
        public string UrunKategori { get ; set; }
        public void Ara()
        {
            
        }

        public void Ekle()
        {
          
        }

        public void Kaydet()
        {
            
        }

        public void Sil(int row)
        {
            string csvFilePath = @"C:\Users\omerf\source\repos\FormAppCSV\FormAppCSV\Data\Data.csv";
            string[] lines = File.ReadAllLines(csvFilePath);
            List<string> updatedLines = new List<string>(lines);
            updatedLines.RemoveAt(row);
            File.WriteAllLines(csvFilePath, updatedLines);
        }

        public void Sil()
        {
            
        }
    }
}
