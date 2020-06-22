using System;
class Pik : Geslachtsdeel 
{
    public Pik(GeslachtsdeelType t, PikGrootte pg = PikGrootte.Medium) : base(t)
    {
        Grootte = pg;
    }

    public PikGrootte Grootte;

    public override PikGrootte PikGrootte { get => Grootte; set => Grootte = value; }

    public override KutDiepte KutDiepte
    { get => throw new System.Exception("Je heb helemaal geen kuhhuutt."); set => throw new System.Exception("Kan toch helemaal geen kut diepte voor een lul kiezen joh."); }    
}
