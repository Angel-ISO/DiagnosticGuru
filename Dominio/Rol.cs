using System.ComponentModel.DataAnnotations;

namespace Dominio;
public class Rol : BaseEntityA
{
    public ICollection<RolEmploye> ?RolEmployes { get; set; }
    public string ?Description {get; set;}
}

