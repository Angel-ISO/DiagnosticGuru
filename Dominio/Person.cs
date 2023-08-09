using System.ComponentModel.DataAnnotations;

namespace Dominio;
public class Person
{
//llave principal no autoincremental
  [Key]
  public string ? Id_Person {get; set;}
     public ICollection<Vehicle> ? Vehicles { get; set; }

  public ICollection<Address> ?Addresses { get; set; }
  public ICollection<Employe> ?Employes { get; set; }

  public string ? NamePerson {get; set;}
  public string ? LastNamePerson {get; set;}
  public int Id_TypePerson {get; set;}
  public TypePerson ? TypePerson {get; set; }

  public  int Id_Contact {get; set;}
  public Contact? Contact {get; set; }

}

