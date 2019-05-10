using Dapper;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeSheet.Domain;
using TimeSheet.Domain.Enty;
using TimeSheet.Domain.Util;
using TimeSheet.Infrastructure.Interface;

namespace TimeSheet.Infrastructure.Repository
{

    public class ProtheusRepository
    {
        //192.168.0.8
        // BASE TESTE AP12HML
        private OracleConnection Conexao;
        private const string ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=stark.intranet.bahiagas.com.br)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=AP12HML)));User Id=ap6;Password=ap6;";

        public ProtheusRepository()
        {
            Conexao = new OracleConnection(ConnectionString);
        }

        public CodDivergencia ObterCodigoDivergenciaPorCodigo(string cod)
        {
            try
            {
                Conexao.Open();
                var sql = $@"SELECT LTRIM(RTRIM(P6_FSTPTS))  as Constant, P6_CODIGO as Codigo, P6_DESC as Descricao  FROM SP6010
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

        public IEnumerable<CodDivergencia> ObterListaCodigoDivergenciaPorIdDesc(string descId)
        {
            try
            {
                List<CodDivergencia> listCodivegencia = new List<CodDivergencia>();
                Conexao.Open();
                var sql = $@"SELECT LTRIM(RTRIM(P6_FSTPTS))  as Constant, P6_CODIGO as Codigo, LTRIM(RTRIM(P6_DESC)) as Descricao  FROM SP6010
                                WHERE (P6_DESC LIKE LTRIM(RTRIM('%{descId}%')) OR P6_CODIGO LIKE LTRIM(RTRIM('%{descId}%'))) AND P6_FSTPTS IN('01','02','03') AND D_E_L_E_T_ <> '*'";
                Conexao.Query<CodDivergencia>(sql);
                var QueryResult = Conexao.Query<CodDivergencia>(sql);

                foreach (CodDivergencia codigoResult in QueryResult)
                {
                    CodDivergencia novo = new CodDivergencia();
                    novo.codigo = codigoResult.codigo;
                    novo.Descricao = codigoResult.Descricao;
                    if(Constantes.HRSEXCEDENTES == codigoResult.Constant){ novo.Constant = "Hrs Excedentes";}
                    else if (Constantes.ABONOS == codigoResult.Constant) { novo.Constant = "Abonos";}
                    else if (Constantes.NAOTRABALHADA == codigoResult.Constant) { novo.Constant = "Não trabalhadas"; }
                    
                    listCodivegencia.Add(novo);
                }

                return listCodivegencia;
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
                                ,SZA.ZA_FASE ZA_FASE
                                ,SZA.ZA_STATUS
                              FROM SZA010 SZA
                              WHERE SZA.D_E_L_E_T_ = ' '
                            ) SZA ON SZA010.ZA_COD = SZA.ZA_COD
                              AND SZA010.ZA_FASE = SZA.ZA_FASE
                            WHERE SZA010.D_E_L_E_T_ = ' '
                                AND (LTRIM(RTRIM(SZA010.ZA_DESC)) LIKE '%{nome.ToUpper()}%'
                                   OR LTRIM(RTRIM(SZA010.ZA_COD)) LIKE '%{nome.ToUpper()}%') AND SZA.ZA_STATUS = '1'
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
                    var sql = $@"Select  LTRIM(RTRIM(P8_HORA)) AS hora from SP8010
                         where P8_MAT = LTRIM(RTRIM('{mat}'))  AND P8_FILIAL = LTRIM(RTRIM('{filial}')) 
                          AND D_E_L_E_T_ <> '*' AND P8_APONTA = 'S' AND P8_DATA = LTRIM(RTRIM('{Data}'))";
                    Conexao.Open();
                    var QueryResult = Conexao.Query<Apontamento>(sql);
                    foreach (Apontamento ApResult in QueryResult)
                    {
                        apontamento = new Apontamento();
                        int virgulaIndice = ApResult.hora.IndexOf(',');
                        string valor = ApResult.hora.Substring(virgulaIndice);
                        if (ApResult.hora.Length == 1 | ApResult.hora.Length == 2) { apontamento.apontamento = TimeSpan.Parse("0"+ApResult.hora+":00"); }
                        else if (valor.Length == 2) { string horaMinuto = ApResult.hora + "0"; apontamento.apontamento = TimeSpan.Parse(horaMinuto.Replace(',', ':')); } else
                        {
                            
                            apontamento.apontamento = TimeSpan.Parse(ApResult.hora.Replace(',', ':'));
                            apontamento.horaFim = TimeSpan.Parse(ApResult.hora.Replace(',', ':'));
                        }

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


        public List<Apontamento> ObterApontamentos(string matricula, string filial, string Data)
        {
            try
            {
                using (OracleConnection Conexao = new OracleConnection(ConnectionString))
                {
                    var sql = $@"SELECT DISTINCT SP8010.P8_HORA AS ""hora""
                                  ,SP8010.P8_DATA AS ""dataApontamento""
                                  ,ZYY010.ZYY_CODIGO AS ""listLancamento.Codigo""
                                  ,ZYY010.ZYY_SEQ AS ""listLancamento.Seq""
                                  ,ZYY010.ZYY_DATA AS ""listLancamento.DateLancamento""
                                  ,ZYY010.ZYY_HORINI AS ""listLancamento.HoraInicio""
                                  ,ZYY010.ZYY_HORFIN AS ""listLancamento.HoraFim""
                                  ,ZYY010.ZYY_OBSERV AS ""listLancamento.Observacao""
                                  ,ZYY010.ZYY_CODDIV AS ""listLancamento.CodDivergencia""
                                FROM ZYY010
                                INNER JOIN ZYZ010 ON ZYY010.ZYY_FILIAL = ZYZ010.ZYZ_FILIAL
                                  AND ZYY010.ZYY_CODIGO = ZYZ010.ZYZ_CODIGO
                                  AND ZYZ010.D_E_L_E_T_ <> '*'
                                INNER JOIN SP8010 ON SP8010.P8_FILIAL = ZYZ010.ZYZ_FILIAL
                                  AND SP8010.P8_MAT = ZYZ010.ZYZ_MATUSU
                                  AND ZYY010.ZYY_DATA = SP8010.P8_DATA
                                  AND SP8010.D_E_L_E_T_ <> '*'
                                  AND SP8010.P8_APONTA = 'S'
                                  AND SP8010.P8_DATA = '{Data}'
                                  AND SP8010.P8_MAT = '{matricula}'
                                  AND SP8010.P8_FILIAL = '{filial}'
                                WHERE ZYY010.D_E_L_E_T_ <> '*'";
                    Conexao.Open();
                    return Conexao.Query<Apontamento>(sql).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Usuario ObterUsuarioPorMatricula(string mat)
        {
            Conexao.Open();
            try
            {

                Usuario usuario = new Usuario();
                var sqlUser = $@"Select RA_NOME AS Nome from SRA010
                          WHERE RA_MAT = LTRIM(RTRIM('{mat}'))";
                var QueryResult = Conexao.Query<Usuario>(sqlUser);

                foreach (Usuario UserGerenciaResult in QueryResult)
                {
                    usuario.Nome = UserGerenciaResult.Nome;
                }

                return usuario;
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


        public Usuario ObterCoordenador(string centroCusto)
        {
            Conexao.Open();
            try
            {

                Usuario usuario = new Usuario(); ;
                var sqlUser = $@"Select LTRIM(RTRIM(CTT_DESC03)) AS Nome, LTRIM(RTRIM(CTT_EMLGER))  AS Email,  LTRIM(RTRIM(CTT_DESC01)) as Gerencia  from CTT010 
                               where CTT_CUSTO = '{centroCusto}'";
                var QueryResult = Conexao.Query<Usuario>(sqlUser);

                foreach (Usuario UserGerenciaResult in QueryResult)
                {
                    usuario.Nome = UserGerenciaResult.Nome;
                    usuario.Email = UserGerenciaResult.Email;
                    usuario.Gerencia = UserGerenciaResult.Gerencia;
                }

                return usuario;
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

                foreach (Feriado feriadoResult in QueryResult)
                {
                    feriado.Data = feriadoResult.Data;
                    feriado.Descricao = feriadoResult.Descricao;
                    feriado.Filial = feriadoResult.Filial;
                    feriado.Fixo = feriadoResult.Fixo;
                }

                if (feriado.Descricao == null)
                {
                    var sqlUser2 = $@"Select P3_FILIAL AS Filial, P3_FIXO AS FIXO, P3_DATA Data, P3_DESC AS Descricao, P3_FIXO from  SP3010
                                where P3_MESDIA = '{data.Substring(4, 4)}' AND P3_FILIAL = '{filial}'";
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


        public List<Usuario> ObterListColaborador(string descricao, string centroDeCusto)
        {
            Conexao.Open();
            try
            {

                var sqlUser = $@"Select LTRIM(RTRIM(RA_MAT)) as SubjectId, LTRIM(RTRIM(RA_NOMECMP))  as Nome from SRA010
                                  where (LTRIM(RTRIM(RA_NOMECMP)) LIKE UPPER('%{descricao}%') OR LTRIM(RTRIM(RA_MAT)) = '{descricao}') AND LTRIM(RTRIM(RA_CC)) = '{centroDeCusto}'";
                var QueryResult = Conexao.Query<Usuario>(sqlUser).ToList();

                return QueryResult;
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


        public CodDivergencia ObterTipoCodigoDivergencia(string codigo)
        {
            try
            {
                Conexao.Open();
                var sql = $@"SELECT LTRIM(RTRIM(P6_FSTPTS))  as Constant, P6_CODIGO as Codigo, P6_DESC as Descricao  FROM SP6010
                                WHERE  P6_CODIGO = '{codigo}' AND D_E_L_E_T_ <> '*'";
                Conexao.Query<CodDivergencia>(sql);
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



    }
}
