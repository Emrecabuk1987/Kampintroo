using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string Adi = " elma";
            double Fiyat = 15;
            string Aciklama = "amasya";

            Urun urun1  = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "amasya";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz ";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Diyarbakır";

//            type.safe = tip güvenliği
            Urun[] urunler = new Urun[] {urun1 , urun2 };

            foreach (Urun urun in urunler)
            {
                
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
            }

            Console.WriteLine("*******Metodlar*********");
//          encapsulation = urun.cs içerisinden çağırma
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            
        }                                                                                               
    }
}
