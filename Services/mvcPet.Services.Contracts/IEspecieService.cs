using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ServiceModel;
using mvcPet.Entities;

namespace mvcPet.Services.Contracts
{    
    [ServiceContract]
    public interface IEspecieService
    {
        [OperationContract]
        Especie Agregar(Especie especie);

        [OperationContract]
        Especie Editar(Especie especie);

        [OperationContract]
        Especie Eliminar(int id);

        [OperationContract]
        Especie BuscarPorId(int id);

        [OperationContract]
        List<Especie> ListarTodos();
    }
}
