using System.ComponentModel;

namespace burc_hesaplama;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Dogum gununuzu giriniz");
        int day = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Dogum ayinizi giriniz");
        int month = Convert.ToInt32(Console.ReadLine());
        DateTime dogumtarihimiz = new DateTime(2005,month,day);
        #region burc_hesap
            if((month >0 && month <= 12) && (day > 0 && day <= 30))
        {
            if (month == 1)
            {
                if(day > 0 && day <= 21)
                {
                    System.Console.WriteLine("Burcunuz Oglak burcudur");
                }
                else if (day > 21 && day <= 31){
                    System.Console.WriteLine("Burcunuz Kova burcudur");
                }
            }
            else if(month == 2)
            {
                if (day > 0 && day < 20){
                    System.Console.WriteLine("Burcunuz Kova burcudur");
                }
                else if (day > 20 && day <= 30)
                {
                    System.Console.WriteLine("Burcunuz Balik burcudur");
                }
            }
            else if (month == 3)
            {
                if(day > 0 && day < 21){
                    System.Console.WriteLine("Burcunuz Balik burcudur");
                }
                else if (day > 21 && day <= 31){
                    System.Console.WriteLine("Burcunuz Koc burcudur");
                }
            }
            else if(month == 4 )
            {
                if (day >0 && day <= 20)
                {
                    System.Console.WriteLine("Burcunuz Koc burcudur");
                }
                else if(day >20 && day <= 30){
                    System.Console.WriteLine("Burcunuz Boga burcudur");
                }
            }
            else if (month == 5)
            {
                if (day >0  && day <= 21){
                    System.Console.WriteLine("Burcunuz Boga burcudur");
                }
                else if(day > 21 && day <= 31){
                    System.Console.WriteLine("Burcunuz Ikizler burcudur");
                }
            }
            else if(month ==6){
                if(day >0 && day <= 22)
                {
                    System.Console.WriteLine("Burcunuz Ikizler burcudur");
                }
                else if(day >22 && day <= 30){
                    System.Console.WriteLine("Burcunuz Yengec burcudur");
                }
            }
            else if(month == 7){
                if (day >0 &&  day <= 22){
                    System.Console.WriteLine("Burcunuz Yengec burcudur");
                }
                else if(day > 22 && day <= 31)
                {
                    System.Console.WriteLine("Burcunuz Aslan burcudur");
                }
            }
            else if(month == 8){
                if(day >0 && day <= 22){
                    System.Console.WriteLine("Burcunuz Aslan burcudur");

                }
                else if(day > 22 && day <= 30)
                {
                    System.Console.WriteLine("Burcunuz Basak burcudur");
                }

            }
            else if(month == 9){
                if(day > 0 && day <= 22)
                {
                    System.Console.WriteLine("Burcunuz Basak burcudur");
                }
                else if(day > 22 && day <= 31){
                    System.Console.WriteLine("Burcunuz Terazi burcudur");
                }
            }
            else if(month == 10){
                if(day >0 && day <= 22){
                    System.Console.WriteLine("Burcunuz Terazi burcudur");
                }
                else if(day > 22 && day <= 30 ){
                    System.Console.WriteLine("Burcunuz Akrep burcudur");
                }
            }
            else if(month == 11){
                if(day >0 && day <= 21){
                    System.Console.WriteLine("Burcunuz Akrep burcudur");
                }
                else if (day > 21 && day <= 31){
                    System.Console.WriteLine("Burcunuz Yay burcudur");
                }
                

                
            }
            else if (month == 12){
                if (day>0 && day <=21)
                {
                    System.Console.WriteLine("Burcunuz Yay burcudur");
                }
                else if(day >21 && day <= 30){
                    System.Console.WriteLine("Burcunuz Oglak burcudur");

                }
            }

        }
        else{
            System.Console.WriteLine("Hatali Gun ya da Ay girisi yaptiniz");
        }
        #endregion
        
        
        
    }
}
