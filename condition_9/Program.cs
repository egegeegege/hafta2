using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condition_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcının girdiği sayının tek mi çift mi olduğunu veren program.

            Console.WriteLine("Bir sayı giriniz:");
            int sayi = int.Parse(Console.ReadLine());

            if(sayi % 2 == 0)
            {
                Console.WriteLine("Sayı Çifttir.");
            }
            else
            {
                Console.WriteLine("Sayı Tektir.");
            }

            Console.ReadLine();
        }
    }
}
