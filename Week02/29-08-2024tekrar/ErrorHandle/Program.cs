using System.Diagnostics;

namespace ErrorHandle;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // Console.Write("Birinci Sayi");
        //  int a = int.Parse(Console.ReadLine());
        //  Console.Write("Ikinci Sayi");
        //  int b = int.Parse(Console.ReadLine());
        //  Console.Write(a/b);
        int a = default;
        int b = default;
        try
        {
            Console.Write("Birinci Sayi");
               a = int.Parse(Console.ReadLine());
                Console.Write("Ikinci Sayi");
             b = int.Parse(Console.ReadLine());
            Console.Write(a / b);
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (OverflowException){
            Console.WriteLine($"Lutfen gecerli  {int.MinValue} ile {int.MaxValue} arasinda bir deger giriniz");
        }
        catch(DivideByZeroException){
            Console.WriteLine(a);
            System.Console.WriteLine("0 a bolme islemi yaptiginiz icin varsayilan 1 e bolme islemi yapilmistir");
        }
        finally
        {
            Console.WriteLine("Program sona erdi ");
        }
    }
}
