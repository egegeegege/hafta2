using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condition_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 5;
            if(n1 > 5)
            {
                Console.WriteLine("Sayı 5'ten büyüktür");
            }
            else if(n1 < 5)
            {
                Console.WriteLine("Sayı 5'ten küçüktür");
            }
            else
            {
                Console.WriteLine("Sayı 5'tir.");
            }

            bool sonuc = false;

            if (sonuc)
            {
                Console.WriteLine("True");
            }
            if (!sonuc) // ! => olumsuzluk katar True => False
            {
                Console.WriteLine("False");
            }

            string ad = null; // null boş değer ataması

            if (ad == null)
            {
                Console.WriteLine("Ad değeri nulldur.");
            }
            else
            {
                Console.WriteLine("Ad değeri null değildir");
            }

            Console.ReadLine();
        }
    }
}
