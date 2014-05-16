using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace SolicitantesBecas.Models
{
    static class err
    {
        private static List<string> _setError = new List<string>();
        public static string setError { set {
                string text = DateTime.Today.ToString() + "  -  " + value;
                _setError.Add(text);

                if (_setError.Count >= SolicitantesBecas.Properties.Settings.Default.numErrAntesdeEnviarCorreo) {
                    sendEmail();
                    _setError.Clear();
                }
            } 
        }

        public static void sendEmail() {
            if (!SolicitantesBecas.Properties.Settings.Default.sendEmailErrors) return;
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(SolicitantesBecas.Properties.Settings.Default.emailFrom);
                mail.To.Add(SolicitantesBecas.Properties.Settings.Default.emailTo);
                mail.Subject = "Errores [Formulario solicitantes becas]";

                string body = "<b>Errores encontrados</b><br/>";

                foreach (string item in _setError)
                {
                    body += item + "</br>";
                }

                mail.Body = body;
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient(SolicitantesBecas.Properties.Settings.Default.smtpAddress, SolicitantesBecas.Properties.Settings.Default.portNumber);
                smtp.Credentials = new NetworkCredential(SolicitantesBecas.Properties.Settings.Default.emailFrom, SolicitantesBecas.Properties.Settings.Default.password);
                smtp.EnableSsl = SolicitantesBecas.Properties.Settings.Default.enableSSL;
                smtp.Send(mail);
            }
            catch (Exception e)
            {
            }
        }
    }
}
