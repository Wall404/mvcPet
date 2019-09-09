﻿using System;
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
        public TipoMovimiento Create(TipoMovimiento tipoMovimiento)
        {
            try
            {
                // TODO: Completar *************** aca toque GABY------
                const string SQL_STATEMENT = "INSERT INTO TipoMovimiento ([Nombre]) VALUES(@Nombre,); SELECT SCOPE_IDENTITY();";

                var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
                using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
                {
                    db.AddInParameter(cmd, "@Nombre", DbType.AnsiString, tipoMovimiento.Nombre);
                    //db.AddInParameter(cmd, "@Multiplicador", DbType.UInt16, tipoMovimiento.Multiplicador);
                    tipoMovimiento.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
                }
                return tipoMovimiento;

            }
            catch (Exception)
            {

                throw;
            }
           
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            // TODO: Completar *************** aca toque GABY------
            const string SQL_STATEMENT = "DELETE TipoMovimiento WHERE [Id]= @Id ";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
            throw new NotImplementedException();
        }

        public List<TipoMovimiento> Read()
        {
            // TODO: Completar *************** aca toque GABY------
            const string SQL_STATEMENT = "SELECT [Id], [Nombre] FROM TipoMovimiento ";

            List<TipoMovimiento> result = new List<TipoMovimiento>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        TipoMovimiento TipoMovimiento = LoadTipoMovimiento(dr);
                        result.Add(TipoMovimiento);
                    }
                }
            }
            return result;
            throw new NotImplementedException();
        }

        public TipoMovimiento ReadBy(int id)
        {
            // TODO: Completar *************** aca toque GABY------
            const string SQL_STATEMENT = "SELECT [Id], [Nombre] FROM TipoMovimiento WHERE [Id]=@Id ";
            TipoMovimiento tipoMovimiento = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        tipoMovimiento = LoadTipoMovimiento(dr);
                    }
                }
            }
            return tipoMovimiento;
            throw new NotImplementedException();
        }

        public void Update(TipoMovimiento tipoMovimiento)
        {
            // TODO: Completar *************** aca toque GABY------
            const string SQL_STATEMENT = "UPDATE TipoMovimiento SET [Nombre]= @Nombre WHERE [Id]= @Id ";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Nombre", DbType.AnsiString, tipoMovimiento.Nombre);
                //db.AddInParameter(cmd, "@Multiplicador", DbType.UInt16, tipoMovimiento.Multiplicador);
                db.AddInParameter(cmd, "@Id", DbType.Int32, tipoMovimiento.Id);
                db.ExecuteNonQuery(cmd);
            }
            throw new NotImplementedException();
        }

        private TipoMovimiento LoadTipoMovimiento(IDataReader dr)
        {
            TipoMovimiento tipoMovimiento = new TipoMovimiento();
            tipoMovimiento.Id = GetDataValue<int>(dr, "Id");
            tipoMovimiento.Nombre = GetDataValue<string>(dr, "Nombre");
            //tipoMovimiento.Multiplicador = GetInt16Value(dr, "Multiplicador");
            tipoMovimiento.Multiplicador = GetInt16Value(dr, "Multiplicador");

            return tipoMovimiento;
        }

       
    }
}
