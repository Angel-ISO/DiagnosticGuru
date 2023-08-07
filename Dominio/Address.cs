namespace Dominio;

public class Address : BaseEntityA
{
    public string ? Neigborhood { get; set; }
    
    public string ? TypeWay  {get; set;}
    public string ? QuadrantPrefix {get; set;}
    public double  NumberWay {get; set;}
    public double NumberVenereableWay {get; set;}
    public double NumberPlate {get; set;}
    public int Id_Pa {get; set;}
    public Person ? Person {get; set;}
    public int Id_CityA {get; set;}
    public City ? City  {get; set;}
}
