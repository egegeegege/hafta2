using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condition_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Öğrenciden vize ve final notlarını isteyeceğiz
            // Eğer bu notlar 0-100 arasında değil ise uyarı vereceğiz.
            // Öğrencinin notları doğru girmesi durumunda vize notunun %40 'ı final notunun %60'ını alarak ortalamayı hesaplayacağız ve bu ortalamaya göre;
            // 0-20 => FF
            // 21-35 => DD
            // 36-45 => CC
            // 46-70 => BB
            // 70-100 => AA sonuçları öğrenciye harfli not olarak gösterilecek.
            Console.WriteLine("Vizenizi giriniz");
            int vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Finali giriniz");
            int final = Convert.ToInt32(Console.ReadLine());
            double ortalama;

            if(vize < 0 || final < 0)
            {
                Console.WriteLine("Not bilgileriniz 0'dan küçük olamaz!");
            }
            else if(vize > 100 || final > 100)
            {
                Console.WriteLine("Not bilgileriniz 100'den büyük olamaz!");
            }
            else
            {
                ortalama = (vize * 0.40) + (final * 0.60);

                if(ortalama>=0 && ortalama <= 20)
                {
                    Console.WriteLine("Ortalamınız: {0} - Harf Notunuz: FF",ortalama);
                }
                else if (ortalama >= 21 && ortalama <= 35)
                {
                    Console.WriteLine("Ortalamınız: {0} - Harf Notunuz: DD", ortalama);
                }
                else if (ortalama >= 36 && ortalama <= 45)
                {
                    Console.WriteLine("Ortalamınız: {0} - Harf Notunuz: CC", ortalama);
                }
                else if (ortalama >= 46 && ortalama <= 70)
                {
                    Console.WriteLine("Ortalamınız: {0} - Harf Notunuz: BB", ortalama);
                }
                else if (ortalama >= 71 && ortalama <= 100)
                {
                    Console.WriteLine("Ortalamınız: {0} - Harf Notunuz: AA", ortalama);
                }

            }

            Console.ReadLine();
        }
    }
}
