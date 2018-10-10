using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class CategoriaBL
    {
        private CategoriaDA categoriaDA;

        public CategoriaBL()
        {
            categoriaDA = new CategoriaDA();
        }

        public DataTable ListarInsumos()
        {
            return categoriaDA.ListarCategorias("SELECT NOMBRE FROM CATEGORIA WHERE ID_FAMILIA != 2");
        }

        public DataTable ListarMercaderias()
        {
            return categoriaDA.ListarCategorias("SELECT NOMBRE FROM CATEGORIA WHERE ID_FAMILIA = 2");
        }
    }
}
