/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package LogicaNegocio;
import modelo.Usuario;
import modelo.Gerente;
import AccesoDatos.UsuarioDA;
import java.util.ArrayList;
import java.util.Properties;
import javax.mail.Message;
import javax.mail.MessagingException;
import javax.mail.Session;
import javax.mail.Transport;
import javax.mail.internet.InternetAddress;
import javax.mail.internet.MimeMessage;

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
    
    public void crearUsuario(Usuario user){
        usuariosDA.crearUsuario(user);
    }
    
    public void modificarUsuario(Usuario user){
        usuariosDA.modificarUsuario(user);
    }
    
    public void eliminarUsuario(Usuario user){
        usuariosDA.eliminarUsuario(user);
    }
    
    public Gerente EnviarCorreo(String correo) {
        // Esto es lo que va delante de @gmail.com en tu cuenta de correo. Es el remitente también.
        Gerente usuario = usuariosDA.MostrarNombreUsuario(correo);
        if(usuario == null) return null;
        String remitente = "lucet.lp2@gmail.com";  //Para la dirección nomcuenta@gmail.com
        String asunto = "Recuperación de la contraseña";
        String codigo = GenerarCodigo();
        String cuerpo = "Hola " + usuario.getNombre() + " " + usuario.getApellidos() + "\n\nTu contraseña del Sistema de Almacén LUCET SAC " +
                "puede ser restablecida ingresando el siguiente código en el campo 'Código de Verificación' " +
                "del cuadro de diálogo 'Contraseña Olvidada'.\n\n" +
                codigo + "\n\n" +
                "IMPORTANTE: No responda a este mensaje para intentar restablecer su contraseña, eso no funcionará.";

        Properties props = System.getProperties();
        props.put("mail.smtp.host", "smtp.gmail.com");  //El servidor SMTP de Google
        props.put("mail.smtp.user", remitente);
        props.put("mail.smtp.clave", "miClaveDeGMail");    //La clave de la cuenta
        props.put("mail.smtp.auth", "true");    //Usar autenticación mediante usuario y clave
        props.put("mail.smtp.starttls.enable", "true"); //Para conectar de manera segura al servidor SMTP
        props.put("mail.smtp.port", "587"); //El puerto SMTP seguro de Google

        Session session = Session.getDefaultInstance(props);
        MimeMessage message = new MimeMessage(session);

        try {
            message.setFrom(new InternetAddress(remitente));
            message.addRecipient(Message.RecipientType.TO, new InternetAddress(correo));   //Se podrían añadir varios de la misma manera
            message.setSubject(asunto);
            message.setText(cuerpo);
            Transport transport = session.getTransport("smtp");
            transport.connect("smtp.gmail.com", remitente, "lucetlp22018");
            transport.sendMessage(message, message.getAllRecipients());
            transport.close();
        }
        catch (MessagingException me) {
            me.printStackTrace();   //Si se produce un error
        }
        return usuario;
    }
    
    private String GenerarCodigo() {
        String alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        int n = alfabeto.length();
        int num1 = (int)(Math.random()*9);
        int num2 = (int)(Math.random()*9);
        int p1 = (int)(Math.random()*(n-1));
        int p2 = (int)(Math.random()*(n-1));
        String codigo = String.valueOf(num1) + alfabeto.charAt(p1) + String.valueOf(num2) + alfabeto.charAt(p2);
        return codigo;
    }
}
