using System;
using System.Collections.Generic;

namespace Modelo
{
    public class Categoria
    {
        private long id_categoria;
        private string nombre;
        private string descripcion;
        private List<Articulo> articulos;



        //Constructores
        public Categoria()
        {
            id_categoria = 0;
            nombre = descripcion = null;
            articulos = new List<Articulo>();
        }

        public Categoria(long id_categoria, string nombre, string descripcion)
        {
            Id_categoria = id_categoria;
            Nombre = nombre;
            Descripcion = descripcion;
            articulos = new List<Articulo>();
        }

        //Destructor
        ~Categoria()
        {
            nombre = descripcion = null;
            articulos = null;
        }

        //Metodos set y get
        public long Id_categoria { get => id_categoria; set => id_categoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public void AgregarArticulo(Articulo articulos)
        {
            this.articulos.Add(articulos);
        }

        public List<Articulo> GetArticulos()
        {
            return this.articulos;
        }

        public override string ToString()
        {
            return String.Format("{0}", Nombre);
        }

    }
}