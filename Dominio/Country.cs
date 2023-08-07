namespace Dominio;

public class Country : BaseEntityA
{
    public ICollection<Region> ?Regions { get; set; }
    public string ? NameCountry { get; set; }
}