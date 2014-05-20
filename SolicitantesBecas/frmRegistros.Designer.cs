namespace SolicitantesBecas
{
    partial class frmRegistros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gdLista = new DevExpress.XtraGrid.GridControl();
            this.bsListaReducida = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcurp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprimerApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsegundoApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidEscuela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmunicipio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinstitucion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnivel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplantel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfIns = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListaReducida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gdLista
            // 
            this.gdLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdLista.DataSource = this.bsListaReducida;
            this.gdLista.Location = new System.Drawing.Point(1, 1);
            this.gdLista.MainView = this.gridView1;
            this.gdLista.Margin = new System.Windows.Forms.Padding(1);
            this.gdLista.Name = "gdLista";
            this.gdLista.Size = new System.Drawing.Size(607, 416);
            this.gdLista.TabIndex = 0;
            this.gdLista.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bsListaReducida
            // 
            this.bsListaReducida.DataSource = typeof(SolicitantesBecas.Models.strPaListaRegistrosReducida);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Transparent;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Courier New", 10F);
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("Courier New", 10F);
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Courier New", 10F);
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Courier New", 10F);
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("Courier New", 10F);
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Courier New", 10F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.ViewCaption.BackColor = System.Drawing.Color.Transparent;
            this.gridView1.Appearance.ViewCaption.Options.UseBackColor = true;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcurp,
            this.colprimerApellido,
            this.colsegundoApellido,
            this.colnombres,
            this.colidEscuela,
            this.colmunicipio,
            this.colinstitucion,
            this.colnivel,
            this.colplantel,
            this.colfIns});
            this.gridView1.GridControl = this.gdLista;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.PaintStyleName = "Flat";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colfIns, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // colcurp
            // 
            this.colcurp.Caption = "CURP";
            this.colcurp.FieldName = "curp";
            this.colcurp.Name = "colcurp";
            this.colcurp.Visible = true;
            this.colcurp.VisibleIndex = 0;
            this.colcurp.Width = 96;
            // 
            // colprimerApellido
            // 
            this.colprimerApellido.Caption = "Primer Apellido";
            this.colprimerApellido.FieldName = "primerApellido";
            this.colprimerApellido.Name = "colprimerApellido";
            this.colprimerApellido.Visible = true;
            this.colprimerApellido.VisibleIndex = 1;
            this.colprimerApellido.Width = 134;
            // 
            // colsegundoApellido
            // 
            this.colsegundoApellido.Caption = "Segundo Apellido";
            this.colsegundoApellido.FieldName = "segundoApellido";
            this.colsegundoApellido.Name = "colsegundoApellido";
            this.colsegundoApellido.Visible = true;
            this.colsegundoApellido.VisibleIndex = 2;
            this.colsegundoApellido.Width = 142;
            // 
            // colnombres
            // 
            this.colnombres.Caption = "Nombre(s)";
            this.colnombres.FieldName = "nombres";
            this.colnombres.Name = "colnombres";
            this.colnombres.Visible = true;
            this.colnombres.VisibleIndex = 3;
            this.colnombres.Width = 153;
            // 
            // colidEscuela
            // 
            this.colidEscuela.FieldName = "idEscuela";
            this.colidEscuela.Name = "colidEscuela";
            // 
            // colmunicipio
            // 
            this.colmunicipio.FieldName = "municipio";
            this.colmunicipio.Name = "colmunicipio";
            // 
            // colinstitucion
            // 
            this.colinstitucion.Caption = "Institución";
            this.colinstitucion.FieldName = "institucion";
            this.colinstitucion.Name = "colinstitucion";
            this.colinstitucion.Visible = true;
            this.colinstitucion.VisibleIndex = 4;
            this.colinstitucion.Width = 236;
            // 
            // colnivel
            // 
            this.colnivel.FieldName = "nivel";
            this.colnivel.Name = "colnivel";
            // 
            // colplantel
            // 
            this.colplantel.Caption = "Plantel";
            this.colplantel.FieldName = "plantel";
            this.colplantel.Name = "colplantel";
            this.colplantel.Visible = true;
            this.colplantel.VisibleIndex = 5;
            this.colplantel.Width = 174;
            // 
            // colfIns
            // 
            this.colfIns.Caption = "Fecha de creación";
            this.colfIns.FieldName = "fIns";
            this.colfIns.Name = "colfIns";
            this.colfIns.Visible = true;
            this.colfIns.VisibleIndex = 6;
            this.colfIns.Width = 169;
            // 
            // lineShape4
            // 
            this.lineShape4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape4.BorderWidth = 2;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 329;
            this.lineShape4.X2 = 617;
            this.lineShape4.Y1 = 425;
            this.lineShape4.Y2 = 424;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4});
            this.shapeContainer1.Size = new System.Drawing.Size(609, 482);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
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
            this.btnCerrar.Image = global::SolicitantesBecas.Properties.Resources.close;
            this.btnCerrar.Location = new System.Drawing.Point(554, 428);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(54, 54);
            this.btnCerrar.TabIndex = 45;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(609, 482);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gdLista);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmRegistros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.gdLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListaReducida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gdLista;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bsListaReducida;
        private DevExpress.XtraGrid.Columns.GridColumn colcurp;
        private DevExpress.XtraGrid.Columns.GridColumn colprimerApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colsegundoApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colnombres;
        private DevExpress.XtraGrid.Columns.GridColumn colidEscuela;
        private DevExpress.XtraGrid.Columns.GridColumn colmunicipio;
        private DevExpress.XtraGrid.Columns.GridColumn colinstitucion;
        private DevExpress.XtraGrid.Columns.GridColumn colnivel;
        private DevExpress.XtraGrid.Columns.GridColumn colplantel;
        private DevExpress.XtraGrid.Columns.GridColumn colfIns;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Button btnCerrar;
    }
}