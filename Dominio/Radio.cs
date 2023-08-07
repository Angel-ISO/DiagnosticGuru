namespace Dominio;

public class Radio : BaseEntityA
{
    public string ? Brand {get; set;}
    public string ? State {get; set;}
    public int Id_Cabine {get; set;}
    public Cabine ? Cabine {get; set;}
}
