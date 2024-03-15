internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("enter clauses please (for reverse sentence)");
        string sentence = Console.ReadLine();
        for (int i = sentence.Length-1; i >=  0 ; i--)
        {
            Console.Write(sentence[i]);

    
        } 
        Console.WriteLine( );
    }
}