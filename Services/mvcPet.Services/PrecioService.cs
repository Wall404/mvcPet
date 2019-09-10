using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using mvcPet.Business;
using mvcPet.Entities;
using mvcPet.Services.Contracts;

namespace mvcPet.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class PrecioService : IPrecioService
    {
        public Precio Agregar(Precio precio)
        {
            try
            {
                var bc = new PrecioComponent();
                return bc.Agregar(precio);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            
        }

        public Precio BuscarPorId(int id)
        {
            var bc = new PrecioComponent();
            return bc.BuscarPorId(id);
        }

        public List<Precio> BuscarPorTipoServicio(int tipoServicioId)
        {
            var bc = new PrecioComponent();
            return bc.BuscarPorTipoServicio(tipoServicioId);
        }

        public Precio Editar(Precio precio)
        {
            var bc = new PrecioComponent();
            return bc.Editar(precio);
        }

        public List<Precio> ListarTodos()
        {
            var bc = new PrecioComponent();
            return bc.ListarTodos();
        }
    }
}
