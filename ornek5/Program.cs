using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek5
{
    class Program
    {
        static void Main(string[] args)
        {       //dinamik olarak veri ekleme ve kontrol
            var kullanicilar = new Dictionary<int, string>();
            kullanicilar.Add(0, "Kerem Bürsin");
            kullanicilar.Add(1, "Ali Atay");
            kullanicilar.Add(2, "Okan Bayülgen");
            kullanicilar.Add(3, "Sinan Kaya");
            kullanicilar.Add(4, "Haluk Bilginer");
            kullanicilar.Add(5, "Furkan Erbaş");
            foreach (KeyValuePair<int, string> kullanici in kullanicilar)
            {
                Console.WriteLine("ID=>" + kullanici.Key + "\t" + "Ad Soyad=>" + kullanici.Value);

            }
            string newUser;
            bool varMi = kullanicilar.TryGetValue(6, out newUser);
            newUser = "Mertkan İskurt";
            if (varMi)
            {
                Console.WriteLine("Bu ID'de kullanıcı mevcuttur");
            }
            else { 
                //ekleme işlemi yapar
                kullanicilar.Add(6, newUser);
            Console.WriteLine("Ekleme işlemi başarıyla gerçekleşmiştir");
            Console.WriteLine(newUser);
        }
            Console.ReadLine();
    }
}
}
