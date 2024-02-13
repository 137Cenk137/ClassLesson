using System.Data;
using System.Xml.Schema;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.Write("kenar sayısını giriniz");
        int x = Convert.ToInt32(Console.ReadLine());
        int b = x;
        for (int i = 0; i <=x ;i++)
        {
            
            for (int j = b; j >0; j--)
            {
                Console.Write("-");
                
            }
            for (int k = 0; k <= i;k++)
            {
                 Console.Write("*");
                b = (x-k)-1;
            }
            for (int k = 0; k < i;k++)
            {
                 Console.Write("*");
                
            }
            
            Console.WriteLine();
            
            //Console.WriteLine("*");
        }
        
         /*for  (int i = 1; i <= x; i++)
        {
            for (int j = 1; j <= x - i; j++)
            {
                                        // Console.Write("");  
            }
            for (int k = 1; k <= i; k++)
            {
                 Console.Write("*");
            }
            Console.WriteLine("");
        }*/

    }
}

