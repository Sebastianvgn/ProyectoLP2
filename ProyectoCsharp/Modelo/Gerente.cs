namespace Modelo
{
    public class Gerente : Usuario
    {
        //Constructor
        public Gerente()
        {

        }


        public Gerente(long id_usuario, string nombre, string apellidos, string correo, string dni, string username,
                        string contraseņa, string descripcion_permisos) : base(id_usuario, nombre,
                        apellidos, correo, dni, username, contraseņa, descripcion_permisos)
        {

        }
    }
}