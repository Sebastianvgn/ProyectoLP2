using System;
using System.Collections.Generic;

namespace Modelo
{
    public abstract class Almacen
    {
        private long idAlmacen;
        private string nomAlmacen;
        private string descripcion;
        private List<Operario> operarios;
        private List<Articulo> articulos;



        //Constructores
        public Almacen()
        {
            idAlmacen = 0;
            articulos = new List<Articulo>();
            operarios = new List<Operario>();
        }

        public Almacen(long id, string nomAlmacen, string descripcion)
        {
            IdAlmacen = id;
            NomAlmacen = nomAlmacen;
            articulos = new List<Articulo>();
            operarios = new List<Operario>();
            Descripcion = descripcion;
        }

        //Destructor
        ~Almacen()
        {
            operarios = null;
        }

        //Metodos set y get
        public long IdAlmacen { get => idAlmacen; set => idAlmacen = value; }
        public string NomAlmacen { get => nomAlmacen; set => nomAlmacen = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public void AgregarOperario(Operario oper)
        {
            operarios.Add(oper);
        }

        public List<Operario> GetOperarios()
        {
            return this.operarios;
        }

        public void AgregarArticulo(Articulo art)
        {
            articulos.Add(art);
        }

        public List<Articulo> GetArticulos()
        {
            return this.articulos;
        }

        public override string ToString()
        {
            return String.Format("{0}", NomAlmacen);
        }
    }
}
