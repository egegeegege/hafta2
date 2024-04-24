using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condition_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad = null;

            if(ad == null)
            {
                Console.WriteLine("Nulldur");
            }
            else
            {
                Console.WriteLine($"{ad}");
            }

            // Kısa if kullanımı (Ternary Operator) ?:
            string name = "Ahmet";
            string sonuc = name == "Ali" ?  "Ali" : "Yok";  // kosul ? true olma durumu : false olma durumu

            if(name == "Ali")
            {
                string s = "ALi";
            }
            else
            {
                string s = "Yok";
            }


            Console.WriteLine("Sonuc: {0}", sonuc);

            string result = name ?? "Yok"; // Null check (Boş mu değil mi kontrolü)  name != null ? name : "Yok"

            Console.WriteLine("Result: {0}", result);


            Console.ReadLine();
        }
    }
}
