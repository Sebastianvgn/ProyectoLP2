package modelo;
import java.util.Date;
import java.util.ArrayList;
public class RegistroIngreso{
	private long id_Ingreso;
	private Proveedor proveedor;
	private Almacen almacen;
	private Date fecha;
	private Date fecha_proceso;
	private TTipoComprobante tipoComprobante;
	private double subtotal;
	private double igv;
	private double monto_igv;
	private double total;
	private TEstado estado;
	private ArrayList<DetalleRegistroIngreso> detalles;
	

	public RegistroIngreso(){
		this.id_Ingreso = 0;
        this.proveedor=null;
        this.almacen=null;
        this.subtotal=0;
        this.igv=0;
        this.monto_igv=0;
        this.total=0;
        this.detalles = new ArrayList<DetalleRegistroIngreso>();
	}

	public RegistroIngreso(long id_Ingreso, Proveedor proveedor, Almacen almacen,Date fecha,
				Date fecha_proceso, TTipoComprobante tipoComprobante, double subtotal, 
				double igv, double monto_igv,double total, TEstado estado){
		
		this.id_Ingreso = id_Ingreso;
        this.proveedor=proveedor;
        this.almacen=almacen;
        this.fecha=fecha;
        this.fecha_proceso=fecha_proceso;
        this.tipoComprobante=tipoComprobante;
        this.subtotal=subtotal;
        this.igv=igv;
        this.monto_igv=monto_igv;
        this.total=total;
        this.estado=estado;
        this.detalles = new ArrayList<DetalleRegistroIngreso>();
	}

	public void setProveedor(Proveedor proveedor){
		this.proveedor = proveedor;
	}
	public Proveedor getProveedor(){
		return this.proveedor;
	}

	public void setId_ingreso(long id_Ingreso){
		this.id_Ingreso = id_Ingreso;
	}
	public long getId_ingreso(){
		return this.id_Ingreso;
	}

	public void setAlmacen(Almacen almacen){
		this.almacen = almacen;
	}
	public Almacen getAlmacen(){
		return this.almacen;
	}


	public void setFecha(Date fecha){
		this.fecha = fecha;
	}
	public Date getFecha(){
		return this.fecha;
	}


	public void setFecha_proceso(Date fecha_proceso){
		this.fecha_proceso = fecha_proceso;
	}
	public Date getFecha_proceso(){
		return this.fecha_proceso;
	}


	public void setTipoComprobante(TTipoComprobante tipoComprobante){
		this.tipoComprobante = tipoComprobante;
	}
	public TTipoComprobante getTipoComprobante(){
		return this.tipoComprobante;
	}

	public void setSubtotal(double subtotal){
		this.subtotal = subtotal;
	}
	public double getSubtotal(){
		return this.subtotal;
	}
	
	public void setIgv(double igv){
		this.igv = igv;
	}
	public double getIgv(){
		return this.igv;
	}
	
	public void setMonto_igv(double monto_igv){
		this.monto_igv = monto_igv;
	}
	public double getMonto_igv(){
		return this.monto_igv;
	}
	
	public void setTotal(double total){
		this.total = total;
	}
	public double getTotal(){
		return this.total;
	}

	public void setDetalle(DetalleRegistroIngreso detalle){
		detalles.add(detalle);
	}
	public ArrayList<DetalleRegistroIngreso> getDetalle(){
		return detalles;
	}

}