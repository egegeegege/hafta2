using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condition_odev_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan fiyat bilgisi ve ürün kategorisi istenecek. Eğer ürün kategorisi elektronik ise fiyata
            // %22 kdv uygulanıp yeni fiyat gösterilecek Eğer ürün kategorisi gıda ise fiyata %20 kdv uygulanıp gösterilecek.
            // Kategori bunlar dışında bir kategori ise ürüne %23 kdv uygulanıp ödenmesi gerek fiyat gösterilecek.

            Console.WriteLine("Ürün fiyatı giriniz");
            int fiyat = int.Parse(Console.ReadLine());
            Console.WriteLine("Ürün Kategorisini giriniz");
            string kategori = Console.ReadLine();

            double Kdv, toplam;

            if (kategori == "elektronik"+"Elektronik")
            {
                Kdv = Kdv = fiyat * 22 / 100; ;
                toplam = fiyat + Kdv;

                Console.WriteLine("Elektronik ürününün KDV' li satış tutarı : " + toplam.ToString());
            }
            else if (kategori == "gıda" + "Gıda") 
            {

                Kdv = Kdv = fiyat * 20 / 100; ;
                toplam = fiyat + Kdv;

                Console.WriteLine("Gıda ürününün KDV' li satış tutarı : " + toplam.ToString());
            }
            else
            {
                Kdv = Kdv = fiyat * 23 / 100; ;
                toplam = fiyat + Kdv;

                Console.WriteLine("Diğer ürünlerin KDV' li satış tutarı : " + toplam.ToString());
            }


            Console.ReadLine();
        }
    }
}
