
using Dapper;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Domain.Enty;

namespace TimeSheet.Infrastructure.Repository
{
    public class RepositoryFluig
    {
        private OracleConnection Conexao;
        private const string ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=stark.intranet.bahiagas.com.br)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=AP12HML)));User Id=FLUIG;Password=FLUIG;";


        public RepositoryFluig()
        {
            Conexao = new OracleConnection(ConnectionString);
        }

        public Usuario ObterUsuarioFluigPorEmail(string email)
        {
            try
            {
                Conexao.Open();
                var sql = $@"Select EMAIL, USER_CODE as CodigoFluig from  FDN_USERTENANT
                                WHERE EMAIL = '{email}' AND USER_STATE = '1'";
                return Conexao.QueryFirstOrDefault<Usuario>(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
