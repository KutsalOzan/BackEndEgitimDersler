namespace Soru6;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Aldiginiz notu giriniz");
     int sinav_not = Convert.ToInt32(Console.ReadLine());

     if (sinav_not <= 100 && sinav_not >= 90)
     {
        System.Console.WriteLine("Sinav notu : AA");
     }
     else if (sinav_not < 90 &&  sinav_not >= 85)  {
        System.Console.WriteLine("Sinav notu : BA");
     } 
     else if (sinav_not < 85 &&  sinav_not >= 80)  {
        System.Console.WriteLine("Sinav notu : BB");
     }  
     else if (sinav_not < 80 &&  sinav_not >= 70)  {
        System.Console.WriteLine("Sinav notu : CB");
     }  
     else if (sinav_not < 70 &&  sinav_not >= 60)  {
        System.Console.WriteLine("Sinav notu : CC");
     }  
     else if (sinav_not < 60 &&  sinav_not >= 65)  {
        System.Console.WriteLine("Sinav notu : DC");
     }  
     else if (sinav_not < 55 &&  sinav_not >= 50)  {
        System.Console.WriteLine("Sinav notu : DD");
     }  
     else if (sinav_not < 50 &&  sinav_not >= 40)  {
        System.Console.WriteLine("Sinav notu : FD");
     }  
     else if (sinav_not < 40 &&  sinav_not >= 0)  {
        System.Console.WriteLine("Sinav notu : FF");
     }  
     else if (sinav_not < 0 &&  sinav_not >= 85)  {
        System.Console.WriteLine("Sinav notu : YE");
     }  
     else if (sinav_not < 90 &&  sinav_not >= 85)  {
        System.Console.WriteLine("Sinav notu : YS");
     }  


    }
}
