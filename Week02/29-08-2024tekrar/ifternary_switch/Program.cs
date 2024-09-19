using System.Diagnostics;

namespace ifternary_switch;

class Program
{
    static void Main(string[] args)
    {
        #region Ternary If
            
        #endregion
        #region Switch
            
            //kullanicidan alinan 0-100 arasidnaki puanin gecer not olup olmadigina bakip ekrana gecti ya da kaldi yazdiran kodu hazirlayalim.
            // Console.Write("1-100 ARASINDA puani giriniz");
            // byte point = byte.Parse(Console.ReadLine());
            // string resultMessage;

            // switch (point){
            //     case >= 50:
            //     resultMessage = "Gecti";
            //     break;
            //     default :
            //     resultMessage = "Kaldi";
            //     break;                 

            // } 

            // Console.Write("1-100 arasinda puan giriniz");
            // string point = Console.ReadLine();

            // string  result;;
            // if (byte.TryParse(point, out byte pointResult))
            // {
            //     switch (pointResult)
            // {
            //     case  <= 0 or > 100 :
            //     result = "Lutfen 0-100 araliginda bir puan giriniz";
            //     break;
            //     case < 45:
            //     result = "1";
            //     break;
            //     case < 55 :
            //     result = "2";
            //     break;
            //     case < 70 :
            //     result = "3";
            //     break;
            //     case < 85:
            //     result = "4";
            //     break;
            //     default:
            //     result = "5";
            //     break;
            // }
            // }
            // else{
            //     result = "Lutfen gecerli bir sayisal deger giriniz";
            // }
            
            // System.Console.WriteLine(result);

            // 
            string result;
            Console.Write("Lutfen ay numarasini giriniz(1-12)");
            string monthNumberString = Console.ReadLine();
            if (byte.TryParse(monthNumberString, out byte monthNumber))
            {
                switch (monthNumber)
                {
                    case 1:
                    case 2:
                    case 12:
                    result = "Kis";
                    break;
                    case 3:
                    case 4:
                    case 5:
                    result = "Ilkbahar";
                    break;
                    case 6:
                    case 7:
                    case 8:
                    result = "Yaz";
                    break;
                    case 9:
                    case 10 :
                    case 11 :
                    result = "Sonbahar";
                    break;
                    
                    default:
                    result = "Hata! 1-12 arasinda bir ay numarasi giriniz";
                    break;
                }
            }
            else
            {
                result = "Hatali veri girisi";
            }



        #endregion 
    }
}
