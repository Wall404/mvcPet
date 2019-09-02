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
        public Precio Create(Precio precio)
        {
            const string SQL_STATEMENT = "INSERT INTO Precio ([TipoServicioId],[FechaDesde],[FechaHasta],[Valor]) VALUES (<@TipoServicioId, int,>,<@FechaDesde, date,>,<@FechaHasta, date,>,<@Valor, decimal(10,2),>);";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@TipoServicioId", DbType.Int32, precio.Id);
                db.AddInParameter(cmd, "@FechaDesde", DbType.DateTime2, precio.FechaDesde);
                db.AddInParameter(cmd, "@FechaHasta", DbType.DateTime2, precio.FechaHasta);
                precio.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return precio;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Precio> Read()
        {
            const string SQL_STATEMENT = "SELECT [TipoServicioId],[FechaDesde],[FechaHasta],[Valor] FROM Precio";

            List<Precio> result = new List<Precio>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Precio precio = LoadPrecio(dr);
                        result.Add(precio);
                    }
                }
            }
            return result;
        }

        public Precio ReadBy(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Precio entity)
        {
            throw new NotImplementedException();
        }

        private Precio LoadPrecio(IDataReader dr)
        {
            Precio precio = new Precio();
            precio.Id = GetDataValue<int>(dr, "TipoServicioId");
            precio.FechaDesde = GetDataValue<DateTime>(dr, "FechaDesde");
            precio.FechaDesde = GetDataValue<DateTime>(dr, "FechaDesde");
            precio.Valor = GetDataValue<double>(dr, "Valor");
            return precio;
        }
    }
}
