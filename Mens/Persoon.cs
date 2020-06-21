

using System;
using System.Runtime.CompilerServices;

class Persoon {
    public Persoon(string n, string g, PikGrootte pg, Persoon wsm) 
    {
        Name = n;
        Geaardheid = g;
        PikGrootte = pg;
        WiltSeksMet = wsm;
    }

    String Name;
    String Geaardheid;
    PikGrootte PikGrootte;
    Persoon WiltSeksMet;

    public void Knallen (Persoon persoon)
    {
        if (persoon == WiltSeksMet)
            Console.WriteLine($"{this.Name} neukt met volle overtuiging {persoon.Name}, zijn droom is uitgekomen.");
        else
            Console.WriteLine($"{this.Name} neukt {persoon.Name}, zonder enige passie");

        if (this.PikGrootte == PikGrootte.Neger)
            Console.WriteLine($"Dit doet erg pijn bij {persoon.Name}");
    }
}

enum PikGrootte { Mini, Klein, Normaal, Groot, Neger }

