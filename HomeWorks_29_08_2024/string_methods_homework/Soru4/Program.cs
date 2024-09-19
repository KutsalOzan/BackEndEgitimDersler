namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bugun neler yaptiniz");
        string sentence = Console.ReadLine();
        System.Console.WriteLine(sentence);
        string kisaltsentence = sentence.Trim();
        System.Console.WriteLine(kisaltsentence);

    }
}
