package modelo;
public class JefeDeAlmacen extends Usuario{
	private AlmacenPrincipal almacen; 

	public JefeDeAlmacen(){
		almacen = new AlmacenPrincipal();
	}

	public JefeDeAlmacen(long id_usuario, String nombre, String apellidos, String correo, String codigo,
                    String username, String contrasena, String descripcion_permisos)
        {
            super(id_usuario, nombre,
                apellidos, correo, codigo, username, contrasena, descripcion_permisos);
            setAlmacen(almacen);
	}

	public AlmacenPrincipal getAlmacen(){
		return almacen;
	}

	public void setAlmacen(AlmacenPrincipal almacen){
		this.almacen = almacen;
	}
}