package modelo;
import java.util.ArrayList;
import java.util.Date;
public class Pedido{
	private long id_pedido;
	private Date fecha_produccion;
	private Date fecha_entrega;
	private String hora_entrega;
	private Usuario responsable;
	private TEstado estado;
	private TTipoPedido tipo_pedido;
	private Almacen almacen;
	private Area area;
	private double monto;
	private double monto_igv;
	private double total;
	private ArrayList<DetallePedido> detalles;

	public Pedido(){
		this.hora_entrega = null;
        this.id_pedido = 0;
        this.responsable=null;
        this.almacen=null;
        this.area=null;
        this.monto=0;
        this.monto_igv=0;
        this.total=0;
		this.detalles = new ArrayList<DetallePedido>();
	}

	public Pedido(long id_pedido,Date fecha_produccion,Date fecha_entrega,String hora_entrega, 
					Usuario responsable, TEstado estado, TTipoPedido tipo_pedido,Almacen almacen,
					Area area, double monto, double monto_igv, double total){
       	this.id_pedido = id_pedido;
        this.fecha_produccion=fecha_produccion;
        this.fecha_entrega=fecha_entrega;
        this.hora_entrega=hora_entrega;
        this.responsable=responsable;
        this.estado=estado;
        this.tipo_pedido=tipo_pedido;
        this.almacen=almacen;
        this.area=area;
        this.monto=monto;
        this.monto_igv=monto_igv;
        this.total=total;
		this.detalles = new ArrayList<DetallePedido>();
	}

	public void setId_pedido(long id_pedido){
		this.id_pedido = id_pedido;
	}
	public long getId_pedido(){
		return id_pedido;
	}
	
	public void setEstado(TEstado estado){
		this.estado = estado;
	}
	public TEstado getEstado(){
		return estado;
	}

	
	public void setDetalle(DetallePedido detalle){
		detalles.add(detalle);
	}
	public ArrayList<DetallePedido> getDetalle(){
		return detalles;
	}

	public void setFecProduccion(Date fecha_produccion){
		this.fecha_produccion=fecha_produccion;
	}
	public Date getFecProduccion(){
		return this.fecha_produccion;
	}
	
	public void setFecEntrega(Date fecha_entrega){
		this.fecha_produccion=fecha_entrega;
	}
	public Date getFecEntrega(){
		return this.fecha_entrega;
	}
	
	public void setHoraEntrega(String hora_entrega){
		this.hora_entrega=hora_entrega;
	}
	public String getHoraEntrega(){
		return this.hora_entrega;
	}
	
	public void setResponsable(Usuario responsable){
		this.responsable=responsable;
	}
	public Usuario getResponsable(){
		return this.responsable;
	}
	
	public void setTipoPedido(TTipoPedido tipo_pedido){
		this.tipo_pedido=tipo_pedido;
	}
	public TTipoPedido getTipoPedido(){
		return this.tipo_pedido;
	}
	
	public void setAlmacen(Almacen almacen){
		this.almacen=almacen;
	}
	public Almacen getAlmacen(){
		return this.almacen;
	}
	
	public void setArea(Area area){
		this.area=area;
	}
	public Area getArea(){
		return this.area;
	}
	
	public void setMonto(double monto){
		this.monto=monto;
	}
	public double getMonto(){
		return this.monto;
	}
	
	public void setMonto_igv(double monto_igv){
		this.monto_igv=monto_igv;
	}
	public double getMonto_igv(){
		return this.monto_igv;
	}
	
	public void setTotal(double total){
		this.total=total;
	}
	public double getTotal(){
		return this.total;
	}
}