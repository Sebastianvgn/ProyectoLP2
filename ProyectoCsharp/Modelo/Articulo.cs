using System;

public class Articulo{
	private long id_articulo;
	private string codigo;
	private string descripcion;
	private double cantidad;
	private TUnidad unidad;
	private DateTime fecha_caducidad;
	private Categoria categoria;
    private double precio;

    //Constructores
    public Articulo(){
        id_articulo = 0;
        cantidad = 0;
		codigo = descripcion = null;
		categoria = null;
        precio = 0;
	}
	
	public Articulo(long id_articulo, string codigo, string descripcion, double cantidad,
	                TUnidad unidad, DateTime fecha_caducidad, Categoria categoria, double precio){
        Id_articulo = id_articulo;
        Codigo = codigo;
        Descripcion = descripcion;
        Cantidad = cantidad;
        Unidad = unidad;
        Fecha_caducidad = fecha_caducidad;
        Categoria = categoria;
        Precio = precio;
	}
	
	//Destructor
	~Articulo(){
		codigo = descripcion = null;
		categoria = null;
	}

    //Set y get
    public long Id_articulo { get => id_articulo; set => id_articulo = value; }
    public string Codigo { get => codigo; set => codigo = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public double Cantidad { get => cantidad; set => cantidad = value; }
    public TUnidad Unidad { get => unidad; set => unidad = value; }
    public DateTime Fecha_caducidad { get => fecha_caducidad; set => fecha_caducidad = value; }
    public Categoria Categoria { get => categoria; set => categoria = value; }
    public double Precio { get => precio; set => precio = value; }

    public override string ToString()
    {
        return Descripcion;
    }
}