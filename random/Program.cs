using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Random (Rastgele) 
            Random rastgele = new Random(); // Instance (Örneklem alma)
            int sayi = rastgele.Next(1,10);
            Console.WriteLine(sayi);

            Console.ReadLine();

        }
    }
}
