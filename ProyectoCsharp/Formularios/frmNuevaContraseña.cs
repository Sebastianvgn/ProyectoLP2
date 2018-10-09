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
    public partial class frmNuevaContraseña : Form
    {
        private int idUsuario;
        private string codigo;
        public frmNuevaContraseña()
        {
            InitializeComponent();
        }

        public frmNuevaContraseña(int idUsuario, string codigo)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.codigo = codigo;
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

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (codigo == txtCodigo.Text)
            {
                btnVerificar.Enabled = false;
                txtCodigo.Enabled = false;
                txtConfirmarContraseña.Enabled = true;
                txtNuevaContraseña.Enabled = true;
                MessageBox.Show("Verificado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
                MessageBox.Show("ERROR: Código incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
