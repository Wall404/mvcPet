using mvcPet.Data;
using mvcPet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcPet.Business
{
    public partial class PrecioComponent
    {
        public Precio Agregar(Precio precio)
        {
            Precio result = default(Precio);
            var precioDAC = new PrecioDAC();
            result = precioDAC.Create(precio);
            return result;
        }
        public Precio Editar(Precio precio)
        {
            Precio result = default(Precio);
            var precioDAC = new PrecioDAC();
            precioDAC.Update(precio);
            result = precio;
            return result;
        }
        public Precio BuscarPorTipoServicio(int tipoServicioId)
        {
            Precio result = default(Precio);
            var precioDAC = new PrecioDAC();
            result = precioDAC.ReadBy(tipoServicioId);
            return result;
        }
        public List<Precio> ListarTodos()
        {
            List<Precio> result = default(List<Precio>);
            var precioDAC = new PrecioDAC();
            result = precioDAC.Read();
            return result;

        }
    }
}
