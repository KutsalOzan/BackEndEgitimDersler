namespace Project05_ConvertTypes;

class Program
{
    static void Main(string[] args)
    {
       #region ExplicitConvert
       float number7 = 456.3f;
       int number8 = (int)number7; //Casting cast etme

       long number9 = 4232323L;
       int number10 = (int)number9;

       int number11 = 255;
       byte number12 = (byte)number11;
       //Boxing - Unboxing
       int number13 =123;
       object boxedNumber13 = number13; //Boxing

       object number14 = 123;
       int unboxedNumber14 = (int)number14; //Unboxing

       //Convert
       string number15String = "123";
       int convertedNumber15 = Convert.ToInt32(number15String);

       bool isDelete = true;
       string isDeletedString = Convert.ToString(isDelete);

       //Parse -TryParse
       string age = "45";
       int parsedAge = int.Parse(age);

       string  doubleString = "123.45";
       double parsedDouble;
       bool result = double.TryParse(doubleString, out parsedDouble);
       if(result == true){
        Console.WriteLine(parsedAge);
       }
       else
       {
        Console.WriteLine("Bir Hata Olustu");
       }
       #endregion 
        #region ImplicitConvert   


        byte number1 = 123;
        int number2 =  number1;

        float number3 = 123.45f;
        double number4 = number3;

        int number5 = 4556;
        float number6 = number5;
            
        #endregion
    }
}
//int  00000000 00000000 000000000 0000000
//byte                            1111111