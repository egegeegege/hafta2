using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condition_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcının girdiği sayı değer eğer sıfırdan büyükse farklı bir koşul küçükse farklı bir koşul çalışacak fakat girdiği sayı hem sıfırdan büyük hemde 10 dan büyükse farklı bir koşul 10 dan küçükse farklı bir koşul çalışacak.

            Console.WriteLine("Sayı giriniz:");
            int sayi = int.Parse(Console.ReadLine());

            if(sayi > 0)
            {
                if(sayi > 10)
                {
                    Console.WriteLine("Sayı 10 dan büyüktür");
                }
                else if(sayi < 10)
                {
                    Console.WriteLine("Sayı 10 dan küçüktür");
                }
                else
                {
                    Console.WriteLine("Sayı 10'dur");
                }
            }
            else if(sayi < 0)
            {
                Console.WriteLine("Sayı sıfırdan küçüktür.");
            }
            else
            {
                Console.WriteLine("Sayı sıfırdır.");
            }

            Console.ReadLine();
        }
    }
}
