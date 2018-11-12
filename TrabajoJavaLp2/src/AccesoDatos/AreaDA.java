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
    
    public ArrayList<Area> listarAreas(long idAlm){
        ArrayList<Area> areas = new ArrayList<Area>();
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://quilla.lab.inf.pucp.edu.pe/inf282g2",
                    "inf282g2", "UInag9");
            Statement sentencia = con.createStatement();
            String instruccion = "SELECT * FROM AREA WHERE AREA.ID_ALMACEN = "+idAlm+" AND AREA.REGISTRO_ACTIVO = 1";
            ResultSet rs = sentencia.executeQuery(instruccion);
            while(rs.next()){
                long idAr = rs.getInt("ID_AREA");
                String nombre = rs.getString("NOMBRE");
                Area ar = new Area(idAr,nombre);
                areas.add(ar);
            }
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return areas;
    }
}
