namespace Dominio;
public class Telephone : BaseEntityA
{
  public ICollection<TypeContact> ?TypeContacts { get; set; }
  public string ? MobileNumber {get; set;}
  public string ? TelephoneNumber {get; set;}

}

