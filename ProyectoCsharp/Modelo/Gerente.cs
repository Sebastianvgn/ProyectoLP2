namespace Modelo
{
    public class Gerente : Usuario
    {
        //Constructor
        public Gerente()
        {

        }


        public Gerente(long id_usuario, string nombre, string apellidos, string correo, string codigo,
                        string contraseña, string descripcion_permisos) : base(id_usuario, nombre,
                        apellidos, correo, codigo, contraseña, descripcion_permisos)
        {

        }
    }
}