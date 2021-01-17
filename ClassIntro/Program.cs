using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.izlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.izlenmeOrani = 64;

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
            Product urun1 = new Product();
            urun1.ad = "Laptop";
            urun1.barkod_no = 111111;
            urun1.model = "Tuf Gaming";
            urun1.marka = "Asus";
            urun1.fiyat = 8299;
            Product urun2 = new Product();
            urun2.ad = "Protein Tozu";
            urun2.barkod_no = 11111122;
            urun2.model = "Whey Protein";
            urun2.marka = "Protein Ocean";
            urun2.fiyat = 79;
            Product[] urunler = new Product[] { urun1,urun2 };
            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.ad + " " + urun.marka + " " + urun.model + " " + urun.barkod_no + " " + urun.fiyat + "  tl");
            }
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].ad + " " + urunler[i].model + " " + urunler[i].marka + " " + urunler[i].barkod_no + " " + urunler[i].fiyat + "Tl "  );
            }
            int sayi = 0;
            while (sayi<urunler.Length)
            {
                Console.WriteLine(urunler[sayi].ad + " " + urunler[sayi].model + " " + urunler[sayi].marka + " " + urunler[sayi].barkod_no + " " + urunler[sayi].fiyat + "Tlllll ");
                sayi++;
            }
        }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeOrani { get; set; }

    }

    class Product
    {
        public string ad { get; set; }
        public int barkod_no { get; set; }
        public string model { get; set; }
        public int fiyat { get; set; }
        public string marka { get; set; }
}

