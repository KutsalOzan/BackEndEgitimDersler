namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Sirasiyla 3 tane sayi giriniz");
        Console.Write("1.sayi :");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("2.sayi :");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("3.sayi :");
        int sayi3 = Convert.ToInt32(Console.ReadLine());
        int enbuyuksayi = 0;
        int ortasayi = 0;
        int enkucuksayi = 0;
        #region sayisiralama
           if (sayi1 > sayi2 && sayi1 > sayi3)
        {
            enbuyuksayi = sayi1;
            if (sayi2 > sayi3)
            {
                ortasayi = sayi2;
                enkucuksayi = sayi3;
            }
            else {
                ortasayi = sayi3;
                enkucuksayi = sayi2;
            }
        }
        else if (sayi2 > sayi1 && sayi2 > sayi3)
        {
            enbuyuksayi = sayi2;
            if (sayi1 > sayi3){
                ortasayi = sayi1;
                enkucuksayi = sayi3;
            }
            else
            {
                ortasayi = sayi3;
                enkucuksayi = sayi1;
            }
        }
        else if (sayi3 > sayi1 && sayi3 > sayi2){
            enbuyuksayi = sayi3;
            if (sayi2 > sayi1)
            {
                ortasayi = sayi2;
                enkucuksayi = sayi1;
            }
            else
            {
                ortasayi = sayi1;
                enkucuksayi = sayi2;
            }
        } 
        #endregion
        
        Console.WriteLine($"En buyuk sayi {enbuyuksayi} \n  Ortanca sayi {ortasayi} \n En kucuk sayi {enkucuksayi}");
    
    }
}
