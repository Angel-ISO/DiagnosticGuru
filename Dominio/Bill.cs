namespace Dominio;
public class Bill : BaseEntityA
{
    public int Id_RepairOrder {get; set;}
    public RepairOrder ? RepairOrder {get; set;}
    public string ? TotalCostParts {get; set;}
    public string ? TotalService {get; set;}
    public string ? Total {get; set;}
}

