

using System;
using System.Runtime.CompilerServices;

class Mens {
    public Mens(string n, string g, PikGrootte pg, Mens wsm) 
    {
        Name = n;
        Geaardheid = g;
        PikGrootte = pg;
        WiltSeksMet = wsm;
    }

    String Name;
    String Geaardheid;
    PikGrootte PikGrootte;
    Mens WiltSeksMet;

    public void Knallen (Mens mens)
    {
        if (mens == WiltSeksMet)
            Console.WriteLine($"{this.Name} neukt met volle overtuiging {mens.Name}, zijn droom is uitgekomen.");
        else
            Console.WriteLine($"{this.Name} neukt {mens.Name}, zonder enige passie");

        if (this.PikGrootte == PikGrootte.Neger)
            Console.WriteLine($"Dit doet erg pijn bij {mens.Name}");
    }
}

enum PikGrootte { Mini, Klein, Normaal, Groot, Neger }

class program 
{
    static void Main(string[] args)
    {
        var Nick = new Mens("Nick","Hetero", PikGrootte.Normaal);
        var Angelo = new Mens("Angelo", "Homo, Gay-pride waardig", PikGrootte.Mini);
        var Joris = new Mens("Joris", "Kontebonker", PikGrootte.Neger, Angelo);

        Joris.Knallen(Nick);
        Joris.Knallen(Angelo);
        Joris.Knallen(Joris);
    }
}