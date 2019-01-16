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
                    string sQuery = $@"INSERT INTO ZYY010 (ZYY_CODIGO, ZYY_FILIAL, ZYY_DATA , ZYY_HORINI,ZYY_HORFIN, ZYY_PROJET,ZYY_CODDIV, R_E_C_N_O_)
                    VALUES('{item.Codigo}','{filial}', '{dataProthues}', '{item.HoraInicio}','{item.HoraFim}', '{item.codEmpredimento}', '{item.CodDivergencia}', (SELECT MAX(X.R_E_C_N_O_)+1 FROM ZYV010 X))";
                    dbConnection.Open();
                    dbConnection.Execute(sQuery);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Lancamento> ObterListaMarcacaoPorDataMatricula(string data, string matricula)
        {
            try
            {
                List<Lancamento> listlancamento = new List<Lancamento>();
                Lancamento lancamento;
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    string sQuery = $@" Select DISTINCT 
                              ZYY_CODIGO as Codigo,
                               ZYY_HORINI as  HoraInicio,
                               ZYY_HORFIN as HoraFim,
                               ZYY_PROJET as codEmpredimento,
                               ZYY_CODDIV AS CodDivergencia,
                               SZ.ZA_DESC AS DescricaoEmp
                               FROM ZYY010 ZA
                               INNER JOIN  ZYZ010  ZB ON (ZB.ZYZ_CODIGO =  ZA.ZYY_CODIGO) 
                               INNER JOIN  SZA010 SZ ON (ZA.ZYY_PROJET =  SZ.ZA_COD) 
                               WHERE ZB.ZYZ_MATUSU = '{matricula}' AND ZA.ZYY_DATA = '{data}'";
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

        public Lancamento ObterListaMarcacaoEdit(string data, string matricula, string codlancamento)
        {
            try
            {
                Lancamento lancamento;
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    string sQuery = $@" Select 
                              ZYY_CODIGO as Codigo,
                               ZYY_HORINI as  HoraInicio,
                               ZYY_HORFIN as HoraFim,
                               ZYY_PROJET as codEmpredimento,
                               ZYY_CODDIV AS CodDivergencia
                               FROM ZYY010 ZA
                               INNER JOIN  ZYZ010  ZB ON (ZB.ZYZ_CODIGO =  ZA.ZYY_CODIGO) 
                               WHERE ZB.ZYZ_MATUSU = '{matricula}' AND ZA.ZYY_DATA = '{data}'  AND ZYY_CODIGO = '{codlancamento}'";
                    var LacamentoResult = dbConnection.QueryFirstOrDefault<LancamentoDb>(sQuery);

                        lancamento = new Lancamento();
                        lancamento.Codigo = LacamentoResult.Codigo;
                        lancamento.HoraInicio = TimeSpan.Parse(LacamentoResult.HoraInicio);
                        lancamento.HoraFim = TimeSpan.Parse(LacamentoResult.HoraFim);
                        lancamento.codEmpredimento = LacamentoResult.codEmpredimento;
                        lancamento.DescricaoEmp = LacamentoResult.DescricaoEmp;
                        lancamento.CodDivergencia = LacamentoResult.CodDivergencia;
                       
                    
                    return lancamento;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
