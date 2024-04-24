using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condition_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IF ELSE
            /* 
             Yapı
            if(kosul) kosul => bir karşılaştırma ifadesi yada değerin olup olmama durumu her türlü geriye boolean ifade döndüren bir koşul olmalı
            else if(kosul)
            else if (kosul)
            else => koşul yok
             
             
             */

            if (true)
            {
                Console.WriteLine("Hello If Tekli");
            }
            if (false)
            {
                Console.WriteLine("Hello If Çoklu");
            }
            else if (true)
            {
                Console.WriteLine("Hello Else If");
            }
            else if (true)
            {
                Console.WriteLine("Hello Else If");
            }
            else
            {
                Console.WriteLine("Hello Else");
            }
           

            // Bir if bloğunda mutlaka 1 tane if olmak zorunda eğer farklı bir koşul ifadesi bağımlı olarak çalışacaksa else if ifadesi koyulur else if bir yada birden fazla olabilir. Fakat else if olmak zorunda değildir. else ifadesi ise koşulsuz çalışır ve 1 tane olur ve olmak zorunda değildir.
            // Eğer if - else if gibi bir ifade varsa ve bu ifadelerin ikiside true ise ilk gördüğü true ifadeyi gerçekleştirir.

            Console.ReadLine();
        }
    }
}
