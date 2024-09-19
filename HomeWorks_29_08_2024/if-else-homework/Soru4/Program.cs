namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir yil giriniz");
        int yil = Convert.ToInt32(Console.ReadLine());
        if (yil % 4 == 0)
        {
            Console.WriteLine("Girdiginiz yil artik yildir");
        }
        else
        {
            System.Console.WriteLine("Girdiginiz yil artik yil degildir");
        }
    }
}
