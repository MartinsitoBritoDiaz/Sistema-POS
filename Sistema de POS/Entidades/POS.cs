using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_POS.Entidades
{
    public class POS
    {
        [Key]
        public int PosId { get; set; }
        public DateTime Fecha { get; set; }
        public double SubTotal { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }
        public int Cantidad { get; set; }
        public string TipoPago { get; set; }
        public bool Estado { get; set; }

        public virtual List<DetalleProductoPOS> ProductosPOS { get; set; }

        public POS()
        {
            PosId = 0;
            Fecha = DateTime.Now;
            SubTotal = 0;
            Impuesto = 0;
            Total = 0;
            Cantidad = 0;
            TipoPago = string.Empty;
            ProductosPOS = new List<DetalleProductoPOS>();
            Estado = false;
        }
    }
}
