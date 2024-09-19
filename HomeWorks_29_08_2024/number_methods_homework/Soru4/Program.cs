namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir sayi giriniz");
        double sayi1 = Convert.ToDouble(Console.ReadLine());
        double karekok_sayi1 = Math.Sqrt(sayi1);
        System.Console.WriteLine("Karekoku " + karekok_sayi1);
    }
}
