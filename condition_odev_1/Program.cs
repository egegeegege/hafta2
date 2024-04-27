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
string Name=Console.ReadLine();
Console.WriteLine("Şifernizi giriniz");
string Pass=Console.ReadLine();

if (Pass =="12345" && Name == "Admin")
{
    Console.WriteLine("Sisteme başarıyla giriş yaptın {0}",Name);
    Console.ReadLine();
}
else
{
    if(Pass == "" || Name == "")
    {
        Console.WriteLine("Boş yapma");
        Console.ReadLine();
    }
    else if(Pass != "12345")
    {
        Console.WriteLine("şifre hatalı");
        Console.ReadLine();
    }
    else if (Name != "Admin")
    {
        Console.WriteLine("kullanıcı adı hatalı");
        Console.ReadLine();
    }

    Console.ReadLine();
        }
    }
}
