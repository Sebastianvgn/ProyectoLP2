package modelo;
import java.util.ArrayList;
public class AlmacenVirtual extends Almacen{
	private ArrayList<Area> areas;
	public AlmacenVirtual(){
		
	}

	public AlmacenVirtual(long id, String nom){
		super(id,nom);
	}
	public void setArea(Area areas){
		this.areas.add(areas);
	}

	public ArrayList<Area> getArea(){
		return areas;
	}
}