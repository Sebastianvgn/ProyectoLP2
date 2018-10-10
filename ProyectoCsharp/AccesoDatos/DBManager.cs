using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class DBManager
    {

        private static string cadena = "server=quilla.lab.inf.pucp.edu.pe; user=inf282g2; password=0Fjw8H; database=a20145779; SslMode=None";
        private static MySqlConnection conexion = null; 

        private MySqlCommand cmd = null;
        private MySqlDataAdapter adaptador = null;
        private DataTable tabla = null;

        public bool EjecutarProcedure(MySqlParameter[] parametrosEntrada, string nombProcedimiento)
        {
            try
            {
                conexion = new MySqlConnection(cadena);
                conexion.Open();
                cmd = new MySqlCommand(nombProcedimiento, conexion);
                
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parametrosEntrada);
                cmd.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conexion.Dispose();
                cmd.Dispose();
            }
        }

        public DataTable MostrarTablaDatos(string comando) //SELECT * FROM TABLA
        {
            try
            {
                conexion = new MySqlConnection(cadena);
                tabla = new DataTable();
                conexion.Open();
                adaptador = new MySqlDataAdapter(comando, conexion);
                adaptador.Fill(tabla);
                conexion.Close();
                return tabla;
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                return null;
            }
            finally
            {
                conexion.Dispose();
                //adaptador.Dispose();
            }
        }

        /*public MySqlDataReader MostrarInformacion(string datos)
        {
            try
            {
                conexion = new MySqlConnection(cadena);
                cmd = new MySqlCommand(datos, conexion);
                conexion.Open();
                leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conexion.Dispose();
                cmd.Dispose();
            }
        }*/
    }
}
