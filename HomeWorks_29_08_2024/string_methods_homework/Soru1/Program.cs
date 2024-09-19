namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
       string cumle = "Merhaba benim adim Ozan Kutsal";
       string[] kelimeler = cumle.Split(" ");

       foreach (var kelime in kelimeler)
       {
        System.Console.WriteLine(kelime);
       }
    }
}
