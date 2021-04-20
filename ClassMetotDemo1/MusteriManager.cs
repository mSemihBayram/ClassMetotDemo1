using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo1
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri Id: " + musteri.Id + " Tc: " + musteri.Tc + " Musteri Adı: " + musteri.MusteriAdi
                + " Musteri Soyadı: " + musteri.MusteriSoyadi
                + " Sehir: " + musteri.Sehir + " Banka Hesabı: " + musteri.HesapNo);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Musteri silindi " + musteri.MusteriAdi + musteri.MusteriSoyadi);
        }
        public void Listele(Musteri musteri)
        {

            Console.WriteLine("Musteri Id: " + musteri.Id + " Tc: " + musteri.Tc + " Musteri Adı: " + musteri.MusteriAdi
               + " Musteri Soyadı: " + musteri.MusteriSoyadi
               + " Sehir: " + musteri.Sehir + " Banka Hesabı: " + musteri.HesapNo);
        }

    }
}
