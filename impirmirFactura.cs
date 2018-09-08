using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace TALLER_DE_MODA
{
    public partial class impirmirFactura : Form
    {
        public impirmirFactura()
        {
            InitializeComponent();
        }

        private void impirmirFactura_Load(object sender, EventArgs e)
        {
            ReportDocument RD = new ReportDocument();
            impirmirFactura doc = new impirmirFactura();
            RD.Load(@"C:/Users/Beatriz/Desktop/copias seguridad/copia2/Proyecto1 moda/TALLER DE MODA/TALLER DE MODA/CrystalReport1.rpt");
            crystalReportViewer1.ReportSource = RD;
            crystalReportViewer1.Refresh();
        }
    }
}
