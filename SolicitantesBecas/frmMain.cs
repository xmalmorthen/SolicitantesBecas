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
    public partial class frmMain : Form
    {
        public int? idUsuario = null;

        public frmMain()
        {
            InitializeComponent();

            bsPlanteles.DataSource = getData.caEscuelas();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            strMaSolicitantes dataToSave = new strMaSolicitantes();


            dataToSave.curp = txtCURP.Text;
            dataToSave.primerApellido = "";
            dataToSave.segundoApellido = "";
            dataToSave.nombres = "";
            dataToSave.correo = "";
            dataToSave.telCel = "";
            dataToSave.telPart = "";

            dataToSave.papaPrimerApellido = "";
            dataToSave.papaSegundoApellido = "";
            dataToSave.papaNombres = "";

            dataToSave.mamaPrimerApellido = "";
            dataToSave.mamaSegundoApellido = "";
            dataToSave.mamaNombres = "";

            dataToSave.domIdMpio = "";
            dataToSave.domIdLocalidad = "";
            dataToSave.domIdColonia = "";
            dataToSave.domIdCalle = "";
            dataToSave.domNumExt = 0;
            dataToSave.domNumInt = 0;
            dataToSave.domLetra = "";
            dataToSave.domDesc = "";

            dataToSave.idEscuela = 0;

            dataToSave.idUsuario = 0;



            try
            {
                int idEscuela = (int)cmbEscuelas.EditValue;
            }
            catch (Exception)
            {
                
            }
            


        }
    }
}
