internal class Program
{
    private static void Main(string[] args)
    {
        Focus focus= new Focus();
        Console.WriteLine(focus.HangiMArkaAraci().ToString());
        Console.WriteLine(focus.KacTekerlikVar().ToString());
        Console.WriteLine(focus.StandartRenkNe().ToString());

    }
}

interface IOtomobil
{
    int KacTekerlikVar();
    Marka HangiMArkaAraci();
    Renk StandartRenkNe();
}

enum Marka{
    Ford,
    Toyotai,
    Nissan
}

enum Renk{
    Beyaz,
    Gri

}


class Focus : IOtomobil
{
    public Marka HangiMArkaAraci()
    {
        return Marka.Ford;
    }

    public int KacTekerlikVar()
    {
        return 4;
    }

    public Renk StandartRenkNe()
    {
        return Renk.Beyaz;
    }
}

class Corolla : IOtomobil
{
    public Marka HangiMArkaAraci()
    {
        return Marka.Toyotai;
    }

    public int KacTekerlikVar()
    {
        return 4 ;
    }

    public Renk StandartRenkNe()
    {
       return Renk.Gri;
    }
}

class Juke : IOtomobil
{
    public Marka HangiMArkaAraci()
    {
        return Marka.Nissan;
    }

    public int KacTekerlikVar()
    {
        return 4;
    }

    public Renk StandartRenkNe()
    {
        return Renk.Beyaz;
    }
}