using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {   //keye göre yazdırma
            Dictionary<int, string> Ogrenci = new Dictionary<int, string>();
            Ogrenci.Add(150, "Tom Hanks");
            Ogrenci.Add(230, "Steve Jobs");
            Ogrenci.Add(300, "Sergey Brin");
            Ogrenci.Add(145, "Larry Page");


            Dictionary<int, string>.KeyCollection AnahtarListesi = Ogrenci.Keys;
            foreach (int Anahtar in AnahtarListesi)
            {
                Console.WriteLine(Anahtar);
            }
            Console.ReadKey();
        }
    }
}
