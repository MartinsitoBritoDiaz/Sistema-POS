using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_POS.Entidades
{
    public class Articulo
    {
        [Key]
        public int Articuloid { get; set; }
        public string Descripcion { get; set; }
        public int code { get; set; }

        public Articulo()
        {
        }
    }
}
