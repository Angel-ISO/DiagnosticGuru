namespace Dominio;
public class Inspeccion : BaseEntityA
{

    public OrderService ? OrderService { get; set; }
    public ICollection<Door> ?Doors { get; set; }
    public ICollection<Cabine> ?Cabines { get; set; }

    public DateTime DateOfEntry {get; set;}
    public string ? DiagCustomer {get; set;}
    public int Id_Vehicle {get; set;}
    public Vehicle ? Vehicle {get; set;}
}

