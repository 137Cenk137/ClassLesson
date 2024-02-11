internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Fibonacci.Fibo(5);
    }
}

class Fibonacci{
    public static void Fibo(int derinlik){
        int[] fibo = new int[derinlik];
        fibo[0]=0;
        fibo[1]=1;
        for (int i = 2; i < derinlik; i++)
        {   
            fibo[i]=fibo[i-1]+fibo[i-2];   
        }
         int ortalama = fibo.Sum()/fibo.Length;

        Console.WriteLine("[{0}]", string.Join(", ", fibo)); 
        System.Console.WriteLine("Fibonachi dizinin ortalama ağırlığı : {0}",ortalama);  
    }
}