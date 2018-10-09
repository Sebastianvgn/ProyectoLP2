/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modelo;

/**
 *
 * @author Lenovo
 */
public class DetalleRegistroIngreso {
    private long id_detalle_ingreso;
    private Articulo articulo;
    private double cantidad;
    private double precio;
    private double subtotal;

	public DetalleRegistroIngreso() {
        id_detalle_ingreso = 0;
        cantidad = 0;
        precio = 0;
        subtotal = 0;
    }

    public DetalleRegistroIngreso(long id, Articulo art, double cant, double precio, double subtotal)
    {
        articulo = art;
        id_detalle_ingreso = id;
        cantidad = cant;
        precio = precio;
        subtotal = subtotal;
    }


    //Metodos set y get
    public void SetId_detalle_ingreso(long id){
		this.id_detalle_ingreso  = id;
	}
	
	public long GetId_detalle_ingreso(){
		return this.id_detalle_ingreso;
	}
	
	public void SetArticulo(Articulo articulo){
		this.articulo = articulo;
	}
	
	public Articulo GetArticulo(){
		return this.articulo;
	}
	
	public void SetCantidad(double cantidad){
		this.cantidad = cantidad;
	}
	
	public double GetCantidad(){
		return this.cantidad;
	}

	public void SetPrecio(double precio){
		this.precio = precio;
	}
	
	public double GetPrecio(){
		return this.precio;
	}

	public void SetSubtotal(double subtotal){
		this.subtotal = subtotal;
	}
	
	public double GetSubtotal(){
		return this.subtotal;
	}

}

