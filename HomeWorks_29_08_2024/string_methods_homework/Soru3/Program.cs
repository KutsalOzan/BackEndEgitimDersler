using System.Security.Cryptography.X509Certificates;

namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Girmek Istediginiz cumleyi giriniz");
       string text = Console.ReadLine();
       Console.WriteLine("Aranacak kelimeyi giriniz");
       string aranacak = Console.ReadLine();
       string sekil = text.Replace(aranacak,"*");
       int adet = sekil.Count(x => x == '*');
       System.Console.WriteLine(adet);

    }
}
