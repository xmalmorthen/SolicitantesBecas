using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ConsultaSolicitudes.Libs;

namespace ConsultaSolicitudes
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
                Application.Run(new frmConsultaGeneral());
            }
        }
    }
}
