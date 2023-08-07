using System.ComponentModel.DataAnnotations;

namespace Dominio;

public class Employe
{
    //llave no autoincremental
    [Key]
    public string ? Cc_Employe {get; set;}
    public DiagnosticMechanic ? DiagnosticMechanic {get; set;}
    public RolEmploye ? RolEmploye {get; set;}
    public string ? Description {get; set;}
    public string ?Id_PE {get; set;}
    public Person ? Person {get; set;}
    public int Id_Speciality {get; set;}
    public Speciality ? Speciality {get; set;}
    public int Id_Arl {get; set;}
    public Arl ? Arl {get; set;}
    public int Id_Eps {get; set;}
    public Eps ? Eps {get; set;}

}
