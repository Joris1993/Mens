using System;

class Kut : Geslachtsdeel 
{
    public Kut(GeslachtsdeelType t, KutDiepte d = KutDiepte.Gat) : base(t)
    {
        HoeVoeltIe = d;
    }
    KutDiepte HoeVoeltIe;

    public override PikGrootte PikGrootte
    { get => throw new System.Exception("Je heb helemaal geen pik."); set => throw new System.Exception("Kan toch helemaal geen pik grootte voor een kut kiezen joh."); }

    public override KutDiepte KutDiepte { get => HoeVoeltIe; set => HoeVoeltIe = value; }
}
