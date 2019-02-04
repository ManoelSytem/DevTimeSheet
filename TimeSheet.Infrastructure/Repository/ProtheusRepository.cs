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
                              ,SZA010.ZA_FASE AS Fase
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


        public List<Domain.Enty.Apontamento> ObterListBatidaDePontoDiario(string mat, string filial, string Data)
        {

            try
            {
                using (OracleConnection Conexao = new OracleConnection(ConnectionString))
                {
                    List<Apontamento> listApontamento = new List<Apontamento>();
                    Apontamento apontamento;
                    var sql = $@"Select  P8_HORA AS hora from SP8010
                         where P8_MAT = LTRIM(RTRIM('{mat}'))  AND P8_FILIAL = LTRIM(RTRIM('{filial}')) 
                          AND D_E_L_E_T_ <> '*' AND P8_APONTA = 'S' AND P8_DATA = LTRIM(RTRIM('{Data}'))";
                    Conexao.Open();
                    var QueryResult = Conexao.Query<Apontamento>(sql);
                    foreach (Apontamento ApResult in QueryResult)
                    {
                        apontamento = new Apontamento();
                        apontamento.apontamento = TimeSpan.Parse(ApResult.hora.Replace(',', ':'));
                        apontamento.horaFim = TimeSpan.Parse(ApResult.hora.Replace(',', ':'));
                        listApontamento.Add(apontamento);
                    }

                    return listApontamento;
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

        public Usuario ObterUsuarioPorMatricula(string mat)
        {
            Conexao.Open();
            try
            {

                Usuario usuarioGerencia = new Usuario(); ;
                var sqlUser = $@"Select RA_NOME AS Nome from SRA010
                          WHERE RA_MAT = LTRIM(RTRIM('{mat}'))";
                var QueryResult = Conexao.Query<Usuario>(sqlUser);

                foreach (Usuario UserGerenciaResult in QueryResult)
                {
                    usuarioGerencia.Nome = UserGerenciaResult.Nome;
                }

                return usuarioGerencia;
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

        public Feriado ObterFeriadoProthues(string data, string filial)
        {
            Conexao.Open();
            try
            {

                Feriado feriado = new Feriado(); ;
                var sqlUser = $@"Select P3_FILIAL AS Filial, P3_FIXO AS FIXO, P3_DATA Data, P3_DESC AS Descricao, P3_FIXO from  SP3010
                                where P3_DATA = '{data}' AND P3_FILIAL = '{filial}'";
                var QueryResult = Conexao.Query<Feriado>(sqlUser);

                foreach(Feriado feriadoResult in QueryResult) {
                    feriado.Data = feriadoResult.Data;
                    feriado.Descricao = feriadoResult.Descricao;
                    feriado.Filial = feriadoResult.Filial;
                    feriado.Fixo = feriadoResult.Fixo;
                }

                if(feriado.Descricao == null)
                {
                    var sqlUser2 = $@"Select P3_FILIAL AS Filial, P3_FIXO AS FIXO, P3_DATA Data, P3_DESC AS Descricao, P3_FIXO from  SP3010
                                where P3_MESDIA = '{data.Substring(4,4)}' AND P3_FILIAL = '{filial}'";
                    var QueryResult2 = Conexao.Query<Feriado>(sqlUser2);

                    foreach (Feriado feriadoResult in QueryResult2)
                    {
                        feriado.Data = feriadoResult.Data;
                        feriado.Descricao = feriadoResult.Descricao;
                        feriado.Filial = feriadoResult.Filial;
                        feriado.Fixo = feriadoResult.Fixo;
                    }
                }
                return feriado;
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
