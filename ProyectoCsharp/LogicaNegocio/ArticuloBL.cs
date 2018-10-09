using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class ArticuloBL
    {
        private ArticuloDA articuloDA;

        public ArticuloBL()
        {
            articuloDA = new ArticuloDA();
        }

        public DataTable ListarArticulos()
        {
            return articuloDA.ListarArticulos();
        }
    }
}
