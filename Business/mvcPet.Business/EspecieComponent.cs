using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using mvcPet.Entities;
using mvcPet.Data;


namespace mvcPet.Business
{  
    public partial class EspecieComponent
    {        
        public Especie Agregar(Especie especie)
        {
            Especie result = default(Especie);
            var especieDAC = new EspecieDAC();
            result = especieDAC.Create(especie);
            return result;
        }
        public Especie Editar(Especie especie)
        {
            Especie result = default(Especie);
            var especieDAC = new EspecieDAC();
            especieDAC.Update(especie);
            result = especie;
            return result;
        }
        public Especie BuscarPorId(int id)
        {
            Especie result = default(Especie);
            var especieDAC = new EspecieDAC();
            result = especieDAC.ReadBy(id);
            return result;
        }
        public List<Especie> ListarTodos()
        {
            List<Especie> result = default(List<Especie>);
            var especieDAC = new EspecieDAC();
            result = especieDAC.Read();
            return result;

        }
    }
}
