namespace Soru8;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        System.Console.WriteLine("Logunu bulacaginiz sayiyi giriniz");
        double sayi = Convert.ToDouble(Console.ReadLine());
        double logsayi = Math.Log(sayi);
        System.Console.WriteLine($"Girdiginiz sayinin logu {logsayi}");
    }
}