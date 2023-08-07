namespace Dominio;
public class RolEmploye : BaseEntityA
{
    public int Id_Rol {get; set;}
    public Rol ? Rol {get; set;}
    public int Id_Employe {get; set;}
    public ICollection<Employe> ?Employes { get; set; }


}

