using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araba
{
    class Araba
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Araba Markasını Giriniz: ");
            string marka = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Araba Modelini Giriniz: ");
            string model = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Araba Fiyatını Giriniz: ");
            int fiyat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Araba Üretim Yılını Giriniz: ");
            int yil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Araba Rengini Giriniz: ");
            string renk = Convert.ToString(Console.ReadLine());

            Console.WriteLine(" \n[][][][][][][][][][][][][][][][][][][][][]\n");
            ArabaMarka(marka);
            ArabaModel(model);
            ArabaRenk(renk);
            ArabaUretim(yil);
            ArabaFiyat(fiyat);

            Console.WriteLine("\nÇıkış için herhangi bir tuşa basın.\n");
            Console.ReadKey();
        }

        static void ArabaMarka(string marka)
        {
            Console.WriteLine("Araba Markası:" + marka);
            
        }

        static void ArabaModel(string model)
        {
            Console.WriteLine("Araba Modeli:" + model);
            
        }
        static void ArabaFiyat(int fiyat)
        {
            Console.WriteLine("Araba Fiyatı: " + fiyat);
            
        }

        static void ArabaUretim(int yil)
        {
            Console.WriteLine("Araba Üretim Yılı:" + yil);

        }

        static void ArabaRenk(string renk)
        {
            Console.WriteLine("Araba Rengini Giriniz:"+renk);
            
        }
        
    }

   
}
