using System.Runtime.Serialization;

namespace Project16_Random_Password_Generator;

class Program
{
    static void Main(string[] args)
    {
        //icinde harf, rakam ve bazi ozel karakterleri barindiran bir sifre ureten kodu yazacagiz .
        //Sifre 8 karakterden olusacak En az 1 adet rakam ve 1 adet  de ozel karakter barindiracak Ozel karakter olarak(.)(,)(-)(+)(*)
        Random rnd = new Random();
        const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefgihjklmnoprstuvwxyz";
        const string numbers = "0123456789";
        const string specialCharacters = ".,-+*";
        
        int passwordLength = 8;

        char[] password = new char[passwordLength];
        password[0] = numbers[rnd.Next(numbers.Length)];
        password[1] = specialCharacters[rnd.Next(specialCharacters.Length)];
        for (int i = 2; i < password.Length; i++)
        {
            int type = rnd.Next(3);
            if (type == 0)
            {
                password[i] = letters[rnd.Next(letters.Length)];
            }
            else if(type ==1)
            {
                password[i] = numbers[rnd.Next(numbers.Length)];

            }
            else if (type == 2)
            {
                password[i]= specialCharacters[rnd.Next(specialCharacters.Length)];
            }
        }

        for(int i = password.Length - 1; i > 0 ; i--)
        {
            int index = rnd.Next(i + 1);
            char temp =password[i];
            password[i] = password[index];
            password[index] = temp;

        }
        Console.Write(password);
       
    }
}
