namespace Dominio;

public class Vehicle : BaseEntityA
{
    public ICollection<Inspeccion> ?Inspeccions { get; set; }

    public string ? CodPlate {get; set;}
    public string ? Model {get; set;}
    public DateTime YearModel {get; set;}
    public int Id_Brand {get; set;}
    public Brand ? Brand {get; set;}

    public int Id_Person {get; set;}
    public Person? Person {get; set;}
}
