package modelo;
import java.util.ArrayList;
public class Operario extends Usuario{
	private ArrayList<Almacen> almacenes;
	private ArrayList<Pedido> pedidos;
	//Constructores
	public Operario(){
		almacenes = new ArrayList<Almacen>();
		pedidos = new ArrayList<Pedido>();
	}
	
	public Operario(long id_usuario, String nombre, String apellidos, String correo, String codigo,
                    String contrasena, String descripcion_permisos)
    {
		super(id_usuario, nombre,
                    apellidos, correo, codigo, contrasena, descripcion_permisos);
		almacenes = new ArrayList<Almacen>();
		pedidos = new ArrayList<Pedido>();
    }

	//Metodos set y get
	public void agregarAlmacen(Almacen almacen){
		almacenes.add(almacen);
	}

	public ArrayList<Almacen> getAlmacen(){
		return almacenes;
	}
	public void agregarPedidos(Pedido pedido){
		pedidos.add(pedido);
	}

	public ArrayList<Pedido> getPedidos(){
		return pedidos;
	}
}