namespace Dominio;
public class Door : BaseEntityA
{
    public string ? Fowardleft {get; set;}
    public string ? Backdoorleft {get; set;}
    public string ? Fowardright {get; set;}
    public string ? Backdoorright {get; set;}
    public string ? Trunk {get; set;}
    public string ? Hood {get; set;}
    public int Id_Inspeccion {get; set;}
    public Inspeccion ? Inspecccion {get; set;}
}

