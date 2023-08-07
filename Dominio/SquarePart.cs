namespace Dominio;

    public class SquarePart : BaseEntityA
    {
      public ICollection<RelPartsOrder> ?RelPartsOrders { get; set; }

        public int Id_Nit {get; set;}
        public Nit ? Nit {get; set;}
        public string ? Description {get; set;}
        public string ? Price {get; set;}
        public string ? Brand {get; set;}
    }
