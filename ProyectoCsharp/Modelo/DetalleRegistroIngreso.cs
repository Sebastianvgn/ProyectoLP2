public class DetalleRegistroIngreso {
    private long id_detalle_ingreso;
    private Articulo articulo;
    private double cantidad;
    private double precio;
	private double subtotal;



    public DetalleRegistroIngreso() {
        Articulo = null;
        Id_detalle_ingreso = 0;
        cantidad = precio = subtotal = 0;
    }

    public DetalleRegistroIngreso(long id, Articulo art, double cant, double precio, double subtotal)
    {
        Articulo = art;
        Id_detalle_ingreso = id;
        Cantidad = cant;
        Precio = precio;
        Subtotal = subtotal;
    }

    //Destructor
    ~DetalleRegistroIngreso() {
        articulo = null;
    }

    //Metodos set y get
    public Articulo Articulo { get => articulo; set => articulo = value; }
    public double Cantidad { get => cantidad; set => cantidad = value; }
    public double Precio { get => precio; set => precio = value; }
    public double Subtotal { get => subtotal; set => subtotal = value; }
    public long Id_detalle_ingreso { get => id_detalle_ingreso; set => id_detalle_ingreso = value; }
}