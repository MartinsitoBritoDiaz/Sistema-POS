using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_POS.Entidades
{
    public class DetalleProducto
    {
        [Key]
        public int id { get; set; }
        public int Facturaid { get; set; }
        public int cantidad { get; set; }
        public string Unidad { get; set; }
        public string descripcion { get; set; }
        public decimal precioUnitario { get; set; }
        public decimal importe { get; set; }
        public DetalleProducto()
        {

        }
        public DetalleProducto(int id, int facturaid, int cantidad,string unidad, string descripcion, decimal precioUnitario, decimal importe)
        {
            this.id = id;
            this.Facturaid = facturaid;
            this.cantidad = cantidad;
            this.Unidad = unidad;
            this.descripcion = descripcion; 
            this.precioUnitario = precioUnitario;
            this.importe = importe;
        }
    }
}
