/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package LogicaNegocio;
import modelo.Almacen;
import modelo.Area;
import AccesoDatos.AlmacenDA;
import AccesoDatos.AreaDA;
import java.util.ArrayList;
/**
 *
 * @author Sebastian
 */
public class AlmacenBL {
    private AlmacenDA almacenDA;
    private AreaDA areaDA;
    
    public AlmacenBL(){
        almacenDA = new AlmacenDA();
        areaDA = new AreaDA();
    }
    
    public void crearAlmacen(Almacen alm, ArrayList<Area> ar, int user){
        int auto_id = almacenDA.crearAlmacen(alm, user);
        int cant = ar.size();
        int i;
        for(i = 0; i<cant; i++){
            areaDA.crearArea(ar.get(i), auto_id);
        }
        alm.setAreas(ar);
    }
}
