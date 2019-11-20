
using Sistema_de_POS.BLL;
using Sistema_de_POS.Entidades;
using SistemaPOS.DAL;
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
            ClienteRepositorio repositorio = new ClienteRepositorio();

            foreach (var item in factura.DetalleProducto)
            {
                if (item.ProductoId == 0)
                {
                    _contexto.Entry(item).State = EntityState.Added;
                    repositorio.ModificarDeudas(factura.ClienteId, factura.Total);
                }
                else
                {
                    _contexto.Entry(item).State = EntityState.Modified;

                    repositorio.ModificarDeudas(factura.ClienteId, (factura.Total)*-1);
                }
                  
            }
        
            return base.Modificar(factura);
        }
        
        public override bool Guardar(Factura factura)
        {
            ClienteRepositorio repositorio = new ClienteRepositorio();
            
            repositorio.ModificarDeudas(factura.ClienteId, factura.Total);
            
            return base.Guardar(factura);
        }

        public override Factura Buscar(int id)
        {
            Factura factura = new Factura();

            factura = base.Buscar(id);

            if(factura != null)
                 factura.DetalleProducto.Count();

            return base.Buscar(id);
        }
    }


}
