using Sistema_de_POS.Entidades;
using SistemaPOS.BLL;
using SistemaPOS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_POS.BLL
{

    public class POSRepositorio : RepositorioBase<POS>
    {
        public override bool Modificar(POS pos)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var anterior = db.pos.Find(pos.POSid);

                foreach (var item in anterior.ProductosPOS)
                {
                    if (!pos.ProductosPOS.Exists(d => d.id == item.id))
                        db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                }
                db.Entry(pos).State = System.Data.Entity.EntityState.Modified;
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
