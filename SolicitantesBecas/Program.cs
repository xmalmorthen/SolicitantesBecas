using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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

            frmUsuario frmusuario = new frmUsuario();
            DialogResult loginresult = frmusuario.ShowDialog();

            if (loginresult == DialogResult.OK) {
                int? idUsuario = frmusuario.idUsuario;

                frmusuario.Dispose();
                frmusuario = null;

                Application.Run(new frmMain() { idUsuario = idUsuario });
            }
        }
    }
}
