using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Indivicual musteri1 = new Indivicual();
            musteri1.Id = 1;
            musteri1.CustomerNumber = "123";
            musteri1.CustomerFirstName = "Emre";
            musteri1.CustomerLastName = "Çabuk";
            musteri1.TcNo = "1231";

            Coorporate musteri2 = new Coorporate();
            musteri2.Id = 2;
            musteri2.CustomerNumber = "122";
            musteri2.CustomerCompany = "Kodlama.io";
            musteri2.VergiNo = "1111";
            


            //Gerçek müşteri - Tüzel müşteri
            //SOLID- L harfi


            Musteri musteri3 = new Indivicual();
            Musteri musteri4 = new Coorporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);






        }
    }
}
