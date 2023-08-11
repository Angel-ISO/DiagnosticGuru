namespace Dominio;
public class Bill : BaseEntityA
{
    public int Id_RepairOrder {get; set;}
    public RepairOrder ? RepairOrder {get; set;}
    public int ? TotalCostParts {get; set;}
    public int ? TotalService {get; set;}
    public int ? Total {get; set;}
}

