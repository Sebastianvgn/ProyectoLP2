public class AdministradorDeSistema : Usuario{
    //Constructor
    public AdministradorDeSistema()
    {
        //asdfghjk
    }

    public AdministradorDeSistema(long id_usuario, string nombre, string apellidos, string correo, string codigo,
                    string contrase�a, string descripcion_permisos) : base(id_usuario, nombre,
                    apellidos, correo, codigo, contrase�a, descripcion_permisos)
    {

    }
}