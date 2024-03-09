
namespace ClassMetotDemo
{
    class Musteri
    {
        internal string ýd;

        public Musteri()
        {
        }

        public Musteri(string isim, int ýd, string soyadý)
        {
            this.isim = isim;
            this.Id = ýd;
            this.Soyadý = soyadý;
        }

        public string isim { get; set; }
        public int Id { get; set; }
        public string Soyadý { get; set; }
    }
}