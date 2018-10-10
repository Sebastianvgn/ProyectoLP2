/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modelo;

import java.util.Date;

/**
 *
 * @author Lenovo
 */
public class Articulo {
        private long id_articulo;
	private String codigo;
	private String descripcion;
	private double cantidad;
        private double precio;
	private TUnidad unidad;
	private Date fecha_caducidad;
	private Categoria categoria;

    

	//Constructores
	public Articulo(){
		id_articulo = 0;
		codigo = descripcion = null;
		cantidad = 0;
		unidad = null;
		categoria = null;
	}

	public Articulo(long id_articulo, String codigo, String descripcion, double cantidad, double precio, TUnidad unidad, Date fecha_caducidad, Categoria categoria) {
            this.id_articulo = id_articulo;
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.precio = precio;
            this.unidad = unidad;
            this.fecha_caducidad = fecha_caducidad;
            this.categoria = categoria;
        }

	//Metodos set y get
	public void setId_articulo(long id_articulo){
		this.id_articulo = id_articulo;
	}

	public long getId_articulo(){
		return id_articulo;
	}

        public double getPrecio() {
            return precio;
        }
        
        public void setPrecio(double precio) {
            this.precio = precio;
        }
        
	public void setCodigo(String codigo){
		this.codigo = codigo;
	}

	public String getCodigo(){
		return codigo;
	}

	public void setDescripcion(String descripcion){
		this.descripcion = descripcion;
	}

	public String getDescripcion(){
		return descripcion;
	}

	public void setCantidad(double cantidad){
		this.cantidad = cantidad;
	}

	public double getCantidad(){
		return cantidad;
	}        

	public void setUnidad(TUnidad unidad){
		this.unidad = unidad;
	}

	public TUnidad getUnidad(){
		return unidad;
	}

	public void setFecha_caducidad(Date fecha_caducidad){
		this.fecha_caducidad = fecha_caducidad;
	}

	public Date getFecha_caducidad(){
		return fecha_caducidad;
	}

	public void setCategoria(Categoria categoria){
		this.categoria = categoria;
	}

	public Categoria getCategoria(){
		return categoria;
	}
}
