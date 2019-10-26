using SistemaPOS.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPOS.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Factura> Facturas { get; set; }

        public Contexto() : base("ConStr") { }
    }
}
