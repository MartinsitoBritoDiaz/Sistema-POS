using Sistema_de_POS.Entidades;
using SistemaPOS.BLL;
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

            if (IDNumericUpDown.Value != 0)
            {
                int id = Convert.ToInt32(IDNumericUpDown.Value);
                Listado = repositorio.GetList(c => c.FacturaId == id);
                Listado = Listado.Where(c => c.Fecha.Date >= DesdedateTimePicker.Value.Date && c.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
            }
            else if (IDClienteNumericUpDown.Value != 0)
            {
                int IDC = Convert.ToInt32(IDClienteNumericUpDown.Value.ToString());
                Listado = repositorio.GetList(c => c.ClienteId == IDC);

                Listado = Listado.Where(c => c.Fecha.Date >= DesdedateTimePicker.Value.Date && c.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
            }
            else if (!string.IsNullOrWhiteSpace(TotalTextBox.Text))
            {
                double total = Convert.ToDouble(TotalTextBox.Text);
                Listado = repositorio.GetList(c => c.Total == total);

                Listado = Listado.Where(c => c.Fecha.Date >= DesdedateTimePicker.Value.Date && c.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
            }
            else
                Listado = repositorio.GetList(p => true);


            ConsultadataGridView.DataSource = null;
            ConsultadataGridView.DataSource = Listado;
        }

        private void IDClienteNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
