using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Bilgileri : \n Ad    : {0} \n Soyad : {1} \n Id    : {2}", musteri.Ad, musteri.Soyad, musteri.Id);
            Console.WriteLine("Kaydediliyor...\n\n\n");

        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Bilgileri : \n Ad    : {0} \n Soyad : {1} \n Id    : {2}", musteri.Ad, musteri.Soyad, musteri.Id);
            Console.WriteLine("Siliniyor...");
        }
        public void Goster(Musteri[] musteriler)
        {
            int sayac = 0;
            Console.WriteLine("***KAYITLI MÜŞTERİ BİLGİLERİ***");
            foreach (var musteri in musteriler)
            {
                sayac++;
                Console.WriteLine("***** Müşteri-" + sayac + " *****");
                Console.WriteLine(musteri.Ad+" "+musteri.Soyad);
                Console.WriteLine("Yaş : " + musteri.Yas);
                Console.WriteLine("Id  : " + musteri.Id);
                Console.WriteLine("Meslek : " + musteri.meslek);
                Console.WriteLine("************************");
                

            }
            Console.WriteLine("\n" + sayac + " adet kayıt bulundu...\n\n\n");
        }

    }
}
