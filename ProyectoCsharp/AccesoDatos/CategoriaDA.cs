using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CategoriaDA
    {
        private DBManager objManager;

        public CategoriaDA()
        {
            objManager = new DBManager();
        }

        public DataTable ListarCategorias()
        {
            return objManager.MostrarTablaDatos("SELECT * from CATEGORIA where ID_CATEGORIA != 2");

        }
    }
}
