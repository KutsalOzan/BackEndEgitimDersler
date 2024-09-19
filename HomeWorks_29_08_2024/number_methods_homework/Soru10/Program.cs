namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Istediginiz bir sayiyi giriniz");
        decimal sayi1 =  Convert.ToDecimal(Console.ReadLine());
        Console.Write("Yuvarlamak istediginiz sayiyi giriniz");
        decimal sayi2 = Convert.ToDecimal(Console.ReadLine());
         sayi1 = Math.Round(sayi2);
        System.Console.WriteLine(sayi1);
    }
}
