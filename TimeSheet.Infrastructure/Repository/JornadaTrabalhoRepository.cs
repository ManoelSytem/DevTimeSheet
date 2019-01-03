using Dapper;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Domain.Enty;
using TimeSheet.Infrastructure.Interface;

namespace TimeSheet.Infrastructure.Repository
{
    public class JornadaTrabalhoRepository 
    {

        private OracleConnection Conexao;
        private const string ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=bgasha-scan.intranet.bahiagas.com.br)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=BAHIAGAS)));User Id=ap6;Password=msbd106;";

        public JornadaTrabalhoRepository()
        {
            Conexao = new OracleConnection(ConnectionString);
        }

        public void Add(JornadaTrabalho item)
        {
            try
            {
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    string sQuery = $@"INSERT INTO ZYX010 (ZYX_FILIAL,ZYX_CODIGO, ZYX_DLIFEC,  ZYX_FEMAIL, ZYX_DEMAIL, ZYX_INIMAR, ZYX_FINMAR, ZYX_CODDIV,ZYX_MATUSU,ZYX_AEMAIL)"
                                    + "VALUES()";
                    dbConnection.Open();
                    dbConnection.Execute(sQuery);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<JornadaTrabalho> FindAll()
        {
            throw new NotImplementedException();
        }

        public  JornadaTrabalho FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(string id)
        {
            throw new NotImplementedException();
        }

        public  void Update(JornadaTrabalho item)
        {
            try
            {
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    string sQuery = $@"INSERT INTO ZYX010 (ZYX_FILIAL,ZYX_CODIGO, ZYX_DLIFEC,  ZYX_FEMAIL, ZYX_DEMAIL, ZYX_INIMAR, ZYX_FINMAR, ZYX_CODDIV,ZYX_MATUSU,ZYX_AEMAIL)"
                                    + "VALUES()";
                    dbConnection.Open();
                    dbConnection.Execute(sQuery);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
