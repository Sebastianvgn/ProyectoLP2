using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

enum Ventana { Insumos, GenerarConsolidado, IngresarPedido, RegistroIngresoComprobante, RegistroTransferencias, Mermas, PedidosPorPendientes, Ayuda, ArticulosCaducar}

namespace Formularios
{
    public partial class frmPrincipal : Form
    {
        private int ventanActual;
        private int x, y;
        public frmPrincipal()
        {
            InitializeComponent();
            ventanActual = -1;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnOcultarMenu_Click(object sender, EventArgs e)
        {
            OcultarPanelLateral();
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            MaximizarVentana();
        }

        private void MaximizarVentana()
        {
            x = this.Location.X;
            y = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMinimizar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1346, 839);
            this.Location = new Point(x, y);
            btnMinimizar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void OcultarPanelLateral()
        {
            if (panelLateral.Width == 260)
            {
                panelLateral.Width = 50;
                //btnOcultarMenu.Location = new Point(6, 6);
            }
            else
            {
                panelLateral.Width = 260;
                //btnOcultarMenu.Location = new Point(219, 6);
            }
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmArticulos(), (int)Ventana.Insumos);
            btnMermas.BackColor = Color.FromArgb(64,64,64);
            btnInsumos.BackColor = Color.FromArgb(14, 39, 164);
            btnIngresarPedido.BackColor = Color.FromArgb(64, 64, 64);
            btnGenerarConsolidado.BackColor = Color.FromArgb(64, 64, 64);
            btnRegistroIngresoComprobantes.BackColor = Color.FromArgb(64, 64, 64);
            btnRegistroTransferencias.BackColor = Color.FromArgb(64, 64, 64);
            btnPedidosPendientes.BackColor = Color.FromArgb(64, 64, 64);
            btnArticulosCaducar.BackColor = Color.FromArgb(64, 64, 64);
            btnAyuda.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MaximizarVentana();
        }

