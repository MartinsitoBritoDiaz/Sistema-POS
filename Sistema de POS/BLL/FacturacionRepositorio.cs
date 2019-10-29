
using Sistema_de_POS.BLL;
using Sistema_de_POS.Entidades;
using SistemaPOS.DAL;
using SistemaPOS.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPOS.BLL
{
    class FacturacionRepositorio : RepositorioBase<Factura>
    {
        public override bool Modificar(Factura factura)
        {

            var anterior = base._contexto.Facturas.Find(factura.Facturaid);

            foreach (var item in anterior.Productos)
            {
                if (!factura.Productos.Exists(d => d.id == item.id))
                    base._contexto.Entry(item).State =  EntityState.Deleted;
            }
        
            return base.Modificar(factura);
        }

        public override bool Guardar(Factura factura)
        {
            ClienteRepositorio repositorio = new ClienteRepositorio();

            repositorio.ModificarDeudas(factura.ClienteId, factura.Deuda);

            return base.Guardar(factura);
        }
    }


}
