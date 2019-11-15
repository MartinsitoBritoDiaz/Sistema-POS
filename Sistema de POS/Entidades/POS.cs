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
        public int POSid { get; set; }
        public int Usuario { get; set; }
        public string NombreUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuentos { get; set; }
        public decimal ITBIS { get; set; }
        public decimal Total { get; set; }
        public int Cantidad { get; set; }
        public string Cajero { get; set; }
        public string TipoPago { get; set; }

        public virtual List<DetalleProductoPOS> ProductosPOS { get; set; }
        

        public POS()
        {
        }
    }
}
