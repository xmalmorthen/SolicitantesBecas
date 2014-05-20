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
        private int? idUsuario {get; set;}
        private string usuario {get; set;}
        private string idMpio = null;
        private string idLoc = null;
        private string idCol = null;
        private string idCall = null;
        private int? idEscuela = null;

        public frmMain(int? idUsuario, string usuario)
        {
            InitializeComponent();

            this.idUsuario = idUsuario;
            this.usuario = usuario;

            estableceTituloVentana();

            this.BackColor = Color.WhiteSmoke;

            this.Paint += new PaintEventHandler(frmMain_Paint);
        }

        private void Proc(Boolean show = true) {            
            pnlProc.Visible = show;
            this.Enabled = !show;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        Boolean CURPValidada = false;
        private Boolean validateForm() {
            dxErrorProvider.ClearErrors();

            try
            {
                idEscuela = (int)cmbEscuelas.EditValue;
            }
            catch (Exception)
            {
                dxErrorProvider.SetError(cmbEscuelas, "Debe indicar el centro de estudios...");
            }

            if (request == null)
            {
                dxErrorProvider.SetError(txtCURP, "Falta indicar la CURP...");
                CURPValidada = false;
            }
            else
            {
                if (request.Response.statusOper == "NO EXITOSO")
                {
                    dxErrorProvider.SetError(txtCURP, "No se encontró información de la CURP...");
                    CURPValidada = false;
                }
                else 
                {
                    if (!CURPValidada)
                    {
                        if (idEscuela != null)
                        {
                            try
                            {
                                if ((Boolean)getData.isCURPInserted((int)idUsuario, request.CURP, (int)idEscuela))
                                {
                                    dxErrorProvider.SetError(txtCURP, "La CURP ya se encuentra registrada, favor de revisar...");
                                    CURPValidada = false;
                                }
                                else
                                {
                                    CURPValidada = true;
                                }
                            }
                            catch (Exception e)
                            {
                                Proc(false);
                                MessageBox.Show(SolicitantesBecas.Properties.Settings.Default.errGeneral + " " + Environment.NewLine +
                                                SolicitantesBecas.Properties.Settings.Default.errWSSolicitantesBecas + " " + Environment.NewLine +
                                                "Es necesario revisar su conexión a internet e intentarlo de nuevo, si el problema persiste " +
                                                SolicitantesBecas.Properties.Settings.Default.errAdmin, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                dxErrorProvider.SetError(txtCURP, "No fué posible validar duplicidad de la CURP, favor de intentarlo de nuevo...", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning);
                                CURPValidada = false;
                            }
                        }
                    }
                }
            }

            if (cmbMpio.EditValue != null)
            {
                idMpio = (string)cmbMpio.EditValue;
            }
            else
            {
                dxErrorProvider.SetError(cmbMpio, "Debe seleccionar el municipio...");
            }

            if (cmbLoc.EditValue != null)
            {
                idLoc = (string)cmbLoc.EditValue;
            }
            else
            {
                dxErrorProvider.SetError(cmbLoc, "Debe seleccionar el municipio...");
            }

            
            idCol = (string)cmbCol.EditValue;            
            idCall = (string)cmbCalle.EditValue;
            
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

            return dxErrorProvider.GetControlsWithError().Count == 0 ? true : false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Proc();
            Application.DoEvents();

            if (validateForm())
            {

                try
                {
                    strMaSolicitantes dataToSave = new strMaSolicitantes();

                    dataToSave.curp = txtCURP.Text.Trim();
                    dataToSave.primerApellido = request.Apellido1;
                    dataToSave.segundoApellido = request.Apellido2;
                    dataToSave.nombres = request.Nombre;
                    dataToSave.edad = request.Edad;
                    dataToSave.sexo = request.Sexo;
                    dataToSave.correo = txtEmail.Text.Trim();
                    dataToSave.telCel = txtCel.Text.Trim();
                    dataToSave.telPart = txtTel.Text.Trim();

                    dataToSave.papaPrimerApellido = txtAp1Padre.Text.Trim();
                    dataToSave.papaSegundoApellido = txtAp2Padre.Text.Trim();
                    dataToSave.papaNombres = txtNomPadre.Text.Trim();

                    dataToSave.mamaPrimerApellido = txtAp1Madre.Text.Trim();
                    dataToSave.mamaSegundoApellido = txtAp2Madre.Text.Trim();
                    dataToSave.mamaNombres = txtNomMadre.Text.Trim();

                    dataToSave.domIdMpio = idMpio;
                    dataToSave.domMpio = cmbMpio.Text.Trim();
                    dataToSave.domIdLocalidad = idLoc;
                    dataToSave.domLocalidad = cmbLoc.Text.Trim();
                    dataToSave.domIdColonia = idCol;
                    dataToSave.domColonia = cmbCol.Text.Trim();
                    dataToSave.domIdCalle = idCall;
                    dataToSave.domCalle = cmbCalle.Text.Trim();
                    if (!string.IsNullOrEmpty(txtNumExt.Text.Trim())) {
                        dataToSave.domNumExt = Convert.ToInt32(txtNumExt.Text.Trim());
                    } else {
                        dataToSave.domNumExt = null;
                    }
                    if (!string.IsNullOrEmpty(txtNumInt.Text.Trim())) {
                        dataToSave.domNumInt = Convert.ToInt32(txtNumInt.Text.Trim());
                    } else {
                        dataToSave.domNumInt = null;
                    }
                    dataToSave.domLetra = txtLet.Text.Trim();
                    dataToSave.domDesc = txtDomDesc.Text.Trim();

                    dataToSave.idEscuela = (int)this.idEscuela;
                    dataToSave.idUsuario = (int)this.idUsuario;

                    string error = null;
                    Boolean? respuesta = setData.inserSolicitud(dataToSave,ref error);

                    if (respuesta == null)
                    {
                        if (!string.IsNullOrEmpty(error)) {
                            string msg = "La CURP ya se encuentra registrada, favor de revisar...";
                            dxErrorProvider.SetError(txtCURP, msg);
                            CURPValidada = false;
                            MessageBox.Show(msg, "Guardar registro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        } else {
                            throw new Exception("Ocurrió un problema al intentar conectar con el servicio web...");
                        }
                    }
                    else if ((Boolean)respuesta == false)
                    {
                        MessageBox.Show("No fué posible guardar el registro, favor de intentarlo de nuevo", "Guardar registro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        MessageBox.Show("Registro guardado con EXITO", "Guardar registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarFormulario();
                    }

                }
                catch (Exception err)
                {
                    Proc(false);
                    MessageBox.Show(SolicitantesBecas.Properties.Settings.Default.errGeneral + " " + Environment.NewLine +
                                    SolicitantesBecas.Properties.Settings.Default.errWSSolicitantesBecas + " " + Environment.NewLine +
                                    "Es necesario revisar su conexión a internet e intentarlo de nuevo, si el problema persiste " + Environment.NewLine +
                                    err.Message + Environment.NewLine +
                                    SolicitantesBecas.Properties.Settings.Default.errAdmin, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            Application.DoEvents();
            Proc(false);
        }

        strCURP request = null;
        private void buscarCURP() {
            string CURP = txtCURP.Text.Trim('_');
            if (string.IsNullOrEmpty(CURP))
            {
                //MessageBox.Show("Favor de introducir la CURP a buscar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //txtCURP.Focus();
                return;
            }

            if (request != null)
            {
                if (request.CURP == CURP) return;
            }


            txtNombre.Text = "";
            txtSexoEdad.Text = "";

            Proc();
            Application.DoEvents();

            request = getData.getInfoCURP(CURP);

            Application.DoEvents();
            Proc(false);

            if (request == null)
            {
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
            else
            {                
                txtNombre.Text = "";
                txtSexoEdad.Text = request.Response.message;
                txtSexoEdad.ForeColor = Color.Red;
                dxErrorProvider.SetError(txtCURP, request.Response.message + "...");
                MessageBox.Show(request.Response.message, "Servicio de CURP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void btnBucarCURP_Click(object sender, EventArgs e)
        {
            dxErrorProvider.ClearErrors();
            string CURP = txtCURP.Text.Trim('_');
            if (string.IsNullOrEmpty(CURP))
            {
                dxErrorProvider.SetError(txtCURP, "Falta indicar la CURP...");
                txtCURP.Focus();
                return;
            }
            buscarCURP();
        }   

        private void txtCURP_Validated(object sender, EventArgs e)
        {
            dxErrorProvider.ClearErrors();
            buscarCURP();           
        }

        private void btnCambiarUsuario_Click(object sender, EventArgs e)
        {
            frmUsuario frmusuario = new frmUsuario();
            frmusuario.StartPosition = FormStartPosition.CenterParent;
            DialogResult loginresult = frmusuario.ShowDialog();

            if (loginresult == DialogResult.OK)
            {
                this.idUsuario = frmusuario.idUsuario;
                this.usuario = frmusuario.usuario;

                frmusuario.Dispose();
                frmusuario = null;

                estableceTituloVentana();
            }
        }

        private void estableceTituloVentana() {
            this.Text = "Usuario: " + usuario + " - " + SolicitantesBecas.Properties.Settings.Default.tituloVentana;
        }

        private void limpiarFormulario() {
            Proc();
            Application.DoEvents();

            dxErrorProvider.ClearErrors();
            txtCURP.Text = "";
            txtEmail.Text = "";
            txtCel.Text = "";
            txtTel.Text = "";
            txtAp1Padre.Text = "";
            txtAp2Padre.Text = "";
            txtNomPadre.Text = "";
            txtAp1Madre.Text = "";
            txtAp2Madre.Text = "";
            txtNomMadre.Text = "";
            cmbMpio.EditValue = null;
            cmbLoc.EditValue = null;
            cmbCol.EditValue = null;
            cmbCalle.EditValue = null;
            txtNumExt.Text = "";
            txtNumInt.Text = "";
            txtLet.Text = "";
            txtDomDesc.Text = "";
            cmbEscuelas.EditValue = null;

            bsCall.Clear();
            bsCol.Clear();
            bsLoc.Clear();

            idMpio = null;
            idLoc = null;
            idCol = null;
            idCall = null;
            idEscuela = null;
            CURPValidada = false;
            request = null;

            Application.DoEvents();
            Proc(false);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Limpoar formulario...", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                limpiarFormulario();
            }
        }

        private void cmbMpio_Leave(object sender, EventArgs e)
        {
            try
            {
                Proc();
                Application.DoEvents();

                if (idMpio != (string)cmbMpio.EditValue) {
                    idMpio = (string)cmbMpio.EditValue;
                    if (idMpio != null)
                    {
                        Boolean error = false;
                        bsLoc.DataSource = getData.getLoc(idMpio, ref error);
                        if (error) throw new Exception("No se pudo obtener la lista de Colonias");

                        cmbLoc.EditValue = null;
                        bsCol.Clear();
                        cmbCol.EditValue = null;
                        bsCall.Clear();
                        cmbCalle.EditValue = null;
                    }
                }

                Application.DoEvents();
                Proc(false);
            }
            catch (Exception _e)
            {
                Proc(false);
                MessageBox.Show(SolicitantesBecas.Properties.Settings.Default.errGeneral + " " + Environment.NewLine +
                                SolicitantesBecas.Properties.Settings.Default.errWSFwrkDomicilios + " " + Environment.NewLine +
                                "Es necesario revisar su conexión a internet e intentarlo de nuevo, si el problema persiste " +
                                SolicitantesBecas.Properties.Settings.Default.errAdmin, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbLoc_Leave(object sender, EventArgs e)
        {
            try
            {
                Proc();
                Application.DoEvents();

                if (idLoc != (string)cmbLoc.EditValue)
                {
                    idLoc = (string)cmbLoc.EditValue;
                    if (idLoc != null)
                    {

                        Boolean error = false;
                        bsCol.DataSource = getData.getCol(idLoc, ref error);
                        if (error) throw new Exception("No se pudo obtener la lista de Colonias");

                        cmbCol.EditValue = null;
                        bsCall.Clear();
                        cmbCalle.EditValue = null;
                    }
                }
                Application.DoEvents();
                Proc(false);
            }
            catch (Exception _e)
            {
                Proc(false);
                MessageBox.Show(SolicitantesBecas.Properties.Settings.Default.errGeneral + " " + Environment.NewLine +
                                SolicitantesBecas.Properties.Settings.Default.errWSFwrkDomicilios + " " + Environment.NewLine +
                                "Es necesario revisar su conexión a internet e intentarlo de nuevo, si el problema persiste " +
                                SolicitantesBecas.Properties.Settings.Default.errAdmin, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCol_Leave(object sender, EventArgs e)
        {
            try
            {
                Proc();
                Application.DoEvents();

                if (idCol != (string)cmbCol.EditValue)
                {
                    idCol = (string)cmbCol.EditValue;
                    if (idCol != null)
                    {
                        Boolean error = false;
                        bsCall.DataSource = getData.getCall(idCol, ref error);
                        if (error) throw new Exception("No se pudo obtener la lista de Colonias");

                        cmbCalle.EditValue = null;
                    }
                }
                Application.DoEvents();
                Proc(false);
            }
            catch (Exception _e)
            {
                Proc(false);
                MessageBox.Show(SolicitantesBecas.Properties.Settings.Default.errGeneral + " " + Environment.NewLine +
                                SolicitantesBecas.Properties.Settings.Default.errWSFwrkDomicilios + " " + Environment.NewLine +
                                "Es necesario revisar su conexión a internet e intentarlo de nuevo, si el problema persiste " +
                                SolicitantesBecas.Properties.Settings.Default.errAdmin, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            Proc();
            Application.DoEvents();
                
                frmRegistros FrmRegistros = new frmRegistros((int)idUsuario,usuario);
            
            Application.DoEvents();
            Proc(false);

            FrmRegistros.ShowDialog(this);
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            this.Paint -= new PaintEventHandler(frmMain_Paint);

            Proc();
            Application.DoEvents();

            Boolean error = false;
            bsMpios.DataSource = getData.getMpios(ref error, 6);
            bsPlanteles.DataSource = getData.caEscuelas();
            
            Application.DoEvents();
            Proc(false);

            lineShape1.Refresh();
            lineShape2.Refresh();
            lineShape3.Refresh();
            lineShape4.Refresh();
            rectangleShape1.Refresh();
            rectangleShape2.Refresh();
        }

    }
}
