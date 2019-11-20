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
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Categoria {get; set;}
        public int Existencia { get; set; }
        public double PrecioUnitario { get; set; }
        public double Impuesto { get; set; }
        public string Unidad { get; set; }

        public Producto()
        {
            ProductoId = 0;
            Nombre = string.Empty;
            Categoria = string.Empty;
            Existencia = 0;
            PrecioUnitario = 0;
            Impuesto = 0;
            Unidad = string.Empty;
        }
    }
}
