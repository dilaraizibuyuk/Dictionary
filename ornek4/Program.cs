using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek4
{
    class Program
    {
        static void Main(string[] args)
        {   //trygetvalue(a, out b) methodu

            Dictionary<int, string> ogrenci = new Dictionary<int, string>();
            ogrenci.Add(134, "Tolga Demirer");
            ogrenci.Add(158, "Ümit Özkan");
            ogrenci.Add(115, "Yasin Göktepe");
            ogrenci.Add(174, "Meryem Yıldız");
            Console.WriteLine("Öğrenci no giriniz:");
            int No = int.Parse(Console.ReadLine());
            string isim = " ";
            if (ogrenci.TryGetValue(No,out isim))
            {
                Console.WriteLine(isim);
            }
            else
                Console.WriteLine("Öğrenci Bulunamadı.");
            Console.ReadLine();
        }
    }
}
