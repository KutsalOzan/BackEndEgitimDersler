using System.Net;

namespace Project18_Methods;

class Program
{
    /*
        1- <Erisim Belirleyici> <Geri Donus Tipi> MetotAdi(parametre1_tipi parametre1_adi)a
        {
            Metot Govdesi
            Bu metotta calismasi istenen tum kodlar buraya yazilacak
            return geri_dondurelecek_deger;
            return keywordu sadece metot geriye bir deger dondurecekse kullanilir
        ;
        
    */
    static void Greet(){
        System.Console.WriteLine("Merhaba Drogba");
    }

    static void GreetToName(string name)
    {
        System.Console.WriteLine($"Merhaba {name}");
    }
    static void GreetToNameWithGender(string name, bool gender)
    {
        if (gender)
        {
            System.Console.WriteLine("Cinsiyetiniz Kadindir");
      }
      else
      {
        System.Console.WriteLine("Cinsiyetiniz Erkektir");
      }
    }

    static void CalculateAge(string name, bool gender,int year)
    {
        string resultMessage = "";
        int age = DateTime.Now.Year - year;
        if (gender)
        {
            resultMessage = $"{name} hanim {age} yasindasiniz";
        }
        else
        {
            resultMessage = $"{name} bey {age} yasindasiniz";
        }
        System.Console.WriteLine(resultMessage);
    }
    
    static byte Sum1()
    {
        byte result = 5 + 10;
        return result;
    }
    static  DayOfWeek GetDayName()
    {
        DateTime today = DateTime.Now;
        DayOfWeek result = today.DayOfWeek;
        return result;
    }
    
    static int  Sum2(int number1,int number2)
    {
        int result = number1 + number2;
        return result;
    }
    
    static double SumSqrt(double number1,double number2){
        double total = number1 +number2;
        double sqrt = Math.Sqrt(total);
        return sqrt;
    }

    static void SampleValue(int x)
    {
        x += 3;
        Console.WriteLine($"SampleValue metodunun icindeki x'icindeki {x}");
    }

    static bool  Sum3(int number1,int number2,out int result)
    {
         result = number1 + number2;
        if (result>0)
        {
            return true;
        }
        return false;
    }
    static int Sum4(int number1, int number2 , int number3 = 0)
    {
        int result = number1 + number2 + number3;
        return result;
    }

    static int[] GetArrayWithRandomValues(int length,int min= 1,int max= 100 )
    {
        int[] array= new int[length];
        Random rnd = new Random();
        for (int i = 0; i < length; i++)
        {
            array[i] = rnd.Next(min,max);
        }
        return array;

    }

    static int GetMaxValue(int[] arrays)
    {
        int max = arrays[0];
        for (int i = 0; i < arrays.Length; i++)
        {
            if (arrays[i] > max) 
            {
                max = arrays[i];
            }
        }
        return max;
    }
    static void Main(string[] args)
    {
            int[] numbers = GetArrayWithRandomValues(10,50);
            Console.WriteLine($"Rastgele Dizi {String.Join("\n",numbers)}");
            Console.WriteLine($"En Buyuk Deger : {GetMaxValue(numbers)}");
        
        // bool isPositive = Sum3(4,5,out int result);
        // Console.WriteLine($"Sonuc : {result} \n {isPositive}");
        //Greet();
        //GreetToName("Engin");
        //GreetToNameWithGender("Ozan",false);
        //CalculateAge("Engin",false,1975);
        // byte a = Sum1();
        // Console.WriteLine(a);
       //System.Console.WriteLine(GetDayName());
            //    System.Console.WriteLine(Sum2(6,2));
    }
}
