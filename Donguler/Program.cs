using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Gkampı";
            string kurs2 = "Programlama tk";
            string kurs3 = "java";

            // array = diziler

            string[] kurslar = new string[] { "Yazılım Gkampı", "Programlama tk", "java" };


            for (int i = 0; i <kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("Kurs bitti");
            // kurs = alias (takma ad çok önemli değil )

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");



        }
    }
}



