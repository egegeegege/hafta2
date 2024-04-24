using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condition_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string veri içersinden rastgele elemanlar çekme
            string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!#$%&*@";
            Random random = new Random();
            int rnd = random.Next(0, characters.Length - 1);
            Console.WriteLine(characters[rnd]);

            Console.ReadLine();
        }
    }
}
