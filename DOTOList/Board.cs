class Board {

    public List<Card> CardList { get; set; }
    public List<Kisi> KisiList { get; set; }

    public Board()
    {
        KisiList = new List<Kisi>(){
            new Kisi(12,"mehmet"),
            new Kisi(13,"Ahmet"),
            new Kisi(14,"Fatih"),
            new Kisi(15,"Baran"),
            new Kisi(16,"utku")
        };
        CardList = new List<Card>(){
             new Card("Yazilim1", "Patika",KisiList[0],Boyut.M,Type.TODO),
             new Card("Yazilim2", "Frontend",KisiList[1],Boyut.S,Type.INPROGRESS),
             new Card("Yazilim3", "Backend",KisiList[2],Boyut.XS,Type.DONE)
        };
        
    }

    /*
    Başlık Giriniz                                  : 
 İçerik Giriniz                                  :
 Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :
 Kişi Seçiniz                                    : */

    public void KartEkle(){
        
        Console.Write(" Başlık Giriniz : ");
        string title = Console.ReadLine();
        Console.Write(" İçerik Giriniz :");
        string content = Console.ReadLine();
        Console.Write(" Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5) : ");
        int size = Convert.ToInt32(Console.ReadLine());
        Console.Write("  Kişi Seçiniz (id) : ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Tür Giriniz -> 1- ToDo 2- In Progress 3- Done	 : ");
		int secim = int.Parse(Console.ReadLine());
        
        Kisi kisi = GetTeamMemberByID(id);
        if (kisi == null){
            Console.WriteLine("Böyle bir kisi yok");
        }
        else{
            CardList.Add(new Card(title,content,kisi,(Boyut)size,(Type)secim));
        }
        foreach (var item in CardList)
        {
            Console.WriteLine(item.Icerik);
        }



    }
    public Kisi GetTeamMemberByID(int id)
	{
			return KisiList.Find(x => x.ID == id);
	}
    public Card GetFindtitle(string title){
        return CardList.Find(x => x.Baslik == title);
    }
    public void KartGüncelle(){
        
    }
    public void KartSil(){
        Console.Write("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.\nLütfen kart başlığını yazınız: ");
        string baslik = Console.ReadLine();
         var x = GetFindtitle(baslik);
        if(x == null ){
            Console.WriteLine("böyle bir baslik yok");
        }
        else{
             CardList.Remove(x);
        }
    }
    
    public void KartTaşı(){
        
    }
    public void BoardListeleme(){
        
    }

}