        private void btnGenerarConsolidado_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmGenerarConsolidado(), (int)Ventana.GenerarConsolidado);
            btnMermas.BackColor = Color.FromArgb(64, 64, 64);
            btnInsumos.BackColor = Color.FromArgb(64,64,64);
            btnIngresarPedido.BackColor = Color.FromArgb(64, 64, 64);
            btnGenerarConsolidado.BackColor = Color.FromArgb(14, 39, 164);
            btnRegistroIngresoComprobantes.BackColor = Color.FromArgb(64, 64, 64);
            btnRegistroTransferencias.BackColor = Color.FromArgb(64, 64, 64);
            btnPedidosPendientes.BackColor = Color.FromArgb(64, 64, 64);
            btnArticulosCaducar.BackColor = Color.FromArgb(64, 64, 64);
            btnAyuda.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void btnIngresarPedido_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmIngresarPedido(), (int)Ventana.IngresarPedido);
            btnMermas.BackColor = Color.FromArgb(64, 64, 64);
            btnInsumos.BackColor = Color.FromArgb(64, 64, 64);
            btnIngresarPedido.BackColor = Color.FromArgb(14, 39, 164);
            btnGenerarConsolidado.BackColor = Color.FromArgb(64,64,64);
            btnRegistroIngresoComprobantes.BackColor = Color.FromArgb(64, 64, 64);
            btnRegistroTransferencias.BackColor = Color.FromArgb(64, 64, 64);
            btnPedidosPendientes.BackColor = Color.FromArgb(64, 64, 64);
            btnArticulosCaducar.BackColor = Color.FromArgb(64, 64, 64);
            btnAyuda.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void btnRegistroIngresoComprobantes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmRegistroIngresoComprobantes(), (int)Ventana.RegistroIngresoComprobante);
            btnMermas.BackColor = Color.FromArgb(64, 64, 64);
            btnInsumos.BackColor = Color.FromArgb(64, 64, 64);
            btnIngresarPedido.BackColor = Color.FromArgb(64,64,64);
            btnGenerarConsolidado.BackColor = Color.FromArgb(64, 64, 64);
            btnRegistroIngresoComprobantes.BackColor = Color.FromArgb(14, 39, 164);
            btnRegistroTransferencias.BackColor = Color.FromArgb(64, 64, 64);
            btnPedidosPendientes.BackColor = Color.FromArgb(64, 64, 64);
            btnArticulosCaducar.BackColor = Color.FromArgb(64, 64, 64);
            btnAyuda.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void btnRegistroTransferencias_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmRegistroTransferencias(), (int)Ventana.RegistroTransferencias);
            btnMermas.BackColor = Color.FromArgb(64, 64, 64);
            btnInsumos.BackColor = Color.FromArgb(64, 64, 64);
            btnIngresarPedido.BackColor = Color.FromArgb(64, 64, 64);
            btnGenerarConsolidado.BackColor = Color.FromArgb(64, 64, 64);
            btnRegistroIngresoComprobantes.BackColor = Color.FromArgb(64,64,64);
            btnRegistroTransferencias.BackColor = Color.FromArgb(14, 39, 164);
            btnPedidosPendientes.BackColor = Color.FromArgb(64, 64, 64);
            btnArticulosCaducar.BackColor = Color.FromArgb(64, 64, 64);
            btnAyuda.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMermas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmMermas(), (int)Ventana.Mermas);
            btnMermas.BackColor = Color.FromArgb(14, 39, 164);
            btnInsumos.BackColor = Color.FromArgb(64, 64, 64);
            btnIngresarPedido.BackColor = Color.FromArgb(64, 64, 64);
            btnGenerarConsolidado.BackColor = Color.FromArgb(64, 64, 64);
            btnRegistroIngresoComprobantes.BackColor = Color.FromArgb(64, 64, 64);
            btnRegistroTransferencias.BackColor = Color.FromArgb(64, 64, 64);
            btnPedidosPendientes.BackColor = Color.FromArgb(64, 64, 64);
            btnArticulosCaducar.BackColor = Color.FromArgb(64, 64, 64);
            btnAyuda.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void btnPedidosPendientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmPedidosPorPendientes(), (int)Ventana.PedidosPorPendientes);
            btnMermas.BackColor = Color.FromArgb(64,64,64);
            btnInsumos.BackColor = Color.FromArgb(64, 64, 64);
            btnIngresarPedido.BackColor = Color.FromArgb(64, 64, 64);
            btnGenerarConsolidado.BackColor = Color.FromArgb(64, 64, 64);
            btnRegistroIngresoComprobantes.BackColor = Color.FromArgb(64, 64, 64);
            btnRegistroTransferencias.BackColor = Color.FromArgb(64, 64, 64);
            btnPedidosPendientes.BackColor = Color.FromArgb(14, 39, 164);
            btnArticulosCaducar.BackColor = Color.FromArgb(64, 64, 64);
            btnAyuda.BackColor = Color.FromArgb(64, 64, 64);
        }

        // Método para abrir un formulario en el panel principal (menú principal)
        private void AbrirFormEnPanel(object FormHijo, int numVentana)
        {
            //if (ventanActual == numVentana) return;
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            ventanActual = numVentana;
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(fh);
            this.panelPrincipal.Tag = fh;
            fh.Show();
        }

        private void btnArticulosCaducar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmArticulosCaducar(), (int)Ventana.ArticulosCaducar);
            btnMermas.BackColor = Color.FromArgb(64, 64, 64);
            btnInsumos.BackColor = Color.FromArgb(64, 64, 64);
            btnIngresarPedido.BackColor = Color.FromArgb(64, 64, 64);
            btnGenerarConsolidado.BackColor = Color.FromArgb(64, 64, 64);
            btnRegistroIngresoComprobantes.BackColor = Color.FromArgb(64, 64, 64);
            btnRegistroTransferencias.BackColor = Color.FromArgb(64, 64, 64);
            btnPedidosPendientes.BackColor = Color.FromArgb(64,64,64);
            btnArticulosCaducar.BackColor = Color.FromArgb(14, 39, 164);
            btnAyuda.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            btnMermas.BackColor = Color.FromArgb(64, 64, 64);
            btnInsumos.BackColor = Color.FromArgb(64, 64, 64);
            btnIngresarPedido.BackColor = Color.FromArgb(64, 64, 64);
            btnGenerarConsolidado.BackColor = Color.FromArgb(64, 64, 64);
            btnRegistroIngresoComprobantes.BackColor = Color.FromArgb(64, 64, 64);
            btnRegistroTransferencias.BackColor = Color.FromArgb(64, 64, 64);
            btnPedidosPendientes.BackColor = Color.FromArgb(64, 64, 64);
            btnArticulosCaducar.BackColor = Color.FromArgb(64,64,64);
            btnAyuda.BackColor = Color.FromArgb(14, 39, 164);
        }

        private void CambiarColorSeleccion()
        {
            int n = 9;
            
            foreach(Ventana ventana in Enum.GetValues(typeof(Ventana)))
            {
                if(ventanActual == (int)ventana)
                {

                }
            }
        }
    }
}
