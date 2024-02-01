namespace INHERITANCE;
class Hayvanlar:Canlılar{
    public void Adaptasyon(){
        Console.WriteLine("adaptasyon yapabilir");
    }
}

class Sürüngenler : Hayvanlar{
    public void SurunerekHareket(){
        Console.WriteLine("sürünerek hareket eder");
    }
}

class Kuslar:Hayvanlar{
    public void Ucmak(){
        Console.WriteLine("kuslar uçar ");
    }
}