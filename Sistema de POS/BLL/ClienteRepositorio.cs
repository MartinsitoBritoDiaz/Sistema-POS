using Sistema_de_POS.Entidades;
using SistemaPOS.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_POS.BLL
{
    public class ClienteRepositorio : RepositorioBase<Cliente>
    {
        public bool ModificarDeudas(int id,double Deuda)
        {
            Cliente cliente = base.Buscar(id);

            if (cliente != null)
                cliente.Deudas += Deuda;

            return (base.Modificar(cliente));
            
        }
    }
}
