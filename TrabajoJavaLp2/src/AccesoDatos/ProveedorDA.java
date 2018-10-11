/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package AccesoDatos;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import modelo.Proveedor;

/**
 *
 * @author alulab14
 */
public class ProveedorDA {
    public ArrayList<Proveedor> listarProveedores(){
        ArrayList<Proveedor> proveedores = new ArrayList<Proveedor>();
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://quilla.lab.inf.pucp.edu.pe/inf282g2",
                    "inf282g2", "UInag9");
            Statement sentencia = con.createStatement();
            String instruccion = "SELECT * FROM PROVEEDOR WHERE REGISTRO_ACTIVO = 1";
            ResultSet rs = sentencia.executeQuery(instruccion);
            
            while(rs.next()){
                long idProv = rs.getInt("ID_PROVEEDOR");
                String ruc = rs.getString("RUC");
                String razonSocial = rs.getString("RAZON_SOCIAL");
                String mail = rs.getString("CORREO");
                String tele = rs.getString("TELEFONO");
                Proveedor prov = new Proveedor(idProv,ruc,razonSocial,mail,tele);
                proveedores.add(prov);
            }
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }    
        return proveedores;
    }
    
    public void crearProveedor(Proveedor prov){
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://quilla.lab.inf.pucp.edu.pe/inf282g2",
                    "inf282g2", "UInag9");
            PreparedStatement ps = con.prepareStatement("INSERT INTO PROVEEDOR"
                    + "(RUC,RAZON_SOCIAL,CORREO,TELEFONO,FECHA_REGISTRO,"
                    + "REGISTRO_ACTIVO) VALUES(?,?,?,?,NOW(),?);");
            
            ps.setString(1, prov.getRUC());
            ps.setString(2, prov.getRazon_socual());
            ps.setString(3, prov.getEmail());
            ps.setString(4, prov.getTelefono());
            ps.setInt(5, 1);
            
            ps.executeUpdate();
            
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    }
    
    public void modificarProveedor(Proveedor prov){
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://quilla.lab.inf.pucp.edu.pe/inf282g2",
                    "inf282g2", "UInag9");
            PreparedStatement ps = con.prepareStatement("UPDATE PROVEEDOR SET RUC = ?, RAZON_SOCIAL = ?,"
                    + "CORREO = ?, TELEFONO=?,"
                    + "FECHA_REGISTRO = NOW() WHERE ID_PROVEEDOR = ?;");
            ps.setString(1,prov.getRUC());
            ps.setString(2,prov.getRazon_socual());
            ps.setString(3, prov.getEmail());
            ps.setString(4, prov.getTelefono());
            ps.setLong(5,prov.getId_proveedor());
            
            ps.executeUpdate();
            
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    }
    
    public void eliminarProveedor(Proveedor prov){
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://quilla.lab.inf.pucp.edu.pe/inf282g2",
                    "inf282g2", "UInag9");
            PreparedStatement ps = con.prepareStatement("UPDATE PROVEEDOR SET REGISTRO_ACTIVO = ? WHERE ID_PROVEEDOR = ?");
            ps.setInt(1, 0);
            ps.setLong(2, prov.getId_proveedor());
            
            ps.executeUpdate();
            
            con.close();     
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    }
}
