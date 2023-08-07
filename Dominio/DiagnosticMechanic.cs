namespace Dominio;
    public class DiagnosticMechanic : BaseEntityA
    {
        public ICollection<SummaryFail> ?SummaryFails { get; set; }
         public ICollection<    RepairOrder> ?RepairOrders { get; set; }

        

        public int Id_Mechanic {get; set;}
        public ICollection<Employe> ?Employes { get; set; }

    }

