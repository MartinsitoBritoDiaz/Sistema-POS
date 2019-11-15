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
    public partial class RPosForm : Form
    {
        
        public decimal Primero { get; set; }
        public decimal Segundo { get; set; }
        public string Operador { get; set; }

        public List<DetalleProductoPOS> detalle { get; set; }
        public RPosForm()
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
            int id;
            int.TryParse(IDNumericUpDown.Text, out id);
            RepositorioBase<POS> repo = new RepositorioBase<POS>();
            POS p = new POS();
            p = repo.Buscar(id);

            Limpiar();

            if(p == null)
            {
                MessageBox.Show("No encontrado");
            }
            else
            {
                LlenarCampo(p);
            }
            
        }

        private void ProductosMasVendidosbutton_Click(object sender, EventArgs e)
        {
            Form formulario = new ProductosMasVendidos();
            formulario.Show();
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
            CajeroTextBox.Text = string.Empty;
            TotalResultadolabel.Text = "0.00";
            ImpuestosResultadolabel.Text = "0.00";
            ITBISLabel.Text = "0.00";
            TotalResultadolabel.Text = "0.00";
            CantidadLabel.Text = "0.00";
            FechaDateTimePicker.Value = DateTime.Now;

            this.detalle = new List<DetalleProductoPOS>();
            
            CargarGrid();
        }
        
        public POS LlenarClase()
        {
            POS p = new POS();

            p.POSid = Convert.ToInt32(IDNumericUpDown.Value);
            p.Cajero = CajeroTextBox.Text;
            p.Cantidad = Convert.ToInt32(CantidadLabel.Text);
            p.Fecha = FechaDateTimePicker.Value;
            p.Descuentos = Convert.ToDecimal(ImpuestosResultadolabel.Text);
            p.ITBIS = Convert.ToDecimal(ITBISLabel.Text);
            p.SubTotal = Convert.ToDecimal(SubtotalResultadolabel.Text);
            p.Total = Convert.ToDecimal(TotalResultadolabel.Text);

            if (TarjetaRadioButton.Checked)
                p.TipoPago = "Tarjeta credito";
            else
                p.TipoPago = "Efectivo";
            p.ProductosPOS = this.detalle;
            p.Usuario = rLogin.UsuarioActual.UsuarioId;
            p.NombreUsuario = rLogin.UsuarioActual.Nombre;
            CargarGrid();
            return p;
        }

        public void LlenarCampo(POS p)
        {
            IDNumericUpDown.Value = p.POSid;
            CajeroTextBox.Text = p.Cajero;
            CantidadLabel.Text = Convert.ToString(p.Cantidad);
            ImpuestosResultadolabel.Text = Convert.ToString(p.Descuentos);
            FechaDateTimePicker.Value = p.Fecha.Date;
            ITBISLabel.Text = Convert.ToString(p.ITBIS);
            SubtotalResultadolabel.Text = Convert.ToString(p.SubTotal);
            TotalResultadolabel.Text = Convert.ToString(p.Total);

            this.detalle = p.ProductosPOS;
        
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
            RepositorioBase<POS> repo = new RepositorioBase<POS>();
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
            RepositorioBase<POS> repo = new RepositorioBase<POS>();

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
            if(DetalledataGridView.Rows.Count > 0 && DetalledataGridView.CurrentRow!= null)
            {
                detalle.RemoveAt(DetalledataGridView.CurrentRow.Index);

                CargarGrid();
            }

            decimal subtotal = 0;
            decimal descuentos = 0;
            decimal ITBIS = 0;
            decimal total = 0;
            int cantidad = 0;

            foreach (var item in this.detalle)
            {
                subtotal += item.importe;
                descuentos = 0;
                ITBIS += (decimal)(item.importe * (decimal)0.18);
                total += subtotal - descuentos - ITBIS;
                cantidad += 1;
            }

            SubtotalResultadolabel.Text = ("$" + subtotal);
            ImpuestosResultadolabel.Text = ("$" + descuentos);
            ITBISLabel.Text = ("$" + ITBIS);
            TotalResultadolabel.Text = ("$" + total);
            CantidadLabel.Text = ("" + cantidad);

            CantidadNumericUpDown.Value = 0;
            UnidadComboBox.Text = string.Empty;
            PrecioUnitarioTextBox.Text = string.Empty;
            ImporteTextBox.Text = string.Empty;

            CargarGrid();
        }

        private void AgregarProductoButton_Click(object sender, EventArgs e)
        {
            Form formulario = new RegistroProductos();
            formulario.ShowDialog();

            ProductoComboBox.Items.Clear();

            RepositorioBase<Articulo> repo = new RepositorioBase<Articulo>();

            var Lista = repo.GetList(p => true);

            foreach (var item in Lista)
            {
                ProductoComboBox.Items.Add(item.Descripcion);
            }
        }

        private void RPosForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            CajeroTextBox.Text = rLogin.UsuarioActual.Nombre;
           /*RepositorioBase<Articulo> repo = new RepositorioBase<Articulo>();

            var Lista = repo.GetList(p => true);

            foreach (var item in Lista)
            {
                ProductoComboBox.Items.Add(item.Descripcion);
            }*/
        }

        public void ProductoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void AplicarCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            RepositorioBase<ArticuloMV> repo = new RepositorioBase<ArticuloMV>();

            var Lista = repo.GetList(p => true);

            foreach (var item in Lista)
            {
                if (item.code == 1)
                {
                    ProductoComboBox.Text = item.Descripcion;
                }
            }

            foreach (var item in Lista)
            {
                repo.Eliminar(item.ArticuloMVid);
            }
        }

        private void Finbutton_Click(object sender, EventArgs e)
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

            this.Close();
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
            ResultadotextBox.Clear();
        }

        private void Multiplicacionbutton_Click(object sender, EventArgs e)
        {
            Operador = "*";
            Primero = decimal.Parse(ResultadotextBox.Text);
            ResultadotextBox.Clear();
        }

        private void Restabutton_Click(object sender, EventArgs e)
        {
            Operador = "-";
            Primero = decimal.Parse(ResultadotextBox.Text);
            ResultadotextBox.Clear();
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            Operador = "/";
            Primero = decimal.Parse(ResultadotextBox.Text);
            ResultadotextBox.Clear();
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
                    res = Primero / Segundo;
                    ResultadotextBox.Text = res.ToString();
                    break;
            }
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            ResultadotextBox.Clear();
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

            if (DetalledataGridView.DataSource != null)
                this.detalle = (List<DetalleProductoPOS>)DetalledataGridView.DataSource;

            this.detalle.Add(

                new DetalleProductoPOS(
                    id: 0,
                    POSid: (int)IDNumericUpDown.Value,
                    cantidad: Convert.ToInt32(CantidadNumericUpDown.Value),
                    unidad: UnidadComboBox.Text,
                    descripcion: ProductoComboBox.Text,
                    precioUnitario: Convert.ToDecimal(PrecioUnitarioTextBox.Text),
                    importe: (Convert.ToDecimal(PrecioUnitarioTextBox.Text) * Convert.ToDecimal(CantidadNumericUpDown.Value))

                    )

                );
            decimal subtotal = 0;
            decimal descuentos = 0;
            decimal ITBIS = 0;
            decimal total = 0;
            int cantidad = 0;

            foreach (var item in this.detalle)
            {
                subtotal += item.importe;
                descuentos = 0;
                ITBIS += (decimal)(item.importe * (decimal)0.18);
                total += subtotal - descuentos - ITBIS;
                cantidad += 1;
            }

            SubtotalResultadolabel.Text = (subtotal).ToString();
            ImpuestosResultadolabel.Text = (descuentos).ToString();
            ITBISLabel.Text = (ITBIS).ToString();
            TotalResultadolabel.Text = (total).ToString();
            CantidadLabel.Text = (cantidad).ToString();

            CantidadNumericUpDown.Value = 0;
            UnidadComboBox.Text = string.Empty;
            PrecioUnitarioTextBox.Text = string.Empty;
            ImporteTextBox.Text = string.Empty;

            AplicarCheckBox.Checked = false;
            CargarGrid();
        }

        private void CantidadNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal cantidad = 0;
            decimal PrecioUnitario = 0;

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


            cantidad = Convert.ToDecimal(CantidadNumericUpDown.Value);
            PrecioUnitario = Convert.ToDecimal(PrecioUnitarioTextBox.Text);

            decimal Total = 0;
            Total = cantidad * PrecioUnitario;

            ImporteTextBox.Text = Convert.ToString(Total);
        }

        private void PrecioUnitarioTextBox_TextChanged(object sender, EventArgs e)
        {
            decimal cantidad = 0;
            decimal PrecioUnitario = 0;

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


            cantidad = Convert.ToDecimal(CantidadNumericUpDown.Value);
            PrecioUnitario = Convert.ToDecimal(PrecioUnitarioTextBox.Text);

            decimal Total = 0;
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
    }
}
