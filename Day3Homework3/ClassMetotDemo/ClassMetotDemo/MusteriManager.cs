using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) {
            Console.WriteLine(musteri.adi + " " + musteri.soyadi + " sisteme eklendi.");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.adi + " " + musteri.soyadi + " sistemden silindi");
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Id: " + musteri.id + " Müşteri Ad Soyad: " + musteri.adi + " " + musteri.soyadi);
            }
        }


    }
}
