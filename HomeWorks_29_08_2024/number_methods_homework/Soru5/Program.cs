namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Taban sayiyi giriniz");
        int taban = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Us sayiyi giriniz");
        int us = Convert.ToInt32(Console.ReadLine());
        int uslusayi = (int)Math.Pow(taban,us);
        Console.Write("Uslu islemi : " + uslusayi );
    }
}
