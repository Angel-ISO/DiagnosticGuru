using System.ComponentModel.DataAnnotations;

namespace Dominio;
public class TypeContact : BaseEntityA
{
    public ICollection<Contact> ?Contacts { get; set; }

    public string ? Email {get; set;}
    public int Id_Telephone {get; set;}
    public Telephone ? Telephone {get; set;}
}

