using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SolicitantesBecas.Libs;

namespace SolicitantesBecas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!Verifica.hayInternet())
            {
                MessageBox.Show("No se detectó conexión a internet...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmUsuario frmusuario = new frmUsuario();
                DialogResult loginresult = frmusuario.ShowDialog();

                if (loginresult == DialogResult.OK)
                {
                    int? idUsuario = frmusuario.idUsuario;
                    string usuario = frmusuario.usuario;

                    frmusuario.Dispose();
                    frmusuario = null;

                    Application.Run(new frmMain(idUsuario, usuario));
                }    
            }
        }
    }
}
