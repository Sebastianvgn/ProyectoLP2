package modelo;
public abstract class Usuario{
	private long id_usuario;
	private String nombre;
	private String apellidos;
	private String correo;
	private String codigo;
	private String contrasena;
	private String descripcion_permisos;

	public Usuario(){
		id_usuario = 0;
		nombre = apellidos = correo = codigo = contrasena = descripcion_permisos = null;
	}

	public Usuario(long id_usuario, String nombre, String apellidos, String correo, String codigo, String contrasena, String descripcion_permisos) {
            this.id_usuario = id_usuario;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.correo = correo;
            this.codigo = codigo;
            this.contrasena = contrasena;
            this.descripcion_permisos = descripcion_permisos;
        }

	public void setId_usuario(long id_usuario){
		this.id_usuario = id_usuario;
	} 

	public long getId_usuario(){
		return id_usuario;
	}

	public void setNombre(String nombre){
		this.nombre = nombre;
	}

	public String getNombre(){
		return nombre;
	}

	public void setApellidos(String apellidos){
		this.apellidos = apellidos;
	}

	public String getApellidos(){
		return apellidos;
	}

	public void setCorreo(String correo){
		this.correo = correo;
	}

	public String getCorreo(){
		return correo;
	}

	public void setCodigo(String codigo){
		this.codigo = codigo;
	}

	public String getCodigo(){
		return codigo;
	}

	public void setContrasena(String contrasena){
		this.contrasena = contrasena;
	}

	public String getContrasena(){
		return contrasena;
	}

	public void setDescripcion_permisos(String descripcion_permisos){
		this.descripcion_permisos = descripcion_permisos;
	}

	public String getDescripcion_permisos(){
		return descripcion_permisos;
	}
}