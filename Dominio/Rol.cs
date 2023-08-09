using System.ComponentModel.DataAnnotations;

namespace Dominio;
public class Rol
{
    [Key]
    public int ?Id_Rol {get; set;}
    public ICollection<RolEmploye> ?RolEmployes { get; set; }
    public string ?Description {get; set;}
}

