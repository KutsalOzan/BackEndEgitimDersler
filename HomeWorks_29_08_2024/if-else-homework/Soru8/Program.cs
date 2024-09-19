namespace Soru8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("3 e ve 5 e bolunme kontrolu icin Bir sayi giriniz ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        if (sayi % 3 == 0 && sayi % 5 == 0)
        {
            System.Console.WriteLine("Bu sayi 3 e ve 5e tam bolunuyor");
        }
        else
        {
            System.Console.WriteLine("Bu sayi iki sayidan birine ya da ikisine bolunemiyor");
        }
    }
}
