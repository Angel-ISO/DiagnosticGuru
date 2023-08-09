namespace Dominio;

public class ServiceFee : BaseEntityA
{ 
    public ICollection<Service> ?Services { get; set; }

    public string ? FeePorcent {get; set;}
}
