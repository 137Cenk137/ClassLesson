internal class Program
{
    private static void Main(string[] args)
    {

    
    
       Student student = new Student("cenk", "kıran", 23,123);

    
    
    student.GetStudentInformation();
    
    
    
    
    }
}

class Student{
    private string _name;
    private string _surname;
    private int _ogrenciNo;
    public int OgrenciNo
    {
        get { return _ogrenciNo; }
        set { _ogrenciNo = value; }
    }
    
    private int _classRoom;

    public string Name { get => _name; set => _name = value; }
    public string Surname { get => _surname; set => _surname = value; }
    public int ClassRoom { get => _classRoom; set => _classRoom = value; }



    public Student(string name, string surname,int classRoom,int ogrenciNo)
    {
        Name = name;
        Surname = surname;
        ClassRoom = classRoom;
        OgrenciNo = ogrenciNo;
        
    }




    public void GetStudentInformation(){
        Console.WriteLine(" ****** Student informartion *********");
        
         Console.WriteLine($" name {_name}");
          Console.WriteLine($" name {_ogrenciNo}");
           Console.WriteLine($" name {_surname}");
    }
}