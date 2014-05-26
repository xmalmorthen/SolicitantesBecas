using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
using SolicitantesBecas.Libs;

namespace SolicitantesBecas.Models
{
    static class err
    {
        private static List<string> _setError = new List<string>();
        public static string setError { set {
                string text = DateTime.Today.ToString() + "  -  " + value;
                _setError.Add(text);

                if (_setError.Count >= SolicitantesBecas.Properties.Settings.Default.numErrAntesdeEnviarCorreo) {
                    if (SolicitantesBecas.Properties.Settings.Default.sendEmailErrors)
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
                MailAddress addrs = new MailAddress(SolicitantesBecas.Properties.Settings.Default.emailTo.ToString().Trim());
                to.Add(addrs);

                string body = "<b>Errores encontrados</b><br/>";

                foreach (string item in _setError)
                {
                    body += item + "</br>";
                }

                mail.enviar(to,
                             new MailAddress(SolicitantesBecas.Properties.Settings.Default.emailFrom),
                             "Errores [Formulario solicitantes becas]",
                             body,
                             null,
                             SolicitantesBecas.Properties.Settings.Default.emailFrom,
                             SolicitantesBecas.Properties.Settings.Default.password,
                             SolicitantesBecas.Properties.Settings.Default.smtpAddress,
                             SolicitantesBecas.Properties.Settings.Default.portNumber,
                             true,
                             false);
            }
            catch (Exception e)
            {
            }
        }
    }
}
