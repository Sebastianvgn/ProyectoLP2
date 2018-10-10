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

        public DataTable ListarCategorias()
        {
            return categoriaDA.ListarCategorias();
        }
    }
}
