using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace condition_odev_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ÖDEV => Kullanıcıdan ilk olarak kullanıcı adı ve daha sonra şifre istenecek.
            // Eğer kullanıcı adı admin ve şifre 12345 ise sisteme giriş yapıldı Uyarısı gösterilecek.
            // Eğer kullanıcı adı veya şifre boş girildiyse lütfen boş girmeyiniz uyarısı verilecek.
            // Eğer kullanıcı adı ve şifre yanlış ise Kullanıcı bulunamadı uyarısı verilecek.

            Console.WriteLine("Kullanıcı Adınızı giriniz");
            string Ad = Console.ReadLine();
            Console.WriteLine("Şifrenizi giriniz");
            string Sifre =Console.ReadLine();

            string result = Ad ?? "Yok";


            if (Sifre == "12345" || Ad == "Admin")
            {
                Console.WriteLine("Sisteme giriş yapıldı");
            }
            else if (string.IsNullOrWhiteSpace(Ad) || string.IsNullOrWhiteSpace(Sifre))
            {
                Console.WriteLine("Lütfen boş girmeyiniz");
            }
            else
            {
                Console.WriteLine("Kullanıcı bulunamadı");
            }
            Console.ReadLine();
        }
    }
}
