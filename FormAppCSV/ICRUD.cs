using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAppCSV
{
    internal interface ICRUD<T> where T : class
    {
        void Ekle(T entity);
        void Guncelle(T entity);
        void Sil(int id);
        List<T> Listele();
        T Bul(int id);

    }
}
