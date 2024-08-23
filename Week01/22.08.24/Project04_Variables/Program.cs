namespace Project04_Variables;

class Program
{
    static void Main(string[] args)
    {

        #region Intro
            /*int age;
        age = 19;
        Console.WriteLine(age);
        */
        //int age = 49;
        //System.Console.WriteLine(age);
        #endregion

        #region TamSayilar(Integers)
            byte studentPoint = 76; // 0-255
            sbyte number1 =  127; //-128 ,127
            short number2 = 5000;
            ushort number3 = 50000;
            int number4 = 200000000;
            uint number5 = 4000000000;
            long number6 = 8231231231231231231;
        #endregion
        
        #region Ondalikli Sayilar(Decimal)
        float number8 = 34.8f;
        double number9 = 59.8; // sonuna d yazilabilir
        decimal number10 = 2333.2m;
            
        #endregion
        
        #region Diger Tipler
            char char1 = 'g';
            bool isActive = true;

        #endregion

         #region Deger Tipler
         
         #region Deger Tipleri(Value Types)
            /*
            Deger
            */
         #endregion
            
            #region Referans Tipler(Reference Types)
                string firstName = "Ozan Kutsal";
                Console.WriteLine(firstName);
                object object1 = "Ozan"; //Herhangi bir deger
            #endregion

        #endregion


    }
}
