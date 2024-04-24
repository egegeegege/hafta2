using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condition_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan aldığımız değerin pozitif, negatif yada sıfır olduğunu bize bildiren programı yazın.

            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());

            if(sayi > 0)
            {
                Console.WriteLine("Sayı pozitiftir.");
            }
            else if(sayi < 0)
            {
                Console.WriteLine("Sayı negatiftir");
            }
            else 
            {
                Console.WriteLine("Sayı sıfırdır.");
            }

            Console.ReadLine();
        }
    }
}
