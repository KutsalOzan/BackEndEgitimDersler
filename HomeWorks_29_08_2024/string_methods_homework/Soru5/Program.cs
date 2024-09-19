namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Bir cumle giriniz");
        string cumle1 = "Denizli de yasiyorum";
        System.Console.WriteLine("Neresinde yasiyorsunuz");
        string cumle2 = "Pamukkale de yasiyorum";
        string butuncumle = cumle1 + " " + cumle2;
        int aranankelime = butuncumle.IndexOf("Bir");
        System.Console.WriteLine(aranankelime);
    }
}
