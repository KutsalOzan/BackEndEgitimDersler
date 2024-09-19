using System.Xml.XPath;

namespace Project10_Conditions_Ternaryif_Switch;

class Program
{
    static void Main(string[] args)
    {
        #region Ternary IF
           /* int number = int.Parse(Console.ReadLine());
            string result = number > 50 ? "Indirim hakkiniz bulunmaktadir , lutfen yoneticiyle gorusunuz" : "Indirim yok";                                    System.Console.WriteLine(result);              
            
            Console.Write("Adinizi Giriniz:");
            string name = Console.ReadLine();
            int lengthName = name.Length;
            string result = lengthName>10 ? "Uygun!": " Uygun degil";
            System.Console.WriteLine($"Sevgili {name}, adinizin uzunlugu {lengthName} karakterdir. Durum {result}");
            Console.Write("Adinizi giriniz");
            string name1 = Console.ReadLine();
            int name1uzunluk = name.Length;
            1-12 arasinda ay bilgisi mevsimiveren konsola yaziniz
            
            //if ile cozum
            Console.Write("Lutfen ay bilgisini giriniz(1-12)");
            byte monthNumber = byte.Parse(Console.ReadLine());
            string result;
            if(monthNumber == 12 || monthNumber<3)
            {
                result = "Kis";
            }
            else if(monthNumber <6){
                result = "Ilkbahar";
            }
            else if (monthNumber < 9 ){
                result = "Yaz";
            }
            else{
                result = "Sonbahar";
            }
            System.Console.WriteLine($"Mevsim {result}");
*/
            //  ternary if ile yapiniz
            Console.Clear();

            /*
            kullanicinin girecegi tarihbilgisine gore gun ay yil icinde bulunulan ayin adini konsola yaziniz
            
            
            System.Console.WriteLine("Sirasiyla gun ay yil giriniz");
            DateTime inputDate = DateTime.Parse(Console.ReadLine());
            int monthNumber = inputDate.Month;
            string monthName;
            */

            
        #endregion
    
        #region Switch
        /*System.Console.Write("1-100 arasi sayi giriniz puan");
        byte point = byte.Parse(Console.ReadLine());
        string resultMessage;
        switch(point)
        {
            case >= 50:
            resultMessage = "Gecti";
            break;
            case <50:
            resultMessage = "Kaldi";
            break;
            default:

        }
        System.Console.WriteLine(resultMessage);
        
        Console.Write("1-100 ARASINDA PUANI griniz");
        byte point = byte.Parse(Console.ReadLine());
        string result;
        switch(point)
        {
            case < 0 or >100 :
            result = "Lutfen 0-100 araliginda bir puan giriniz";
            break;
            case <45:
            result = "1";
            break;
            case < 55:
            result = "2";
            break;

            default:
            result = "5";
            break;
        }
        
        Console.Write("Lutfen bir tarih giriniz (gg.aa.yyyy)");
        string inputString = Console.ReadLine();
        bool isConvertStatus = DateTime.TryParse(inputString, out DateTime inputDate);
        string result;
        if (isConvertStatus) // true ile ayni 
        {
            DayOfWeek dayOfWeek = inputDate.DayOfWeek;
            switch (dayOfWeek)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                result = "Hafta Sonu";
                break;
                default:
                result = "Hafta ici";
                break;
            }
        }
        */
        string result;
        Console.Write("Lutfen ay numarasini giriniz: ");
        string monthNumberString = Console.ReadLine();
        if (byte.TryParse(monthNumberString, out byte monthNumber))
        {
            switch(monthNumber){
                
            }
        }
        else
        {
            
        }
        #endregion   
    }
}
