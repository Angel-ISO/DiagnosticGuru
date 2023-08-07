namespace Dominio;

    public class RelServiceOrder : BaseEntityA
    {
        public int Id_RepairOrder {get; set;}
        public RepairOrder ? RepairOrder {get; set;}
        public int Id_Service {get; set;}
        public Service ? Service {get; set;}
    }
