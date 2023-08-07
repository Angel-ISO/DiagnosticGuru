namespace Dominio;

public class Region : BaseEntityA
{
    public ICollection<City> ?Cities { get; set; }

    public string? NameRegion { get; set; }
    public int IdPais { get; set; }
    public Country ? Country { get; set; }
}
