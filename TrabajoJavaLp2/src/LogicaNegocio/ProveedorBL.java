/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package LogicaNegocio;
import modelo.Proveedor;
import AccesoDatos.ProveedorDA;
import java.util.ArrayList;

/**
 *
 * @author alulab14
 */
public class ProveedorBL {
    private ProveedorDA proveedorDA;
    
    public ProveedorBL(){
        proveedorDA = new ProveedorDA();
    }
    
    public ArrayList<Proveedor> listarProveedoreS(){
        return proveedorDA.listarProveedores();
    }
    
    public void crearProveedor(Proveedor prov){
        proveedorDA.crearProveedor(prov);
    }
}
