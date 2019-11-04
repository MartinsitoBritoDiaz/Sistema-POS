using Sistema_de_POS.Entidades;
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

namespace Sistema_de_POS.UI.Registros
{
  
    public partial class RegistroFacturacion : Form
        {
     
            public List<DetalleProducto> Detalle { get; set; }
            public RegistroFacturacion()
            {
                InitializeComponent();
                this.Detalle = new List<DetalleProducto>();
            }
            public void CargarGrid()
            {
                DetalledataGridView.DataSource = null;
                DetalledataGridView.DataSource = this.Detalle;
            }
            public void Limpiar()
            {
                IDnumericUpDown.Value = 0;
                FechadateTimePicker.Value = DateTime.Now;
                ClientetextBox.Text = string.Empty;
                CondicioncomboBox.Text = string.Empty;
                TipoPagocomboBox.Text = string.Empty;
                CantidadnumericUpDown.Value = 0;
                DescripcionTextBox.Text = string.Empty;
                PrecioUnitariotextBox.Text = Convert.ToString("0");
                SubtotaltextBox.Text = Convert.ToString("0");
                DescuentostextBox.Text = Convert.ToString("0");
                TotalVentatextBox.Text = Convert.ToString("0");
                this.Detalle = new List<DetalleProducto>();

                CargarGrid();
            }

            private Factura LlenarClase()
            {
                Factura factura = new Factura();

                factura.Facturaid = Convert.ToInt32(IDnumericUpDown.Value);
                factura.Fecha = FechadateTimePicker.Value.Date;
                factura.Cliente = ClientetextBox.Text;
                factura.Condicion = CondicioncomboBox.Text;
                factura.TipoPago = TipoPagocomboBox.Text;
                factura.SubTotal = Convert.ToDecimal(SubtotaltextBox.Text);
                factura.Total = Convert.ToDecimal(TotalVentatextBox.Text);
                factura.Descuento = 0;

                factura.Productos = this.Detalle;

                return factura;
            }

            public void LlenarCampo(Factura factura)
            {
                IDnumericUpDown.Value = factura.Facturaid;
                FechadateTimePicker.Value = factura.Fecha;
                ClientetextBox.Text = factura.Cliente;
                CondicioncomboBox.Text = factura.Condicion;
                TipoPagocomboBox.Text = factura.TipoPago;
                SubtotaltextBox.Text = Convert.ToString(factura.SubTotal);
                TotalVentatextBox.Text = Convert.ToString(factura.Total);
                DescuentostextBox.Text = Convert.ToString(factura.Descuento);

                this.Detalle = factura.Productos;

            }
            
            public bool Validar()
            {
                bool paso = true;

                if (string.IsNullOrWhiteSpace(CondicioncomboBox.Text))
                {
                    MyErrorProvider.SetError(CondicioncomboBox, "El campo condicion no puede estar vacio");
                    CondicioncomboBox.Focus();
                    paso = false;
                }
                if (string.IsNullOrWhiteSpace(TipoPagocomboBox.Text))
                {
                    MyErrorProvider.SetError(TipoPagocomboBox, "El campo tipo de pago no puede estar vacio");
                    TipoPagocomboBox.Focus();
                    paso = false;
                }
                if (this.Detalle.Count == 0)
                {
                    MyErrorProvider.SetError(Agregarbutton, "Debe agregar al menos un producto");
                    Agregarbutton.Focus();
                    paso = false;
                }

                return paso;

            }

            public bool ExisteEnLaBaseDeDatos()
            {
                RepositorioBase<Factura> repositorio = new RepositorioBase<Factura>();
                Factura f = repositorio.Buscar((int)IDnumericUpDown.Value);
                return f != null;
            }

            private void Nuevobutton_Click(object sender, EventArgs e)
            {
                Limpiar();
            }

            private void Guardarbutton_Click(object sender, EventArgs e)
            {
                bool paso = false;
                Factura factura = new Factura();
                RepositorioBase<Factura> repositorio = new RepositorioBase<Factura>();
                FacturacionRepositorio f = new FacturacionRepositorio();

                if (!Validar())
                    return;

                factura = LlenarClase();

                if (IDnumericUpDown.Value == 0)
                    paso = repositorio.Guardar(factura);
                else
                {
                    if (!ExisteEnLaBaseDeDatos())
                    {
                        MessageBox.Show("No existe en la base de datos");
                        return;
                    }
                    f.Modificar(factura);
                }
                if (paso)
                {
                    MessageBox.Show("Guardado");
                }
                else
                {
                    MessageBox.Show("No fue posible guardar");
                }
            }

