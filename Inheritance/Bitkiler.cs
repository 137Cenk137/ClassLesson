namespace INHERITANCE;
 class Bitkiler:Canlılar{
    protected void Fotosentez(){
        Console.WriteLine("Bitkiler fotosentez yapar");
    }
}

class TohumluBitkiler:Bitkiler{

public TohumluBitkiler()
{
    
    base.Fotosentez();
}    public void TohumlaCogalir(){
        Console.WriteLine("Tohumla cögalir");
    }
}

class TohumsuzBitkiler:Bitkiler{
    public void SporlaCogalir(){
        Console.WriteLine("Sporla çoğalir");
    }
}