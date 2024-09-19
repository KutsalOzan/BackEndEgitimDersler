using System.Data;

namespace Project15_Arrays;

class Program
{
    static void Main(string[] args)
    {
        // // int[] numbers;
        // // numbers = new int[6];
        // int [] numbers = new int[5];
        // numbers[0] = 12;
        // numbers[4] = 50;
        // System.Console.WriteLine(numbers[4]);\ 
        //  
        // for (int i = 0; i < 5; i++)
        // {
        //     System.Console.WriteLine($"{i + 1},Item : {numbers[i]}");
        // }
        // foreach (var number in numbers)
        // {
        //     System.Console.WriteLine(number);
        // }
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     numbers[i] = (int)(numbers[i] * 1.1);
        // }
        // foreach (var number in numbers)
        // {
        //     System.Console.WriteLine(number);
        // }
        // 10 elemanli bir dizideki en buyuk sayiyi bulup ekrana yazdiran kodu hazirlayin
        // int[] numbers = {50,23,122,213,1234,123,5476,435,754,54};
        // int enb = int.MinValue;
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     if (numbers[i] > enb)
        //     {
        //         enb = numbers[i];
        //     }
        // 
        //Diziyi siralamak
        // int[] numbers = {50,23,12,563,675,23,63,29};
        // Array.Sort(numbers);
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     System.Console.WriteLine(numbers[i]);
        // }
        //Diziyi ters cevirme
        // int[] numbers = {50,23,122,213,1234,123,5476,435,754,54};
        // Array.Sort(numbers);
        // Array.Reverse(numbers);
        // foreach (int number in numbers)
        // {
        //     System.Console.WriteLine(number);
        // }

        //Dizinin belirli bir elemaninin indexini bulmak
        // int[] numbers = {50,23,122,213,1234,123,5476,435,754,54};
        // int index = Array.IndexOf(numbers,1234);
        // System.Console.WriteLine(index);

        // string firstName = "Osimhen";
        // Console.WriteLine(firstName[4]);
        // string kurumAd = "Macbook Egitim bilimleri akademisi";
        // string[] kurumAdDizi = kurumAd.Split(" ");
        // System.Console.WriteLine(kurumAdDizi.Length);
        // foreach (var dizi in kurumAdDizi)
        // {
        //     System.Console.WriteLine(dizi);
        // }
        // string[] names = {"Ali","Ozan","Ahmet"};
        // string[] newnames = names;
        // foreach (var name in names)
        // {
        //     System.Console.WriteLine(name);
        // }
        // names[0] = "Engin";
        // foreach (var newname in newnames)
        // {
        //     System.Console.WriteLine(newname);
        // }
        // string[] names = {"Ali","Ozan","Ahmet"};
        // string[] newNames = new string[names.Length];
        // Array.Copy(names,newNames,3);
        //Dizi icinde var yok  kontrolu yapmak
        // int[] numbers = {50,23,15,25,84,64,45,1252};
        // bool exists= Array.Exists(numbers,x=> x>65); //lambda operatoru
        // Console.WriteLine((exists == true ? "600den buyuk"  : "600den buyuk sayi yok"));
        //Dizi icinde belirtilen kosula uygun ilk elemani geitmrkje
        // int[] numbers = {50,300,800,444,23,52325,546,9632};
        // int result = Array.Find(numbers, x=> x > 600);
        // System.Console.WriteLine(result);
        //*************************************
        //Dizi Icinde belirtilen kosula uygun tum elemanlari getirmek 
        // int[] numbers = {23,532,800,555,782,653,24,532,999};
        // int[] results = Array.FindAll(numbers, x => x > 600);
        // foreach (var item in results)
        // {
        //         System.Console.WriteLine(item);
        // }
        //Dizinin boyutunu degistirmek 
        // int[] numbers = {3,6,9};
        // Array.Resize(ref numbers,4);
        // numbers[3] = 35;
        //Dizinin belirli bir bolumunu temizlemek
        int[] numbers = {23,532,800,555,782,653,24,532,999};
        System.Console.WriteLine("Dizinin orjinal hali");
        foreach (var item in numbers)
        {
            System.Console.WriteLine(item);
        }
        Array.Clear(numbers);
        foreach (var item in numbers)
        {
            System.Console.WriteLine(item);
        }


    }
}
