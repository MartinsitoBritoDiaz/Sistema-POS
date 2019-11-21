using Sistema_de_POS.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_POS.UI.Reportes
{
    public partial class VentasPOSReportViewer : Form
    {
        private List<POS> ListaVentasPOS { get; set; }

        public VentasPOSReportViewer(List<POS> ventas)
        {
            this.ListaVentasPOS = ventas;
            InitializeComponent();
        }

        private void VentasPOSReportViewer_Load(object sender, EventArgs e)
        {
            ReporteVentasPOSCrystalReport listadoVentas = new ReporteVentasPOSCrystalReport();
            listadoVentas.SetDataSource(ListaVentasPOS);

            MycrystalReportViewer.ReportSource = listadoVentas;
            MycrystalReportViewer.Refresh();
        }
    }
}
