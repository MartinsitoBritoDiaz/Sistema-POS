using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_POS.Entidades
{
    public class ArticuloMV
    {
        [Key]
        public int ArticuloMVid { get; set; }
        public string Descripcion { get; set; }
        public int code { get; set; }

        public ArticuloMV()
        {
        }
    }
}
