using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_POS.Entidades
{
    public class Factura
    {
        [Key]
        public int FacturaId { get; set; }
        public int ClienteId { get; set; }
        public DateTime Fecha { get; set; }
        public string  Cliente { get; set; }
        public double SubTotal { get; set; }
        public double ITBIS { get; set; }
        public double Total { get; set; }

        public virtual List<DetalleProducto> DetalleProducto { get; set; }
        public Factura()
        {
            FacturaId = 0;
            ClienteId = 0;
            Fecha = DateTime.Now;
            Cliente = string.Empty;
            SubTotal = 0;
            ITBIS = 0;
            Total = 0;

            DetalleProducto = new List<DetalleProducto>();
        }
    }
}
