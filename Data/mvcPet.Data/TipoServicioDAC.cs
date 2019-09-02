using mvcPet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data;

namespace mvcPet.Data
{
    public partial class TipoServicioDAC : DataAccessComponent, IRepository<TipoServicio>
    {
        public TipoServicio Create(TipoServicio tipoServicio)
        {
            const string SQL_STATEMENT = "INSERT INTO TipoServicio ([Nombre]) VALUES(@Nombre); SELECT SCOPE_IDENTITY();";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Nombre", DbType.AnsiString, tipoServicio.Nombre);
                tipoServicio.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }
            return tipoServicio;
        }

        public List<TipoServicio> Read()
        {
            const string SQL_STATEMENT = "SELECT [Id], [Nombre] FROM TipoServicio ";

            List<TipoServicio> result = new List<TipoServicio>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        TipoServicio tipoServicio = LoadTipoServicio(dr);
                        result.Add(tipoServicio);
                    }
                }
            }
            return result;
        }

        public TipoServicio ReadBy(int id)
        {
            const string SQL_STATEMENT = "SELECT [Id], [Nombre] FROM TipoServicio WHERE [Id]=@Id ";
            TipoServicio tipoServicio = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        tipoServicio = LoadTipoServicio(dr);
                    }
                }
            }
            return tipoServicio;
        }

        public void Update(TipoServicio tipoServicio)
        {
            const string SQL_STATEMENT = "UPDATE TipoServicio SET [Nombre]= @Nombre WHERE [Id]= @Id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Nombre", DbType.AnsiString, tipoServicio.Nombre);
                db.AddInParameter(cmd, "@Id", DbType.Int32, tipoServicio.Id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "DELETE TipoServicio WHERE [Id]= @Id ";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        private TipoServicio LoadTipoServicio(IDataReader dr)
        {
            TipoServicio tipoServicio = new TipoServicio();
            tipoServicio.Id = GetDataValue<int>(dr, "Id");
            tipoServicio.Nombre = GetDataValue<string>(dr, "Nombre");
            return tipoServicio;
        }
    }
}
