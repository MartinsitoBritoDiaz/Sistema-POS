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
        public string Condicion { get; set; }
        public string TipoPago { get; set; }
        public int Cantidad { get; set; }
        public String Unidad { get; set; }
        public string Descripcion { get; set; }
        public double PrecioUnitario { get; set; }
        public double SubTotal { get; set; }
        public double Descuento { get; set; }
        public double ITBIS { get; set; }
        public double Total { get; set; }
        public double Pago { get; set; }
        public double Deuda { get; set; }

        public virtual List<DetalleProducto> DetalleProducto { get; set; }
        public Factura()
        {
            FacturaId = 0;
            ClienteId = 0;
            Fecha = DateTime.Now;
            Cliente = string.Empty;
            Condicion = string.Empty;
            TipoPago = string.Empty;
            Cantidad = 0;
            Unidad = string.Empty;
            Descripcion = string.Empty;
            PrecioUnitario = 0;
            SubTotal = 0;
            Descuento = 0;
            ITBIS = 0;
            Total = 0;
            Pago = 0;
            Deuda = 0;

            DetalleProducto = new List<DetalleProducto>();
        }
    }
}
