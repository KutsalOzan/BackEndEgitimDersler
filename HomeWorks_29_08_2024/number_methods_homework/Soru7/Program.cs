namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sayi giriniz");
        double derecesayi = Convert.ToInt32(Console.ReadLine());
        double R;
        double radyan = (derecesayi / 180);
        R = radyan * 3.14;
        System.Console.WriteLine(R);
        
    }
}
