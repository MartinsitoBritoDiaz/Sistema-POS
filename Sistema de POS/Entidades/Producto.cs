using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_POS.Entidades
{
    public class Producto
    {
        [Key]
        public int ProductoID { get; set; }
        public int cantidad { get; set; }
        public string descripcion { get; set; }
        public decimal precioUnitario { get; set; }
        public decimal importe { get; set; }

        public Producto()
        {

        }
        public Producto(int productoID, int cantidad, string descripcion, decimal precioUnitario)
        {
            ProductoID = productoID;
            this.cantidad = cantidad;
            this.descripcion = descripcion ?? throw new ArgumentNullException(nameof(descripcion));
            this.precioUnitario = precioUnitario;
        }
    }
}
