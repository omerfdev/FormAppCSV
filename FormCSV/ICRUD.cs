namespace FormCSV
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