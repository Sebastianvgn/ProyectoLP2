using System;
using System.Collections.Generic;

namespace Modelo
{
    public class Pedido
    {
        private long id_pedido;
        private DateTime fecha_produccion;
        private DateTime fecha_entrega;
        private string hora_entrega;
        private Usuario responsable;
        private TEstado estado;
        private TTipoPedido tipo_pedido;
        private AlmacenVirtual almacen;
        private Area area;
        private double monto;
        private double monto_igv;
        private double total;
        private List<DetallePedido> detalles;


        //Constructores
        public Pedido()
        {
            this.Id_pedido = 0;
            responsable = null;
            area = null;
            monto = monto_igv = total = 0;
            this.detalles = new List<DetallePedido>();
        }


        public Pedido(long id_pedido, DateTime fecha_produccion, DateTime fecha_entrega, string hora_entrega,
                        Usuario responsable, TEstado estado, TTipoPedido tipo_pedido, AlmacenVirtual almacen,
                        Area area, double monto, double monto_igv, double total)
        {
            this.Id_pedido = id_pedido;
            this.Fecha_produccion = fecha_produccion;
            this.Fecha_entrega = fecha_entrega;
            this.Hora_entrega = hora_entrega;
            this.Responsable = responsable;
            this.Estado = estado;
            this.Tipo_pedido = tipo_pedido;
            this.Almacen = almacen;
            this.Area = area;
            this.Monto = monto;
            this.Monto_igv = monto_igv;
            this.Total = total;
            this.detalles = new List<DetallePedido>();
        }

        //Destructor
        ~Pedido()
        {
            detalles = null;
            area = null;
            responsable = null;
        }

        //Metodos set y get
        public long Id_pedido { get => id_pedido; set => id_pedido = value; }
        public DateTime Fecha_produccion { get => fecha_produccion; set => fecha_produccion = value; }
        public DateTime Fecha_entrega { get => fecha_entrega; set => fecha_entrega = value; }
        public string Hora_entrega { get => hora_entrega; set => hora_entrega = value; }
        public Usuario Responsable { get => responsable; set => responsable = value; }
        public TEstado Estado { get => estado; set => estado = value; }
        public TTipoPedido Tipo_pedido { get => tipo_pedido; set => tipo_pedido = value; }
        public AlmacenVirtual Almacen { get => almacen; set => almacen = value; }
        public Area Area { get => area; set => area = value; }
        public double Monto { get => monto; set => monto = value; }
        public double Monto_igv { get => monto_igv; set => monto_igv = value; }
        public double Total { get => total; set => total = value; }

        public void AgregarDetalle(DetallePedido detalle)
        {
            detalles.Add(detalle);
        }

        public List<DetallePedido> GetDetalles()
        {
            return this.detalles;
        }
    }
}