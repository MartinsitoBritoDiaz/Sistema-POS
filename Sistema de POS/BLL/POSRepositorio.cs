using Sistema_de_POS.Entidades;
using SistemaPOS.BLL;
using SistemaPOS.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_POS.BLL
{

    public class POSRepositorio : RepositorioBase<POS>
    {
        public override bool Modificar(POS pos)
        {
            foreach (var item in pos.ProductosPOS)
            {
                if (item.ProductId == 0)
                    _contexto.Entry(item).State = EntityState.Added;
                else
                    _contexto.Entry(item).State = EntityState.Modified;
            }

            return base.Modificar(pos);
        }

        public override POS Buscar(int id)
        {
            POS pos = new POS();

            pos = base.Buscar(id);

            if(pos != null)
                pos.ProductosPOS.Count();

            return base.Buscar(id);
        }
    }
}
