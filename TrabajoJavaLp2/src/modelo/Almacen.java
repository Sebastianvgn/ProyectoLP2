package modelo;
import java.util.ArrayList;
public class Almacen{
	private long idAlmacen;
	private String nomAlmacen;
        private String descripcion;
        private int tipo_almacen;
	private ArrayList<Operario> operarios;
	private ArrayList<Articulo> articulos;
        private ArrayList<Area> areas;

    public Almacen(){
        idAlmacen = 0;
        nomAlmacen = null;
        descripcion = null;
        tipo_almacen = 0;
        operarios = new ArrayList<Operario>();
        articulos = new ArrayList<Articulo>();
        areas = new ArrayList<Area>();
                
    }    
        
    public Almacen(long idAlmacen, String nomAlmacen, String descripcion, int tipo_almacen, ArrayList<Operario> operarios, ArrayList<Articulo> articulos, ArrayList<Area> areas) {
        this.idAlmacen = idAlmacen;
        this.nomAlmacen = nomAlmacen;
        this.descripcion = descripcion;
        this.tipo_almacen = tipo_almacen;
        this.operarios = operarios;
        this.articulos = articulos;
        this.areas = areas;
    }

    public long getIdAlmacen() {
        return idAlmacen;
    }

    public void setIdAlmacen(long idAlmacen) {
        this.idAlmacen = idAlmacen;
    }

    public String getNomAlmacen() {
        return nomAlmacen;
    }

    public void setNomAlmacen(String nomAlmacen) {
        this.nomAlmacen = nomAlmacen;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public int getTipo_almacen() {
        return tipo_almacen;
    }

    public void setTipo_almacen(int tipo_almacen) {
        this.tipo_almacen = tipo_almacen;
    }

    public ArrayList<Operario> getOperarios() {
        return operarios;
    }

    public void setOperarios(ArrayList<Operario> operarios) {
        this.operarios = operarios;
    }

    public ArrayList<Articulo> getArticulos() {
        return articulos;
    }

    public void setArticulos(ArrayList<Articulo> articulos) {
        this.articulos = articulos;
    }

    public ArrayList<Area> getAreas() {
        return areas;
    }

    public void setAreas(ArrayList<Area> areas) {
        this.areas = areas;
    }

	

	
}
