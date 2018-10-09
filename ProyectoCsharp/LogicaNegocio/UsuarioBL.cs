using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

namespace LogicaNegocio
{
    public class UsuarioBL
    {
        private UsuarioDA usuarioDA;

        public UsuarioBL()
        {
            usuarioDA = new UsuarioDA();
        }

        public void RecuperarContraseña(string correo, out string codigo, out int idUsuario)
        {
            DataTable tabla = usuarioDA.MostrarNombreUsuario(correo);
            codigo = "";
            idUsuario = 0;
            if (tabla.Rows.Count <= 0) return;
            string usuario = tabla.Rows[0]["NOMBRE"].ToString();
            idUsuario = Convert.ToInt32(tabla.Rows[0]["ID_USUARIO"].ToString());
            codigo = GenerarCodigo();

            /*-------------------------MENSAJE DE CORREO----------------------*/

            //Creamos un nuevo Objeto de mensaje
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

            //Direccion de correo electronico a la que queremos enviar el mensaje
            mmsg.To.Add(correo);

            //Nota: La propiedad To es una colección que permite enviar el mensaje a más de un destinatario

            //Asunto
            mmsg.Subject = "Recuperación de la contraseña";
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

            //Direccion de correo electronico que queremos que reciba una copia del mensaje
            //mmsg.Bcc.Add("lucet.lp2@gmail.com"); //Opcional

            //Cuerpo del Mensaje
            mmsg.Body = "Hola " + usuario + "\n\nTu contraseña del Sistema de Almacén LUCET SAC " +
                "puede ser restablecida ingresando el siguiente código en el campo 'Código de Verificación' " +
                "del cuadro de diálogo 'Contraseña Olvidada'.\n\n" +
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
                return;
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                //Aquí gestionamos los errores al intentar enviar el correo
                return;
                
            }
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
