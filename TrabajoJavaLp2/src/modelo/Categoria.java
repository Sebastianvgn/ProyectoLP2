/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modelo;

import java.util.ArrayList;

/**
 *
 * @author Lenovo
 */
public class Categoria {
    private long id_categoria;
	private String nombre;
	private String descripcion;
	private ArrayList<Articulo> articulos;
	public Categoria(){
		id_categoria = 0;
		nombre = null;
		descripcion = null;
		articulos = new ArrayList<Articulo>();
	}

	public Categoria(long id_categoria, String nombre, String descripcion){
		setId_categoria(id_categoria);
		setNombre(nombre);
		setDescripcion(descripcion);
	}

	public void setId_categoria(long id_categoria){
		this.id_categoria = id_categoria;
	}

	public long getId_categoria(){
		return id_categoria;
	}

	public void setNombre(String nombre){
		this.nombre = nombre;
	}

	public String getNombre(){
		return nombre;
	}

	public void setDescripcion(String descripcion){
		this.descripcion = descripcion;
	}

	public String getDescripcion(){
		return descripcion;
	}
	public void AgregarArticulo(Articulo articulos){
		this.articulos.add(articulos);
	}
	
	public ArrayList<Articulo> articulos(){
		return this.articulos;
	}
}
