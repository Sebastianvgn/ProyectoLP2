using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmPedidosPorPendientes : Form
    {
        private BindingList<Pedido> pedidos; //Contendra los detalles del pedido seleccionado para pasarselo a la ventana de detalles de pedido

        public frmPedidosPorPendientes()
        {
            InitializeComponent();
            pedidos = new BindingList<Pedido>();
            LeerDatosPedidos();
            dgvPedidos.DataSource = pedidos;
            lblCant.Text = dgvPedidos.Rows.Count.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrarPedido_Click(object sender, EventArgs e)
        {
            //Encontramos la fila seleccionada
            int fil = dgvPedidos.SelectedRows[0].Index;
            frmDetallePedido fdp = new frmDetallePedido(pedidos[fil].Id_pedido);
            fdp.Visible = true;
        }

        private void LeerDatosPedidos()
        {
            String id;
            FileStream fs = new FileStream("Pedidos.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((id = sr.ReadLine()) != null)
            {
                Pedido ped = new Pedido();
                ped.Id_pedido = Int32.Parse(id);
                ped.Estado = (TEstado)Enum.Parse(typeof(TEstado), sr.ReadLine());
                ped.Fecha_entrega = DateTime.Parse(sr.ReadLine());
                ped.Hora_entrega = sr.ReadLine();
                ped.Fecha_produccion = DateTime.Parse(sr.ReadLine());
                ped.Tipo_pedido = (TTipoPedido)Enum.Parse(typeof(TTipoPedido), sr.ReadLine());
                Operario responsable = new Operario();
                responsable.Nombre = sr.ReadLine();
                responsable.Apellidos = sr.ReadLine();
                ped.Responsable = responsable;
                AlmacenVirtual almac = new AlmacenVirtual();
                almac.NomAlmacen = sr.ReadLine();
                ped.Almacen = almac;
                Area area = new Area();
                area.NombreArea = sr.ReadLine();
                ped.Area = area;
                ped.Monto = Double.Parse(sr.ReadLine());
                ped.Monto_igv = Double.Parse(sr.ReadLine());

                if (ped.Estado == TEstado.Pendiente)
                    pedidos.Add(ped);

            }
            sr.Close();
            fs.Close();
        }
    }
}
