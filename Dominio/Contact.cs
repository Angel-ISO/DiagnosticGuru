namespace Dominio;
public class Contact : BaseEntityA
{
    public int Id_Person {get; set;}
    public ICollection<Person> ?Persons { get; set; }
    public int Id_TypeContact {get; set;}
    public TypeContact ? typeContact {get; set;}

}

