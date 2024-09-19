namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
       DateTime now =  DateTime.Now;
       DateTime dogumtarih = new DateTime(2005,4,29);
       TimeSpan aradakifark = now.Subtract(dogumtarih);
       System.Console.WriteLine(Math.Floor(aradakifark.TotalDays));
    }
}
