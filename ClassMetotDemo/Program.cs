using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriID = 123123;
            musteri1.Adi = "Yunus Emre";
            musteri1.Soyadi = "AKSU";
            musteri1.Sehir = "Karabük";
            musteri1.Yas = 25;
            musteri1.Telefon = 5455455555;
            musteri1.KimlikNo = 11111111111;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriID = 456456;
            musteri2.Adi = "Yasin";
            musteri2.Soyadi = "AKSU";
            musteri2.Sehir = "Karabük";
            musteri2.Yas = 30;
            musteri2.Telefon = 5452345678;
            musteri2.KimlikNo = 22222222222;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriID = 789789;
            musteri3.Adi = "İlhami";
            musteri3.Soyadi = "AKSU";
            musteri3.Sehir = "Karabük";
            musteri3.Yas = 58;
            musteri3.Telefon = 5451234567;
            musteri3.KimlikNo = 33333333333;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriID);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Yas);
                Console.WriteLine(musteri.KimlikNo);
                Console.WriteLine(musteri.Sehir);
                Console.WriteLine(musteri.Telefon);
                Console.WriteLine("****************************");

            }

            MusteriManager MusMngr = new MusteriManager();
            MusMngr.Ekle(musteri1);
            MusMngr.Ekle(musteri2);
            MusMngr.Ekle(musteri3);
            Console.WriteLine("*********************");
            MusMngr.Sil(musteri1);
            MusMngr.Sil(musteri1);
            MusMngr.Sil(musteri1);
            Console.WriteLine("*********************");
            MusMngr.Listele(musteri1);
            MusMngr.Listele(musteri1);
            MusMngr.Listele(musteri1);


        }
    }
}
