using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek6
{
    class Program
    {
        static void Main(string[] args)
        {
            var kullanicilarSortedList = new SortedList<int, string>();
            var kullanicilarDictionary = new Dictionary<int, string>();
            kullanicilarSortedList.Add(3, "Sinan Tuzcu");
            kullanicilarSortedList.Add(8, "Ali Atay");
            kullanicilarSortedList.Add(2, "Okan Bayülgen");
            kullanicilarSortedList.Add(7, "Emir Emiroğlu");
            kullanicilarSortedList.Add(6, "Murat Boz");
            kullanicilarSortedList.Add(0, "Zeynep Bastık");

            kullanicilarDictionary.Add(3, "Sinan Tuzcu");
            kullanicilarDictionary.Add(8, "Ali Atay");
            kullanicilarDictionary.Add(2, "Okan Bayülgen");
            kullanicilarDictionary.Add(7, "Emir Emiroğlu");
            kullanicilarDictionary.Add(6, "Murat Boz");
            kullanicilarDictionary.Add(0, "Zeynep Bastık");

            Console.WriteLine("Dictionary ile");
            foreach (KeyValuePair<int,string> kullanici in kullanicilarDictionary)
            {
                Console.WriteLine("ID=>"+kullanici.Key+"\t"+"Ad Soyad=>"+kullanici.Value);
            }
            Console.WriteLine(" ");
            Console.WriteLine("SortedList ile");
            foreach (KeyValuePair<int, string> kullanici in kullanicilarSortedList)
            {
                Console.WriteLine("ID=>" + kullanici.Key + "\t" + "Ad Soyad=>" + kullanici.Value);
            }
            Console.ReadLine();

        }
    }
}
