using INHERITANCE;

internal class Program
{
    private static void Main(string[] args)
    {
        
        /*          Canlılar
                        |

            Bitkiler            Hayvanlar
        |           |           |           |  
    Tohumlu     Tohumsuz    Sürüngenler     Kuslar

        */
    
        TohumluBitkiler tohumluBitki= new TohumluBitkiler();
        tohumluBitki.TohumlaCogalir();
        tohumluBitki.Beslenme();
        
        tohumluBitki.Solumun();

        Kuslar marti  = new Kuslar();
        marti.Bosaltim();
        marti.Solumun();
        marti.Ucmak();
        marti.Beslenme();
    }
}