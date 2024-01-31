using System.Runtime.InteropServices.Marshalling;
using System.Security.AccessControl;

internal class Program
{
    private static void Main(string[] args)
    {
        //Static sınıf üyesine erişim
        Console.WriteLine("Öğrenci sayısı: {0}",Customer.AmountEmployee);

        Customer customer = new Customer("cenk","kiran");
        Customer custome1 = new Customer("cenk","kiran");
        Customer customer2 = new Customer("cenk","kiran");
        Customer customer3 = new Customer("cenk","kiran");
         Console.WriteLine("Öğrenci sayısı: {0}",Customer.AmountEmployee);

    }
}


class Customer{
    private static int _omountEmployee;
    public static int AmountEmployee
    {
        get { return _omountEmployee; }
        
    }

    private string _name;
    private string _lastName;
    static Customer(){
        _omountEmployee = 0;
    }

    public Customer(string name, string lastName)
    {
        _lastName = lastName;
        _name = name;
        _omountEmployee++;
    }
    
}