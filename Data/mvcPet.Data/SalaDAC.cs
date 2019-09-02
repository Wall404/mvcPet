using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using mvcPet.Entities;

namespace mvcPet.Data
{
    public partial class SalaDAC : DataAccessComponent, IRepository<Sala>
    {
        public Sala Create(Sala entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Sala> Read()
        {
            throw new NotImplementedException();
        }

        public Sala ReadBy(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Sala entity)
        {
            throw new NotImplementedException();
        }

        private Sala LoadSala(IDataReader dr)
        {
            Sala sala = new Sala();
            sala.Id = GetDataValue<int>(dr, "Id");
            sala.Nombre = GetDataValue<string>(dr, "Nombre");
            sala.TipoSala = GetDataValue<string>(dr, "TipoSala");
            return sala;
        }
    }
}
