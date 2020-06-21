using System;
class Program 
{
    static void Main(string[] args)
    {
        var Nick = new Persoon("Nick","Hetero", PikGrootte.Normaal);
        var Angelo = new Persoon("Angelo", "Homo, Gay-pride waardig", PikGrootte.Mini);
        var Joris = new Persoon("Joris", "Kontebonker", PikGrootte.Neger, Angelo);

        Joris.Knallen(Nick);
        Joris.Knallen(Angelo);
        Joris.Knallen(Joris);
    }
}