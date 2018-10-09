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
import java.util.Date;
import modelo.Usuario;
import modelo.Gerente;
import modelo.Operario;
import modelo.JefeDeAlmacen;
import modelo.AdministradorDeSistema;

/**
 *
 * @author alulab14
 */
public class UsuarioDA {
    
    public ArrayList<Usuario> listarUsuarios(){
        ArrayList<Usuario> usuarios = new ArrayList<Usuario>();
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://quilla.lab.inf.pucp.edu.pe/inf282g2",
                    "inf282g2", "UInag9");
            Statement sentencia = con.createStatement();
            String instruccion = "SELECT U.*, P.NOMBRE FROM USUARIO AS U, PERFIL AS P WHERE U.ID_PERFIL = P.ID_PERFIL";
            ResultSet rs = sentencia.executeQuery(instruccion);
            
            while(rs.next()){
                long idUser = rs.getInt("ID_USUARIO");
                //long idPerf = rs.getInt("ID_PERFIL");
                String name = rs.getString("NOMBRES");
                String ap = rs.getString("APELLIDOS");
                String mail = rs.getString("CORREO");
                String dni = rs.getString("DNI");
                String user = rs.getString("USERNAME");
                String pass = rs.getString("PASSWORD");
                //Date fecha = rs.getDate("FECHA_REGISTRO");
                //int reg = rs.getInt("REGISTRO_ACTIVO");
                String perfil = rs.getString("NOMBRE");

                if(perfil.equals("GERENTE")){
                    Gerente ger = new Gerente(idUser,name,ap,mail,dni,user,pass,perfil);
                    usuarios.add(ger);
                }
                else if(perfil.equals("JEFE DE ALMACEN")){
                    JefeDeAlmacen jefe = new JefeDeAlmacen(idUser,name,ap,mail,dni,user,pass,perfil);
                    usuarios.add(jefe);
                }
                else if(perfil.equals("OPERARIO")){
                    Operario oper = new Operario(idUser,name,ap,mail,dni,user,pass,perfil);
                    usuarios.add(oper);
                }
                else if(perfil.equals("ADMINISTRADOR DE SISTEMAS")){
                    AdministradorDeSistema admin = new AdministradorDeSistema(idUser,name,ap,mail,dni,user,pass,perfil);
                    usuarios.add(admin);
                }
                
            }
            con.close();
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return usuarios;
    }
    
    public void crearUsuario(Usuario user){
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://quilla.lab.inf.pucp.edu.pe/inf282g2",
                    "inf282g2", "UInag9");
            
            PreparedStatement ps = con.prepareStatement("INSERT INTO USUARIO(ID_PERFIL"
                    + ",NOMBRES,APELLIDOS,CORREO,DNI,USERNAME,PASSWORD,"
                    + "FECHA_REGISTRO,REGISTRO_ACTIVO) VALUES"
                    + "(?,?,?,?,?,?,?,NOW(),?);");
            if(user.getDescripcion_permisos().equals("GERENTE")){
                ps.setInt(1, 1);
            }else if(user.getDescripcion_permisos().equals("JEFE DE ALMACEN")){
                ps.setInt(1, 3);
            }else if(user.getDescripcion_permisos().equals("OPERARIO")){
                ps.setInt(1, 4);
            }
            
            ps.setString(2, user.getNombre());
            ps.setString(3, user.getApellidos());
            ps.setString(4, user.getCorreo());
            ps.setString(5, user.getDni());
            ps.setString(6, user.getUsername());
            ps.setString(7, user.getContrasena());
            ps.setInt(8, 1);
            
            ps.executeUpdate();
            
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    }

}
