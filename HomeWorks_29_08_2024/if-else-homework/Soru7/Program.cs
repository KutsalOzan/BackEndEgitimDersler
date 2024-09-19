namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sirasiyla uc sayi giriniz");
        Console.Write("1.Sayi");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
         Console.Write("2.Sayi");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
         Console.Write("3.Sayi");
        int sayi3 = Convert.ToInt32(Console.ReadLine());
        int enbuyuksayi = 0;
        if (sayi1 > sayi2 && sayi1 > sayi3)
        {
            enbuyuksayi =sayi1;
        }
        else if (sayi2 > sayi1 && sayi2 > sayi3){
            enbuyuksayi = sayi2;
        }
        else if(sayi3 > sayi1 && sayi3 > sayi2){
            enbuyuksayi = sayi3;

        }
        Console.WriteLine("En buyuk sayi " + enbuyuksayi);


    }
}
