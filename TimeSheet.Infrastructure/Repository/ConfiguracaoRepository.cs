using Dapper;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Domain;
using TimeSheet.Infrastructure.Interface;

namespace TimeSheet.Infrastructure.Repository
{
    public class ConfiguracaoRepository : AbstractRepository<Configuracao>
    {
        public ConfiguracaoRepository(IConfiguration configuration) : base(configuration) { }


        public override void Add(Configuracao item)
        {
            try
            {
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    string sQuery = "INSERT INTO ZYX010 (ZYX_FILIAL, ZYX_DLIFEC,ZYX_FEMAIL,ZYX_DEMAIL,ZYX_INIMAR,ZYX_FINMAR,"
                                    + "VALUES(@ZYX_FILIAL, @ZYX_DLIFEC, @ZYX_FEMAIL,@ZYX_DEMAIL,@ZYX_INIMAR,@ZYX_FINMAR)";
                    dbConnection.Open();
                    dbConnection.Execute(sQuery, item);
                }
            }
            catch (Exception ex)
            {
                // Handle exception
            }
          
        }

        public override IEnumerable<Configuracao> FindAll()
        {
            try
            {
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    dbConnection.Open();
                    return  dbConnection.Query<Configuracao>("SELECT * FROM ZYX010");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                
            }
        }

        public override Configuracao FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public override void Update(Configuracao item)
        {
            throw new NotImplementedException();
        }


    }
}
