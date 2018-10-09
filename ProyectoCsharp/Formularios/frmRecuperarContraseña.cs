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
    public partial class frmRecuperarContraseña : Form
    {
        public frmRecuperarContraseña()
        {
            InitializeComponent();
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
            /*-------------------------MENSAJE DE CORREO----------------------*/

            //Creamos un nuevo Objeto de mensaje
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();
            string usuario = "Sebastian Villa-Garcia";
            string codigo = GenerarCodigo();

            //Direccion de correo electronico a la que queremos enviar el mensaje
            mmsg.To.Add(txtCorreo.Text);

            //Nota: La propiedad To es una colección que permite enviar el mensaje a más de un destinatario

            //Asunto
            mmsg.Subject = "Recuperación de la contraseña";
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

            //Direccion de correo electronico que queremos que reciba una copia del mensaje
            mmsg.Bcc.Add("lucetlp22018@gmail.com"); //Opcional

            //Cuerpo del Mensaje
            mmsg.Body = "Hola " + usuario + "\n\nTu contraseña del Sistema de Almacén LUCET SAC " +
                "puede ser restablecida ingresando el siguiente código en el campo 'Código de Verificación' " +
                "del cuadro de diálogo 'Contraseña Olvidada'.\n\n"+
                codigo + "\n\n" +
                "IMPORTANTE: No responda a este mensaje para intentar restablecer su contraseña, eso no funcionará.";
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = false; //Si no queremos que se envíe como HTML

            //Correo electronico desde la que enviamos el mensaje
            mmsg.From = new System.Net.Mail.MailAddress("lucet.lp2@gmail.com");


            /*-------------------------CLIENTE DE CORREO----------------------*/

            //Creamos un objeto de cliente de correo
            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

            //Hay que crear las credenciales del correo emisor
            cliente.Credentials =
                new System.Net.NetworkCredential("lucet.lp2@gmail.com", "lucetlp22018");

            //Lo siguiente es obligatorio si enviamos el mensaje desde Gmail
            
            cliente.Port = 587;
            cliente.EnableSsl = true;
            

            cliente.Host = "smtp.gmail.com"; //Para Gmail "smtp.gmail.com";


            /*-------------------------ENVIO DE CORREO----------------------*/

            try
            {
                //Enviamos el mensaje      
                cliente.Send(mmsg);
                MessageBox.Show("Se envió el nombre de usuario y contraseña al correo:\n" + txtCorreo.Text,
                    "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                //Aquí gestionamos los errores al intentar enviar el correo
                MessageBox.Show("Error de correo: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private string GenerarCodigo()
        {
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int n = alfabeto.Length;
            var guid = Guid.NewGuid();
            string justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
            int seed = int.Parse(justNumbers.Substring(0, 4));

            Random random = new Random(seed);
            string value1 = random.Next(0, 10).ToString();
            string value2 = random.Next(0, 10).ToString();
            int p1 = random.Next(0, n);
            int p2 = random.Next(0, n);
            string codigo = alfabeto[p1] + value1 + alfabeto[p2] + value2;
            return codigo;
        }
    }
}
