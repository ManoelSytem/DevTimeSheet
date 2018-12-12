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

    public class ProtheusRepository 
    {
        private OracleConnection Conexao;
        private const string ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=bgasha-scan.intranet.bahiagas.com.br)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=BAHIAGAS)));User Id=ap6;Password=msbd106;";

        public ProtheusRepository()
        {
            Conexao = new OracleConnection(ConnectionString);
        }

        public CodDivergencia ObterCodigoDivergenciaPorContigo(int cod)
        {
            try
            {
                   Conexao.Open();
                    var sql = $@"SELECT P6_CODIGO as Codigo, P6_DESC as Descricao  FROM SP6010
                                WHERE P6_CODIGO = LTRIM(RTRIM('{cod}')) AND D_E_L_E_T_ <> '*'";
                  return Conexao.QueryFirstOrDefault<CodDivergencia>(sql);
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

        public  IEnumerable<CodDivergencia> ObterListaCodigoDivergenciaPorIdDesc(string descId)
        {
            try
            {
                Conexao.Open();
                var sql = $@"SELECT P6_CODIGO as Codigo, P6_DESC as Descricao  FROM SP6010
                                WHERE  (P6_DESC LIKE LTRIM(RTRIM('%{descId}%')) OR P6_CODIGO = LTRIM(RTRIM('%{descId}%'))) AND D_E_L_E_T_ <> '*'";
                return Conexao.Query<CodDivergencia>(sql);
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
