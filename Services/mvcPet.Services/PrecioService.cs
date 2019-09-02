using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using mvcPet.Entities;
using mvcPet.Services.Contracts;

namespace mvcPet.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class PrecioService : IPrecioService
    {
        public Precio Agregar(Precio precio)
        {
            throw new NotImplementedException();
        }

        public Precio BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Precio Editar(Precio precio)
        {
            throw new NotImplementedException();
        }

        public List<Precio> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
