using mvcPet.Data;
using mvcPet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcPet.Business
{
    public partial class TipoServicioComponent
    {
        public TipoServicio Agregar(TipoServicio tipoServicio)
        {
            TipoServicio result = default(TipoServicio);
            var tipoServicioDAC = new TipoServicioDAC();
            result = tipoServicioDAC.Create(tipoServicio);
            return result;
        }
        public TipoServicio Editar(TipoServicio tipoServicio)
        {
            TipoServicio result = default(TipoServicio);
            var tipoServicioDAC = new TipoServicioDAC();
            tipoServicioDAC.Update(tipoServicio);
            result = tipoServicio;
            return result;
        }
        public TipoServicio BuscarPorId(int id)
        {
            TipoServicio result = default(TipoServicio);
            var tipoServicioDAC = new TipoServicioDAC();
            result = tipoServicioDAC.ReadBy(id);
            return result;
        }
        public List<TipoServicio> ListarTodos()
        {
            List<TipoServicio> result = default(List<TipoServicio>);
            var tipoServicioDAC = new TipoServicioDAC();
            result = tipoServicioDAC.Read();
            return result;

        }
    }
}
