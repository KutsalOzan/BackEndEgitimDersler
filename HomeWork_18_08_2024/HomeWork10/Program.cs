namespace HomeWork10;

class Program
{
    static void Main(string[] args)
    {
      int sayi1,sayi2,sayi3;
      sayi1 = 5;
      sayi2 = 10;
      sayi3 = 15;
      int ort = (sayi1 + sayi2 + sayi3) / 3;
      double sonuc = Convert.ToInt32(ort);
      System.Console.WriteLine(sonuc);
    }
}
