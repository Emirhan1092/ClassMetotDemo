
namespace ClassMetotDemo
{
    class Musteri
    {
        internal string �d;

        public Musteri()
        {
        }

        public Musteri(string isim, int �d, string soyad�)
        {
            this.isim = isim;
            this.Id = �d;
            this.Soyad� = soyad�;
        }

        public string isim { get; set; }
        public int Id { get; set; }
        public string Soyad� { get; set; }
    }
}