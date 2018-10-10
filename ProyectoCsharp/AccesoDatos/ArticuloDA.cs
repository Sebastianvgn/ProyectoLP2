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
            /*return objManager.MostrarTablaDatos("select A.CODIGO, C.DESCRIPCION AS CATEGORIA, A.NOMBRE, A.UNIDAD, A.PRECIO_PROMEDIO, SUM(D.STOCK) as CANTIDAD, A.FECHA_REGISTRO " +
                                                "from ARTICULO AS A, CATEGORIA AS C, DETALLE_INGRESO as D " +
                                                "where A.REGISTRO_ACTIVO = 1 and A.ID_CATEGORIA = C.ID_CATEGORIA and D.ID_ARTICULO = A.ID_ARTICULO");*/
            return objManager.MostrarTablaDatos("select A.CODIGO, C.DESCRIPCION AS CATEGORIA, A.NOMBRE, A.UNIDAD, A.PRECIO_PROMEDIO, A.FECHA_REGISTRO , D.STOCK as CANTIDAD " +
                                                "from CATEGORIA as C, ARTICULO as A " +
                                                    "LEFT JOIN " +
                                                    "(select* " +
                                                    "from DETALLE_INGRESO D " +
                                                    " group by ID_ARTICULO) D " +
                                                    "using (ID_ARTICULO) " +
                                                "where A.REGISTRO_ACTIVO = 1 and A.ID_CATEGORIA = C.ID_CATEGORIA");
            
        }
    }
}
