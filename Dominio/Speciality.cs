using System.ComponentModel.DataAnnotations;

namespace Dominio;
public class Speciality : BaseEntityA
{
    public ICollection<Employe> ?Employes { get; set; }

    public string ? Description {get; set;}
}

