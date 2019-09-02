﻿using System;
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
            var bc = new PrecioComponent();
            return bc.Agregar(precio);
        }

        public Precio BuscarPorTipoServicio(int tipoServicioId)
        {
            // TODO
            throw new NotImplementedException();
        }

        public Precio Editar(Precio precio)
        {
            // TODO
            throw new NotImplementedException();
        }

        public List<Precio> ListarTodos()
        {
            var bc = new PrecioComponent();
            return bc.ListarTodos();
        }
    }
}
