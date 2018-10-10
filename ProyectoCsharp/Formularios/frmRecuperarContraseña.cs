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
using LogicaNegocio;

namespace Formularios
{
    public partial class frmRecuperarContraseña : Form
    {
        private UsuarioBL usuarioBL;
        public frmRecuperarContraseña()
        {
            InitializeComponent();
            usuarioBL = new UsuarioBL();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EnviarCodigo();
        }

        private void EnviarCodigo()
        {
            int idUsuario;
            string codigo;
            usuarioBL.EnviarCodigo(txtCorreo.Text, out codigo, out idUsuario);
            if (idUsuario != 0)
            {
                MessageBox.Show("Se envió el nombre de usuario y contraseña al correo:\n" + txtCorreo.Text,
                    "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                frmNuevaContraseña frm = new frmNuevaContraseña(idUsuario, codigo);
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Error de correo: No existe este correo en la base de datos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
                EnviarCodigo();
        }
    }
}
