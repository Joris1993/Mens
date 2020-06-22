using System;

class Program 
{
    static void Main(string[] args)
    {
        var Nick = new Persoon("Nick","Hetero", Geslacht.Man, GeslachtsdeelType.Pik, null);
        var Angelo = new Persoon("Angelo", "Homo, Gay-pride waardig", Geslacht.Anders, GeslachtsdeelType.Hermafrodiet, Nick);
        var Joris = new Persoon("Joris", "Kontebonker", Geslacht.Man,GeslachtsdeelType.Pik, Angelo);

        Joris.Knallen(Nick);
        Joris.Knallen(Angelo);
        Joris.Knallen(Joris);
    }
}