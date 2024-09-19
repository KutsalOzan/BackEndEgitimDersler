using System.Numerics;
using System.Reflection.Metadata;

namespace Project13_Loops_While;

class Program
{
    static void Main(string[] args)
    {
        // int total = 0;
        // string input = "";

        // while(input.ToLower() != "exit")
        // {

        //     Console.WriteLine("Bir sayi giriniziz (Cikis icin 'exit' yaziniz)");
        //     input = Console.ReadLine();
        //     if (int.TryParse(input, out int inputNumber))
        //     {
        //         total = inputNumber + total;
        //     } 
        //     else if (input.ToLower() != "exit")
        //     {
        //         Console.WriteLine("Lutfen gecerli bir deger giriniz !");
        //     }
        // }
        // Console.WriteLine($"Toplam : {total}");
        // int total = 0;
        // string message = "Bir sayi giriniz";
        // string input = "";
        // int i = 1;
        // while (total <= 100)
        // {
        //     Console.Write($"{message} ({i}.sayi))");
        //     input = Console.
        // }
        // int total =0;
        // string message = "Bir sayi giriniz";
        // string input ="";
        // int counter;
        // while (input.ToLower() != "exit")
        // {
        //     Console.Write($"{message} (Cikis icin 'exit' yaziniz):");
        //     input = Console.ReadLine();
        //     if (int.TryParse(input,out int inputNumber))
        //     {
        //         total = total + inputNumber;
        //     }
        //     else if (input.ToLower() != "exit")
        //     {
        //         message = "Lutfen gecerli bir sayi giriniz";
        //     }   
        // }
        // Console.WriteLine($"Toplam: {total}");


        // int total = default;
        // string input = "";
        // string message = "Bir sayi giriniz";
        // int counter;
        // while (input.ToLower() != "exit")
        // {
        //     Console.WriteLine("Sayi giriniz");
        //     input = Console.ReadLine();
        //     if (int.TryParse(input, out int inputNumber))
        //     {
        //         total = total + inputNumber;
        //     }
        //     else if (input != "exit"){
        //         Console.WriteLine("Lutfen sayi giriniz");
        //     }
        // }

        // int total = 0 ;
        // string message = "Bir sayi giriniz";
        // string input = "";
        // int  i = 1;

        // while (total <= 100)
        // {
        //     Console.WriteLine($"Bir sayi girniz  {i}.sayi");
        //     input = Console.ReadLine();
        //     if (int.TryParse(input, out int inputNumber))
        //     {
        //         total = inputNumber + total;
        //         i++;
        //     }

        // }
        // System.Console.WriteLine(total);
        /* Sadece sayi girisi yaptiralim*/
        //  ConsoleKeyInfo input; //her basilan tusu bu degiskenler karsilicak
        //  string resultNumber = "";
        //  Console.Write("Bir sayi giriniz");
        //  do
        //  {
        //     input = Console.ReadKey(true);
        //     if (char.IsDigit(input.KeyChar) )
        //     {
        //         Console.Write(input.KeyChar);
        //         resultNumber = resultNumber + input.KeyChar;
        //     }
        //     else
        //     {
        //         if (input.Key == ConsoleKey.Backspace && resultNumber.Length > 0 )
        //         {
        //             resultNumber = resultNumber.Substring(0, resultNumber.Length -1);
        //             Console.Write("\b \b");
        //         }
        //     }
        //  } while (input.Key != ConsoleKey.Enter);
        //  Console.WriteLine(int.Parse(resultNumber));

        //Girilen sayiin asal sayi  olup olmadigini tespit edip ekrana yazdiralarim
        // bool isPrime = true;
        // Console.Write("Bir sayi giriniz");
        // double number = double.Parse(Console.ReadLine());
        // if (number<=1)
        // {
        //     isPrime = false;
        // }
        // else
        // {
        //     int i = 2;
            
        //     while (i <= number)
        //     {
        //         if (number % i == 0)
        //         {
        //             isPrime = false;
        //             break;
        //         }
        //         {
                    
        //         }
        //     }
        // }
        // Console.Write(isPrime ? "Asal" : "Asal Degil");

        

    }
}
