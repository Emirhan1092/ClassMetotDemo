
namespace ClassMetotDemo
{
	class MusteriManager
	{
		public void Ekle(Musteri musteri)
		{
			Console.WriteLine(musteri.isim + "adlý Musteri eklendi");
		}
		public void	Sil(Musteri musteri)
		{
			Console.WriteLine(musteri.isim + "adlý Musteri silindi");
		}

	public void MusteriListele(Musteri[] musteri)
		{
			foreach (Musteri musteriler in musteri)
			{
				Console.WriteLine("musteri ismi:" + musteriler.isim);
				Console.WriteLine("musteri ismi:" + musteriler.ýd);
				Console.WriteLine("musteri ismi:" + musteriler.Soyadý);

            }
        }
	}

	

}