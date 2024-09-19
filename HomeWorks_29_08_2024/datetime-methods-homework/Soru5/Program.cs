namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sirasiyla yil/ay/gun giriniz");
        int yil = Convert.ToInt32(Console.ReadLine());
        int ay = Convert.ToInt32(Console.ReadLine());
        int gun = Convert.ToInt32(Console.ReadLine());
        DateTime date = new DateTime(yil,ay,gun);
        System.Console.WriteLine(date.ToLongDateString());
    }
}