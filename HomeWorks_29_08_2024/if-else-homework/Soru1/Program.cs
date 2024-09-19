namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayi giriniz :");
        int girilen_sayi = Convert.ToInt32(Console.ReadLine());
        if (girilen_sayi > 0){
            Console.WriteLine("Girdiginiz sayi pozitifdir");
        }
        else if (girilen_sayi < 0){
            Console.WriteLine("Girdiginiz sayi negatiftir");
        }
        else if(girilen_sayi == 0){
            System.Console.WriteLine("Girdigininiz sayi sifirdir");

        }
        else
        {
            System.Console.WriteLine("Hatali giris");
        }
        
    }
}