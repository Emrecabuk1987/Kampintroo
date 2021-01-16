using System;

namespace Kampintroo
{
    class Program
    {
        static void Main(string[] args)

        {
         string Kategoriler = "kategori6";
         int OgrenciSayisi = 32000;
         double Faizorani = 1.45;
         bool SistemeGirisYapmismi = false;
         double dolarbugun = 7.55;
         double dolardun = 7.55;

            if (dolardun > dolarbugun)
            {
                Console.WriteLine("azalis butonu goster");
            }
            else if (dolardun < dolarbugun)
            {
                Console.WriteLine("artis butonu goster");

                }
            else
            {
                Console.WriteLine("Esitlik butonu goster");
            }
           
            if (SistemeGirisYapmismi == true)
            {
              Console.WriteLine("Sisteme Giriş Yapıldı");
            
            }
            else
            {
                Console.WriteLine("Giriş Yapılmadı");          
            }

          


        }
    }
}
