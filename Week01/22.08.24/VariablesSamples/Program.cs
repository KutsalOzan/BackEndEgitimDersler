namespace VariablesSamples;

class Program
{
    static void Main(string[] args)
    { 

        #region Sample2
            string word1 = "Bugun ";
            string word2 = "Hava ";
            string word3 = "Cok ";
            string word4 = "Guzel";
            string sentense = word1 + word2 + word3 + word4;
            System.Console.WriteLine(sentense);
        #endregion
          #region Sample1  
        //int number1 = 10;
        //int number2 = 5; 
            //Ekrana bu sayilarin toplami, farki , carpimi ,bolumu , mod islem sonucunu yazdiralim
            /*System.Console.WriteLine(number1 + number2);
            System.Console.WriteLine(number1 - number2);
            System.Console.WriteLine(number1 * number2);
            System.Console.WriteLine(number1 / number2);
            System.Console.WriteLine(number1 % number2);*/


        #endregion
        #region Sample3
    /*System.Console.WriteLine($"Int=> Min: {int.MinValue}");
    System.Console.WriteLine($"Int=> Min: {int.MaxValue}");

    byte maxByte = byte.MaxValue;
        System.Console.WriteLine(maxByte);*/
    #endregion
        #region Sample4
        /*float f = 0.1f + 0.2f;
        double d = 0.1 + 0.2;
        decimal m = 0.1m + 0.2m;
        System.Console.WriteLine($"float: {f}");
        System.Console.WriteLine($"Double: {d}");
        System.Console.WriteLine($"Decimal: {m}");*/
        
       #endregion
    #region Sample5
        double number1 = 10.5;
        double number2  = 20.3;
        char op = '*';
        double result = op switch
        {
            '+' => number1 + number2,
            '-' => number1 - number2,
            '*' => number1 * number2,
            '/' => number1 / number2,
            _=> throw new ArgumentException("Gecersiz Islem")

        };
        System.Console.WriteLine($"{number1} {op} {number2} = {result} ");
    #endregion

    }
}


/*  
  Degisken Isimlendirme kurallari
  1)Gecerli bir isim kullanmayiz.
     *Degisken adi harf alt cizgi ya da @ baslamak zorundadir
    *Degisken adinda bosluk OLMAMALIDIR
    *degisken adi sadece harf rakam yada alt cizgi karakterini barindirabilir
    Orn
    int age;
    int _age;
    int age1;
    int 1age; gecersiz
    int age/#; gecersiz
    int @age;
    2) Anahtar Kelimeleri (keywords) degisken adi olarak kullanmamaya dikkat etmeliyiz
    int class; Gecersiz
    int namespace; GECERSIZ
    int @class; Gecerli ama tavsiye edilmez
    3) Degiskenlere Anlamli isilmler vermeye dikkat etmeliyiz.

    int x; ANLAMSIZ! onerilmez
    int customerAge;

    4) CamelCase isilendirme teknigi kullanilmalidir
    Degisken adi tek kelimeden olusuyorsa tamamen kucuk harfle 
    birden fazla kelimeden olusuyorsa ilk kelimesi tamamen kucuk diger kelimelerin ilk harfi buyuk digerleri kucuk olmalidir
    int birthOfDate;
    int customerNumber;
    5) Degisken isimlerinde Turkce kullanabailirsiniz ancak tavsiye edilmez.
    6) C# BUYUK/KUCUK HARF duyarli bir dildir bu yuzden degisken isimlerine dikkat edilmelidir.
    int age;
    int Age;
    Ustteki iki degisken farklidir.
    7) Sabit (Const) ifadeler BUYUK HARFLERLE ve kelime aralarinda alt tire(_) ile yazilmasi tavsiye edilir
    const double PI= 3.14;
    const int MAX_AGE = 100;
*/