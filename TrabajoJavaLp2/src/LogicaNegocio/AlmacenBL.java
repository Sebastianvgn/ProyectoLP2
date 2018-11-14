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
    
    public void crearAlmacen(Almacen alm, ArrayList<Area> ar, long user){
        int auto_id = almacenDA.crearAlmacen(alm, user);
        int cant = ar.size();
        int i;
        for(i = 0; i<cant; i++){
            areaDA.crearArea(ar.get(i), auto_id);
        }
        alm.setAreas(ar);
    }
    
    public ArrayList<Almacen> listarAlmacenes(){
        ArrayList<Almacen> almacenes = almacenDA.listarAlmacenes();
        int cant = almacenes.size();
        for(int i = 0; i<cant; i++){
            long id = almacenes.get(i).getIdAlmacen();
            ArrayList<Area> areas = new ArrayList<Area>();
            areas = areaDA.listarAreas(id);
            almacenes.get(i).setAreas(areas);
        }
        return almacenes;
    }
    
    public void modificarAlmacen(Almacen alm, boolean flag){
        ArrayList<Area> areas = new ArrayList<Area>();
        areas = alm.getAreas();
        int cant = areas.size();
        int idAlm = (int)alm.getIdAlmacen();
        
        if(flag){
            for(int i = 0; i<cant; i++){
                areaDA.eliminarAreas(areas.get(i), alm.getIdAlmacen());
            }
            for(int j = 0; j<cant; j++){
                areaDA.crearArea(areas.get(j), idAlm);
            }
        }
        
        almacenDA.modificarAlmacen(alm);
    }
    
    public void eliminarAlmacen(Almacen alm){
        ArrayList<Area> areas = new ArrayList<Area>();
        areas = alm.getAreas();
        int cant = areas.size();
        int idAlm = (int)alm.getIdAlmacen();
        for(int i = 0; i<cant; i++){
            areaDA.eliminarAreas(areas.get(i), alm.getIdAlmacen());
        }
        almacenDA.eliminarAlmacen(alm.getIdAlmacen());
    }
}
