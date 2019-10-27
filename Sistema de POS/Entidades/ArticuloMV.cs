using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_POS.Entidades
{
    public class ArticuloMV
    {
        [key]
        public int ArticuloMVid { get; set; }
        public string Descripcion { get; set; }
        public int code { get; set; }

        public ArticuloMV()
        {
        }
    }
}
