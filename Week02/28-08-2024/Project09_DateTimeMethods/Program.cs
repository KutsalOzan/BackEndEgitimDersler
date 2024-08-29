namespace Project09_DateTimeMethods;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine(DateTime.Now);
        System.Console.WriteLine(DateTime.Today);
        DateTime birthDay = new DateTime(2005,4,29);
        System.Console.WriteLine(birthDay);
        Console.Clear();

        DateTime now = DateTime.Now;
        System.Console.WriteLine(now);
        System.Console.WriteLine(now.ToShortDateString());
        System.Console.WriteLine(now.ToLongDateString());
        System.Console.WriteLine(now.ToShortTimeString());
        Console.Clear();
        int year = birthDay.Year;
        System.Console.WriteLine(year);
        Console.Clear();
        TimeSpan span = now.Subtract(birthDay);
        System.Console.WriteLine(Math.Round(span.TotalDays));
        Console.Clear();
        DateTime orderDate = new DateTime(2024,7,3);
        DateTime checkoutDate = orderDate.AddDays(21);
        Console.Clear();
        DateTime orderDate2 = new DateTime(2024,5,5);
        DateTime checkoutDate2 = orderDate2.AddDays(3);
        TimeSpan delayday = now.Subtract(checkoutDate2);
        System.Console.WriteLine(delayday.TotalDays);
        Console.Clear();
        //Gelecek Yilin ilk ginini yarhini ekrana 1 ocak 2025 carsamba formatinda yazdiran kodu hazirlayiniz
        DateTime today = DateTime.Today;//28.08.2024
        int nextYear = today.Year + 1;
        DateTime gelecekyil =  new  DateTime(nextYear,1,1);
        System.Console.WriteLine(gelecekyil.ToLongDateString());

    }
}
