public class DetallePedido {
    private long id_detalle_pedido;
    private Articulo articulo;
    private double cantidad;



    //Constructores
    public DetallePedido() {
        articulo = null;
        id_detalle_pedido = 0;
        cantidad = 0;
    }

    public DetallePedido(long id, Articulo art, double cant)
    {
        Id_detalle_pedido = id;
        Articulo = art;
        Cantidad = cant;
    }

    //Destructor
    ~DetallePedido() {
        articulo = null;
    }

    //Metodos set y get
    public long Id_detalle_pedido { get => id_detalle_pedido; set => id_detalle_pedido = value; }
    public Articulo Articulo { get => articulo; set => articulo = value; }
    public double Cantidad { get => cantidad; set => cantidad = value; }

}