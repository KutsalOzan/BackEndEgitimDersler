namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sayi giriniz");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        int mutlakdeger = Math.Abs(sayi1);
        System.Console.WriteLine($"Mutlak degeri {mutlakdeger}");
    }
}
