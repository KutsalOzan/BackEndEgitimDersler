namespace Project12_Loops;

class Program
{
    static void Main(string[] args)
    {
        #region For
            
            for(int a = 0 ; a < 5 ; a++)
            {
                System.Console.WriteLine("a");
            
            }
            for(int i = 0 ; i < 20; i++){
                if(i % 2 == 0){
                    System.Console.WriteLine(i);
                }
            } 
            
        #endregion
    }
}
