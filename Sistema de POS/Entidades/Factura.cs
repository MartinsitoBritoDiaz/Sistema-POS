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
        public int ClienteId { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Condicion { get; set; }
        public string TipoPago { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }/*
        public decimal Pago { get; set; }
        public decimal Deuda { get; set; }
        */
        public decimal ITBIS { get; set; }
        public virtual List<DetalleProducto> Productos { get; set; }

        public Factura()
        {
            Facturaid = 0;
            ClienteId = 0;
            Fecha = DateTime.Now;
            Cliente = string.Empty;
            Condicion = string.Empty;
            TipoPago = string.Empty;
            SubTotal = 0;
            Descuento = 0;
            Total = 0;/*
            Pago = 0;
            Deuda = 0;*/
            ITBIS = 0;
            Productos = new List<DetalleProducto>();
        }
    }
}
