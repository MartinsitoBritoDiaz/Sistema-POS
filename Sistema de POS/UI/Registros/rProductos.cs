using Sistema_de_POS.Entidades;
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
    public partial class rProductos : Form
    {
        public rProductos()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Label_Click(object sender, EventArgs e)
        {

        }

        private void RProductos_Load(object sender, EventArgs e)
        {

        }

        private void MinimizarButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Limpiar()
        {
            MyErrorProvider.Clear();
            IDnumericUpDown.Value = 0;
            NombreTextBox.Text = string.Empty;
            PrecioTextBox.Text = string.Empty;
            CategoriaComboBox.ResetText();
            UnidadComboBox.ResetText();
            ImpuestoTextBox.Text = string.Empty;
            ExistenciaTextBox.Text = string.Empty;
        }

        private void LlenaCampos(Producto producto)
        {
            IDnumericUpDown.Value = producto.ProductoId;
            NombreTextBox.Text = producto.Nombre;
            PrecioTextBox.Text = Convert.ToString(producto.PrecioUnitario);
            CategoriaComboBox.Text = producto.Categoria;
            UnidadComboBox.Text = producto.Unidad;
            ImpuestoTextBox.Text = Convert.ToString(producto.Impuesto);
            ExistenciaTextBox.Text = Convert.ToString(producto.Existencia);
        }

        private Producto LlenaClase()
        {
            Producto producto = new Producto();
            producto.ProductoId = Convert.ToInt32(IDnumericUpDown.Value);
            producto.Nombre = NombreTextBox.Text;
            producto.Categoria = CategoriaComboBox.Text;
            producto.PrecioUnitario = Convert.ToDouble(PrecioTextBox.Text);
            producto.Existencia = Convert.ToInt32(ExistenciaTextBox.Text);
            producto.Unidad = UnidadComboBox.Text;
            producto.Impuesto = Convert.ToDouble(ImpuestoTextBox.Text);
            return producto;
        }

        private bool Validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                MyErrorProvider.SetError(NombreTextBox, "El campo nombre no puede estar vacio");
                NombreTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CategoriaComboBox.Text))
            {
                MyErrorProvider.SetError(CategoriaComboBox, "Debe de seleccionar una categoria");
                CategoriaComboBox.Focus();
                paso = false;
            }


            if (string.IsNullOrWhiteSpace(PrecioTextBox.Text))
            {
                MyErrorProvider.SetError(PrecioTextBox, "El campo precio no puede estar vacio");
                PrecioTextBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(ExistenciaTextBox.Text))
            {
                MyErrorProvider.SetError(ExistenciaTextBox, "El campo existencia no puede estar vacio");
                ExistenciaTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(UnidadComboBox.Text))
            {
                MyErrorProvider.SetError(UnidadComboBox, "Debe de seleccionar una categoria");
                UnidadComboBox.Focus();
                paso = false;
            }

            if(Convert.ToDouble(PrecioTextBox.Text) <= 0)
            {
                MyErrorProvider.SetError(PrecioTextBox, "El campo precio no puede ser mejor que 0");
                PrecioTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Producto> repositorio = new RepositorioBase<Producto>();

            Producto producto = repositorio.Buscar((int)IDnumericUpDown.Value);

            return (producto != null);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Producto> repositorio = new RepositorioBase<Producto>();

            int id;
            int.TryParse(Convert.ToString(IDnumericUpDown.Value), out id);

            Producto producto = repositorio.Buscar(id);
            Limpiar();

            if (producto != null)
            {
                repositorio.Eliminar(id);
                MessageBox.Show("Eliminado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MyErrorProvider.SetError(IDnumericUpDown, "No se puede eliminar un producto que no existe");
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Producto> repositorio = new RepositorioBase<Producto>();
            Producto productoSelecionado = new Producto();

            bool interruptor = true;

            if ((string.IsNullOrWhiteSpace(NombreTextBox.Text))){
                int id;
                int.TryParse(Convert.ToString(IDnumericUpDown.Value), out id);

                Producto producto = repositorio.Buscar(id);
                Limpiar();

                if (producto != null)
                {
                    LlenaCampos(producto);
                }
                else
                    MyErrorProvider.SetError(IDnumericUpDown, "No se puede buscar un producto que no existe");
            }
            else
            {
                foreach (var item in repositorio.GetList(p => true))
                {
                    if (NombreTextBox.Text.Contains(item.Nombre))
                    {
                        productoSelecionado = item;
                        interruptor = false;
                        break;
                    }
                }

                Limpiar();

                if (!interruptor)
                {
                    LlenaCampos(productoSelecionado);
                }
                else
                {
                    MyErrorProvider.SetError(NombreTextBox, "No se puede Buscar un producto que no existe");
                }
            }
        }

        private void PrecioTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(PrecioTextBox.Text)))
            {
                if(Convert.ToDouble(PrecioTextBox.Text) > 0)
                    ImpuestoTextBox.Text = Convert.ToString(Convert.ToDouble(PrecioTextBox.Text) * 0.18);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IDnumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UnidadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CelularLabel_Click(object sender, EventArgs e)
        {

        }

        private void Label_Click_1(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;

            RepositorioBase<Producto> repositorio = new RepositorioBase<Producto>();

            if (!Validar())
                return;

            Producto producto = LlenaClase();

            if (IDnumericUpDown.Value == 0)
                paso = repositorio.Guardar(producto);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se encuentra el producto a modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                paso = repositorio.Modificar(producto);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se puede guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BarraTituloPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTituloPanel_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
