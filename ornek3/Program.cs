using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek3
{
    class Program
    {
        static void Main(string[] args)
        {       //anahtar ve değer çiftlerini aynı anda dönüştürme
            Dictionary<int, string> Ogrenci = new Dictionary<int, string>();
            Ogrenci.Add(150, "Tom Hanks");
            Ogrenci.Add(230, "Steve Jobs");
            Ogrenci.Add(300, "Sergey Brin");
            Ogrenci.Add(145, "Larry Page");

            foreach (KeyValuePair<int,string> veri in Ogrenci)
            {
                Console.WriteLine("Numara:{0} - isim{1}",veri.Key,veri.Value);
            }
            Console.ReadKey();
        }
    }
}
