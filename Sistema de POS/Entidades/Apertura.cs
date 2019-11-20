using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_POS.Entidades
{
    public class Apertura
    {
        public int AperturaId { get; set; }
        public DateTime Fecha { get; set; }
        public int Caja { get; set; }
        public double TotalEfectivo { get; set; }
        public string Comentario { get; set; }
        public bool Cerrada { get; set; }

        public Apertura()
        {
        }

    }
}
