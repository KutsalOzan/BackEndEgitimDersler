namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        System.Console.WriteLine("Bir ondalikli sayi giriniz");
        decimal sayi = Convert.ToDecimal(Console.ReadLine());
        decimal yuvarlanansayi = Math.Round(sayi);
        System.Console.WriteLine(yuvarlanansayi);
    }
}
