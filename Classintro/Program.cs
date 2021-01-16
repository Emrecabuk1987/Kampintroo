using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "engin";
            int yas = 36;

            kurs kurs1 = new kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.Izlenmeorani = 68;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.Izlenmeorani = 64;


            kurs kurs3 = new kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.Izlenmeorani = 80;

            Console.WriteLine(kurs.Izlenmeorani + " " + kurs.Egitmen);
            kurs[] kurslar = new kurs[] {kurs1,kurs2,kurs3 };
            foreach (kurs kurs in kurslar)
                Console.WriteLine(kurs.KursAdi + kurs. + kurs.Egitmen);
            {

            }
        }   
    }
}
class kurs 
{
  public string KursAdi { get; set; }
  public string Egitmen { get; set; }
  public int Izlenmeorani { get; set; }

}   
