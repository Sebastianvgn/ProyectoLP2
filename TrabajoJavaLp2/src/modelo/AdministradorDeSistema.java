package modelo;
public class AdministradorDeSistema extends Usuario{
	public AdministradorDeSistema(){
		
	}
	public AdministradorDeSistema(long id_usuario, String nombre, String apellidos, String correo, String codigo,
                    String username, String contrasena, String descripcion_permisos)
    {
		super(id_usuario, nombre,
                    apellidos, correo, codigo, username, contrasena, descripcion_permisos);
    }
}