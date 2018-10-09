/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package LogicaNegocio;
import modelo.Usuario;
import AccesoDatos.UsuarioDA;
import java.util.ArrayList;

/**
 *
 * @author alulab14
 */
public class UsuarioBL {
    private UsuarioDA usuariosDA;
    
    public UsuarioBL(){
        usuariosDA = new UsuarioDA();
    }
    
    public ArrayList<Usuario> listarUsuarios(){
        return usuariosDA.listarUsuarios();
    }
    
    public String buscarUsuario(String user, String pass){
        ArrayList<Usuario> users = usuariosDA.listarUsuarios();
        int i;
        boolean existe = false;
        int cant = users.size();
        String tipo = "";
        for(i = 0; i<cant; i++){
            String usuario = users.get(i).getUsername();
            String contrasena = users.get(i).getContrasena();
            if(user.equals(usuario) && pass.equals(contrasena)){
                tipo = users.get(i).getDescripcion_permisos();
                existe = true;
            }
        }
        if(!existe){
            tipo = "NONE";
        }
        return tipo;
    }
}
