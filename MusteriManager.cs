
namespace ClassMetotDemo
{
	class MusteriManager
	{
		public void Ekle(Musteri musteri)
		{
			Console.WriteLine(musteri.isim + "adl� Musteri eklendi");
		}
		public void	Sil(Musteri musteri)
		{
			Console.WriteLine(musteri.isim + "adl� Musteri silindi");
		}

	public void MusteriListele(Musteri[] musteri)
		{
			foreach (Musteri musteriler in musteri)
			{
				Console.WriteLine("musteri ismi:" + musteriler.isim);
				Console.WriteLine("musteri ismi:" + musteriler.�d);
				Console.WriteLine("musteri ismi:" + musteriler.Soyad�);

            }
        }
	}

	

}