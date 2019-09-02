using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data;
using mvcPet.Entities;

namespace mvcPet.Data
{
    public partial class PrecioDAC : DataAccessComponent, IRepository<Precio>
    {
        public Precio Create(Precio entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Precio> Read()
        {
            throw new NotImplementedException();
        }

        public Precio ReadBy(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Precio entity)
        {
            throw new NotImplementedException();
        }
    }
}
