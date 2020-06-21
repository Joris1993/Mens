

using System;
using System.Runtime.CompilerServices;
using Geslachtsdeel;

partial class Persoon {
    public Persoon(string n, string g, Geslacht geslacht, Persoon wsm) 
    {

        Name = n;
        Geaardheid = g;
        PikGrootte = pg;
        WiltSeksMet = wsm;

        switch (geslacht) 
        {
            case Man : 
            {
                NeukGereedschap = new Pik();
                break;
            }
            case Vrouw :
            {
                NeukGereedschap = new Kut();
                break;
            }
            case Anders :
            {
                // gooit error, behalve als de persoon 'Angelo' heet
                break;
            }
        }

    }

    Geslacht Sex;
    Geslachtsdeel NeukGereedschap;
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




