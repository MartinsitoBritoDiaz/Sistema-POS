using Sistema_de_POS.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPOS.Entidades
{
    public class Factura
    {
        [Key]
        public int Facturaid { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Condicion { get; set; }
        public string TipoPago { get; set; }
        public decimal SubTotal { get; set; }
        public decimal descuentos { get; set; }
        public decimal Total { get; set; }
        public decimal ITBIS { get; set; }
        public virtual List<DetalleProducto> Productos { get; set; }


        public Factura()
        {

        }

    }
}
