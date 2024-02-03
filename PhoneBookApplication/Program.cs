using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
       PersonManager personManager= new PersonManager();
       personManager.TelefonNumarasıKaydet("Cenk","kıran","05554443333",0);
       personManager.TelefonNumarasıKaydet("Mahmut","kıran","05554443334",1);
       personManager.TelefonNumarasıKaydet("Mecip","kıran","05554443335",2);
       personManager.TelefonNumarasıKaydet("Engin","kıran","05554443336",3);
       personManager.TelefonNumarasıKaydet("Nazim","kıran","05554443337",4);
       personManager.RehberArama("M");
    }
}

public class Person(){

    public string Name { get; set;}
    public int Id { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
}


class PersonManager{
    public PersonManager()
    {
        PersonList = new List<Person>();
    }
    public List<Person> PersonList{ get; set; }
/*Telefon Numarası Kaydet
Telefon Numarası Sil
Telefon Numarası Güncelle
Rehber Listeleme (A-Z, Z-A seçimli)
Rehberde Arama
*/

    public void TelefonNumarasıKaydet(string name,string lastName,string phoneNumber,int id){
        PersonList.Add(new Person(){Name = name,LastName = lastName,PhoneNumber = phoneNumber,Id = id});    
    }
    public void TelefonNumarasıSil(int index){
        PersonList.RemoveAt(index);
    }

    public void TelefonNumarasıGüncelle(int index){
         int chs;
        while(true)
        {   
            try
            {
                Console.Clear();
                Console.WriteLine("Press one to Update Name");
                Console.WriteLine("Press two to Update Surname");
                Console.WriteLine("Press three to Update Number");
                chs=int.Parse(Console.ReadLine());
                if(chs<4 && chs >0)
                    break;
                else
                    Console.WriteLine("range!!!! pls read correctly ");
                
            }
            catch (System.Exception)
            {
                Console.WriteLine("Look are you blind it's not so hard");
                Console.WriteLine();
            }
        }
        
        Console.Clear();

        switch (chs)
        {
            case 1:
                Console.Write("New Name: ");
                PersonList[index].Name=Console.ReadLine();
                break;
            case 2:
                Console.Write("New Surname: ");
                PersonList[index].LastName=Console.ReadLine();
                break;
            case 3:
                Console.Write("New Number: ");
                PersonList[index].PhoneNumber=Console.ReadLine();
                break;
        }
    }

    public void RehberArama(string entity){

        Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz.********************************************** İsim veya soyisime göre arama yapmak için: (1) Telefon numarasına göre arama yapmak için: (2)");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x == 1){
            var kisi  =  PersonList.Where(x => x.Name.Contains(entity) | x.LastName.Contains(entity)).ToList();
            Console.WriteLine("***************");
            foreach (var item in kisi)
            {
                Console.WriteLine($"isim: {item.Name} \nSoyisim: {item.LastName} \nTelefon Numarası: {item.PhoneNumber}");
            }
        }
        else if (x == 2){
            var kisi  =  PersonList.Where(x => x.PhoneNumber.Contains(entity)).ToList();
        }
       
    }
    public void RehberListeleme(){
        Console.WriteLine(" Telefon Rehberi **********************************************");
        foreach (var item in PersonList)
        {
             Console.WriteLine($"isim: {item.Name} \nSoyisim: {item.LastName}\nTelefon Numarası: {item.PhoneNumber}");
             Console.WriteLine("                ");
        }
   
    } 

}