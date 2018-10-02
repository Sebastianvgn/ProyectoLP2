public class Area{
	private long idArea;
	private string nombreArea;

    //Constructores
    public Area(){
        idArea = 0;
		nombreArea = null;
	}
	public Area(long idArea, string nombreArea){
        IdArea = idArea;
        NombreArea = nombreArea;
	}
	
	~Area(){
		nombreArea = null;
	}

    //Set y get

    public long IdArea { get => idArea; set => idArea = value; }
    public string NombreArea { get => nombreArea; set => nombreArea = value; }

    public override string ToString()
    {
        return NombreArea;
    }
}