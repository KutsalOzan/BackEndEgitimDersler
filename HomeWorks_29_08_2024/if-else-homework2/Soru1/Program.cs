namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
      System.Console.WriteLine("Urun fiyatini giriniz");
      int kdv_urun_fiyati = Convert.ToInt32(Console.ReadLine());
      int kdv_orani =0;
      int kdvsiz = 0;
      if (kdv_urun_fiyati < 1000 && kdv_urun_fiyati > 0)
      {
        kdv_orani = 20; 
        kdvsiz = kdv_urun_fiyati * (kdv_orani / 100);
        System.Console.WriteLine(kdvsiz);
        
      }
      else
      {
        kdv_orani = 8;
      }

    }
}
