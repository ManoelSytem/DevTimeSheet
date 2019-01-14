using Dapper;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Domain;
using TimeSheet.Domain.Enty;
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

        public CodDivergencia ObterCodigoDivergenciaPorCodigo(string cod)
        {
            try
            {
                Conexao.Open();
                var sql = $@"SELECT P6_CODIGO as Codigo, P6_DESC as Descricao  FROM SP6010
                                WHERE P6_CODIGO LIKE LTRIM(RTRIM('%{cod}%')) AND D_E_L_E_T_ <> '*'";
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

        public IEnumerable<CodDivergencia> ObterListaCodigoDivergenciaPorIdDesc(string descId)
        {
            try
            {
                Conexao.Open();
                var sql = $@"SELECT P6_CODIGO as Codigo, P6_DESC as Descricao  FROM SP6010
                                WHERE (P6_DESC LIKE LTRIM(RTRIM('%{descId}%')) OR P6_CODIGO LIKE LTRIM(RTRIM('%{descId}%'))) AND D_E_L_E_T_ <> '*'";
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

        public IEnumerable<Domain.Enty.Empreendimento> ObterEmpreendimentos(string nome)
        {
          
            Conexao.Open();
            try
            {
                var sql = $@"SELECT LTRIM(RTRIM(SZA010.ZA_COD)) AS CodigoProtheus
                              ,LTRIM(RTRIM(SZA010.ZA_DESC)) AS Nome
                              ,SZA010.ZA_FASE
                            FROM SZA010
                            INNER JOIN (
                              SELECT SZA.ZA_COD
                                ,MAX(SZA.ZA_FASE) ZA_FASE
                              FROM SZA010 SZA
                              WHERE SZA.D_E_L_E_T_ = ' '
                              GROUP BY SZA.ZA_COD
                            ) SZA ON SZA010.ZA_COD = SZA.ZA_COD
                              AND SZA010.ZA_FASE = SZA.ZA_FASE
                            WHERE SZA010.D_E_L_E_T_ = ' '
                                AND (LTRIM(RTRIM(SZA010.ZA_DESC)) LIKE '%{nome.ToUpper()}%'
                                   OR LTRIM(RTRIM(SZA010.ZA_COD)) LIKE '%{nome.ToUpper()}%')
                            ORDER BY SZA010.ZA_DESC";
                return Conexao.Query<Empreendimento>(sql);
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
