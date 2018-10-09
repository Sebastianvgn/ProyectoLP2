using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmDetallePedido : Form
    {
        private BindingList<DetallePedido> detalles;
        private int x, y;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        //Constructor donde le envia una lista de detalles de pedidos
        public frmDetallePedido(long id_pedido)
        {
            InitializeComponent();
            LeerDetallesPedidos(id_pedido);
            dgvDetallesPedidos.DataSource = detalles;
        }


        public frmDetallePedido()
        {
            InitializeComponent();
        }
       
        //Para que el usuario pueda manipular la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void LeerDetallesPedidos(long id_pedido)
        {
            detalles = new BindingList<DetallePedido>();
            String id_Ped, unidad;
            FileStream fs = new FileStream("DetallePedido.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((id_Ped = sr.ReadLine()) != null)
            {
                DetallePedido detalle = new DetallePedido();
                int id_ped = Int32.Parse(id_Ped);
                Articulo art = new Articulo();
                art.Codigo = sr.ReadLine();
                art.Descripcion = sr.ReadLine();
                unidad = sr.ReadLine();
                art.Unidad = (TUnidad)Enum.Parse(typeof(TUnidad), unidad);
                art.Cantidad = Double.Parse(sr.ReadLine());
                art.Precio = Double.Parse(sr.ReadLine());
                Categoria cat = new Categoria();
                cat.Descripcion = sr.ReadLine();
                art.Categoria = cat;
                detalle.Articulo = art;
                detalle.Cantidad = art.Cantidad;
                //Agregamos a la lista
                if (id_ped == id_pedido)
                    detalles.Add(detalle);

            }
            sr.Close();
            fs.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel_superior_MouseDown(object sender, MouseEventArgs e)
        {                 
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);                    
        }

        private void txtTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}
