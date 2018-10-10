using System;

namespace Modelo
{
    public class JefeDeAlmacen : Usuario
    {
        private AlmacenPrincipal almacen;



        public JefeDeAlmacen(long id_usuario, string nombre, string apellidos, string correo, string dni, string username, string contraseña, string descripcion_permisos,
                             AlmacenPrincipal almac) : base(id_usuario, nombre, apellidos, correo, dni, username, contraseña, descripcion_permisos)
        {
            Almacen = almac;
        }

        public AlmacenPrincipal Almacen { get => almacen; set => almacen = value; }
    }

}