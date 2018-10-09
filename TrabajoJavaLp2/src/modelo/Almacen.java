package modelo;
import java.util.ArrayList;
public abstract class Almacen{
	private long idAlmacen;
	private String nomAlmacen;
	private ArrayList<Operario> operarios;
	private ArrayList<Articulo> articulos;

	public Almacen(){
		idAlmacen = 0;
		nomAlmacen = null;
		operarios = new ArrayList<Operario>();
		articulos = new ArrayList<Articulo>();
	}

	public Almacen(long id, String nom){
		setIdAlmacen(id);
        setNomAlmacen(nom);
	}
	public void setIdAlmacen(long id)
    {
        this.idAlmacen = id;
    }

    public long getIdAlmacen()
    {
        return this.idAlmacen;
    }
	
	public void setNomAlmacen(String nomAlmacen)
    {
        this.nomAlmacen = nomAlmacen;
    }

    public String getNomAlmacen()
    {
        return this.nomAlmacen;
    }
	
	public void setOperarios(Operario operario){
		operarios.add(operario);
	}

	public ArrayList<Operario> getOperarios(){
		return operarios;
	}

	public void setArticulos(Articulo articulo){
		articulos.add(articulo);
	}

	public ArrayList<Articulo> getArticulos(){
		return articulos;
	}
}
