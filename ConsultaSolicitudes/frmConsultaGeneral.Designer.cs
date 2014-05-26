namespace ConsultaSolicitudes
{
    partial class frmConsultaGeneral
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaGeneral));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.gdMain = new DevExpress.XtraGrid.GridControl();
            this.bsLista = new System.Windows.Forms.BindingSource(this.components);
            this.gdView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcurp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprimerApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsegundoApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coledad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsexo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcorreo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelCel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelPart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfIns = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldomIdMpio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmunicipio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldomIdLocalidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collocalidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldomIdColonia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcolonia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldomIdCalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcalles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldomNumExt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldomNumInt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldomLetra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpapaPrimerApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpapaSegundoApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpapaNombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmamaPrimerApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmamaSegundoApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmamaNombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldomDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidEscuela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinstitucion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnivel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplantel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlProc = new System.Windows.Forms.Panel();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExportToPDF = new System.Windows.Forms.Button();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.btnExporttoHTML = new System.Windows.Forms.Button();
            this.toolTip = new DevExpress.Utils.ToolTipController(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdView)).BeginInit();
            this.pnlProc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::ConsultaSolicitudes.Properties.Resources.close;
            this.btnCerrar.Location = new System.Drawing.Point(950, 648);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(54, 54);
            this.btnCerrar.TabIndex = 46;
            this.toolTip.SetTitle(this.btnCerrar, "Cerrar");
            this.toolTip.SetToolTip(this.btnCerrar, "Cerrar sistema");
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4});
            this.shapeContainer1.Size = new System.Drawing.Size(1008, 702);
            this.shapeContainer1.TabIndex = 47;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape4.BorderWidth = 2;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 808;
            this.lineShape4.X2 = 1013;
            this.lineShape4.Y1 = 644;
            this.lineShape4.Y2 = 643;
            // 
            // gdMain
            // 
            this.gdMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdMain.DataSource = this.bsLista;
            this.gdMain.Location = new System.Drawing.Point(3, 3);
            this.gdMain.MainView = this.gdView;
            this.gdMain.Name = "gdMain";
            this.gdMain.Size = new System.Drawing.Size(1001, 632);
            this.gdMain.TabIndex = 0;
            this.gdMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdView});
            // 
            // bsLista
            // 
            this.bsLista.DataSource = typeof(ConsultaSolicitudes.Models.strVwSolicitudes);
            // 
            // gdView
            // 
            this.gdView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Transparent;
            this.gdView.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gdView.Appearance.FocusedRow.Font = new System.Drawing.Font("Courier New", 10F);
            this.gdView.Appearance.FocusedRow.Options.UseFont = true;
            this.gdView.Appearance.GroupFooter.Font = new System.Drawing.Font("Courier New", 10F);
            this.gdView.Appearance.GroupFooter.Options.UseFont = true;
            this.gdView.Appearance.GroupPanel.Font = new System.Drawing.Font("Courier New", 10F);
            this.gdView.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gdView.Appearance.GroupPanel.Options.UseFont = true;
            this.gdView.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gdView.Appearance.GroupRow.Font = new System.Drawing.Font("Courier New", 10F);
            this.gdView.Appearance.GroupRow.Options.UseFont = true;
            this.gdView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.gdView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gdView.Appearance.HeaderPanel.Options.UseFont = true;
            this.gdView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gdView.Appearance.Preview.Font = new System.Drawing.Font("Courier New", 10F);
            this.gdView.Appearance.Preview.Options.UseFont = true;
            this.gdView.Appearance.Row.Font = new System.Drawing.Font("Courier New", 10F);
            this.gdView.Appearance.Row.Options.UseFont = true;
            this.gdView.Appearance.ViewCaption.BackColor = System.Drawing.Color.Transparent;
            this.gdView.Appearance.ViewCaption.Options.UseBackColor = true;
            this.gdView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcurp,
            this.colprimerApellido,
            this.colsegundoApellido,
            this.colnombres,
            this.coledad,
            this.colsexo,
            this.colcorreo,
            this.coltelCel,
            this.coltelPart,
            this.colfIns,
            this.coldomIdMpio,
            this.colmunicipio,
            this.coldomIdLocalidad,
            this.collocalidad,
            this.coldomIdColonia,
            this.colcolonia,
            this.coldomIdCalle,
            this.colcalles,
            this.coldomNumExt,
            this.coldomNumInt,
            this.coldomLetra,
            this.colpapaPrimerApellido,
            this.colpapaSegundoApellido,
            this.colpapaNombres,
            this.colmamaPrimerApellido,
            this.colmamaSegundoApellido,
            this.colmamaNombres,
            this.coldomDesc,
            this.colidEscuela,
            this.colinstitucion,
            this.colnivel,
            this.colplantel,
            this.colidUsuario,
            this.colusuario});
            this.gdView.GridControl = this.gdMain;
            this.gdView.GroupCount = 3;
            this.gdView.Name = "gdView";
            this.gdView.OptionsBehavior.AutoExpandAllGroups = true;
            this.gdView.OptionsBehavior.Editable = false;
            this.gdView.OptionsBehavior.ReadOnly = true;
            this.gdView.OptionsPrint.AutoWidth = false;
            this.gdView.OptionsPrint.ExpandAllDetails = true;
            this.gdView.OptionsPrint.PrintDetails = true;
            this.gdView.OptionsPrint.PrintFilterInfo = true;
            this.gdView.OptionsView.ColumnAutoWidth = false;
            this.gdView.OptionsView.RowAutoHeight = true;
            this.gdView.OptionsView.ShowAutoFilterRow = true;
            this.gdView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colusuario, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colinstitucion, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colplantel, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colnivel, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colcurp
            // 
            this.colcurp.Caption = "CURP";
            this.colcurp.FieldName = "curp";
            this.colcurp.Name = "colcurp";
            this.colcurp.Visible = true;
            this.colcurp.VisibleIndex = 1;
            this.colcurp.Width = 238;
            // 
            // colprimerApellido
            // 
            this.colprimerApellido.Caption = "Primer Apellido";
            this.colprimerApellido.FieldName = "primerApellido";
            this.colprimerApellido.Name = "colprimerApellido";
            this.colprimerApellido.Visible = true;
            this.colprimerApellido.VisibleIndex = 2;
            this.colprimerApellido.Width = 277;
            // 
            // colsegundoApellido
            // 
            this.colsegundoApellido.Caption = "Segundo Apellido";
            this.colsegundoApellido.FieldName = "segundoApellido";
            this.colsegundoApellido.Name = "colsegundoApellido";
            this.colsegundoApellido.Visible = true;
            this.colsegundoApellido.VisibleIndex = 3;
            this.colsegundoApellido.Width = 304;
            // 
            // colnombres
            // 
            this.colnombres.Caption = "Nombre(s)";
            this.colnombres.FieldName = "nombres";
            this.colnombres.Name = "colnombres";
            this.colnombres.Visible = true;
            this.colnombres.VisibleIndex = 4;
            this.colnombres.Width = 276;
            // 
            // coledad
            // 
            this.coledad.Caption = "Edad";
            this.coledad.FieldName = "edad";
            this.coledad.Name = "coledad";
            this.coledad.Visible = true;
            this.coledad.VisibleIndex = 5;
            this.coledad.Width = 65;
            // 
            // colsexo
            // 
            this.colsexo.Caption = "Sexo";
            this.colsexo.FieldName = "sexo";
            this.colsexo.Name = "colsexo";
            this.colsexo.Visible = true;
            this.colsexo.VisibleIndex = 6;
            this.colsexo.Width = 45;
            // 
            // colcorreo
            // 
            this.colcorreo.Caption = "Correo Electrónico";
            this.colcorreo.FieldName = "correo";
            this.colcorreo.Name = "colcorreo";
            this.colcorreo.Visible = true;
            this.colcorreo.VisibleIndex = 7;
            this.colcorreo.Width = 312;
            // 
            // coltelCel
            // 
            this.coltelCel.Caption = "Tel. Celular";
            this.coltelCel.FieldName = "telCel";
            this.coltelCel.Name = "coltelCel";
            this.coltelCel.Visible = true;
            this.coltelCel.VisibleIndex = 8;
            this.coltelCel.Width = 185;
            // 
            // coltelPart
            // 
            this.coltelPart.Caption = "Tel. Particular";
            this.coltelPart.FieldName = "telPart";
            this.coltelPart.Name = "coltelPart";
            this.coltelPart.Visible = true;
            this.coltelPart.VisibleIndex = 9;
            this.coltelPart.Width = 224;
            // 
            // colfIns
            // 
            this.colfIns.Caption = "Fecha de Inserción";
            this.colfIns.FieldName = "fIns";
            this.colfIns.Name = "colfIns";
            this.colfIns.Visible = true;
            this.colfIns.VisibleIndex = 24;
            this.colfIns.Width = 420;
            // 
            // coldomIdMpio
            // 
            this.coldomIdMpio.FieldName = "domIdMpio";
            this.coldomIdMpio.Name = "coldomIdMpio";
            // 
            // colmunicipio
            // 
            this.colmunicipio.Caption = "Municipio";
            this.colmunicipio.FieldName = "municipio";
            this.colmunicipio.Name = "colmunicipio";
            this.colmunicipio.Visible = true;
            this.colmunicipio.VisibleIndex = 10;
            this.colmunicipio.Width = 218;
            // 
            // coldomIdLocalidad
            // 
            this.coldomIdLocalidad.FieldName = "domIdLocalidad";
            this.coldomIdLocalidad.Name = "coldomIdLocalidad";
            // 
            // collocalidad
            // 
            this.collocalidad.Caption = "Localidad";
            this.collocalidad.FieldName = "localidad";
            this.collocalidad.Name = "collocalidad";
            this.collocalidad.Visible = true;
            this.collocalidad.VisibleIndex = 11;
            this.collocalidad.Width = 228;
            // 
            // coldomIdColonia
            // 
            this.coldomIdColonia.FieldName = "domIdColonia";
            this.coldomIdColonia.Name = "coldomIdColonia";
            // 
            // colcolonia
            // 
            this.colcolonia.Caption = "Colonia";
            this.colcolonia.FieldName = "colonia";
            this.colcolonia.Name = "colcolonia";
            this.colcolonia.Visible = true;
            this.colcolonia.VisibleIndex = 12;
            this.colcolonia.Width = 294;
            // 
            // coldomIdCalle
            // 
            this.coldomIdCalle.FieldName = "domIdCalle";
            this.coldomIdCalle.Name = "coldomIdCalle";
            // 
            // colcalles
            // 
            this.colcalles.Caption = "Calle";
            this.colcalles.FieldName = "calles";
            this.colcalles.Name = "colcalles";
            this.colcalles.Visible = true;
            this.colcalles.VisibleIndex = 13;
            this.colcalles.Width = 371;
            // 
            // coldomNumExt
            // 
            this.coldomNumExt.Caption = "Nu. Exterior";
            this.coldomNumExt.FieldName = "domNumExt";
            this.coldomNumExt.Name = "coldomNumExt";
            this.coldomNumExt.Visible = true;
            this.coldomNumExt.VisibleIndex = 14;
            this.coldomNumExt.Width = 110;
            // 
            // coldomNumInt
            // 
            this.coldomNumInt.Caption = "Num. Interior";
            this.coldomNumInt.FieldName = "domNumInt";
            this.coldomNumInt.Name = "coldomNumInt";
            this.coldomNumInt.Visible = true;
            this.coldomNumInt.VisibleIndex = 15;
            this.coldomNumInt.Width = 123;
            // 
            // coldomLetra
            // 
            this.coldomLetra.Caption = "Letra";
            this.coldomLetra.FieldName = "domLetra";
            this.coldomLetra.Name = "coldomLetra";
            this.coldomLetra.Visible = true;
            this.coldomLetra.VisibleIndex = 16;
            this.coldomLetra.Width = 51;
            // 
            // colpapaPrimerApellido
            // 
            this.colpapaPrimerApellido.Caption = "Primer Apellido Padre";
            this.colpapaPrimerApellido.FieldName = "papaPrimerApellido";
            this.colpapaPrimerApellido.Name = "colpapaPrimerApellido";
            this.colpapaPrimerApellido.Visible = true;
            this.colpapaPrimerApellido.VisibleIndex = 18;
            this.colpapaPrimerApellido.Width = 316;
            // 
            // colpapaSegundoApellido
            // 
            this.colpapaSegundoApellido.Caption = "Segundo Apellido Padre";
            this.colpapaSegundoApellido.FieldName = "papaSegundoApellido";
            this.colpapaSegundoApellido.Name = "colpapaSegundoApellido";
            this.colpapaSegundoApellido.Visible = true;
            this.colpapaSegundoApellido.VisibleIndex = 19;
            this.colpapaSegundoApellido.Width = 310;
            // 
            // colpapaNombres
            // 
            this.colpapaNombres.Caption = "Nombre(s) Padre";
            this.colpapaNombres.FieldName = "papaNombres";
            this.colpapaNombres.Name = "colpapaNombres";
            this.colpapaNombres.Visible = true;
            this.colpapaNombres.VisibleIndex = 20;
            this.colpapaNombres.Width = 216;
            // 
            // colmamaPrimerApellido
            // 
            this.colmamaPrimerApellido.Caption = "Primer Apellido Madre";
            this.colmamaPrimerApellido.FieldName = "mamaPrimerApellido";
            this.colmamaPrimerApellido.Name = "colmamaPrimerApellido";
            this.colmamaPrimerApellido.Visible = true;
            this.colmamaPrimerApellido.VisibleIndex = 21;
            this.colmamaPrimerApellido.Width = 293;
            // 
            // colmamaSegundoApellido
            // 
            this.colmamaSegundoApellido.Caption = "Segundo Apellido Madre";
            this.colmamaSegundoApellido.FieldName = "mamaSegundoApellido";
            this.colmamaSegundoApellido.Name = "colmamaSegundoApellido";
            this.colmamaSegundoApellido.Visible = true;
            this.colmamaSegundoApellido.VisibleIndex = 22;
            this.colmamaSegundoApellido.Width = 276;
            // 
            // colmamaNombres
            // 
            this.colmamaNombres.Caption = "Nombre(s) Madre";
            this.colmamaNombres.FieldName = "mamaNombres";
            this.colmamaNombres.Name = "colmamaNombres";
            this.colmamaNombres.Visible = true;
            this.colmamaNombres.VisibleIndex = 23;
            this.colmamaNombres.Width = 248;
            // 
            // coldomDesc
            // 
            this.coldomDesc.Caption = "Domicilio No Ubicado";
            this.coldomDesc.FieldName = "domDesc";
            this.coldomDesc.Name = "coldomDesc";
            this.coldomDesc.Visible = true;
            this.coldomDesc.VisibleIndex = 17;
            this.coldomDesc.Width = 587;
            // 
            // colidEscuela
            // 
            this.colidEscuela.FieldName = "idEscuela";
            this.colidEscuela.Name = "colidEscuela";
            // 
            // colinstitucion
            // 
            this.colinstitucion.Caption = "Institución";
            this.colinstitucion.FieldName = "institucion";
            this.colinstitucion.Name = "colinstitucion";
            this.colinstitucion.Visible = true;
            this.colinstitucion.VisibleIndex = 0;
            this.colinstitucion.Width = 258;
            // 
            // colnivel
            // 
            this.colnivel.Caption = "Nivel Educativo";
            this.colnivel.FieldName = "nivel";
            this.colnivel.Name = "colnivel";
            this.colnivel.Visible = true;
            this.colnivel.VisibleIndex = 0;
            this.colnivel.Width = 255;
            // 
            // colplantel
            // 
            this.colplantel.Caption = "Plantel";
            this.colplantel.FieldName = "plantel";
            this.colplantel.Name = "colplantel";
            this.colplantel.Visible = true;
            this.colplantel.VisibleIndex = 1;
            this.colplantel.Width = 351;
            // 
            // colidUsuario
            // 
            this.colidUsuario.FieldName = "idUsuario";
            this.colidUsuario.Name = "colidUsuario";
            // 
            // colusuario
            // 
            this.colusuario.Caption = "Usuario";
            this.colusuario.FieldName = "usuario";
            this.colusuario.Name = "colusuario";
            this.colusuario.Visible = true;
            this.colusuario.VisibleIndex = 0;
            this.colusuario.Width = 140;
            // 
            // pnlProc
            // 
            this.pnlProc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlProc.Controls.Add(this.labelControl25);
            this.pnlProc.Controls.Add(this.labelControl24);
            this.pnlProc.Controls.Add(this.pictureBox1);
            this.pnlProc.Location = new System.Drawing.Point(3, 643);
            this.pnlProc.Name = "pnlProc";
            this.pnlProc.Size = new System.Drawing.Size(309, 59);
            this.pnlProc.TabIndex = 58;
            this.pnlProc.Visible = false;
            // 
            // labelControl25
            // 
            this.labelControl25.Appearance.Font = new System.Drawing.Font("Courier New", 12F);
            this.labelControl25.Location = new System.Drawing.Point(61, 32);
            this.labelControl25.Margin = new System.Windows.Forms.Padding(1);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(190, 18);
            this.labelControl25.TabIndex = 59;
            this.labelControl25.Text = "Favor de esperar...";
            // 
            // labelControl24
            // 
            this.labelControl24.Appearance.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold);
            this.labelControl24.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl24.Location = new System.Drawing.Point(61, 11);
            this.labelControl24.Margin = new System.Windows.Forms.Padding(1);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(242, 22);
            this.labelControl24.TabIndex = 58;
            this.labelControl24.Text = "Procesando información";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConsultaSolicitudes.Properties.Resources.clock;
            this.pictureBox1.Location = new System.Drawing.Point(7, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // btnExportToPDF
            // 
            this.btnExportToPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToPDF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExportToPDF.BackColor = System.Drawing.Color.Transparent;
            this.btnExportToPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportToPDF.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExportToPDF.FlatAppearance.BorderSize = 0;
            this.btnExportToPDF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExportToPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExportToPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportToPDF.Image = global::ConsultaSolicitudes.Properties.Resources.MetroUI_Excel;
            this.btnExportToPDF.Location = new System.Drawing.Point(890, 650);
            this.btnExportToPDF.Margin = new System.Windows.Forms.Padding(1);
            this.btnExportToPDF.Name = "btnExportToPDF";
            this.btnExportToPDF.Size = new System.Drawing.Size(25, 27);
            this.btnExportToPDF.TabIndex = 59;
            this.toolTip.SetTitle(this.btnExportToPDF, "Exportar");
            this.toolTip.SetToolTip(this.btnExportToPDF, "Exportar información mostrada a EXCEL");
            this.btnExportToPDF.UseVisualStyleBackColor = false;
            this.btnExportToPDF.Click += new System.EventHandler(this.btnExportToPDF_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintPreview.AutoSize = true;
            this.btnPrintPreview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrintPreview.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintPreview.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrintPreview.FlatAppearance.BorderSize = 0;
            this.btnPrintPreview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrintPreview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintPreview.Image = global::ConsultaSolicitudes.Properties.Resources.printprev;
            this.btnPrintPreview.Location = new System.Drawing.Point(824, 647);
            this.btnPrintPreview.Margin = new System.Windows.Forms.Padding(1);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(54, 54);
            this.btnPrintPreview.TabIndex = 60;
            this.toolTip.SetTitle(this.btnPrintPreview, "Visualizar");
            this.btnPrintPreview.UseVisualStyleBackColor = false;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // btnExporttoHTML
            // 
            this.btnExporttoHTML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExporttoHTML.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExporttoHTML.BackColor = System.Drawing.Color.Transparent;
            this.btnExporttoHTML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExporttoHTML.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExporttoHTML.FlatAppearance.BorderSize = 0;
            this.btnExporttoHTML.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExporttoHTML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExporttoHTML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExporttoHTML.Image = global::ConsultaSolicitudes.Properties.Resources.html;
            this.btnExporttoHTML.Location = new System.Drawing.Point(890, 677);
            this.btnExporttoHTML.Margin = new System.Windows.Forms.Padding(1);
            this.btnExporttoHTML.Name = "btnExporttoHTML";
            this.btnExporttoHTML.Size = new System.Drawing.Size(25, 27);
            this.btnExporttoHTML.TabIndex = 61;
            this.toolTip.SetTitle(this.btnExporttoHTML, "Exportar");
            this.toolTip.SetToolTip(this.btnExporttoHTML, "Exportar información mostrada a Página HTML");
            this.btnExporttoHTML.UseVisualStyleBackColor = false;
            this.btnExporttoHTML.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ConsultaSolicitudes.Properties.Resources.close;
            this.button1.Location = new System.Drawing.Point(465, 647);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 54);
            this.button1.TabIndex = 62;
            this.toolTip.SetTitle(this.button1, "Cerrar");
            this.toolTip.SetToolTip(this.button1, "Cerrar sistema");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmConsultaGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 702);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExporttoHTML);
            this.Controls.Add(this.btnPrintPreview);
            this.Controls.Add(this.pnlProc);
            this.Controls.Add(this.gdMain);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnExportToPDF);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaGeneral";
            this.Load += new System.EventHandler(this.frmConsultaGeneral_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmConsultaGeneral_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.gdMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdView)).EndInit();
            this.pnlProc.ResumeLayout(false);
            this.pnlProc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private DevExpress.XtraGrid.GridControl gdMain;
        private System.Windows.Forms.BindingSource bsLista;
        private DevExpress.XtraGrid.Views.Grid.GridView gdView;
        private DevExpress.XtraGrid.Columns.GridColumn colcurp;
        private DevExpress.XtraGrid.Columns.GridColumn colprimerApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colsegundoApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colnombres;
        private DevExpress.XtraGrid.Columns.GridColumn coledad;
        private DevExpress.XtraGrid.Columns.GridColumn colsexo;
        private DevExpress.XtraGrid.Columns.GridColumn colcorreo;
        private DevExpress.XtraGrid.Columns.GridColumn coltelCel;
        private DevExpress.XtraGrid.Columns.GridColumn coltelPart;
        private DevExpress.XtraGrid.Columns.GridColumn colfIns;
        private DevExpress.XtraGrid.Columns.GridColumn coldomIdMpio;
        private DevExpress.XtraGrid.Columns.GridColumn colmunicipio;
        private DevExpress.XtraGrid.Columns.GridColumn coldomIdLocalidad;
        private DevExpress.XtraGrid.Columns.GridColumn collocalidad;
        private DevExpress.XtraGrid.Columns.GridColumn coldomIdColonia;
        private DevExpress.XtraGrid.Columns.GridColumn colcolonia;
        private DevExpress.XtraGrid.Columns.GridColumn coldomIdCalle;
        private DevExpress.XtraGrid.Columns.GridColumn colcalles;
        private DevExpress.XtraGrid.Columns.GridColumn coldomNumExt;
        private DevExpress.XtraGrid.Columns.GridColumn coldomNumInt;
        private DevExpress.XtraGrid.Columns.GridColumn coldomLetra;
        private DevExpress.XtraGrid.Columns.GridColumn colpapaPrimerApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colpapaSegundoApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colpapaNombres;
        private DevExpress.XtraGrid.Columns.GridColumn colmamaPrimerApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colmamaSegundoApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colmamaNombres;
        private DevExpress.XtraGrid.Columns.GridColumn coldomDesc;
        private DevExpress.XtraGrid.Columns.GridColumn colidEscuela;
        private DevExpress.XtraGrid.Columns.GridColumn colinstitucion;
        private DevExpress.XtraGrid.Columns.GridColumn colnivel;
        private DevExpress.XtraGrid.Columns.GridColumn colplantel;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private System.Windows.Forms.Panel pnlProc;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExportToPDF;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Windows.Forms.Button btnExporttoHTML;
        private DevExpress.Utils.ToolTipController toolTip;
        private System.Windows.Forms.Button button1;

    }
}

