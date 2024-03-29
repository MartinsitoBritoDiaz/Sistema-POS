﻿using System;
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
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
        public string Unidad { get; set; }
        public double Importe { get; set; }
        public int FacturaId { get; set; }

        public DetalleProducto()
        {
        }

        public DetalleProducto(string descripcion, int cantidad, double precioUnitario, string unidad, double importe, int facturaId, int productoId)
        {
            Descripcion = descripcion;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            Unidad = unidad;
            Importe = importe;
            FacturaId = facturaId;
            ProductoId = productoId;
        }
    }
}
