
using System.Security.Cryptography;

class Card{
    private Type _type;
    public Type Type
    {
        get { return _type; }
        set { _type = value; }
    }
    
    private string _baslik;
    public string Baslik
    {
        get { return _baslik; }
        set { _baslik = value; }
    }
    private string _icerik;
    public string Icerik
    {
        get { return _icerik; }
        set { _icerik = value; }
    }
    private Kisi _kisi;
    public Kisi Kisi
    {
        get { return  _kisi; }
        set {  _kisi = value; }
    }

    private Boyut _boyut;
    public Boyut Boyut
    {
        get { return _boyut; }
        set { _boyut = value; }
    }


    public Card(string baslik, string icerik, Kisi kisi, Boyut boyut, Type type)
    {
        _icerik = icerik;
        _kisi = kisi;
        _boyut = boyut;
        _baslik = baslik;
        _type = type;
    }



}

public class   Kisi{
    public int ID { get; set; }
    public string Name { get; set; }
    public Kisi(int id , string name)
    {
        ID = id;
        Name = name;

    }

    
}

enum Boyut{

    XS = 1,
    S,
    M, 
    L, 
    XL
}
enum Type{
    TODO = 1,
	INPROGRESS,
	DONE
}
/*Kart İçeriği:



Baslık
Icerik
Atanan Kisi (Takım üyelerişnden biri olmalı)
Büyüklük (XS, S, M, L, XL)
*/