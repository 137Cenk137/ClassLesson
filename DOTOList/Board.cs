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
    public void KartSil(){
        bool isContunie = false;
        while(!isContunie){

        Console.Write("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.\nLütfen kart başlığını yazınız: ");
        string baslik = Console.ReadLine();
         var x = GetFindtitle(baslik);
        if(x == null ){
            Console.WriteLine("böyle bir baslik yok");
            Console.Write("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız. \n * Silmeyi sonlandırmak için : (1)\n* Yeniden denemek için : (2) \n :");
            int caseOfcontumie = int.Parse(Console.ReadLine()); 
            if (caseOfcontumie == 1){
                isContunie = true;
            }
            else{
                continue;
            }


        }
        else{
             CardList.Remove(x);
             isContunie = true;
        }
        }
       
    }
    
    public void KartTaşı(){
         bool isContunie = false;
        while(!isContunie){

        Console.Write("Öncelikle degistimek istediğiniz kartı seçmeniz gerekiyor.\nLütfen kart başlığını yazınız: ");
        string baslik = Console.ReadLine();
         var card = GetFindtitle(baslik);
        if(card == null ){
            Console.WriteLine("böyle bir baslik yok");
            Console.Write("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\n * İşlemi sonlandırmak için : (1)\n* Yeniden denemek için : (2) \n :");
            int caseOfcontumie = int.Parse(Console.ReadLine()); 
            if (caseOfcontumie == 1){
                isContunie = true;
            }
            else{
                continue;
            }


        }
        else{
             Console.Write($"Bulunan Kart Bilgileri: \n ************************************** Başlık :{card.Baslik} İçerik :{card.Icerik} Atanan Kişi :{card.Kisi.Name} Büyüklük :{card.Boyut} Line :{card.Type}\n  Lütfen taşımak istediğiniz Line'ı seçiniz: (1) TODO (2) IN PROGRESS (3) DONE");
            int caseOfcontumie = int.Parse(Console.ReadLine()); 
            switch (caseOfcontumie)
            {
                case 1 :
                    card.Type = Type.TODO;
                    break;
                case 2:
                    card.Type = Type.INPROGRESS;
                    break;
                 case 3:
                    card.Type = Type.DONE;
                    break;
                
                
                
            }
            isContunie = true;
        }
        }
    }
    public void BoardListeleme(){
        for (int i = 0; i < CardList.Count; i++)
        {
            switch (CardList[i].Type)
            {
                case Type.TODO:
                    Console.WriteLine("TODO Line");
                    Console.WriteLine(" ************************");
                    Console.WriteLine($" Başlık      :{CardList[i].Baslik}");
                    Console.WriteLine($" İçerik      :{CardList[i].Icerik}");
                    Console.WriteLine($" Atanan Kişi :{CardList[i].Kisi.Name}");
                    Console.WriteLine($" Büyüklük    :{CardList[i].Boyut}");
                    Console.WriteLine("-----------------------------------");

                    break;
                case Type.INPROGRESS:
                    Console.WriteLine(" IN PROGRESS Line");
                    Console.WriteLine(" ************************");
                    Console.WriteLine($" Başlık      :{CardList[i].Baslik}");
                    Console.WriteLine($" İçerik      :{CardList[i].Icerik}");
                    Console.WriteLine($" Atanan Kişi :{CardList[i].Kisi.Name}");
                    Console.WriteLine($" Büyüklük    :{CardList[i].Boyut}");
                    Console.WriteLine("-----------------------------------");

                    break;
                case Type.DONE:
                    Console.WriteLine(" Done");
                    Console.WriteLine(" ************************ \n Boş");
                    
                    break;
                default:
                    Console.WriteLine("Liste bos");
                    break;
               
            }
        }
    }

}