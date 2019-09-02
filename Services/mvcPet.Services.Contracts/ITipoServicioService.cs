using mvcPet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace mvcPet.Services.Contracts
{
    [ServiceContract]
    public interface ITipoServicioService
    {
        [OperationContract]
        TipoServicio Agregar(TipoServicio tipoServicio);

        [OperationContract]
        TipoServicio Editar(TipoServicio tipoServicio);

        [OperationContract]
        TipoServicio BuscarPorId(int Id);

        [OperationContract]
        List<TipoServicio> ListarTodos();
    }
}
