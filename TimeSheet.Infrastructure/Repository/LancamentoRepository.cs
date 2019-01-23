using Dapper;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Domain.Enty;
using TimeSheet.Domain.Interface;

namespace TimeSheet.Infrastructure.Repository
{
    public class LancamentoRepository 
    {
        private const string ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=stark.intranet.bahiagas.com.br)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ap12hml)));User Id=ap6;Password=ap6;";


        public LancamentoRepository()
        {

        }

        public void Add(Lancamento item, string filial, string dataProthues)
        {
            try
            {
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    string sQuery = $@"INSERT INTO ZYY010 (ZYY_CODIGO, ZYY_FILIAL, ZYY_DATA , ZYY_HORINI,ZYY_HORFIN, ZYY_PROJET,ZYY_CODDIV,ZYY_OBSERV,R_E_C_N_O_,  R_E_C_D_E_L_)
                    VALUES('{item.Codigo}','{filial}', '{dataProthues}', '{item.HoraInicio}','{item.HoraFim}', '{item.codEmpredimento}', '{item.CodDivergencia}','{item.Observacao}', (SELECT NVL(MAX(X.R_E_C_N_O_),0)+1 FROM ZYY010 X),0)";
                    dbConnection.Open();
                    dbConnection.Execute(sQuery);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Lancamento> ObterListaLancamentoPorDataMatricula(string data, string matricula)
        {
            try
            {
                List<Lancamento> listlancamento = new List<Lancamento>();
                Lancamento lancamento;
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    string sQuery = $@" Select DISTINCT 
                               LTRIM(RTRIM(ZYY_SEQ)) as Seq,
                               LTRIM(RTRIM(ZYY_DATA)) as DateLancamento, 
                               ZYY_HORINI as  HoraInicio,
                               ZYY_HORFIN as HoraFim,
                               ZYY_PROJET as codEmpredimento,
                               ZYY_CODDIV as CodDivergencia,
                               LTRIM(RTRIM(ZYY_OBSERV)) as Observacao,
                               SZ.ZA_DESC as DescricaoEmp
                               FROM ZYY010 ZA
                               INNER JOIN  ZYZ010  ZB ON (ZB.ZYZ_CODIGO =  ZA.ZYY_CODIGO) 
                               INNER JOIN  SZA010 SZ ON (ZA.ZYY_PROJET =  SZ.ZA_COD) 
                               WHERE ZB.ZYZ_MATUSU = '{matricula}' AND ZA.ZYY_DATA = '{data}' AND ZA.D_E_L_E_T_ <> '*'";
                    dbConnection.Open();
                    dbConnection.Execute(sQuery);

                    var QueryResult = dbConnection.Query<LancamentoDb>(sQuery);
                    foreach (LancamentoDb LacamentoResult in QueryResult)
                    {
                        lancamento = new Lancamento();
                        lancamento.Codigo = LacamentoResult.Codigo;
                        lancamento.HoraInicio = TimeSpan.Parse(LacamentoResult.HoraInicio);
                        lancamento.HoraFim = TimeSpan.Parse(LacamentoResult.HoraFim);
                        lancamento.codEmpredimento = LacamentoResult.codEmpredimento;
                        lancamento.DescricaoEmp = LacamentoResult.DescricaoEmp;
                        lancamento.CodDivergencia = LacamentoResult.CodDivergencia;
                        lancamento.Seq = LacamentoResult.Seq;
                        lancamento.DateLancamento = LacamentoResult.DateLancamento;
                        lancamento.Observacao = LacamentoResult.Observacao;
                        listlancamento.Add(lancamento);
                    }
                    return listlancamento;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Lancamento ObterLancamentoEdit(string data, string matricula, string codlancamento)
        {
            try
            {
                Lancamento lancamento;
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    string sQuery = $@" Select 
                              LTRIM(RTRIM(ZYY_SEQ)) as Seq,
                              LTRIM(RTRIM(ZYY_DATA)) as DateLancamento, 
                              ZYY_CODIGO as Codigo,
                               ZYY_HORINI as  HoraInicio,
                               ZYY_HORFIN as HoraFim,
                               LTRIM(RTRIM(ZYY_OBSERV)) as Observacao,
                               ZYY_PROJET as codEmpredimento,
                               ZYY_CODDIV AS CodDivergencia,
                               LTRIM(RTRIM(SZ.ZA_DESC)) as DescricaoEmp
                               FROM ZYY010 ZA
                               INNER JOIN  ZYZ010  ZB ON (ZB.ZYZ_CODIGO =  ZA.ZYY_CODIGO)
                               INNER JOIN  SZA010 SZ ON (ZA.ZYY_PROJET =  SZ.ZA_COD) 
                               WHERE ZB.ZYZ_MATUSU = '{matricula}' AND ZA.ZYY_DATA = '{data}'  AND ZYY_SEQ = '{codlancamento}' AND ZA.D_E_L_E_T_ <> '*'
                               ";
                    var LacamentoResult = dbConnection.QueryFirstOrDefault<LancamentoDb>(sQuery);

                        lancamento = new Lancamento();
                        lancamento.Codigo = LacamentoResult.Codigo;
                        lancamento.HoraInicio = TimeSpan.Parse(LacamentoResult.HoraInicio);
                        lancamento.HoraFim = TimeSpan.Parse(LacamentoResult.HoraFim);
                        lancamento.codEmpredimento = LacamentoResult.codEmpredimento;
                        lancamento.DescricaoEmp = LacamentoResult.DescricaoEmp;
                        lancamento.CodDivergencia = LacamentoResult.CodDivergencia;
                        lancamento.Seq = LacamentoResult.Seq;
                        lancamento.DateLancamento = LacamentoResult.DateLancamento;
                        lancamento.Observacao = LacamentoResult.Observacao;
                    return lancamento;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Lancamento> ObterListaLancamentoPorCodMarcacao(string codigoMarcacao, string matricula)
        {
            try
            {
                List<Lancamento> listlancamento = new List<Lancamento>();
                Lancamento lancamento;
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    string sQuery = $@" Select DISTINCT 
                               LTRIM(RTRIM(ZYY_SEQ)) as Seq,
                              LTRIM(RTRIM(ZYY_DATA)) as DateLancamento, 
                               ZYY_CODIGO as Codigo,
                               ZYY_HORINI as  HoraInicio,
                               ZYY_HORFIN as HoraFim,
                               ZYY_PROJET as codEmpredimento,
                               ZYY_CODDIV AS CodDivergencia,
                               SZ.ZA_DESC AS DescricaoEmp
                               FROM ZYY010 ZA
                               INNER JOIN  ZYZ010  ZB ON (ZB.ZYZ_CODIGO =  ZA.ZYY_CODIGO) 
                               INNER JOIN  SZA010 SZ ON (ZA.ZYY_PROJET =  SZ.ZA_COD) 
                               WHERE ZA.ZYY_CODIGO = '{codigoMarcacao}'AND ZB.ZYZ_MATUSU = '{matricula}' AND ZA.D_E_L_E_T_ <> '*' ";
                    dbConnection.Open();
                    dbConnection.Execute(sQuery);

                    var QueryResult = dbConnection.Query<LancamentoDb>(sQuery);
                    foreach (LancamentoDb LacamentoResult in QueryResult)
                    {
                        lancamento = new Lancamento();
                        lancamento.Codigo = LacamentoResult.Codigo;
                        lancamento.HoraInicio = TimeSpan.Parse(LacamentoResult.HoraInicio);
                        lancamento.HoraFim = TimeSpan.Parse(LacamentoResult.HoraFim);
                        lancamento.codEmpredimento = LacamentoResult.codEmpredimento;
                        lancamento.DescricaoEmp = LacamentoResult.DescricaoEmp;
                        lancamento.CodDivergencia = LacamentoResult.CodDivergencia;
                        lancamento.Seq = LacamentoResult.Seq;
                        lancamento.DateLancamento = LacamentoResult.DateLancamento;
                        listlancamento.Add(lancamento);
                    }
                    return listlancamento;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateLancamento(Lancamento item)
        {

            try
            {
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    string sQuery = $@"UPDATE ZYY010
                            SET ZYY_HORINI =  '{item.HoraInicio}', ZYY_HORFIN = '{item.HoraFim}',
                            ZYY_PROJET = '{item.codEmpredimento}', ZYY_CODDIV = '{item.CodDivergencia}',
                             ZYY_OBSERV = '{item.Observacao}'
                            WHERE ZYY_SEQ  = '{item.Seq}'";

                    dbConnection.Open();
                    dbConnection.Execute(sQuery);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(string sequencia)
        {

            using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
            {
                string sQuery = $@"UPDATE ZYY010 
                                   SET D_E_L_E_T_ = '*',
                                   R_E_C_D_E_L_ = R_E_C_N_O_
                                   WHERE ZYY_SEQ = '{sequencia}'";
                dbConnection.Open();
                dbConnection.Execute(sQuery);
            }
        }


    }
}
