using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Mehmet";
            musteri1.Soyad = "Coşkun";
            musteri1.Yas = 44;
            musteri1.meslek = "Avukat";
            musteri1.Id = 12345;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Sedat";
            musteri2.Soyad = "Kara";
            musteri2.Yas = 65;
            musteri2.meslek = "Doktor";
            musteri2.Id = 55555;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Canan";
            musteri3.Soyad = "Yılmaz";
            musteri3.Yas = 35;
            musteri3.meslek = "Mühendis";
            musteri3.Id = 11111;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Goster(musteriler);
            musteriManager.Sil(musteri3);

        }
    }
}
