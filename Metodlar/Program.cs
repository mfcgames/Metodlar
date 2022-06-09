using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Name = "Elma";
            urun1.Price = 15;
            urun1.Description = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Name = "karpuz";
            urun2.Price = 80;
            urun2.Description = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Name);
                Console.WriteLine(urun.Price);
                Console.WriteLine(urun.Description);
                Console.WriteLine("-----------------");
            }
            Console.WriteLine("----------------Metodlar---------------");

            //Classları instance olarak çağırırız.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("armut", "ye armut", 13, 10);
            sepetManager.Ekle2("elma", "ye elma", 3, 9);
            sepetManager.Ekle2("çilek", "ye çilek", 18, 8);

        }
    }
}

