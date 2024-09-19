namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Bir harf giriniz");
        char harf = Convert.ToChar(Console.ReadLine());
        if ( harf == 'a' )
        {
            System.Console.WriteLine("Sesli harftir");
        }
        else{
            System.Console.WriteLine("Sessiz harftir");
        }
    }
}
