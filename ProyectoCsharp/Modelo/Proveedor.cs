public class Proveedor{
    private long idProveedor;
	private string RUC;
	private string razon_social;
	private string email;
	private string telefono;



    //Constructores
    public Proveedor(){
		RUC = razon_social = email = telefono = null;
	}
	
	public Proveedor(long id_proveedor, string RUC, string razon_social, string email, string telefono){
        IdProveedor = id_proveedor;
        RUC1 = RUC;
        Razon_social = razon_social;
        Email = email;
        Telefono = telefono;
	}
	
	//Destructores
	~Proveedor(){
		RUC = razon_social = email  = telefono = null;
	}

    //Metodos Get y Set

    public long IdProveedor { get => idProveedor; set => idProveedor = value; }
    public string RUC1 { get => RUC; set => RUC = value; }
    public string Razon_social { get => razon_social; set => razon_social = value; }
    public string Email { get => email; set => email = value; }
    public string Telefono { get => telefono; set => telefono = value; }
}