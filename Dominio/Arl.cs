namespace Dominio;

public class Arl : BaseEntityA
{
    public ICollection<Employe> ?Employes { get; set; }

    public string ? Description {get; set;}
}
