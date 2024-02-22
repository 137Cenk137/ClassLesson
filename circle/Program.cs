internal class Program
{
    private static void Main(string[] args)
    {
        DrawCircle.Circle();
    }
}
public class DrawCircle{
    public static void Circle(){
        Console.Write("yarıcapi giriniz: ");
        int lengthOfCircle = Convert.ToInt32(Console.ReadLine());  

        for (int i = 1; i < lengthOfCircle; i++)//y
        {
            for (int j = 1;j < lengthOfCircle*2; j++ ){//x

                
                if (lengthOfCircle-i<j && lengthOfCircle+i>j){
                    Console.Write("*");
                }
                else{
                    Console.Write("-");
                }
            }

            Console.WriteLine(); 
        }

         for (int i = lengthOfCircle; i >0; i--)
        {
            for (int j = 1;j < lengthOfCircle*2; j++ ){//x

                
                if (lengthOfCircle-i<j && lengthOfCircle+i>j){
                    Console.Write("*");
                }
                else{
                    Console.Write("-");
                }
            }

            Console.WriteLine(); 
        }
    }
    

}