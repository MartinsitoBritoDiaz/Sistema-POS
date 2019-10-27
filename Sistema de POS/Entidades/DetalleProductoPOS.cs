using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_POS.Entidades
{
    public class DetalleProductoPOS
    {
        [Key]
        public int id { get; set; }
        public int POSid { get; set; }
        public int cantidad { get; set; }
        public string Unidad { get; set; }
        public string descripcion { get; set; }
        public decimal precioUnitario { get; set; }
        public decimal importe { get; set; }
        public DetalleProductoPOS()
        {

        }
        public DetalleProductoPOS(int id, int POSid, int cantidad, string unidad, string descripcion, decimal precioUnitario, decimal importe)
        {
            this.id = id;
            this.POSid = POSid;
            this.cantidad = cantidad;
            this.Unidad = unidad;
            this.descripcion = descripcion;
            this.precioUnitario = precioUnitario;
            this.importe = importe;
        }
    }
}
