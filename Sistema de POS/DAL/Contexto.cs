using Sistema_de_POS.Entidades;
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
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<POS> pos { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<CajaChica> ReposicionFondos { get; set; }
        public DbSet<EgresoFondos> Egresos { get; set; }

        public DbSet<Apertura> Aperturas { get; set; }
        public DbSet<Cierre> Cierres { get; set; }

        public Contexto() : base("ConStr") { }
    }
}
