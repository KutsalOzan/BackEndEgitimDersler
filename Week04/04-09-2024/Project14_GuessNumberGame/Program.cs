namespace Project14_GuessNumberGame;

class Program
{
    static void Main(string[] args)
    {
        ConsoleKeyInfo key;
        do
        {
            Random rnd = new Random();
        int generatedNumber = rnd.Next(1,101);
        Console.WriteLine($"HILE :D {generatedNumber}");
        System.Console.WriteLine("*****************");

        int guessNumber;
        int live = 1;
        int liveLimit = 5;
        string resultMessage = "";
        
            do
            {
                Console.Write($"{live}.hakkinizi kullaniyorsunuz. Tahminizi giriniz : ");
            guessNumber = int.Parse(Console.ReadLine());
            if (guessNumber < generatedNumber)
            {
                resultMessage = "Daha buyuk bir sayi giriniz";
                
            }
            else if(guessNumber > generatedNumber){
                resultMessage = "Daha kucuk bir sayi giriniz";
            }
            if (guessNumber != generatedNumber)
            {
                live++;
            }
            System.Console.WriteLine(resultMessage);
            } while (guessNumber != generatedNumber && live <= liveLimit);
            

            resultMessage =  guessNumber == generatedNumber ? $"Tebrikler!\n Kazandiniz \n Puan : {(liveLimit - live + 1) * 10}": "Kaybettiniz uzgunummmm";
                    System.Console.WriteLine(resultMessage);
                    System.Console.WriteLine("Tekrar oynamak ister misin ? (E/H=)");
        do
        {
            key = Console.ReadKey();

        } while (key.Key != ConsoleKey.E && key.Key != ConsoleKey.H);
        } while (key.Key  == ConsoleKey.E);
        

        
    }
}
