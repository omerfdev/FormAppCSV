using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAppCSV
{
    internal class UrunYonetici: ICRUD<Urun>, IDosya
    {
     

        List<Urun> urunler = new List<Urun>();

        string _dosyaAdi;
        public UrunYonetici(string dosyaAdi)
        {
            _dosyaAdi = dosyaAdi;
        }

        public Urun Bul(int id)
        {
            return urunler.Find(x => x.UrunID == id);
        }

        public void Ekle(Urun entity)
        {
            urunler.Add(entity);
        }

        public void Guncelle(Urun entity)
        {
            Urun urun = Bul(entity.UrunID);
            urun.UrunAdi = entity.UrunAdi;
            urun.Fiyat = entity.Fiyat;
            urun.Kategori = entity.Kategori;
        }



        public List<Urun> Listele()
        {
            return urunler;
        }

        public void Sil(int id)
        {
            Urun urun = Bul(id);
            urunler.Remove(urun);
        }


        public void Kaydet()
        {
            StreamWriter sw = new StreamWriter(_dosyaAdi);

            foreach (var item in urunler)
            {
                sw.WriteLine(item);
            }
            sw.Close();
        }


        public void Yukle()
        {
            List<Urun> _urunler = new List<Urun>();
            if (DosyaKontrol())
            {
                StreamReader sr = new StreamReader(_dosyaAdi);

                do
                {
                    string satir = sr.ReadLine();
                    string[] dizi = satir.Split(';');

                    Urun urun = new Urun()
                    {
                        UrunID = int.Parse(dizi[0]),
                        UrunAdi = dizi[1],
                        Fiyat = double.Parse(dizi[2]),
                        Kategori = dizi[3]
                    };

                    _urunler.Add(urun);
                }
                while (!sr.EndOfStream);
                sr.Close();
            }
            urunler = _urunler;

        }

        private bool DosyaKontrol()
        {
            foreach (string str in Directory.GetFiles(Application.StartupPath))
            {
                if (str.Contains(_dosyaAdi)) return true;
            }
            return false;
        }
    }
}
