using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_POS.Entidades
{
    public class EgresoFondos : CajaChica
    {
        [Key]
        public int EgresoId { get; set; }
        public string RealizadoPor { get; set; }
        //public int Gastos { get; set; } //Sin uso hast ahora

        public EgresoFondos()
        {
        }
    }
}
