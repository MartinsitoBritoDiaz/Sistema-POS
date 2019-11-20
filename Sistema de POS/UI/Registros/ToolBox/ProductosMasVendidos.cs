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
            bool interruptor = true;

            Producto producto = new Producto();
            RepositorioBase<Producto> repo = new RepositorioBase<Producto>();
            BusquedaProductos.listaProductoEnviar = new List<Producto>();

            foreach (var item in repo.GetList(p => true))
            {
                if (item.Nombre.CompareTo("Manzana") == 0)
                {
                    BusquedaProductos.listaProductoEnviar.Add(item);
                    interruptor = false;
                }
            }

            if (interruptor)
            {
                producto.ProductoId = 0;
                producto.Nombre = "Manzana";
                producto.Existencia = 100;
                producto.PrecioUnitario = 30;
                producto.Impuesto = (30 * 0.18);
                producto.Unidad = "Unidades";
                producto.Categoria = "Comestible";


                repo.Guardar(producto);

                BusquedaProductos.listaProductoEnviar.Add(producto);
            }

            rPointOS.cantidadProductosBuscados = 1;

            this.Close();
        }

        private void AjiesButton_Click(object sender, EventArgs e)
        {
            bool interruptor = true;

            Producto producto = new Producto();
            RepositorioBase<Producto> repo = new RepositorioBase<Producto>();
            BusquedaProductos.listaProductoEnviar = new List<Producto>();

            foreach (var item in repo.GetList(p => true))
            {
                if (item.Nombre.CompareTo("Ajies") == 0)
                {
                    BusquedaProductos.listaProductoEnviar.Add(item);
                    interruptor = false;
                }
            }

            if (interruptor)
            {
                producto.ProductoId = 0;
                producto.Nombre = "Ajies";
                producto.Existencia = 100;
                producto.PrecioUnitario = 25;
                producto.Impuesto = (25 * 0.18);
                producto.Unidad = "Unidades";
                producto.Categoria = "Comestible";

                repo.Guardar(producto);

                BusquedaProductos.listaProductoEnviar.Add(producto);
            }

            rPointOS.cantidadProductosBuscados = 1;
            this.Close();
        }

        private void PlatanoButton_Click(object sender, EventArgs e)
        {
            bool interruptor = true;

            Producto producto = new Producto();
            RepositorioBase<Producto> repo = new RepositorioBase<Producto>();
            BusquedaProductos.listaProductoEnviar = new List<Producto>();

            foreach (var item in repo.GetList(p => true))
            {
                if (item.Nombre.CompareTo("Platano") == 0)
                {
                    BusquedaProductos.listaProductoEnviar.Add(item);
                    interruptor = false;
                }
            }

            if (interruptor)
            {
                producto.ProductoId = 0;
                producto.Nombre = "Platano";
                producto.Existencia = 100;
                producto.PrecioUnitario = 12;
                producto.Impuesto = (12 * 0.18);
                producto.Unidad = "Unidades";
                producto.Categoria = "Comestible";

                repo.Guardar(producto);

                BusquedaProductos.listaProductoEnviar.Add(producto);
            }

            rPointOS.cantidadProductosBuscados = 1;

            this.Close();
        }

        private void CebollaButton_Click(object sender, EventArgs e)
        {
            bool interruptor = true;

            Producto producto = new Producto();
            RepositorioBase<Producto> repo = new RepositorioBase<Producto>();
            BusquedaProductos.listaProductoEnviar = new List<Producto>();

            foreach (var item in repo.GetList(p => true))
            {
                if (item.Nombre.CompareTo("Cebolla") == 0)
                {
                    BusquedaProductos.listaProductoEnviar.Add(item);
                    interruptor = false;
                }
            }

            if (interruptor)
            {
                producto.ProductoId = 0;
                producto.Nombre = "Cebolla";
                producto.Existencia = 100;
                producto.PrecioUnitario = 19;
                producto.Impuesto = (19 * 0.18);
                producto.Unidad = "Paquetes";
                producto.Categoria = "Comestible";

                repo.Guardar(producto);
                BusquedaProductos.listaProductoEnviar.Add(producto);
            }

            rPointOS.cantidadProductosBuscados = 1;
            this.Close();
        }

        private void LimonButton_Click(object sender, EventArgs e)
        {
            bool interruptor = true;

            Producto producto = new Producto();
            RepositorioBase<Producto> repo = new RepositorioBase<Producto>();
            BusquedaProductos.listaProductoEnviar = new List<Producto>();

            foreach (var item in repo.GetList(p => true))
            {
                if (item.Nombre.CompareTo("Limon") == 0)
                {
                    BusquedaProductos.listaProductoEnviar.Add(item);
                    interruptor = false;
                }
            }

            if(interruptor)
            {
                producto.ProductoId = 0;
                producto.Nombre = "Limon";
                producto.Existencia = 100;
                producto.PrecioUnitario = 19;
                producto.Impuesto = (19 * 0.18);
                producto.Unidad = "Paquetes";
                producto.Categoria = "Comestible";

                repo.Guardar(producto);
                BusquedaProductos.listaProductoEnviar.Add(producto);
            }

            rPointOS.cantidadProductosBuscados = 1;
            this.Close();
        }

        private void NaranjaButton_Click(object sender, EventArgs e)
        {
            bool interruptor = true;

            Producto producto = new Producto();
            RepositorioBase<Producto> repo = new RepositorioBase<Producto>();
            BusquedaProductos.listaProductoEnviar = new List<Producto>();

            foreach (var item in repo.GetList(p => true))
            {
                if (item.Nombre.CompareTo("Naranja") == 0)
                {
                    BusquedaProductos.listaProductoEnviar.Add(item);
                    interruptor = false;
                }
            }

            if (interruptor)
            {
                producto.ProductoId = 0;
                producto.Nombre = "Naranja";
                producto.Existencia = 100;
                producto.PrecioUnitario = 15;
                producto.Impuesto = (15 * 0.18);
                producto.Unidad = "Unidades";
                producto.Categoria = "Comestible";

                repo.Guardar(producto);
                BusquedaProductos.listaProductoEnviar.Add(producto);
            }
            rPointOS.cantidadProductosBuscados = 1;

            this.Close();
        }

        private void QuesoButton_Click(object sender, EventArgs e)
        {
            bool interruptor = true;

            Producto producto = new Producto();
            RepositorioBase<Producto> repo = new RepositorioBase<Producto>();
            BusquedaProductos.listaProductoEnviar = new List<Producto>();

            foreach (var item in repo.GetList(p => true))
            {
                if (item.Nombre.CompareTo("Queso de hoja") == 0)
                {
                    BusquedaProductos.listaProductoEnviar.Add(item);
                    interruptor = false;
                }
            }

            if (interruptor)
            {
                producto.ProductoId = 0;
                producto.Nombre = "Queso de hoja";
                producto.Existencia = 100;
                producto.PrecioUnitario = 120;
                producto.Impuesto = (120 * 0.18);
                producto.Unidad = "Libras";
                producto.Categoria = "Comestible";

                repo.Guardar(producto);
                BusquedaProductos.listaProductoEnviar.Add(producto);

            }
            rPointOS.cantidadProductosBuscados = 1;
            this.Close();
        }

        private void PimentonButton_Click(object sender, EventArgs e)
        {
            bool interruptor = true;

            Producto producto = new Producto();
            RepositorioBase<Producto> repo = new RepositorioBase<Producto>();
            BusquedaProductos.listaProductoEnviar = new List<Producto>();

            foreach (var item in repo.GetList(p => true))
            {
                if (item.Nombre.CompareTo("Pimenton") == 0)
                {
                    BusquedaProductos.listaProductoEnviar.Add(item);
                    interruptor = false;
                }
            }

            if (interruptor)
            {
                producto.ProductoId = 0;
                producto.Nombre = "Pimenton";
                producto.Existencia = 100;
                producto.PrecioUnitario = 45;
                producto.Impuesto = (45 * 0.18);
                producto.Unidad = "Libras";
                producto.Categoria = "Comestible";

                repo.Guardar(producto);
                BusquedaProductos.listaProductoEnviar.Add(producto);

            }
            rPointOS.cantidadProductosBuscados = 1;
            this.Close();
        }

        private void PolloButton_Click(object sender, EventArgs e)
        {
            bool interruptor = true;

            Producto producto = new Producto();
            RepositorioBase<Producto> repo = new RepositorioBase<Producto>();
            BusquedaProductos.listaProductoEnviar = new List<Producto>();

            foreach (var item in repo.GetList(p => true))
            {
                if (item.Nombre.CompareTo("Pollo") == 0)
                {
                    BusquedaProductos.listaProductoEnviar.Add(item);
                    interruptor = false;
                }
            }

            if (interruptor)
            {
                producto.ProductoId = 0;
                producto.Nombre = "Pollo";
                producto.Existencia = 100;
                producto.PrecioUnitario = 55;
                producto.Impuesto = (55 * 0.18);
                producto.Unidad = "Libras";
                producto.Categoria = "Comestible";
                repo.Guardar(producto);
                BusquedaProductos.listaProductoEnviar.Add(producto);
            }
            rPointOS.cantidadProductosBuscados = 1;

            this.Close();
        }

        private void ResButton_Click(object sender, EventArgs e)
        {
            bool interruptor = true;

            Producto producto = new Producto();
            RepositorioBase<Producto> repo = new RepositorioBase<Producto>();
            BusquedaProductos.listaProductoEnviar = new List<Producto>();

            foreach (var item in repo.GetList(p => true))
            {
                if (item.Nombre.CompareTo("Carne de res") == 0)
                {
                    BusquedaProductos.listaProductoEnviar.Add(item);
                    interruptor = false;
                }
            }

            if (interruptor)
            {
                producto.ProductoId = 0;
                producto.Nombre = "Carne de res";
                producto.Existencia = 100;
                producto.PrecioUnitario = 90;
                producto.Impuesto = (90 * 0.18);
                producto.Unidad = "Libras";
                producto.Categoria = "Comestible";
                repo.Guardar(producto);
                BusquedaProductos.listaProductoEnviar.Add(producto);

            }

            rPointOS.cantidadProductosBuscados = 1;
            this.Close();
        }


        private void HuevosButton_Click(object sender, EventArgs e)
        {
            bool interruptor = true;

            Producto producto = new Producto();
            RepositorioBase<Producto> repo = new RepositorioBase<Producto>();
            BusquedaProductos.listaProductoEnviar = new List<Producto>();

            foreach (var item in repo.GetList(p => true))
            {
                if (item.Nombre.CompareTo("Huevos") == 0)
                {
                    BusquedaProductos.listaProductoEnviar.Add(item);
                    interruptor = false;
                }
            }

            if (interruptor)
            {
                producto.ProductoId = 0;
                producto.Nombre = "Huevos";
                producto.Existencia = 100;
                producto.PrecioUnitario = 150;
                producto.Impuesto = (150 * 0.18);
                producto.Unidad = "Paquetes";
                producto.Categoria = "Comestible";

                repo.Guardar(producto);
                BusquedaProductos.listaProductoEnviar.Add(producto);

            }
            rPointOS.cantidadProductosBuscados = 1;
            this.Close();
        }

        private void PiñaButton_Click(object sender, EventArgs e)
        {
            bool interruptor = true;

            Producto producto = new Producto();
            RepositorioBase<Producto> repo = new RepositorioBase<Producto>();
            BusquedaProductos.listaProductoEnviar = new List<Producto>();

            foreach (var item in repo.GetList(p => true))
            {
                if (item.Nombre.CompareTo("Piña") == 0)
                {
                    BusquedaProductos.listaProductoEnviar.Add(item);
                    interruptor = false;
                }
            }

            if (interruptor)
            {
                producto.ProductoId = 0;
                producto.Nombre = "Piña";
                producto.Existencia = 100;
                producto.PrecioUnitario = 50;
                producto.Impuesto = (50 * 0.18);
                producto.Unidad = "Unidades";
                producto.Categoria = "Comestible";

                repo.Guardar(producto);
                BusquedaProductos.listaProductoEnviar.Add(producto);

            }
            rPointOS.cantidadProductosBuscados = 1;
            this.Close();
        }
    }
}
