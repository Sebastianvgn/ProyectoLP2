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
    public partial class frmLogin : Form
    {
        private UsuarioBL usuarioBL;
        public frmLogin()
        {
            InitializeComponent();
            usuarioBL = new UsuarioBL();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            IngresarSistema();
        }

        private void IngresarSistema()
        {
            bool existeUsuario = usuarioBL.IngresarSistema(txtUsername.Text, txtPassword.Text);
            if (existeUsuario)
            {
                frmPrincipal frm = new frmPrincipal();
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
            }
            else
                MessageBox.Show("ERROR: El usuario o la contraseña no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void linkRecuperarContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecuperarContraseña frm = new frmRecuperarContraseña();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnVerContraseña_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            btnVerContraseña.Visible = false;
            btnOcultarContraseña.Visible = true;
        }

        private void btnOcultarContraseña_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            btnOcultarContraseña.Visible = false;
            btnVerContraseña.Visible = true;
        }

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                IngresarSistema();
            }
        }
    }
}
