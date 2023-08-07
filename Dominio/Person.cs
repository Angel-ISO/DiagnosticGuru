using System.ComponentModel.DataAnnotations;

namespace Dominio;
public class Person
{
//llave principal no autoincremental
  [Key]
  public string ?Id_Person {get; set;}
  public ICollection<Address> ?Addresses { get; set; }
  public ICollection<Employe> ?Employes { get; set; }

  public string ? Name {get; set;}
  public string ? LastName {get; set;}
  public int Id_TypePerson {get; set;}
  public TypePerson ? TypePerson {get; set; }

}

