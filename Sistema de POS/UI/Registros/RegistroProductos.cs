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

namespace Sistema_de_POS.UI.Registros
{
    public partial class RegistroProductos : Form
    {
        public RegistroProductos()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            IDNumericUpDown.Value = 0;
            ArticuloTextBox.Text = string.Empty;
        }
        public void LlenarCampo(Articulo art)
        {
            IDNumericUpDown.Value = art.Articuloid;
            ArticuloTextBox.Text = art.Descripcion;
        }
        public Articulo LlenarClase()
        {
            Articulo art = new Articulo();

            art.Articuloid = Convert.ToInt32(IDNumericUpDown.Value);
            art.Descripcion = ArticuloTextBox.Text;

            return art;
        }
        public bool validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if (string.IsNullOrWhiteSpace(ArticuloTextBox.Text))
            {
                MyErrorProvider.SetError(ArticuloTextBox, "El campo articulo no puede estar vacio");
                ArticuloTextBox.Focus();
                paso = false;
            }
            return paso;
        }
        public bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Articulo> repo = new RepositorioBase<Articulo>();
            Articulo art = repo.Buscar((int)IDNumericUpDown.Value);
            return art != null;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            RepositorioBase<Articulo> repo = new RepositorioBase<Articulo>();
            Articulo art = new Articulo();

            if (!validar())
                return;

            art = LlenarClase();

            if (IDNumericUpDown.Value == 0)
                paso = repo.Guardar(art);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No esta registrado");
                    return;
                }
                paso = repo.Modificar(art);
            }
            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado");
            }
            else
            {
                MessageBox.Show("No fue posible guardar");
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IDNumericUpDown.Text, out id);
            RepositorioBase<Articulo> repo = new RepositorioBase<Articulo>();
            Articulo art = repo.Buscar(id);

            Limpiar();

            if (art == null)
            {
                MessageBox.Show("No encontrado");
            }
            else
            {
                LlenarCampo(art);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();

            int id;
            int.TryParse(IDNumericUpDown.Text, out id);
            RepositorioBase<Articulo> repo = new RepositorioBase<Articulo>();

            Limpiar();

            if (repo.Buscar(id)!=null)
            {
                if (repo.Eliminar(id))
                {
                    MessageBox.Show("Eliminado");
                }
                else
                {
                    MessageBox.Show("No fue posible eliminar");
                }
            }
            else
            {
                MessageBox.Show("No fue encontrado");
            }
        }
    }
}
