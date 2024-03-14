internal class Program
{

    private static void Main(string[] args)
    {
        var tempList = new List<string>();
        Console.WriteLine("kelimeri virgül ile ayıran cümleciler girin");//enter clauses separating words with commas
        var  sentece = Console.ReadLine();
        foreach (var item in sentece){
            if(char.IsNumber(item) || item == ','){}
            else{
                tempList.Add(Convert.ToString(item));
            }

        }

        foreach (var item in tempList){
            Console.Write(item);
            

        }

        
    }
        
    
}
