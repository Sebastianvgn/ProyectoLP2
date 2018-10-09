package modelo;
public class AdministradorDeSistema extends Usuario{
	public AdministradorDeSistema(){
		
	}
	public AdministradorDeSistema(long id_usuario, String nombre, String apellidos, String correo, String codigo,
                    String contrasena, String descripcion_permisos)
    {
		super(id_usuario, nombre,
                    apellidos, correo, codigo, contrasena, descripcion_permisos);
    }
}