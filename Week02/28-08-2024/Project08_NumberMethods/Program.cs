namespace Project08_NumberMethods;

class Program
{
    static void Main(string[] args)
    {
        /*int a = 10;
        int b = 4;
        int result;

        result = a + b;
        result = a - b ;
        result = a * b ;
        result = a / b ; 
        result = a % b;

        result = Math.Abs(-5);
        Console.Clear();
        result = (int)Math.Pow(4,2);
        double result2;
        result2 = Math.Sqrt(16);
        result2 = Math.Round(2.3);
        result2 = Math.Ceiling(7.05);
        result2 =Math.Floor(7.99);*/
        Console.Clear();
        Random rnd = new Random();
        int randomNumber = rnd.Next();
        System.Console.WriteLine(randomNumber);
        randomNumber = rnd.Next(10); //10 haric
        randomNumber = rnd.Next(0,13); // 13 haric

        
    }
}
