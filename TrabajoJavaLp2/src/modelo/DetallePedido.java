public class DetallePedido{
	private long id_detalle_pedido;
	private	Articulo articulo;
	private double cantidad;
	
	public DetallePedido(){
		id_detalle_pedido = 0;
		articulo = null;
		cantidad = 0;
	}

	public DetallePedido(long id_detalle_pedido, Articulo articulo, double cantidad){
		setId_detalle_pedido(id_detalle_pedido);
		setArticulo(articulo);
		setCantidad(cantidad);
	}

	public void setId_detalle_pedido(long id){
		this.id_detalle_pedido  = id;
	}
	
	public long getId_detalle_pedido(){
		return this.id_detalle_pedido;
	}
	
	public void setArticulo(Articulo articulo){
		this.articulo = articulo;
	}
	
	public Articulo getArticulo(){
		return this.articulo;
	}
	
	public void setCantidad(double cantidad){
		this.cantidad = cantidad;
	}
	
	public double getCantidad(){
		return this.cantidad;
	}
	

}