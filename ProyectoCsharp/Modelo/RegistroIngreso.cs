using System;
using System.Collections.Generic;

namespace Modelo
{
    public class RegistroIngreso
    {
        private long id_Ingreso;
        private Proveedor proveedor;
        private AlmacenPrincipal almacen;
        private DateTime fecha;
        private DateTime fecha_proceso;
        private TTipoComprobante tipoComprobante;
        private double subtotal;
        private double igv;
        private double monto_igv;
        private double total;
        private TEstado estado;
        private List<DetalleRegistroIngreso> detalles;

        public RegistroIngreso()
        {
            this.Id_Ingreso = 0;
            this.proveedor = null;
            this.almacen = null;
            this.Subtotal = 0;
            this.Igv = 0;
            this.Monto_igv = 0;
            this.Total = 0;
            this.detalles = new List<DetalleRegistroIngreso>();
        }

        public RegistroIngreso(long id_Ingreso, Proveedor proveedor, AlmacenPrincipal almacen, DateTime fecha,
                    DateTime fecha_proceso, TTipoComprobante tipoComprobante, double subtotal,
                    double igv, double monto_igv, double total, TEstado estado)
        {

            this.Id_Ingreso = id_Ingreso;
            this.Proveedor = proveedor;
            this.Almacen = almacen;
            this.Fecha = fecha;
            this.Fecha_proceso = fecha_proceso;
            this.TipoComprobante = tipoComprobante;
            this.Subtotal = subtotal;
            this.Igv = igv;
            this.Monto_igv = monto_igv;
            this.Total = total;
            this.Estado = estado;
            this.detalles = new List<DetalleRegistroIngreso>();
        }

        //Destructor
        ~RegistroIngreso()
        {
            proveedor = null;
            almacen = null;
            detalles = null;
        }

        //Set y get
        public long Id_Ingreso { get => id_Ingreso; set => id_Ingreso = value; }
        public Proveedor Proveedor { get => proveedor; set => proveedor = value; }
        public AlmacenPrincipal Almacen { get => almacen; set => almacen = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public DateTime Fecha_proceso { get => fecha_proceso; set => fecha_proceso = value; }
        public TTipoComprobante TipoComprobante { get => tipoComprobante; set => tipoComprobante = value; }
        public double Subtotal { get => subtotal; set => subtotal = value; }
        public double Igv { get => igv; set => igv = value; }
        public double Monto_igv { get => monto_igv; set => monto_igv = value; }
        public double Total { get => total; set => total = value; }
        public TEstado Estado { get => estado; set => estado = value; }

        public void AgregarDetalle(DetalleRegistroIngreso detalle)
        {
            detalles.Add(detalle);
        }
        public List<DetalleRegistroIngreso> GetDetalle()
        {
            return detalles;
        }

    }

}