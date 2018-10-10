using LogicaNegocio;
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
        private UsuarioBL usuarioBL;
        public frmNuevaContraseña()
        {
            InitializeComponent();
            usuarioBL = new UsuarioBL();
        }

        public frmNuevaContraseña(int idUsuario, string codigo)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.codigo = codigo;
            usuarioBL = new UsuarioBL();
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
            VerificarCodigo();
        }

        private void VerificarCodigo()
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

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            CambiarContraseña();
        }

        private void CambiarContraseña()
        {
            if (txtNuevaContraseña.Text.Length < 8)
            {
                errorNuevaContraseña.SetError(txtNuevaContraseña, "El tamaño mínimo de la contraseña es 8 caracteres");
                txtNuevaContraseña.Focus();
                return;
            }
            else if (txtNuevaContraseña.Text != txtConfirmarContraseña.Text)
            {
                errorNuevaContraseña.SetError(txtNuevaContraseña, "No coinciden las contraseñas");
                errorConfirmarContraseña.SetError(txtConfirmarContraseña, "No coinciden las contraseñas");
                return;
            }
            else
            {
                bool registrado = usuarioBL.RegistrarNuevaContraseña(idUsuario, txtNuevaContraseña.Text);
                if (registrado)
                {
                    errorNuevaContraseña.Clear();
                    errorConfirmarContraseña.Clear();
                    MessageBox.Show("La contraseña ha sido correctamente actualizada", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
                else
                    MessageBox.Show("ERROR: Ocurrió un problema con la base de datos. Vuelva a intentarlo nuevamente dentro de un momento",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNuevaContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Password_Controlador.Validar_Password(e.KeyChar);
        }

        private void txtConfirmarContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar == (int)Keys.Enter)
            {
                CambiarContraseña();
                //return;
            }
            e.Handled = Password_Controlador.Validar_Password(e.KeyChar);
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar == (int)Keys.Enter)
            {
                VerificarCodigo();
            }
        }
    }
}
