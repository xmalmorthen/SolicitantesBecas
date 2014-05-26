using System;
using System.Collections.Generic;
using System.Linq;
using ConsultaSolicitudes.Libs;
using System.Net.Mail;

namespace ConsultaSolicitudes.Models
{
    static class err
    {
        private static List<string> _setError = new List<string>();
        public static string setError { set {
                string text = DateTime.Today.ToString() + "  -  " + value;
                _setError.Add(text);

                if (_setError.Count >= ConsultaSolicitudes.Properties.Settings.Default.numErrAntesdeEnviarCorreo) {
                    if (ConsultaSolicitudes.Properties.Settings.Default.sendEmailErrors)
                    {                        
                        sendEmail();
                        _setError.Clear();
                    }
                }
            } 
        }

        public static void sendEmail() {            
            try
            {
                correoElectronico mail = new correoElectronico();

                List<MailAddress> to = new List<MailAddress>();
                MailAddress addrs = new MailAddress(ConsultaSolicitudes.Properties.Settings.Default.emailTo.ToString().Trim());
                to.Add (addrs);

                string body = "<b>Errores encontrados</b><br/>";

                foreach (string item in _setError)
                {
                    body += item + "</br>";
                }

                mail.enviar( to,
                             new MailAddress(ConsultaSolicitudes.Properties.Settings.Default.emailFrom),
                             "Errores [Formulario solicitantes becas]",
                             body,
                             null,
                             ConsultaSolicitudes.Properties.Settings.Default.emailFrom,
                             ConsultaSolicitudes.Properties.Settings.Default.password,
                             ConsultaSolicitudes.Properties.Settings.Default.smtpAddress,
                             ConsultaSolicitudes.Properties.Settings.Default.portNumber,
                             true,
                             false);
            }
            catch (Exception e)
            {
            }
        }
    }
}
