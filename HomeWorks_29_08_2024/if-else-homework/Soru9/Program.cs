namespace Soru9;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("1.sayiyi giriniz");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("2.sayiyi giriniz");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Hangi islemi yapmak istiyorsunuz");
        char islem = Convert.ToChar(Console.ReadLine());
        if (islem == '+')
        {
            System.Console.WriteLine(sayi1 + sayi2);
        }
        else if (islem == '-')
        {
            System.Console.WriteLine(sayi1 - sayi2);
        }
        else if (islem == '*')
        {
            System.Console.WriteLine(sayi1 * sayi2);
        }
        else if (islem == '/')
        {
            System.Console.WriteLine(sayi1 / sayi2);
        }
    }
}