            private void Eliminarbutton_Click(object sender, EventArgs e)
            {
                MyErrorProvider.Clear();

                RepositorioBase<Factura> repositorio = new RepositorioBase<Factura>();
                int id;
                int.TryParse(IDnumericUpDown.Text, out id);

                Limpiar();

                if (repositorio.Eliminar(id))
                {
                    MessageBox.Show("Eliminado");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar");
                }
            }

            private void Buscarbutton_Click(object sender, EventArgs e)
            {
            }

            private void Agregarbutton_Click(object sender, EventArgs e)
            {
                
            }

        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {

        }

        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Nuevobutton_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IDnumericUpDown.Text, out id);

            Factura factura = new Factura();
            RepositorioBase<Factura> repositorio = new RepositorioBase<Factura>();

            factura = repositorio.Buscar(id);
            Limpiar();

            if (factura == null)
            {
                MessageBox.Show("No encontrado");
            }
            else
            {
                LlenarCampo(factura);
            }
        }

        private void PrecioUnitariotextBox_TextChanged(object sender, EventArgs e)
        {
            SubtotaltextBox.Text = Convert.ToString(Convert.ToDecimal(PrecioUnitariotextBox.Text)*(int)CantidadnumericUpDown.Value);
        }

        private void SubtotaltextBox_TextChanged(object sender, EventArgs e)
        {
            TotalVentatextBox.Text = Convert.ToString(Convert.ToDecimal(SubtotaltextBox.Text));
        }

        private void TotalVentatextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void ITBISTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DescuentostextBox_TextChanged(object sender, EventArgs e)
        {
            TotalVentatextBox.Text = Convert.ToString(Convert.ToDecimal(SubtotaltextBox.Text) - Convert.ToDecimal(DescuentostextBox.Text));
        }

        private void ClientegroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void RegistroFacturacion_Load(object sender, EventArgs e)
        {

        }

        private void UnidadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Nuevobutton_Click_2(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click_2(object sender, EventArgs e)
        {

            bool paso = false;
            Factura factura = new Factura();
            RepositorioBase<Factura> repositorio = new RepositorioBase<Factura>();
            FacturacionRepositorio f = new FacturacionRepositorio();

            if (!Validar())
                return;

            factura = LlenarClase();

            if (IDnumericUpDown.Value == 0)
                paso = repositorio.Guardar(factura);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No existe en la base de datos");
                    return;
                }
                f.Modificar(factura);
            }
            if (paso)
            {
                MessageBox.Show("Guardado");
            }
            else
            {
                MessageBox.Show("No fue posible guardar");
            }
        }

        private void Eliminarbutton_Click_2(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();

            RepositorioBase<Factura> repositorio = new RepositorioBase<Factura>();
            int id;
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            if (repositorio.Eliminar(id))
            {
                MessageBox.Show("Eliminado");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar");
            }
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {

        }

        private void Buscarbutton_Click_2(object sender, EventArgs e)
        {

            int id;
            int.TryParse(IDnumericUpDown.Text, out id);

            Factura factura = new Factura();
            RepositorioBase<Factura> repositorio = new RepositorioBase<Factura>();

            factura = repositorio.Buscar(id);
            Limpiar();

            if (factura == null)
            {
                MessageBox.Show("No encontrado");
            }
            else
            {
                LlenarCampo(factura);
            }
        }

        private void Agregarbutton_Click_1(object sender, EventArgs e)
        {
            if (DetalledataGridView.DataSource != null)
                this.Detalle = (List<DetalleProducto>)DetalledataGridView.DataSource;

            this.Detalle.Add(
                new DetalleProducto(
                    id: 0,
                    facturaid: Convert.ToInt32(IDnumericUpDown.Value),
                    cantidad: Convert.ToInt32(CantidadnumericUpDown.Value),
                    unidad: UnidadComboBox.Text,
                    descripcion: DescripcionTextBox.Text,
                    precioUnitario: Convert.ToDecimal(PrecioUnitariotextBox.Text),
                    importe: (Convert.ToDecimal(PrecioUnitariotextBox.Text) * Convert.ToDecimal(CantidadnumericUpDown.Value))
                    )

                );

            CargarGrid();
        }
    }
    }
