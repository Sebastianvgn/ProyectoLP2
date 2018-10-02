using System;
using System.Collections.Generic;

public class Operario : Usuario{
	private List<Almacen> almacenes;
	private List<Pedido> pedidos;
	//Constructores
	public Operario(){
		almacenes = new List<Almacen>();
        pedidos = new List<Pedido>();
	}
	
	public Operario(long id_usuario, string nombre, string apellidos, string correo, string codigo,
	                string contraseña , string descripcion_permisos) : base(id_usuario, nombre,
				    apellidos, correo, codigo, contraseña, descripcion_permisos){
		almacenes = new List<Almacen>();
		pedidos = new List<Pedido>();
	}
	
	//Destructor
	~Operario(){
		almacenes = null;
	}
	
	//Metodos get y set
	public void AgregarAlmacen(Almacen almacen){
		this.almacenes.Add(almacen);
	}
	
	public List<Almacen> GetAlmacenes(){
		return this.almacenes;
	}

	public void AgregarPedidos(Pedido pedido){
		this.pedidos.Add(pedido);
	}
	
	public List<Pedido> GetPedidos(){
		return this.pedidos;
	}
}