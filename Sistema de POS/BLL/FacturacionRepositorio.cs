
using SistemaPOS.DAL;
using SistemaPOS.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPOS.BLL
{
    class FacturacionRepositorio : RepositorioBase<Factura>
    {
        public override bool Guardar(Factura factura)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var anterior = db.Facturas.Find(factura.Facturaid);

                foreach (var item in anterior.Productos)
                {
                    if (!factura.Productos.Exists(d => d.ProductoID == item.ProductoID))
                        db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                }
                db.Entry(factura).State = System.Data.Entity.EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }
    }
}
