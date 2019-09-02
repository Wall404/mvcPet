using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using mvcPet.Business;
using mvcPet.Entities;
using mvcPet.Services.Contracts;

namespace mvcPet.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class SalaService : ISalaService
    {
        public Sala Agregar(Sala sala)
        {
            // TODO: Completar
            throw new NotImplementedException();
        }

        public Sala BuscarPorId(int Id)
        {
            // TODO: Completar
            throw new NotImplementedException();
        }

        public Sala Editar(Sala sala)
        {
            // TODO: Completar
            throw new NotImplementedException();
        }

        public List<Sala> ListarTodos()
        {
            // TODO: Completar
            throw new NotImplementedException();
        }
    }
}
