using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.id = 1;
            musteri1.adi = "Selin";
            musteri1.soyadi = "Güney";

            Musteri musteri2 = new Musteri();
            musteri2.id = 2;
            musteri2.adi = "Kemal";
            musteri2.soyadi = "Gündoğdu";

            Musteri musteri3 = new Musteri();
            musteri3.id = 3;
            musteri3.adi = "Sinem";
            musteri3.soyadi = "Taşçelik";

            Musteri[] musteriler = { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Sil(musteri2);
            musteriManager.Ekle(musteri1);
            musteriManager.Listele(musteriler);

        }
    }
}
