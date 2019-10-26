using SistemaPOS.BLL;
using SistemaPOS.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_POS.UI.Consultas
{
    public partial class ConsultaFactura : Form
    {
        public ConsultaFactura()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            var Listado = new List<Factura>();
            RepositorioBase<Factura> repositorio = new RepositorioBase<Factura>();

            Listado = repositorio.GetList(p => true);

            ConsultadataGridView.DataSource = null;
            ConsultadataGridView.DataSource = Listado;
        }
    }
}
