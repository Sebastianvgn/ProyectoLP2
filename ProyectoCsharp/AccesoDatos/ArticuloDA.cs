using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ArticuloDA
    {
        private DBManager objManager;

        public ArticuloDA()
        {
            objManager = new DBManager();
        }

        public DataTable ListarArticulos()
        {
            return objManager.MostrarTablaDatos("select A.CODIGO, C.DESCRIPCION AS CATEGORIA, A.NOMBRE, A.UNIDAD, A.PRECIO_PROMEDIO, A.STOCK_MINIMO, A.FECHA_REGISTRO " +
                                                "from ARTICULO AS A, CATEGORIA AS C " +
                                                "where A.REGISTRO_ACTIVO = 1 and A.ID_CATEGORIA = C.ID_CATEGORIA");
        }
    }
}
