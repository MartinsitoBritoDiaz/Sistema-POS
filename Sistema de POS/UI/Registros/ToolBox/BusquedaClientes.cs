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

namespace Sistema_de_POS.UI.Registros.ToolBox
{
    public partial class BusquedaClientes : Form
    {

        public static List<Cliente> listaClientesEnviar = new List<Cliente>();
        public BusquedaClientes()
        {
            InitializeComponent();
        }

        private void BusquedaClientes_Load(object sender, EventArgs e)
        {
            rFacturacion.clientesBuscados = 0;
            RepositorioBase<Cliente> repositorio = new RepositorioBase<Cliente>();

            List<Cliente> lista = new List<Cliente>();

            lista = repositorio.GetList(l => true);

            ClientesDataGridView.DataSource = null;
            ClientesDataGridView.Rows.Clear();

            foreach (var item in lista)
                ClientesDataGridView.Rows.Add(false, item.ClienteId, item.Nombre);
        }

        private List<Cliente> LlenarTextBoxProductos()
        {
            listaClientesEnviar = new List<Cliente>();
            RepositorioBase<Cliente> repositorio = new RepositorioBase<Cliente>();

            foreach (DataGridViewRow row in ClientesDataGridView.Rows)
            {
                if ((Convert.ToBoolean(row.Cells[0].Value) == true))
                {
                    listaClientesEnviar.Add(repositorio.Buscar(Convert.ToInt32(row.Cells[1].Value)));
                    rFacturacion.clientesBuscados = 1;
                }
            }

            if (rFacturacion.clientesBuscados == 0)
                listaClientesEnviar = null;


            return listaClientesEnviar;
        }


        private bool Validar()
        {
            MyErrorProvider.Clear();
            int cantidadAgregar = 0;

            foreach (DataGridViewRow row in ClientesDataGridView.Rows)
            {
                if ((Convert.ToBoolean(row.Cells[0].Value) == true))
                {
                    cantidadAgregar += 1;
                }
            }

            if (cantidadAgregar == 1)
                return true;
            else
                if (cantidadAgregar == 0)
            {
                MyErrorProvider.SetError(Agregarbutton, "Debe de seleccionar un cliente a agregar");
                Agregarbutton.Focus();
                return false;
            }
            else
            {
                MyErrorProvider.SetError(Agregarbutton, "No puede seleccionar mas de un cliente para agregarlo");
                Agregarbutton.Focus();
                return false;
            }

        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;

            LlenarTextBoxProductos();

            this.Close();
        }
    }
}
