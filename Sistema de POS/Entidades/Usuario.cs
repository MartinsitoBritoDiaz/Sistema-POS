using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_POS.Entidades
{
    public class Usuario
    {
        [Key]

        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Celular { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string User { get; set; }
        public string Contraseña { get; set; }
        public  string Tipo { get; set; }
        public virtual List<POS> Ventas { get; set; }
        public Usuario()
        {
            UsuarioId = 0;
            Nombre = string.Empty;
            Cedula = string.Empty;
            Celular = string.Empty;
            FechaNacimiento = DateTime.Now;
            User = string.Empty;
            Contraseña = string.Empty;
            Tipo = string.Empty;
        }
    }
}
