package modelo;

import java.util.Date;

public class Merma  extends Articulo
{
    private String motivo_de_baja;

    public Merma()
    {
        motivo_de_baja = null;
    }

    public Merma(long id_articulo, String codigo, String descripcion, double cantidad,double precio, TUnidad unidad, Date fecha_caducidad, Categoria categoria, String motivo_de_baja) 
         
    {
	super(id_articulo, codigo, descripcion, cantidad, precio, unidad, fecha_caducidad, categoria);
        motivo_de_baja = motivo_de_baja;
    }

	public void setMotivo_de_baja(String motivo){
		this.motivo_de_baja = motivo;
	}
	
	public String getMotivo_de_baja(){
		return this.motivo_de_baja;
	}
}

