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
    public partial class BusquedaProductos : Form
    {
        public static List<Producto> listaProductoEnviar = new List<Producto>();
        public BusquedaProductos()
        {
            InitializeComponent();
        }

        private void BusquedaProductos_Load(object sender, EventArgs e)
        {
            rPointOS.cantidadProductosBuscados = 0;
            RepositorioBase<Producto> repositorio = new RepositorioBase<Producto>();

            List<Producto> lista = new List<Producto>();

            lista = repositorio.GetList(l => true);

            ProductosDataGridView.DataSource = null;
            ProductosDataGridView.Rows.Clear();
            foreach (var item in lista)
                ProductosDataGridView.Rows.Add(false, item.ProductoId, item.Nombre);
        }
        private List<Producto> LlenarTextBoxProductos()
        {
            listaProductoEnviar = new List<Producto>();
            RepositorioBase<Producto> repositorio = new RepositorioBase<Producto>();

            foreach (DataGridViewRow row in ProductosDataGridView.Rows)
            {
                if ((Convert.ToBoolean(row.Cells[0].Value) == true))
                {
                    listaProductoEnviar.Add(repositorio.Buscar(Convert.ToInt32(row.Cells[1].Value)));
                    rPointOS.cantidadProductosBuscados = 1;
                }
            }

            rFacturacion.productosBuscados = rPointOS.cantidadPOSBuscados;

            if (rPointOS.cantidadProductosBuscados == 0)
                listaProductoEnviar = null;

            rFacturacion.productosBuscados = 1;

            return listaProductoEnviar;
        }

        private bool Validar()
        {
            MyErrorProvider.Clear();   
            int cantidadAgregar = 0;

            foreach (DataGridViewRow row in ProductosDataGridView.Rows)
            {
                if ((Convert.ToBoolean(row.Cells[0].Value) == true))
                {
                    cantidadAgregar += 1;
                }
            }

            if (cantidadAgregar == 1)
                return true;
            else    
                if(cantidadAgregar == 0)
                {
                    MyErrorProvider.SetError(Agregarbutton, "Debe de seleccionar un producto a agregar");
                    Agregarbutton.Focus();
                    return false;
                }
                else
                {
                    MyErrorProvider.SetError(Agregarbutton, "No puede seleccionar mas de un producto para agregarlo");
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

        private void ProductosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
