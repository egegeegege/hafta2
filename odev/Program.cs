using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 2 adet sayı istenecek. Sayılar çıkarılıp sonucu gösterilecek.

            Console.WriteLine("1. sayıyı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int sonuc = sayi1 - sayi2;

            Console.WriteLine("Sonuç: {0}",sonuc);

            Console.ReadLine();
        }
    }
}
