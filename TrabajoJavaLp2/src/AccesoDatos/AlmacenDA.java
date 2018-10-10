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
import modelo.Almacen;
import modelo.Usuario;

/**
 *
 * @author alulab14
*/
public class AlmacenDA {
    public int crearAlmacen(Almacen alm, int user){
        int auto_id = 0;
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://quilla.lab.inf.pucp.edu.pe/inf282g2",
                    "inf282g2", "UInag9");
            
            PreparedStatement ps = con.prepareStatement("INSERT INTO ALMACEN(ID_USUARIO,NOMBRE,TIPO_ALMACEN,DESCRIPCION,"
                    + "FECHA_REGISTRO,REGISTRO_ACTIVO) VALUES(?,?,?,?,NOW(),?);", Statement.RETURN_GENERATED_KEYS);
            ResultSet rs = ps.getGeneratedKeys();
            rs.next();
            auto_id = rs.getInt(1);
            ps.setInt(1,user);
            ps.setString(2,alm.getNomAlmacen());
            ps.setInt(3, alm.getTipo_almacen());
            ps.setString(4, alm.getDescripcion());
            ps.setInt(5, 1);
            
            ps.executeUpdate();
            
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return auto_id;
    }
}
