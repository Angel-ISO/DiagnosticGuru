namespace Dominio;

public class RepairOrder : BaseEntityA
{
         public ICollection<RelServiceOrder> ?RelServiceOrders { get; set; }
         public ICollection<RelPartsOrder> ?RelPartsOrders { get; set; }

         public ICollection<Bill> ? Bills { get; set; }

    public int Id_DiagnosticMechanic {get; set;}
    public DiagnosticMechanic ? DiagnosticMechanic{ get; set;}
    public int Id_OrderService {get; set;}
    public OrderService ? OrderService {get; set;}
}
