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
    public partial class ProductosMasVendidos : Form
    {
        public ProductosMasVendidos()
        {
            InitializeComponent();
        }

        private void ManzanaButton_Click(object sender, EventArgs e)
        {
            ArticuloMV articulo = new ArticuloMV();
            RepositorioBase<ArticuloMV> repo = new RepositorioBase<ArticuloMV>();

            articulo.Descripcion = "Manzana";
            articulo.code = 1;

            repo.Guardar(articulo);
            this.Close();
        }

        private void AjiesButton_Click(object sender, EventArgs e)
        {
            ArticuloMV articulo = new ArticuloMV();
            RepositorioBase<ArticuloMV> repo = new RepositorioBase<ArticuloMV>();

            articulo.Descripcion = "Ajies";
            articulo.code = 1;

            repo.Guardar(articulo);
            this.Close();
        }

        private void PlatanoButton_Click(object sender, EventArgs e)
        {
            ArticuloMV articulo = new ArticuloMV();
            RepositorioBase<ArticuloMV> repo = new RepositorioBase<ArticuloMV>();

            articulo.Descripcion = "Platano";
            articulo.code = 1;

            repo.Guardar(articulo);
            this.Close();
        }

        private void CebollaButton_Click(object sender, EventArgs e)
        {
            ArticuloMV articulo = new ArticuloMV();
            RepositorioBase<ArticuloMV> repo = new RepositorioBase<ArticuloMV>();

            articulo.Descripcion = "Cebolla";
            articulo.code = 1;

            repo.Guardar(articulo);
            this.Close();
        }

        private void LimonButton_Click(object sender, EventArgs e)
        {
            ArticuloMV articulo = new ArticuloMV();
            RepositorioBase<ArticuloMV> repo = new RepositorioBase<ArticuloMV>();

            articulo.Descripcion = "Limon";
            articulo.code = 1;

            repo.Guardar(articulo);
            this.Close();
        }

        private void NaranjaButton_Click(object sender, EventArgs e)
        {
            ArticuloMV articulo = new ArticuloMV();
            RepositorioBase<ArticuloMV> repo = new RepositorioBase<ArticuloMV>();

            articulo.Descripcion = "Naranja";
            articulo.code = 1;

            repo.Guardar(articulo);
            this.Close();
        }

        private void QuesoButton_Click(object sender, EventArgs e)
        {
            ArticuloMV articulo = new ArticuloMV();
            RepositorioBase<ArticuloMV> repo = new RepositorioBase<ArticuloMV>();

            articulo.Descripcion = "Queso de hoja";
            articulo.code = 1;

            repo.Guardar(articulo);
            this.Close();
        }

        private void PimentonButton_Click(object sender, EventArgs e)
        {
            ArticuloMV articulo = new ArticuloMV();
            RepositorioBase<ArticuloMV> repo = new RepositorioBase<ArticuloMV>();

            articulo.Descripcion = "Pimenton";
            articulo.code = 1;

            repo.Guardar(articulo);
            this.Close();
        }

        private void PolloButton_Click(object sender, EventArgs e)
        {
            ArticuloMV articulo = new ArticuloMV();
            RepositorioBase<ArticuloMV> repo = new RepositorioBase<ArticuloMV>();

            articulo.Descripcion = "Pollo";
            articulo.code = 1;

            repo.Guardar(articulo);
            this.Close();
        }

        private void ResButton_Click(object sender, EventArgs e)
        {
            ArticuloMV articulo = new ArticuloMV();
            RepositorioBase<ArticuloMV> repo = new RepositorioBase<ArticuloMV>();

            articulo.Descripcion = "Carne de res";
            articulo.code = 1;

            repo.Guardar(articulo);
            this.Close();
        }

        private void CilantroButton_Click(object sender, EventArgs e)
        {
            ArticuloMV articulo = new ArticuloMV();
            RepositorioBase<ArticuloMV> repo = new RepositorioBase<ArticuloMV>();

            articulo.Descripcion = "Cilantro";
            articulo.code = 1;

            repo.Guardar(articulo);
            this.Close();
        }

        private void HuevosButton_Click(object sender, EventArgs e)
        {
            ArticuloMV articulo = new ArticuloMV();
            RepositorioBase<ArticuloMV> repo = new RepositorioBase<ArticuloMV>();

            articulo.Descripcion = "Huevos";
            articulo.code = 1;

            repo.Guardar(articulo);
            this.Close();
        }

        private void SalamiCorrienteButton_Click(object sender, EventArgs e)
        {
            ArticuloMV articulo = new ArticuloMV();
            RepositorioBase<ArticuloMV> repo = new RepositorioBase<ArticuloMV>();

            articulo.Descripcion = "Salami Corriente";
            articulo.code = 1;

            repo.Guardar(articulo);
            this.Close();
        }

        private void HieloButton_Click(object sender, EventArgs e)
        {
            ArticuloMV articulo = new ArticuloMV();
            RepositorioBase<ArticuloMV> repo = new RepositorioBase<ArticuloMV>();

            articulo.Descripcion = "Hielo";
            articulo.code = 1;

            repo.Guardar(articulo);

            this.Close();
        }

        private void PiñaButton_Click(object sender, EventArgs e)
        {
            ArticuloMV articulo = new ArticuloMV();
            RepositorioBase<ArticuloMV> repo = new RepositorioBase<ArticuloMV>();

            articulo.Descripcion = "Piña";
            articulo.code = 1;

            repo.Guardar(articulo);
            this.Close();
        }
    }
}
