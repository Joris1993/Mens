class Mens {
    public Mens(string n, string g) 
    {
        Name = n;
        Geaardheid = g;
    }

    String Name;
    String Geaardheid;
}

class program 
{
    static void Main(string[] args)
    {
        var Nick = new Mens("Nick","Ontzettend Gay");
    }
}