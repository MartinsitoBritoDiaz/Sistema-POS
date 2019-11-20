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
        public int ProductId { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
        public double Importe { get; set; }
        public string Unidad { get; set; }
        public int PosId { get; set; }

        public DetalleProductoPOS()
        {
        }

        public DetalleProductoPOS(int productId, string descripcion, int cantidad, double precioUnitario, double importe, string unidad, int posId)
        {
            ProductId = productId;
            Descripcion = descripcion;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            Importe = importe;
            Unidad = unidad;
            PosId = posId;
        }
    }
}
