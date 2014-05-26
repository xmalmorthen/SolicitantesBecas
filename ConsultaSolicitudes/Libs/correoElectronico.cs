using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.ComponentModel;
using System.Net;

namespace ConsultaSolicitudes.Libs
{
    public class correoElectronico
    {
        //Clase que guarda datos como a quien enviar, asunto, etc.
        MailMessage mail = new MailMessage();

        private void client_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //System.Diagnostics.Trace.WriteLine("Mensaje Enviado");

            /* Debemos liberar este recurso de lo contrario los archivos adjuntos quedarin abiertos y no se
             * podrian eliminar o modificar
             */
            mail.Dispose();
        }

        /// <summary>
        /// Envio un nuevo email
        /// </summary>
        /// <param name="to">Lista a quienes enviar el email</param>
        /// <param name="from">De quien es el email</param>
        /// <param name="subject">El asunto del email</param>
        /// <param name="body">El cuerpo del email</param>
        /// <param name="archivos">Lista de archivos que se enviaran como adjunto</param>
        /// <param name="servUser">Cuenta desde la cual se envia el email</param>
        /// <param name="servPass">Contrasenia de la cuenta</param>
        /// <param name="host">Host smtp, ejemplo de gmail: smtp.gmail.com</param>
        /// <param name="Port">Puerto smtp ejemplo de gmail: 587</param>
        /// <param name="isHtmlBody">Indica si el cuerpo es html o texto plano</param>
        /// <param name="enableSsl">Indica si la seguridad ssl esta activada</param>
        /// <returns>Regresa true si todo esta correcto</returns>
        public bool enviar(List<MailAddress> to, MailAddress from, string subject, string body, List<string> archivos, string servUser, string servPass, string host, int Port, bool isHtmlBody, bool enableSsl)
        {
            //Contiene el resultado del envio,si true todo salio bien.
            bool res = true;


            mail = new MailMessage();

            //Carga al mail la lista de mail a quienes enviar el email
            foreach (MailAddress ad in to)
            {
                mail.To.Add(ad);
            }

            //Carga los demas datos del email (from, subject, body)
            mail.From = from;
            mail.Subject = subject;
            mail.Body = body;
            mail.BodyEncoding = Encoding.UTF8; //Indica la codificacion del email
            mail.IsBodyHtml = isHtmlBody;

            //Esta coleccion es de los email a quienes se le enviaran copias ocultas del email
            //mail.Bcc.Add("emailoculto@gmail.com");
            mail.Priority = MailPriority.High; //Prioridad del email

            //Carga la lista de archivos adjuntos
            if (archivos != null)
            {
                foreach (string file in archivos)
                {
                    mail.Attachments.Add(new Attachment(file));
                }
            }

            //Esta clase nos permitira mandar el email, es donde se configuran
            //los permisos, servidor y puerto
            SmtpClient client = new SmtpClient();

            /* Definimos que vamos a usar nuestras propias credenciales
             * y no las que estan configuradas por defecto. Es muy
             * importante que esta linea este antes de la asignacion de
             * credenciales porque de lo contrario borrara las credenciales
             * que hayamos cargado anteriormente
             */
            client.UseDefaultCredentials = false;

            /* Asignamos nuestras credenciales, para gmail el nombre de usuario
             * debe ser la direccion desde donde se envia el email
             */
            client.Credentials = new NetworkCredential(servUser, servPass);

            //El puerto que se va a usar para smtp (gmail usa el 587)
            client.Port = Port;

            /* En el host cargamos el host smtp que use nuestro servidor de correo,
             * en el caso de gmail es smtp.gmail.com
             */
            client.Host = host;

            //Como gmail nos pide una conexion segura, debemos activar ssl
            client.EnableSsl = enableSsl;

            //Este evento se dispara cuando el envio se ha completado
            client.SendCompleted += new SendCompletedEventHandler(this.client_SendCompleted);

            string userState = "mail";
            try
            {
                /* Enviar el email de forma asincronica significa que se enviara
                 * sin bloquear el programa principal, o sea que tu aplicacion
                 * podra seguir funcionando sin tener que esperar a que se termine
                 * de enviar el email.
                 */
                client.SendAsync(mail, userState);

            }
            catch (Exception ex)
            {
                res = false;
                System.Diagnostics.Trace.WriteLine(ex.Message);
            }
            return res;
        }
    }
}
