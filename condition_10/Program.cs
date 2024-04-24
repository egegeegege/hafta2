using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condition_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcının girdiği sayının tek mi çift mi olduğunu kısa ifle veren program.

            Console.WriteLine("Sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());

            string sonuc = sayi % 2 == 0 ? "Çifttir" : "Tektir";

            Console.WriteLine(sonuc);

            Console.ReadLine();

        }
    }
}
