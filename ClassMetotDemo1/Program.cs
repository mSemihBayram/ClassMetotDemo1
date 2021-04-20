using System;

namespace ClassMetotDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAdi = "Muammer";
            musteri1.MusteriSoyadi = "Baytar";
            musteri1.Tc = "12345678910";
            musteri1.Sehir = "Bahçesaray";
            musteri1.HesapNo = 123;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAdi = "Ömer";
            musteri2.MusteriSoyadi = "Adıgüzel";
            musteri2.Tc = "12345678911";
            musteri2.Sehir = "Gevaş";
            musteri2.HesapNo = 456;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.MusteriAdi = "Muhammed Semih";
            musteri3.MusteriSoyadi = "Bayram";
            musteri3.Tc = "12345678912";
            musteri3.Sehir = "Başkale";
            musteri3.HesapNo = 789;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Tc);
                Console.WriteLine(musteri.MusteriAdi);
                Console.WriteLine(musteri.MusteriSoyadi);
                Console.WriteLine(musteri.Sehir);
                Console.WriteLine(musteri.HesapNo);
                Console.WriteLine("\n");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);

            Console.WriteLine("------Müşteriler-------");
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);

        }
    }
}
