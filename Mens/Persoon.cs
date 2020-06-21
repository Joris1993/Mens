

using System;
using System.Runtime.CompilerServices;

class Persoon {
    public Persoon(string n, string g, Geslacht geslacht, GeslachtsdeelType gt, Persoon wsm) 
    {

        Name = n;
        Geaardheid = g;
        Sex = geslacht;
        WiltSeksMet = wsm;

        switch (geslacht) 
        {
            case Geslacht.Man : 
            {
                NeukGereedschap = new Pik(gt);
                break;
            }
            case Geslacht.Vrouw :
            {
                NeukGereedschap = new Kut(gt);
                break;
            }
            case Geslacht.Anders :
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
    Persoon WiltSeksMet;

    public void Knallen (Persoon persoon)
    {
        if (persoon == WiltSeksMet)
            Console.WriteLine($"{this.Name} neukt met volle overtuiging {persoon.Name}, zijn droom is uitgekomen.");
        else
            Console.WriteLine($"{this.Name} neukt {persoon.Name}, zonder enige passie");

        if (this.NeukGereedschap.PikGrootte == PikGrootte.Neger)
            Console.WriteLine($"Dit doet erg pijn bij {persoon.Name}");
    }
}




