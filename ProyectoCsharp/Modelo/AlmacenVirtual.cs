using System;
using System.Collections.Generic;

namespace Modelo
{
    public class AlmacenVirtual : Almacen
    {
        private List<Area> areas;
        //Constructores
        public AlmacenVirtual()
        {
            areas = new List<Area>();
        }

        public AlmacenVirtual(long id, string nom, string descripcion) : base(id, nom, descripcion)
        {
            areas = new List<Area>();
        }

        //DEstructor
        ~AlmacenVirtual()
        {
            areas = null;
        }

        public void AgregarArea(Area areas)
        {
            this.areas.Add(areas);
        }

        public List<Area> GetArea()
        {
            return this.areas;
        }
    }

}
