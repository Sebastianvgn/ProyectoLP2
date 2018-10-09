using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class UsuarioDA
    {
        private DBManager objManager;
        MySqlParameter[] parametrosEntrada = null;

        public UsuarioDA()
        {
            parametrosEntrada = new MySqlParameter[6];
            objManager = new DBManager();
        }

        public DataTable MostrarNombreUsuario(string correo)
        {
            string datos = "select ID_USUARIO, CONCAT(NOMBRES, ' ', APELLIDOS) AS NOMBRE from USUARIO where REGISTRO_ACTIVO = 1 AND CORREO = '" + correo + "'";
            DataTable tabla = objManager.MostrarTablaDatos(datos);
            return tabla;
        }
    }
}
