using CapaControlador_Seguridad;
using Microsoft.Reporting.WinForms;
using CapaControlador_Seguridad.Modelos_de_controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CapaVista_Seguridad.frmReportes
{
    public partial class FrmReporteTipoPuesto : Form
    {
        private ClsModeloTipoPuesto TipoPuesto = new ClsModeloTipoPuesto();

        public FrmReporteTipoPuesto()
        {
            InitializeComponent();
        }

        private void FrmReporteTipoPuesto_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource("DsTipoPuesto", TipoPuesto.TipoPuestoMetObtenerParaReporte());
            reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista_Seguridad.Reportes.ReporteTipoPuesto.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}