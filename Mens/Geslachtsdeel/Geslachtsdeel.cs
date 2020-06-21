class Geslachtsdeel
{
    public Geslachtsdeel(GeslachtsdeelType t)
    {
        Soort = t;
    }
 
    GeslachtsdeelType Soort;

    public virtual PikGrootte PikGrootte { get; set; }
    public virtual KutDiepte KutDiepte { get; set; }
}