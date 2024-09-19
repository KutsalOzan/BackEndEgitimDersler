namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Dogum tarihinizi giriniz :");
        Console.Write("Gun :");
        int gun = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ay :");
        int ay = Convert.ToInt32(Console.ReadLine());
        Console.Write("Yil :");
        int yil = Convert.ToInt32(Console.ReadLine());
        DateTime kullanicitarih = new DateTime(yil,ay,gun);
        
    }
}
