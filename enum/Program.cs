internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Günler.Pazar);
        Console.WriteLine(Convert.ToInt32 (Günler.Pazar.));

        int sicaklis = 32;
        if (((int)HavaDurumu.Sıcak) <=sicaklis )
        {
            
        }

    }
}

enum Günler{
    Pazartesi,
    Sali,
    Carsamba,
    Persembe,
    Cuma,
    Pazar
}

enum HavaDurumu{
    Soguk = 5,
    Normal = 20,
    Sıcak = 30
}