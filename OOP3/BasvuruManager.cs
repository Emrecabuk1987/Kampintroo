using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //method injection
        public void Basvuruyap(IKrediManager krediManager,ILoggerService loggerService)
        {
            //başvuran bilgilerini değerlendirme
            //
            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnbilgilendirmesiYap(List<IKrediManager>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
