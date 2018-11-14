/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package AccesoDatos;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import modelo.Almacen;
import modelo.Operario;
import modelo.Usuario;

/**
 *
 * @author alulab14
*/
public class AlmacenDA {
    public int crearAlmacen(Almacen alm, long user){
        int auto_id = 0;
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://quilla.lab.inf.pucp.edu.pe/inf282g2",
                    "inf282g2", "UInag9");
            
            CallableStatement cSmt = con.prepareCall("{call REGISTRAR_ALMACENES(?,?,?,?,?)}");
            cSmt.registerOutParameter("idAlmacen", java.sql.Types.INTEGER);
            cSmt.setLong("_ID_USUARIO", user);
            cSmt.setString("_NOMBRE", alm.getNomAlmacen());
            cSmt.setInt("_TIPO_ALMACEN", alm.getTipo_almacen());
            cSmt.setString("_DESCRIPCION", alm.getDescripcion());
            cSmt.execute();
            auto_id = cSmt.getInt("idAlmacen");
            /*PreparedStatement ps = con.prepareStatement("INSERT INTO ALMACEN(ID_USUARIO,NOMBRE,TIPO_ALMACEN,DESCRIPCION,"
                    + "FECHA_REGISTRO,REGISTRO_ACTIVO) VALUES(?,?,?,?,NOW(),?);", Statement.RETURN_GENERATED_KEYS);
            ResultSet rs = ps.getGeneratedKeys();
            rs.next();
            auto_id = rs.getInt(1);
            ps.setLong(1,user);
            ps.setString(2,alm.getNomAlmacen());
            ps.setInt(3, alm.getTipo_almacen());
            ps.setString(4, alm.getDescripcion());
            ps.setInt(5, 1);
            
            ps.executeUpdate();*/
            
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return auto_id;
    }
    
    public ArrayList<Almacen> listarAlmacenes(){
        ArrayList<Almacen> almacenes = new ArrayList<Almacen>();
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://quilla.lab.inf.pucp.edu.pe/inf282g2",
                    "inf282g2", "UInag9");
            Statement sentencia = con.createStatement();
            String instruccion = "SELECT * FROM ALMACEN WHERE REGISTRO_ACTIVO = 1";
            ResultSet rs = sentencia.executeQuery(instruccion);
            ArrayList<Usuario> usuarios = new ArrayList<Usuario>();
            UsuarioDA usuarioDA = new UsuarioDA();
            usuarios = usuarioDA.listarUsuarios();
            int cant = usuarios.size();
            
            while(rs.next()){
                ArrayList<Operario> operarios = new ArrayList<Operario>();
                long idAlm = rs.getInt("ID_ALMACEN");
                long iduser = rs.getInt("ID_USUARIO");
                for(int i = 0; i<cant; i++){
                    if(iduser == usuarios.get(i).getId_usuario()){
                        operarios.add((Operario)usuarios.get(i));
                        break;
                    }
                }
                String nombre = rs.getString("NOMBRE");
                int tipo = rs.getInt("TIPO_ALMACEN");
                String desc = rs.getString("DESCRIPCION");
                Almacen al = new Almacen();
                al.setDescripcion(desc);
                al.setIdAlmacen(idAlm);
                al.setNomAlmacen(nombre);
                al.setOperarios(operarios);
                al.setTipo_almacen(tipo);
                almacenes.add(al);
                
            }
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return almacenes;
    }
    
    public void modificarAlmacen(Almacen alm){
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://quilla.lab.inf.pucp.edu.pe/inf282g2",
                    "inf282g2", "UInag9");
            PreparedStatement ps = con.prepareStatement("UPDATE ALMACEN SET ID_USUARIO = ?, NOMBRE = ?,"
                    + "TIPO_ALMACEN = ?, DESCRIPCION = ?, FECHA_REGISTRO = NOW() WHERE ID_ALMACEN = ?");
            
            ps.setLong(1, alm.getOperarios().get(0).getId_usuario());
            ps.setString(2, alm.getNomAlmacen());
            ps.setInt(3, alm.getTipo_almacen());
            ps.setString(4, alm.getDescripcion());
            ps.setLong(5, alm.getIdAlmacen());
            ps.executeUpdate();
            
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    }
    
    public void eliminarAlmacen(long idAlm){
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://quilla.lab.inf.pucp.edu.pe/inf282g2",
                    "inf282g2", "UInag9");
            PreparedStatement ps = con.prepareStatement("UPDATE ALMACEN SET REGISTRO_ACTIVO = ? WHERE ID_ALMACEN = ?");
            ps.setInt(1, 0);
            ps.setLong(2, idAlm);
            ps.executeUpdate();
            
            con.close(); 
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    }
}
