using System.ComponentModel.DataAnnotations;

namespace Dominio;

public class Brand
{
    [Key]
    public string ? Id_Brand {get; set;}
    public ICollection<Vehicle> ?Vehicles { get; set; }
    public string ? Description {get; set;}
}
