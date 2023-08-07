namespace Dominio;

public class Upholstery : BaseEntityA
{
    public string ? Ceiling {get; set;}
    public string ? Seating {get; set;}
    public string ? Carpet {get; set;}
    public string ? Others {get; set;}
    public int Id_Cabine {get; set;}
    public Cabine ? Cabine {get; set;}
}
