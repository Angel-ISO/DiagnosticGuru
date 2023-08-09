

namespace Dominio;

public class OrderService: BaseEntityA
{
  public ICollection<RepairOrder> ?RepairOrders { get; set; }


    public DateTime DelyveryDate {get; set;}
    public int Id_City {get; set;}
    public City ? City {get; set;}
    public int Id_Vehicle {get; set;}
    public int Id_Inspeccion {get; set;}

    public ICollection<Inspeccion> ? Inspeccions { get; set; }

    public int Id_State {get; set;}
    public State ? State {get; set;}
}
