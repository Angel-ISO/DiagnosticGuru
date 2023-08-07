namespace Dominio;
public class TypePerson : BaseEntityA
{
      public ICollection<Person> ?Persons { get; set; }

    public string ? Description {get; set;} 
}

