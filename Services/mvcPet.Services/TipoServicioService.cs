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
    public class TipoServicioService : ITipoServicioService
    {
        public TipoServicio Agregar(TipoServicio tipoServicio)
        {
            var bc = new TipoServicioComponent();
            return bc.Agregar(tipoServicio);
        }

        public TipoServicio BuscarPorId(int id)
        {
            var bc = new TipoServicioComponent();
            return bc.BuscarPorId(id);
        }

        public TipoServicio Editar(TipoServicio tipoServicio)
        {
            var bc = new TipoServicioComponent();
            return bc.Editar(tipoServicio);
        }

        public List<TipoServicio> ListarTodos()
        {
            var bc = new TipoServicioComponent();
            return bc.ListarTodos();
        }
    }
}
