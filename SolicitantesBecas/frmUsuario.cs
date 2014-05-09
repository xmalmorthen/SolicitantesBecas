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
    public partial class frmUsuario : Form
    {
        public int? idUsuario = null;
        public Boolean close = false;

        public frmUsuario()
        {
            InitializeComponent();

            bsUsuarios.DataSource = getData.caUsuarios();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            close = true;
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                idUsuario = (int)cmbUsuarios.EditValue;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Debe seleccionar un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close == false) {                
                if (idUsuario == null) e.Cancel = true;
            }
        }
    }
}
