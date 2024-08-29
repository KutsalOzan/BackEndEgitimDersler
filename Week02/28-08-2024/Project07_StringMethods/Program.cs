using System.Runtime.InteropServices;

namespace Project07_StringMethods;

class Program
{
    static void Main(string[] args)
    {
        /*string fullName = "yusuf Ziya KELKIT";
        int uzunluk = fullName.Length;
        Console.WriteLine(uzunluk);
        Console.WriteLine(fullName.ToLower());
        Console.WriteLine(fullName.ToLower());*/

        /*string address1 = "Yeni Umut Sitesi F Blok";
        string address2 = "No: 18 D:9";
        string district = "Kadikoy";
        string province = "Istanbul";

        string fullAddress1 = address1 + " " + address2 + " " + district + "/" + province;
        Console.WriteLine(fullAddress1);
        string fullAdress2 = String.Concat(address1, " ",address2," ", district, "/ ",province );
        System.Console.WriteLine(fullAdress2);
        //Enterpolasyon
        string fullAddress3 = $"{address1} {address2} {district} /{province}";
        string fullAddress4 = String.Format("{0} {1} {2} /{3}",address1,address2,district,province);
        System.Console.WriteLine(fullAddress4);

        //Ornek:
        string text1 = "Nisantasi";
        string text2 = "Universitesi";
        string oldlocation = "Bayrampasa";
        string currentLocation = "Sariyer";
        string date1 = "09.09.2009";
        string date2 = "05.05.2018";
        //Hedef:
        /*
        Nisantasi Universitesi, 09.09.2009 tarihinde Istanbul‘ün Bayrampasa ilcesinde faaliyetlerine basladi. Ardindan 05.05.2018 tarihine yine Istanbul"un Sariyer ilcesinde kurulan TechCampus
        e tasindi

        */
        //Cozum1\Odev kendnin yap

        /*
        string result1 = text1 + " " ;

        //Cozum2 
        string result2 = String.Concat(text1, " " ,text2, " ");

        //Cozum3

        string result3 = $"{text1} {text2}";

        //Cozum4 *****************************************

        //odev
        */

       /* string fullName = "yusuf Ziya KELKIT";
        string searchText = "u";
        //bool response = fullName.Contains(searhText);
        bool response = fullName.ToLower().Contains(searchText);
        System.Console.WriteLine(response);
        */

        //string firstName = "Begum";
        //int index = firstName.IndexOf("G");
       // Console.WriteLine(index);
       Console.Clear();
        /*string firstName = "Umay";
        System.Console.WriteLine(firstName.StartsWith("U"));
        System.Console.WriteLine(firstName.EndsWith("y"));
        */

       /* string courseName = "FullStack Web Developer Egitimi";
        courseName = courseName.Replace("FullStack","Tam Donanimli");
        courseName =courseName.Replace("e","X");
        System.Console.WriteLine(courseName);*/

       // string message = "Istanbul‘un Sariyer‘inin en //guzel yeri.";
       //message = message.Replace("‘","");

       //string text = "Backend Yazilim Uzmanligi Egitimi";
       //System.Console.WriteLine(text.Substring(0, text.IndexOf(" ")));
       

    }
}
