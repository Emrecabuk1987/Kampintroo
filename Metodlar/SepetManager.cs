using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi :" + urun.Adi );
            Console.WriteLine(urun.Aciklama);                  
        }




       
    }
}
