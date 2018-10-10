namespace Modelo
{
    public class Gerente : Usuario
    {
        //Constructor
        public Gerente()
        {

        }


        public Gerente(long id_usuario, string nombre, string apellidos, string correo, string dni, string username,
                        string contraseña, string descripcion_permisos) : base(id_usuario, nombre,
                        apellidos, correo, dni, username, contraseña, descripcion_permisos)
        {

        }
    }
}