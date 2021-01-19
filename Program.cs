using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 100;
            urun1.Aciklama = "amasya elması";
            urun1.stokAdedi = 5;

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakır karpuzu";
            urun2.stokAdedi = 6;


            Urun[] urunler = new Urun[] {urun1,urun2 };
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.stokAdedi);
                Console.WriteLine("------------");

            }
            Console.WriteLine("-----------metodlar-----------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "yeşil", 12,10);
            sepetManager.Ekle2("elma", "yeşil", 18,9);
            sepetManager.Ekle2("karpuz", "diyarbakır", 15,6);
        }
    }
    }
