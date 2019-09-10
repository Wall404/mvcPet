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
            try
            {
                const string SQL_STATEMENT = "INSERT INTO Precio ([TipoServicioId],[FechaDesde],[FechaHasta],[Valor]) VALUES (@TipoServicioId, @FechaDesde, @FechaHasta, @Valor ); SELECT SCOPE_IDENTITY();";

                var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
                using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
                {
                    db.AddInParameter(cmd, "@TipoServicioId", DbType.Int32, precio.TipoServicioId);
                    db.AddInParameter(cmd, "@FechaDesde", DbType.Date, precio.FechaDesde);
                    db.AddInParameter(cmd, "@FechaHasta", DbType.Date, precio.FechaHasta);
                    db.AddInParameter(cmd, "@Valor", DbType.Decimal, precio.Valor);
                    precio.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
                }
                return precio;
            }
            catch (Exception e)
            {

                throw e;
            }
            
        }

        public void Delete(int id)
        {
            // TODO:
            throw new NotImplementedException();
        }

        public List<Precio> Read()
        {
            const string SQL_STATEMENT = "SELECT [Id],[TipoServicioId],[FechaDesde],[FechaHasta],[Valor] FROM Precio";

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
            const string SQL_STATEMENT = "SELECT [Id],[TipoServicioId],[FechaDesde],[FechaHasta],[Valor] FROM Precio WHERE [Id]=@Id ";
            Precio precio = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        precio = LoadPrecio(dr);
                    }
                }
            }
            return precio;
        }

        public List<Precio> ReadByTipoServicioId(int tipoServicioId)
        {
            const string SQL_STATEMENT = "SELECT [Id],[TipoServicioId],[FechaDesde],[FechaHasta],[Valor] FROM Precio WHERE [TipoServicioId]=@TipoServicioId ";

            List<Precio> result = new List<Precio>();

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@TipoServicioId", DbType.Int32, tipoServicioId);
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

        public void Update(Precio precio)
        {
            const string SQL_STATEMENT = "UPDATE Precio SET [TipoServicioId]=@TipoServicioId, [FechaDesde]=@FechaDesde, [FechaHasta]=@FechaHasta, [Valor] = @Valor WHERE [Id]= @Id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@TipoServicioId", DbType.Int32, precio.TipoServicioId);
                db.AddInParameter(cmd, "@FechaDesde", DbType.Date, precio.FechaDesde);
                db.AddInParameter(cmd, "@FechaHasta", DbType.Date, precio.FechaHasta);
                db.AddInParameter(cmd, "@Valor", DbType.Decimal, precio.Valor);
                db.AddInParameter(cmd, "@Id", DbType.Int32, precio.Id);
                db.ExecuteNonQuery(cmd);
            }
        }

        private Precio LoadPrecio(IDataReader dr)
        {
            Precio precio = new Precio();
            precio.Id = GetDataValue<int>(dr, "Id");
            precio.TipoServicioId = GetDataValue<int>(dr, "TipoServicioId");
            precio.FechaDesde = GetDateTimeValue(dr, "FechaDesde");
            precio.FechaHasta = GetDateTimeValue(dr, "FechaHasta");
            precio.Valor = GetDataValue<decimal>(dr, "Valor");
            return precio;
        }
    }
}
