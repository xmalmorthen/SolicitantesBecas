using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using ConsultaSolicitudes.Models;
using DevExpress.XtraPrinting;
using ConsultaSolicitudes.Libs;

namespace ConsultaSolicitudes
{
    public partial class frmConsultaGeneral : Form
    {
        public frmConsultaGeneral()
        {
            InitializeComponent();
            
            estableceTituloVentana();

            this.Paint += new PaintEventHandler(frmConsultaGeneral_Paint);
        }

        private void Proc(Boolean show = true)
        {
            pnlProc.Visible = show;
            this.Enabled = !show;
        }

        private void estableceTituloVentana()
        {
            this.Text = ConsultaSolicitudes.Properties.Settings.Default.tituloVentana;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultaGeneral_Paint(object sender, PaintEventArgs e)
        {
            this.Paint -= new PaintEventHandler(frmConsultaGeneral_Paint);

            Proc();
            Application.DoEvents();

                bsLista.DataSource = getData.ListaCompleta();

            Application.DoEvents();
            Proc(false);
        }

        private void frmConsultaGeneral_Load(object sender, EventArgs e)
        {
            gdView.ShowFindPanel();
        }

        private void btnExportToPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Exportar a Excel";
            sfd.DefaultExt = "xls";
            sfd.Filter = "*.xls|*.xls|*.xlsx|*.xlsx";
            sfd.FileName = "SolicitantesBecas";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                
                if (sfd.FileName != "")
                {
                    switch (sfd.FilterIndex)
                    {
                        case 1:

                            DevExpress.XtraPrinting.XlsExportOptions _Options = new DevExpress.XtraPrinting.XlsExportOptions();
                            _Options.SheetName = sfd.FileName;
                            _Options.ExportMode = XlsExportMode.SingleFile;
                            gdMain.ExportToXls(sfd.FileName, _Options);
                            break;

                        case 2:

                            DevExpress.XtraPrinting.XlsxExportOptions _Options2 = new DevExpress.XtraPrinting.XlsxExportOptions();
                            _Options2.SheetName = sfd.FileName;
                            _Options2.ExportMode = XlsxExportMode.SingleFile;
                            gdMain.ExportToXlsx(sfd.FileName, _Options2);
                            break;
                        
                    }

                }

            }
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            gdMain.ShowRibbonPrintPreview();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Exportar a HTML";
            sfd.DefaultExt = "html";
            sfd.Filter = "*.html|*.html|*.htm|*.htm";
            sfd.FileName = "SolicitantesBecas";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                
                if (sfd.FileName != "")
                {
                    HtmlExportOptions _Options = new HtmlExportOptions("Utf-8","Solicitantes de Becas");
                    _Options.EmbedImagesInHTML = true;
                    _Options.ExportMode = HtmlExportMode.SingleFile;
                    gdMain.ExportToHtml(sfd.FileName,  _Options);
                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            err.setError = "Mensaje de prueba para envio por correo...!!!";
            err.sendEmail();
        }
    }
}
