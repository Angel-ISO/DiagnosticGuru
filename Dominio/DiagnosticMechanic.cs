namespace Dominio;
    public class DiagnosticMechanic : BaseEntityA
    {
        public ICollection<SummaryFail> ?SummaryFails { get; set; }
         public ICollection<RepairOrder> ?RepairOrders { get; set; }

        

        public string ? Cc_Mechanic {get; set;}
        public ICollection<Employe> ?Employes { get; set; }

    }

