using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condition_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1-10 arası sayı gireceğimiz ve bilgisayarın ürettiği sayıyı bulmaya çalışacağımız oyun

            Console.WriteLine("1-10 arasında bir sayı giriniz");
            int sansliSayi = int.Parse(Console.ReadLine());

            Random random = new Random();
            int rnd = random.Next(1,10);

            if(sansliSayi == rnd)
            {
                Console.WriteLine("Çok ballısınız");
            }
            else
            {
                Console.WriteLine("Çok şanssızsınız. Aradığınız sayı: {0}", rnd);
            }

            Console.ReadLine();
        }
    }
}
