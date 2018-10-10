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
            //parametrosEntrada = new MySqlParameter[6];
            objManager = new DBManager();
        }

        public DataTable MostrarNombreUsuario(string correo)
        {
            string datos = "select ID_USUARIO, CONCAT(NOMBRES, ' ', APELLIDOS) AS NOMBRE from USUARIO where REGISTRO_ACTIVO = 1 AND CORREO = '" + correo + "'";
            DataTable tabla = objManager.MostrarTablaDatos(datos);
            return tabla;
        }

        public bool RegistrarNuevaContraseña(int idUsuario, string password)
        {
            parametrosEntrada = new MySqlParameter[2];
            parametrosEntrada[0] = new MySqlParameter("@idUsuario", MySqlDbType.Int32);
            parametrosEntrada[1] = new MySqlParameter("@pass", MySqlDbType.VarChar, 50);
            parametrosEntrada[0].Value = idUsuario;
            parametrosEntrada[1].Value = password;
            return objManager.EjecutarProcedure(parametrosEntrada, "registrar_nueva_contraseña");
        }

        public bool IngresarSistema(string usuario, string password)
        {
            string comando = "select ID_USUARIO from USUARIO where USERNAME = '" + usuario + "' AND PASSWORD = '" + password + "'";
            DataTable tabla = objManager.MostrarTablaDatos(comando);
            if (tabla.Rows.Count != 0) return true;
            return false;
        }
    }
}
