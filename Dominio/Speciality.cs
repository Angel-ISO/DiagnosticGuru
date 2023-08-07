using System.ComponentModel.DataAnnotations;

namespace Dominio;
public class Speciality
{
    [Key]
    public string ? Id_Speciality {get; set;}
    public ICollection<Employe> ?Employes { get; set; }

    public string ? Description {get; set;}
}

