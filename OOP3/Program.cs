using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService loggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.Basvuruyap(tasitKrediManager,databaseLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {tasitKrediManager};
          //  basvuruManager.KrediOnbilgilendirmesiYap(krediler);

        }
    }
}
