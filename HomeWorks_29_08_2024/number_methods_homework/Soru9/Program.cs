namespace Soru9;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("1.sayiyi giriniz :");
        double sayi1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("2.sayiyi giriniz :");
        double sayi2 = Convert.ToDouble(Console.ReadLine());
        if ( sayi1 < sayi2){
            System.Console.WriteLine("1.sayi 2.sayidan kucuktur");
        }
        else
        {
            System.Console.WriteLine("2.sayi 1.sayidan kucuktur");
        }
    }
}
