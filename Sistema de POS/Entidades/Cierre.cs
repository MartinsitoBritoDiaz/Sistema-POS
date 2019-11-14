using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_POS.Entidades
{
    public class Cierre
    {
        public int CierreId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Fecha { get; set; }
        public int Caja { get; set; }
        public string Usuario { get; set; }
        public double TotalEfectivo { get; set; }
        public double TotalCredito { get; set; }
        public double TotalGeneral { get; set; }
        public string Comentario { get; set; }

        public Cierre()
        {
        }
    }

}
