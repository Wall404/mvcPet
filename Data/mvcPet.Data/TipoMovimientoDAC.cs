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
    public partial class TipoMovimientoDAC : DataAccessComponent, IRepository<TipoMovimiento>
    {
        public TipoMovimiento Create(TipoMovimiento entity)
        {
            // TODO: Completar
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            // TODO: Completar
            throw new NotImplementedException();
        }

        public List<TipoMovimiento> Read()
        {
            // TODO: Completar
            throw new NotImplementedException();
        }

        public TipoMovimiento ReadBy(int id)
        {
            // TODO: Completar
            throw new NotImplementedException();
        }

        public void Update(TipoMovimiento entity)
        {
            // TODO: Completar
            throw new NotImplementedException();
        }

        private TipoMovimiento LoadTipoMovimiento(IDataReader dr)
        {
            TipoMovimiento tipoMovimiento = new TipoMovimiento();
            tipoMovimiento.Id = GetDataValue<int>(dr, "Id");
            tipoMovimiento.Nombre = GetDataValue<string>(dr, "Nombre");
            tipoMovimiento.Multiplicador = GetDataValue<Int16>(dr, "Multiplicador");
            return tipoMovimiento;
        }
    }
}
