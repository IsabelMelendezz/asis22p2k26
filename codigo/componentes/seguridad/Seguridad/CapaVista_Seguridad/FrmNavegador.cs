using CapaVista_Seguridad.frmReportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Seguridad
{
    public partial class FrmNavegador : Form
    {
        public FrmNavegador()
        {
            InitializeComponent();
            navegador1.NavegadorMetConfigurar("tipo_puesto", 4, 17);
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }

        private void SeguridadbtnReporte_Click(object sender, EventArgs e)
        {
            FrmReporteVideo reporte = new FrmReporteVideo();
            reporte.Show();
        }

        private void SeguridadbtnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/SeguridadAyudas/SeguridadAyudas.chm", "AsigAplPerfiles_Seguridad.html");
        }
    }
}
