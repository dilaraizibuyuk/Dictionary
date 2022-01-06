using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek2
{
    class Program
    {
        static void Main(string[] args)
        {           //değere göre yazdırma
            Dictionary<int, string> Ogrenci = new Dictionary<int, string>();
            Ogrenci.Add(150, "Tom Hanks");
            Ogrenci.Add(230, "Steve Jobs");
            Ogrenci.Add(300, "Sergey Brin");
            Ogrenci.Add(145, "Larry Page");


            Dictionary<int, string>.ValueCollection DegerListesi = Ogrenci.Values;
            foreach (string Deger in DegerListesi)
            {
                Console.WriteLine(Deger);
            }
            Console.ReadKey();
        }
    }
}
