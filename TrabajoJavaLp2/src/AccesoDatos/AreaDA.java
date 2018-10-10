/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package AccesoDatos;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import modelo.Area;
/**
 *
 * @author Sebastian
 */
public class AreaDA {
    public void crearArea(Area ar, int id){
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://quilla.lab.inf.pucp.edu.pe/inf282g2",
                    "inf282g2", "UInag9");
            PreparedStatement ps = con.prepareStatement("INSERT INTO AREA(NOMBRE,ID_ALMACEN,FECHA_REGISTRO,REGISTRO_ACTIVO)"
                    + "VALUES(?,?,NOW(),?);");
            
            ps.setString(1,ar.getNombreArea());
            ps.setInt(2,id);
            ps.setInt(3, 1);
            
            ps.executeUpdate();
            
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    }
}
