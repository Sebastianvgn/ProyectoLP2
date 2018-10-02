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

namespace Formularios
{
    public partial class frmMovimientosArticulo : Form
    {
        public frmMovimientosArticulo()
        {
            InitializeComponent();
        }

        public frmMovimientosArticulo(string codigo, string categoria, string descripcion, string unidad)
        {
            InitializeComponent();
            txtCodigo.Text = codigo;
            txtCategoria.Text = categoria;
            txtDescripcion.Text = descripcion;
            txtUnidad.Text = unidad;
        }

        private void frmMovimientosArticulo_Load(object sender, EventArgs e)
        {
            dgvIngresos.Rows.Add("1001", "26/09/2018", "20");
            dgvIngresos.Rows.Add("1002", "29/09/2018", "30");
            dgvIngresos.Rows.Add("1003", "15/10/2018", "50");
            dgvSalidas.Rows.Add("2001", "26/09/2018", "20");
            dgvSalidas.Rows.Add("2001", "29/09/2018", "30");
            dgvSalidas.Rows.Add("2001", "15/10/2018", "50");
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
