namespace Project21_OOP_Intro;

class Product
{
    string Name;
    string Description;

    decimal Price;
}

class Program
{
    static void Main(string[] args)
    {
         Product product1 = new Product();  
         product1.Name = "Telefon";
         product1.Price = 12000;
         product1.Description = "Iyi bir telefon";
    }
}