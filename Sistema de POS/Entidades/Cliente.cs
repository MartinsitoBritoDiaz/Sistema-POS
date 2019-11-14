using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_POS.Entidades
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Celular{ get; set; }
        public DateTime Fecha { get; set; }
        public string Direccion { get; set; }
        public double Deudas { get; set; }
        public Cliente()
        {
            ClienteId = 0;
            UsuarioId = 0;
            Nombre = string.Empty;
            Cedula = string.Empty;
            Telefono = string.Empty;
            Celular = string.Empty;
            Fecha = DateTime.Now;
            Direccion = string.Empty;
            Deudas = 0;
        }
    }
}
