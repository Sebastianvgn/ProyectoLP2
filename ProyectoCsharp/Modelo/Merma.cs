using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Merma : Articulo
{
    private TTipoMerma motivo_de_baja;

    public Merma()
    {
    }

    public Merma(long id_articulo, string codigo, string descripcion, double cantidad, TUnidad unidad, DateTime fecha_caducidad, Categoria categoria, TTipoMerma motivo_de_baja, double precio) 
         : base(id_articulo, codigo, descripcion, cantidad, unidad, fecha_caducidad, categoria, precio)
    {
        Motivo_de_baja = motivo_de_baja;
    }

    public TTipoMerma Motivo_de_baja { get => motivo_de_baja; set => motivo_de_baja = value; }
}

