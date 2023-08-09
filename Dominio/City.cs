namespace Dominio;

public class City : BaseEntityA
{
public ICollection<Address> ? Addresses { get; set; }
public ICollection<OrderService> ? OrderServices { get; set; }


public string ?NameCity { get; set; }
public int ?Id_Region { get; set; }
public Region ? Region { get; set; }

}
