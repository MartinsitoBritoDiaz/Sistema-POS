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
    public partial class BusquedaPOS : Form
    {
        public static List<POS> listaPOSEnviar = new List<POS>();
        public BusquedaPOS()
        {
            InitializeComponent();
        }

        private void BusquedaPOS_Load(object sender, EventArgs e)
        {
            rPointOS.cantidadPOSBuscados = 0;
            RepositorioBase<POS> repositorio = new RepositorioBase<POS>();

            List<POS> lista = new List<POS>();

            lista = repositorio.GetList(l => true);

            POSDataGridView.DataSource = null;
            POSDataGridView.Rows.Clear();
            foreach (var item in lista)
                POSDataGridView.Rows.Add(false, item.PosId,item.Fecha,item.SubTotal,item.Impuesto,item.Total,item.Cantidad,item.TipoPago);
        }

        private List<POS> LlenarDataGridPOS()
        {
            listaPOSEnviar = new List<POS>();
            RepositorioBase<POS> repositorio = new RepositorioBase<POS>();

            foreach (DataGridViewRow row in POSDataGridView.Rows)
            {
                if ((Convert.ToBoolean(row.Cells[0].Value) == true))
                {
                    listaPOSEnviar.Add(repositorio.Buscar(Convert.ToInt32(row.Cells[1].Value)));
                    rPointOS.cantidadPOSBuscados = 1;
                }
            }

            if (rPointOS.cantidadPOSBuscados == 0)
                listaPOSEnviar = null;

            return listaPOSEnviar;
        }

        private bool Validar()
        {
            MyErrorProvider.Clear();
            int cantidadAgregar = 0;

            foreach (DataGridViewRow row in POSDataGridView.Rows)
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
                    MyErrorProvider.SetError(Agregarbutton, "Debe de seleccionar un registro de pos a agregar");
                    Agregarbutton.Focus();
                    return false;
                }
                else
                {
                    MyErrorProvider.SetError(Agregarbutton, "No puede seleccionar mas de un registro de pos para agregarlo");
                    Agregarbutton.Focus();
                    return false;
                }
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;

            LlenarDataGridPOS();

            this.Close();
        }
    }
}
