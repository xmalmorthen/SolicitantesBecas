using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SolicitantesBecas.Models;

namespace SolicitantesBecas
{
    public partial class frmRegistros : Form
    {
        int idUsuario { get; set; }
        string usuario { get; set; }

        public frmRegistros(int idUsuario, string usuario)
        {
            InitializeComponent();

            this.idUsuario = idUsuario;
            this.usuario = usuario;
            estableceTituloVentana();

            bsListaReducida.DataSource = getData.ListaReducida(idUsuario);
        }

        private void estableceTituloVentana()
        {
            this.Text = "Usuario: " + usuario + " - " + SolicitantesBecas.Properties.Settings.Default.tituloVentanaLista;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
