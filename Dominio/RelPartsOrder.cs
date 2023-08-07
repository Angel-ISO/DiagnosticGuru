namespace Dominio;

public class RelPartsOrder : BaseEntityA
{
    public int Id_RepairOrder {get; set;}
    public RepairOrder ? RepairOrder {get; set;}
    public int Id_SquareParts {get; set;}
    public SquarePart? SquarePart {get; set;}

}
