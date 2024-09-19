namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Ucgenin kenarlarini sirasiyla sgiriniz");
       Console.Write("A kenari :");
       int kenarA = Convert.ToInt32(Console.ReadLine());
       Console.Write("B kenari :");
       int kenarB = Convert.ToInt32(Console.ReadLine());
       Console.Write("C kenari :");
       int kenarC = Convert.ToInt32(Console.ReadLine());

       if (kenarA > Math.Abs(kenarB - kenarC) && kenarA < (kenarB + kenarC))
       {
        System.Console.WriteLine("Ucgen olusturabilir");
       }
       else
       {
        System.Console.WriteLine("Ucgen olusamaz");
       }

       if (kenarB > Math.Abs(kenarA - kenarC) && kenarB < (kenarA + kenarC))
       {
        System.Console.WriteLine("Ucgen olusturabilir");
       }
       else
       {
        System.Console.WriteLine("Ucgen olusamaz");
       }

       if (kenarC > Math.Abs(kenarB - kenarA) && kenarC < (kenarB + kenarA))
       {
        System.Console.WriteLine("Ucgen olusturabilir");
       }
       else
       {
        System.Console.WriteLine("Ucgen olusamaz");
       }

    }
}
