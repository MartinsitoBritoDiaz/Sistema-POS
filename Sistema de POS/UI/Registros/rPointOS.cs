using Sistema_de_POS.BLL;
using Sistema_de_POS.Entidades;
using Sistema_de_POS.UI.Registros.ToolBox;
using SistemaPOS.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_POS.UI.Registros
{
    public partial class rPointOS : Form
    {
        public static int cantidadProductosBuscados = 0;

        public static int cantidadPOSBuscados = 0;
        public decimal Primero { get; set; }
        public decimal Segundo { get; set; }
        public string Operador { get; set; }

        public List<DetalleProductoPOS> detalle { get; set; }
        public rPointOS()
        {
            InitializeComponent();
            this.detalle = new List<DetalleProductoPOS>();
            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void Busquedabutton_Click(object sender, EventArgs e)
        {
            
            
        }

        private void ProductosMasVendidosbutton_Click(object sender, EventArgs e)
        {
            Form productosMasVendidos = new ProductosMasVendidos();
            productosMasVendidos.Show();
        }

        private void TipoDePagobutton_Click(object sender, EventArgs e)
        {
            Form formulario = new TipoDePago();
            formulario.Show();
        }
        public void CargarGrid()
        {
            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = this.detalle;
        }
        public void Limpiar()
        {
            IDNumericUpDown.Value = 0;
            TotalResultadolabel.Text = "0.00";
            SubtotalResultadolabel.Text = "0.00";
            ImpuestosResultadolabel.Text = "0.00";
            TotalResultadolabel.Text = "0.00";
            CantidadLabel.Text = "0.00";
            FechaDateTimePicker.Value = DateTime.Now;
            EfectivoRadioButton.Checked = true;

            this.detalle = new List<DetalleProductoPOS>();
            
            CargarGrid();
        }
        
        public POS LlenarClase()
        {
            POS pos = new POS();
            pos.PosId = Convert.ToInt32(IDNumericUpDown.Value);
            pos.Cantidad = Convert.ToInt32(CantidadLabel.Text);
            pos.Fecha = FechaDateTimePicker.Value;
            pos.Impuesto = Convert.ToDouble(ImpuestosResultadolabel.Text);
            pos.SubTotal = Convert.ToDouble(SubtotalResultadolabel.Text);
            pos.Total = Convert.ToDouble(TotalResultadolabel.Text);
            pos.Estado = false;

            if (TarjetaRadioButton.Checked)
                pos.TipoPago = "Tarjeta credito";
            else
                pos.TipoPago = "Efectivo";

            pos.ProductosPOS = this.detalle;

            CargarGrid();
            return pos;
        }

        public void LlenarCampo(POS pos)
        {
            IDNumericUpDown.Value = pos.PosId;
            CantidadLabel.Text = Convert.ToString(pos.Cantidad);
            ImpuestosResultadolabel.Text = Convert.ToString(pos.Impuesto);
            FechaDateTimePicker.Value = pos.Fecha.Date;
            SubtotalResultadolabel.Text = Convert.ToString(pos.SubTotal);
            TotalResultadolabel.Text = Convert.ToString(pos.Total);

            if (pos.TipoPago == "Tarjeta credito")
                TarjetaRadioButton.Checked = true;
            else
                EfectivoRadioButton.Checked = true;

            this.detalle = pos.ProductosPOS;
            CargarGrid();
        }

        public bool validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if(this.detalle.Count == 0)
            {
                MyErrorProvider.SetError(AgregarGridButton, "Debe agregar un producto");
                AgregarGridButton.Focus();
                paso = false;
            }

            return paso;
        }

        public bool ExisteEnLaBaseDeDatos()
        {
            POSRepositorio repo = new POSRepositorio();
            POS p = repo.Buscar((int)IDNumericUpDown.Value);
            return p != null;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;

            POSRepositorio repo = new POSRepositorio();
            POS p = new POS();

            if (!validar())
                return;

            p = LlenarClase();

            if (IDNumericUpDown.Value == 0)
                paso = repo.Guardar(p);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No esta registrado");
                    return;
                }
                paso = repo.Modificar(p);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado");
            }
            else
                MessageBox.Show("No fue posible guardar");
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IDNumericUpDown.Text, out id);
            POSRepositorio repo = new POSRepositorio();

            Limpiar();

            if(repo.Buscar(id)!= null)
            {
                if (repo.Eliminar(id))
                {
                    MessageBox.Show("Eliminado");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar");
                }
            }
            else
            {
                MessageBox.Show("No encontrado");
            }

        }

        private void AgregarGridButton_Click(object sender, EventArgs e)
        {
        }

        private void EliminarFilabutton_Click(object sender, EventArgs e)
        {
            
        }

        

        private void RPosForm_Load(object sender, EventArgs e)
        {
            ResultadotextBox.Text = "0";
            this.WindowState = FormWindowState.Maximized;

        }

        public void ProductoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void AplicarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            AplicarCheckBox.Checked = false;
            MyErrorProvider.Clear();

            if (cantidadProductosBuscados == 0)
            {
                MyErrorProvider.SetError(ProductosMasVendidosbutton, "Debe de registrar productos al sistema");
                BuscarProdcutoButton.Focus();
                return;
            }

            ProductoTextBox.Text = BusquedaProductos.listaProductoEnviar[0].Nombre;
        }

        private void Unobutton_Click(object sender, EventArgs e)
        {
            ResultadotextBox.Text += "1";
        }

        private void Dosbutton_Click(object sender, EventArgs e)
        {
            ResultadotextBox.Text += "2";
        }

        private void Tresbutton_Click(object sender, EventArgs e)
        {
            ResultadotextBox.Text += "3";
        }

        private void Cuatrobutton_Click(object sender, EventArgs e)
        { 
            ResultadotextBox.Text += "4";
        }

        private void Cincobutton_Click(object sender, EventArgs e)
        {
            ResultadotextBox.Text += "5";
        }

        private void Seisbutton_Click(object sender, EventArgs e)
        {
            ResultadotextBox.Text += "6";
        }

        private void Sietebutton_Click(object sender, EventArgs e)
        {
            ResultadotextBox.Text += "7";
        }

        private void Ochobutton_Click(object sender, EventArgs e)
        {
            ResultadotextBox.Text += "8";
        }

        private void Nuevebutton_Click(object sender, EventArgs e)
        {
            ResultadotextBox.Text += "9";
        }

        private void CEbutton_Click(object sender, EventArgs e)
        {
            ResultadotextBox.Text = string.Empty;
        }

        private void Sumabutton_Click(object sender, EventArgs e)
        {
            Operador = "+";
            Primero = decimal.Parse(ResultadotextBox.Text);
            ResultadotextBox.Value = 0;
        }

        private void Multiplicacionbutton_Click(object sender, EventArgs e)
        {
            Operador = "*";
            Primero = decimal.Parse(ResultadotextBox.Text);
            ResultadotextBox.Value = 0;
        }

        private void Restabutton_Click(object sender, EventArgs e)
        {
            Operador = "-";
            Primero = decimal.Parse(ResultadotextBox.Text);
            ResultadotextBox.Value = 0;
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            Operador = "/";
            Primero = decimal.Parse(ResultadotextBox.Text);
            ResultadotextBox.Value = 0;
        }

        private void IgualButton_Click(object sender, EventArgs e)
        {
            Segundo = decimal.Parse(ResultadotextBox.Text);
            decimal res = 0;

            switch (Operador)
            {
                case "+":
                    res = Primero + Segundo;
                    ResultadotextBox.Text = res.ToString();
                    break;
                case "*":
                    res = Primero * Segundo;
                    ResultadotextBox.Text = res.ToString();
                    break;
                case "-":
                    res = Primero - Segundo;
                    ResultadotextBox.Text = res.ToString();
                    break;
                case "/":

                    if (Primero == 0)
                        Primero = 1;

                    if (Segundo == 0)
                        Segundo = 1;

                    res = Primero / Segundo;
                    ResultadotextBox.Text = res.ToString();
                    break;
            }
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            ResultadotextBox.Value = 0;
        }

        private void Cerobutton_Click(object sender, EventArgs e)
        {
            ResultadotextBox.Text += "0";
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizarButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTituloPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTituloPanel_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
        

        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTituloPanel_MouseDown_2(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ResultadotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarGridButton_Click_1(object sender, EventArgs e)
        {
            if (!ValidarDetalle())
                return;

            if (DetalledataGridView.DataSource != null)
                this.detalle = (List<DetalleProductoPOS>)DetalledataGridView.DataSource;

            this.detalle.Add(

                new DetalleProductoPOS(
                    productId: 0,
                    descripcion: ProductoTextBox.Text,
                    cantidad: Convert.ToInt32(CantidadNumericUpDown.Value),
                    unidad: UnidadComboBox.Text,
                    precioUnitario: Convert.ToDouble(PrecioUnitarioTextBox.Text),
                    importe: (Convert.ToDouble(PrecioUnitarioTextBox.Text) * Convert.ToDouble(CantidadNumericUpDown.Value)),
                    posId: (int)IDNumericUpDown.Value
                    )
                );

            double subtotal = 0;
            double impuesto = 0;
            double total = 0;
            int cantidad = 0;

            foreach (var item in this.detalle)
            {
                subtotal += item.Importe;
                impuesto += Convert.ToDouble((item.Importe * (double)0.18));
                total = (subtotal + impuesto);
                cantidad += 1;
            }

            SubtotalResultadolabel.Text = (subtotal).ToString();
            ImpuestosResultadolabel.Text = (impuesto).ToString();
            TotalResultadolabel.Text = (total).ToString();
            CantidadLabel.Text = (cantidad).ToString();

            CantidadNumericUpDown.Value = 0;
            ProductoTextBox.Text = string.Empty;
            UnidadComboBox.Text = string.Empty;
            PrecioUnitarioTextBox.Text = string.Empty;
            ImporteTextBox.Text = string.Empty;

            AplicarCheckBox.Checked = false;
            CargarGrid();
        }

        private void CantidadNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            double cantidad = 0;
            double PrecioUnitario = 0;

            if (string.IsNullOrWhiteSpace(PrecioUnitarioTextBox.Text) && string.IsNullOrWhiteSpace(CantidadNumericUpDown.Text))
            {
                CantidadNumericUpDown.Value = 0;
                PrecioUnitarioTextBox.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(CantidadNumericUpDown.Text))
            {
                CantidadNumericUpDown.Value = 0;
            }
            if (string.IsNullOrWhiteSpace(PrecioUnitarioTextBox.Text))
            {
                PrecioUnitarioTextBox.Text = "0";
            }


            cantidad = Convert.ToDouble(CantidadNumericUpDown.Value);
            PrecioUnitario = Convert.ToDouble(PrecioUnitarioTextBox.Text);

            double Total = 0;
            Total = cantidad * PrecioUnitario;

            ImporteTextBox.Text = Convert.ToString(Total);
        }

        private void PrecioUnitarioTextBox_TextChanged(object sender, EventArgs e)
        {
            double cantidad = 0;
            double PrecioUnitario = 0;

            if (string.IsNullOrWhiteSpace(PrecioUnitarioTextBox.Text) && string.IsNullOrWhiteSpace(CantidadNumericUpDown.Text))
            {
                CantidadNumericUpDown.Value = 0;
                PrecioUnitarioTextBox.Text = "0";
            }

            if (string.IsNullOrWhiteSpace(CantidadNumericUpDown.Text))
            {
                CantidadNumericUpDown.Value = 0;
            }
            if (string.IsNullOrWhiteSpace(PrecioUnitarioTextBox.Text))
            {
                PrecioUnitarioTextBox.Text = "0";
            }

            cantidad = Convert.ToDouble(CantidadNumericUpDown.Value);
            PrecioUnitario = Convert.ToDouble(PrecioUnitarioTextBox.Text);

            double Total = 0;
            Total = cantidad * PrecioUnitario;

            ImporteTextBox.Text = Convert.ToString(Total);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (TarjetaRadioButton.Checked)
                EfectivoRadioButton.Checked = false;
            else
                EfectivoRadioButton.Checked = true;
        }

        private void TarjetaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (EfectivoRadioButton.Checked)
                TarjetaRadioButton.Checked = false;
            else
                TarjetaRadioButton.Checked = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();

            BusquedaProductos producto = new BusquedaProductos();
            producto.ShowDialog();


            if (cantidadProductosBuscados == 0)
            {
                MyErrorProvider.SetError(BuscarProdcutoButton, "Debe de registrar productos al sistema");
                BuscarProdcutoButton.Focus();
                return;
            }

            ProductoTextBox.Text = BusquedaProductos.listaProductoEnviar[0].Nombre;
        }

        private void ProductoTextBox_TextChanged(object sender, EventArgs e)
        {
            UnidadComboBox.DisplayMember = "Unidad";
            UnidadComboBox.DataSource = BusquedaProductos.listaProductoEnviar;
            PrecioUnitarioTextBox.Text = Convert.ToString(BusquedaProductos.listaProductoEnviar[0].PrecioUnitario);

        }

        private void LimpiarProducto()
        {
            ProductoTextBox.Text = string.Empty;
            CantidadNumericUpDown.Value = 0;
            UnidadComboBox.ResetText();
            PrecioUnitarioTextBox.Text = string.Empty;
            ImporteTextBox.Text = string.Empty;
        }
        //todo: Para validar el detalle
        private bool ValidarDetalle()
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if(Convert.ToInt32(CantidadNumericUpDown.Value) == 0)
            {
                MyErrorProvider.SetError(CantidadNumericUpDown, "La cantidad de productos a vender no puede ser 0");
                CantidadNumericUpDown.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ProductoTextBox.Text))
            {
                MyErrorProvider.SetError(ProductoTextBox, "Debe de seleccionar un producto para poder añadirlo a la lista de compra");
                ProductoTextBox.Focus();
                return false;
            }

            if (CantidadNumericUpDown.Value > BusquedaProductos.listaProductoEnviar[0].Existencia)
            {
                MyErrorProvider.SetError(CantidadNumericUpDown, "La cantidad de productos a vender debe ser menor o igual a la que hay en existencia");
                CantidadNumericUpDown.Focus();
                paso = false;
            }
            return paso;
        }

        private void EliminarFilabutton_Click_1(object sender, EventArgs e)
        {
            if (DetalledataGridView.Rows.Count > 0 && DetalledataGridView.CurrentRow != null)
            {
                detalle.RemoveAt(DetalledataGridView.CurrentRow.Index);

                CargarGrid();
            }
            else
                return;

            double subtotal = 0;
            double impuesto = 0;
            double total = 0;
            int cantidad = 0;

            foreach (var item in this.detalle)
            {
                subtotal += item.Importe;
                impuesto += Convert.ToDouble((double)(item.Importe * (double)0.18));
                total = (subtotal + impuesto);
                cantidad += 1;
            }

            SubtotalResultadolabel.Text = ("" + subtotal);
            ImpuestosResultadolabel.Text = ("" + impuesto);
            TotalResultadolabel.Text = ("" + total);
            CantidadLabel.Text = ("" + cantidad);

            CantidadNumericUpDown.Value = 0;
            UnidadComboBox.Text = string.Empty;
            PrecioUnitarioTextBox.Text = string.Empty;
            ImporteTextBox.Text = string.Empty;

            CargarGrid();
        }

        private void Busquedabutton_Click_1(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IDNumericUpDown.Text, out id);
            POSRepositorio repo = new POSRepositorio();
            POS p = new POS();
            p = repo.Buscar(id);

            Limpiar();

            if (p == null)
            {
                MessageBox.Show("No encontrado");
            }
            else
            {
                if(p.Estado == false)
                    LlenarCampo(p);
                else
                    MessageBox.Show("Ya este registro del pos esta cerrado en caja");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();

            BusquedaPOS busquedaPOS = new BusquedaPOS();
            busquedaPOS.ShowDialog();

            if (cantidadPOSBuscados == 0)
            {
                MyErrorProvider.SetError(BuscarRPOSButton, "Debe de registrar una venta al sistema para poder buscarla");
                BuscarProdcutoButton.Focus();
                return;
            }
            Limpiar();
            LlenarCampo(BusquedaPOS.listaPOSEnviar[0]);
        }
    }
}
