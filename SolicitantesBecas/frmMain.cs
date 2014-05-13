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
        private int? idMpio = null;
        private int? idLoc = null;
        private int? idCol = null;
        private int? idCall = null;
        private int? idEscuela = null;

        public frmMain()
        {
            InitializeComponent();
            
            Boolean error = false;
            bsMpios.DataSource = getData.getMpios(ref error,6);

            bsPlanteles.DataSource = getData.caEscuelas();
        }

        private void Proc(Boolean show = true) {            
            pnlProc.Visible = show;
            this.Enabled = !show;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Boolean validateForm() {
            dxErrorProvider.ClearErrors();

            if (request == null)
            {
                dxErrorProvider.SetError(txtCURP, "Falta indicar la CURP...");
            }
            else
            {
                if (request.Response.statusOper == "NO EXITOSO")
                {
                    dxErrorProvider.SetError(txtCURP, "No se encontró información de la CURP...");
                }
            }

            try
            {
                idMpio = (int)cmbMpio.EditValue;
            }
            catch (Exception)
            {
                dxErrorProvider.SetError(cmbMpio, "Debe seleccionar el municipio...");
            }

            try
            {
                idLoc = (int)cmbLoc.EditValue;
            }
            catch (Exception)
            {
                dxErrorProvider.SetError(cmbLoc, "Debe seleccionar el municipio...");
            }

            try
            {
                idCol = (int)cmbCol.EditValue;
            }
            catch (Exception)
            {}

            try
            {
                idCall = (int)cmbCalle.EditValue;
            }
            catch (Exception)
            { }

            if (idCol == null)
            {
                if (idCall == null)
                {
                    if (string.IsNullOrEmpty(txtDomDesc.Text.Trim()))
                    {
                        dxErrorProvider.SetError(txtDomDesc, "Al no seleccionar colonia ni calle es necesario especificarla aquí, favor de seguir las instrucciones de la NOTA...");
                    }
                }
            }
            else {
                if (idCall == null)
                {
                    if (string.IsNullOrEmpty(txtDomDesc.Text.Trim()))
                    {
                        dxErrorProvider.SetError(txtDomDesc, "Al no seleccionar colonia ni calle es necesario especificarla aquí, favor de seguir las instrucciones de la NOTA...");
                    }
                }
                else {
                    if (string.IsNullOrEmpty(txtNumExt.Text.Trim()))
                    {
                        dxErrorProvider.SetError(txtNumExt, "Debe indicar el número exterior...");
                    }                
                }
            }

            try
            {
                idEscuela = (int)cmbEscuelas.EditValue;
            }
            catch (Exception)
            {
                dxErrorProvider.SetError(cmbEscuelas, "Debe indicar el centro de estudios...");
            }

            return dxErrorProvider.GetControlsWithError().Count == 0 ? true : false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validateForm()) return;


            strMaSolicitantes dataToSave = new strMaSolicitantes();

            dataToSave.curp = txtCURP.Text;
            dataToSave.primerApellido = request.Apellido1;
            dataToSave.segundoApellido = request.Apellido2;
            dataToSave.nombres = request.Nombre;
            dataToSave.correo = txtEmail.Text;
            dataToSave.telCel = txtCel.Text;
            dataToSave.telPart = txtTel.Text;

            dataToSave.papaPrimerApellido = txtAp1Padre.Text;
            dataToSave.papaSegundoApellido = txtAp2Padre.Text;
            dataToSave.papaNombres = txtNomPadre.Text;

            dataToSave.mamaPrimerApellido = txtAp1Madre.Text;
            dataToSave.mamaSegundoApellido = txtAp2Madre.Text;
            dataToSave.mamaNombres = txtNomMadre.Text;

            dataToSave.domIdMpio = "";
            dataToSave.domIdLocalidad = "";
            dataToSave.domIdColonia = "";
            dataToSave.domIdCalle = "";
            dataToSave.domNumExt = 0;
            dataToSave.domNumInt = 0;
            dataToSave.domLetra = "";
            dataToSave.domDesc = "";

            dataToSave.idEscuela = (int)idEscuela;
            dataToSave.idUsuario = (int)idUsuario;
        }

        strCURP request = null;
        private void btnBucarCURP_Click(object sender, EventArgs e)
        {
            string CURP = txtCURP.Text.Trim('_');
            if (string.IsNullOrEmpty(CURP)) 
            {
                //MessageBox.Show("Favor de introducir la CURP a buscar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //txtCURP.Focus();
                return;
            }

            if (request != null) {
                if (request.CURP == txtCURP.Text) return;
            }


            txtNombre.Text = "";
            txtSexoEdad.Text = "";

            Proc();
            Application.DoEvents();

            request = getData.getInfoCURP(txtCURP.Text);
            
            Application.DoEvents();
            Proc(false);

            if (request == null) {
                MessageBox.Show(SolicitantesBecas.Properties.Settings.Default.errGeneral + " " + Environment.NewLine +
                                SolicitantesBecas.Properties.Settings.Default.errWSCURP + " " + Environment.NewLine +
                                SolicitantesBecas.Properties.Settings.Default.errAdmin, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (request.Response.statusOper.ToUpper() == "EXITOSO")
            {
                txtNombre.Text = request.NombreCompleto;
                txtSexoEdad.Text = request.SexoCompleto + " - " + request.Edad.ToString() + " Años cumplidos";
                txtSexoEdad.ForeColor = Color.DimGray;
            }
            else {
                txtNombre.Text = "";
                txtSexoEdad.Text = request.Response.message;
                txtSexoEdad.ForeColor = Color.Red;
                MessageBox.Show(request.Response.message, "Servicio de CURP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }   

        private void txtCURP_Validated(object sender, EventArgs e)
        {
           btnBucarCURP_Click(null, null);
        }

        private void cmbMpio_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Proc();
                Application.DoEvents();

                string idMpio = (string)cmbMpio.EditValue;
                if (idMpio == null) return;

                Boolean error = false;
                bsLoc.DataSource = getData.getLoc(idMpio, ref error);
                if (error) throw new Exception("No se pudo obtener la lista de Colonias");

                cmbLoc.EditValue = null;
                bsCol.Clear();
                cmbCol.EditValue = null;
                bsCall.Clear();
                cmbCalle.EditValue = null;
                

                Application.DoEvents();
                Proc(false);
            }
            catch (Exception _e)
            {
                Proc(false);
                MessageBox.Show(SolicitantesBecas.Properties.Settings.Default.errGeneral + " " + Environment.NewLine +
                                SolicitantesBecas.Properties.Settings.Default.errWSFwrkDomicilios + " " + Environment.NewLine +
                                "Es necesario revisar su conexión a internet, si el problema persiste " +
                                SolicitantesBecas.Properties.Settings.Default.errAdmin, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbLoc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Proc();
                Application.DoEvents();

                string idLoc = (string)cmbLoc.EditValue;
                if (idLoc == null) return;

                Boolean error = false;
                bsCol.DataSource = getData.getCol(idLoc, ref error);
                if (error) throw new Exception("No se pudo obtener la lista de Colonias");

                cmbCol.EditValue = null;
                bsCall.Clear();
                cmbCalle.EditValue = null;

                Application.DoEvents();
                Proc(false);
            }
            catch (Exception _e)
            {
                Proc(false);
                MessageBox.Show(SolicitantesBecas.Properties.Settings.Default.errGeneral + " " + Environment.NewLine +
                                SolicitantesBecas.Properties.Settings.Default.errWSFwrkDomicilios + " " + Environment.NewLine +
                                "Es necesario revisar su conexión a internet, si el problema persiste " +
                                SolicitantesBecas.Properties.Settings.Default.errAdmin, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCol_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Proc();
                Application.DoEvents();

                string idCol = (string)cmbCol.EditValue;
                if (idCol == null) return;

                Boolean error = false;
                bsCall.DataSource = getData.getCall(idCol, ref error);
                if (error) throw new Exception("No se pudo obtener la lista de Colonias");

                cmbCalle.EditValue = null;

                Application.DoEvents();
                Proc(false);
            }
            catch (Exception _e)
            {
                Proc(false);
                MessageBox.Show(SolicitantesBecas.Properties.Settings.Default.errGeneral + " " + Environment.NewLine +
                                SolicitantesBecas.Properties.Settings.Default.errWSFwrkDomicilios + " " + Environment.NewLine +
                                "Es necesario revisar su conexión a internet, si el problema persiste " +
                                SolicitantesBecas.Properties.Settings.Default.errAdmin, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
