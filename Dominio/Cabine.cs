namespace Dominio;

public class Cabine : BaseEntityA
{
  public ICollection<Radio> ?Radios { get; set; }
   public ICollection<Upholstery> ?Upholsteries { get; set; }


    public int Id_Inspeccion {get; set;}
    public Inspeccion ? Inspeccion {get; set;}
}
