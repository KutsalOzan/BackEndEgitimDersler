namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("1.sayiyi giriniz :");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("2.sayiyi giriniz :");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        if (sayi1 > sayi2)
        {
            Console.WriteLine($"{sayi1} sayisi {sayi2} sayisindan buyuktur");
        }
        else
        {
            Console.WriteLine($"{sayi2} sayisi {sayi1} sayisindan buyuktur");
        }
    }
}