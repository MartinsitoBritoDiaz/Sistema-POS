using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_POS.Entidades
{
    public class CajaChica
    {
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public float Monto { get; set; }
        public string Descripcion { get; set; }
        public int Comprobante { get; set; }
        public float SaldoActual { get; set; }

        public CajaChica()
        {
            Fecha = DateTime.Now;
            Monto = 0.00f;
            Descripcion = string.Empty;
            Comprobante = 0;
            SaldoActual = 0.00f;
        }


    }
}

