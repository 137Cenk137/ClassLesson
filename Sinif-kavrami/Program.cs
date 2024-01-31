internal class Program
{
    private static void Main(string[] args)
    {
        

        Employee employee= new Employee(){Id = 1, Name = "cenk",LastName = "kıran", Departman="Physic"};
        employee.CallInformation();
    }
}

class Employee{
    public Employee(string ad ,string soyad, int no , string departman)
    {
        Id = no;
        Name = ad;
        LastName = soyad;
        Departman = departman;
    }
    public Employee()
    {
        
    }
    public int Id { get; set;}  
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Departman { get; set; }

    public void CallInformation(){
        Console.WriteLine($"id : {Id}");
        Console.WriteLine($"name: {Name}");
        Console.WriteLine($"surname : {LastName}");
        Console.WriteLine($"Departman : {Departman}");
           

    }
}