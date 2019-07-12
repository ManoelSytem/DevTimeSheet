using Dapper;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using TimeSheet.Domain.Enty;

namespace TimeSheet.Infrastructure.Repository
{
    public class FechamentoRepository
    {
        private const string ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=stark.intranet.bahiagas.com.br)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ap12hml)));User Id=ap6;Password=ap6;";
        //private const string ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=bgasha-scan.intranet.bahiagas.com.br)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=BAHIAGAS)));User Id=ap6;Password=msbd106";


        public FechamentoRepository()
        {

        }

        public void Add(Fechamento item, string filial, string dataProthues, string matUser, string centroCusto, string projeto, string status, string fase)
        {
            try
            {
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    string sQuery = $@"INSERT INTO ZYU010 (ZYU_FILIAL,ZYU_CODIGO,ZYU_DATA,ZYU_HORA,ZYU_MATUSU,ZYU_THOREX,ZYU_THORAT,ZYU_THORAB,ZYU_THORAS,ZYU_CCUSTO,ZYU_PROJET,ZYU_STATUS,ZYU_FASE,ZYU_THORNT, R_E_C_N_O_,  R_E_C_D_E_L_) 
                                    VALUES ('{filial}','{item.CodigoMarcacao}',
                                            '{dataProthues}',
                                            '{DateTime.Now.ToShortTimeString().Replace(":", "")}',
                                            '{matUser}', {Convert.ToString(item.TotalHoraExedente).Replace(",", ".")},
                                            {Convert.ToString(item.TotalAtraso).Replace(",", ".")},
                                            {Convert.ToString(item.TotalAbono).Replace(",", ".")},
                                            {Convert.ToString(item.TotalHora).Replace(",", ".")},'{centroCusto}',
                                           '{projeto}',
                                           '{status}',
                                           '{fase}',{item.TotalFalta+ item.TotalAbono},(SELECT NVL(MAX(X.R_E_C_N_O_),0)+1 FROM ZYY010 X),0)";
                    dbConnection.Open();
                    dbConnection.Execute(sQuery);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SalvarFechamento(List<Fechamento> fechamentosPordiaLancamento, string filial, string dataProtheus, string matUser, string centroCusto,string status)
        {
            try
            {
               
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    dbConnection.Open();
                    foreach (Fechamento item in fechamentosPordiaLancamento)
                    {
                      string sQuery = $@"INSERT INTO ZYU010 (ZYU_FILIAL,ZYU_CODIGO,ZYU_DATA,ZYU_HORA,ZYU_MATUSU,ZYU_THOREX,ZYU_THORAB,ZYU_THORAS,ZYU_CCUSTO,ZYU_PROJET,ZYU_STATUS,ZYU_FASE,ZYU_DTMARC,ZYU_THORNT, R_E_C_N_O_,  R_E_C_D_E_L_) 
                                    VALUES ('{filial}','{item.CodigoMarcacao}',
                                            '{dataProtheus}',
                                            '{DateTime.Now.ToShortTimeString().Replace(":", "")}',
                                            '{matUser}', {Convert.ToString(item.TotalHoraExedente).Replace(",", ".")},
                                            {Convert.ToString(item.TotalAbono).Replace(",", ".")},
                                            {Convert.ToString(item.TotalHora).Replace(",", ".")},'{centroCusto}',
                                           '{item.CodigoProjeto}',
                                           '{status}',
                                           '{item.Fase}','{item.DataLancamento}',{Convert.ToString(item.TotalFaltaAtraso).Replace(",", ".")},(SELECT NVL(MAX(X.R_E_C_N_O_),0)+1 FROM ZYU010 X),0)";
                        dbConnection.Execute(sQuery);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Fechamento ObterListaFechamentoPorMatriculaEMarcacao(string codigoMarcacao, string matricula)
        {
            try
            {
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    string sQuery = $@"Select LTRIM(RTRIM(ZYU_DATA)) as Datafechamento,
                                     LTRIM(RTRIM(ZYU_THOREX))as TotalHoraExedente,
                                     LTRIM(RTRIM(ZYU_THORAT)) as TotalAtraso,
                                     LTRIM(RTRIM(ZYU_THORAB)) as TotalAbono,
                                     LTRIM(RTRIM(ZYU_THORAS))as TotalHora
                                     from ZYU010
                                     where ZYU_CODIGO = '{codigoMarcacao}' AND ZYU_MATUSU = '{matricula}' AND D_E_L_E_T_ <> '*' ";
                    dbConnection.Open();
                    dbConnection.Execute(sQuery);
                    return dbConnection.QueryFirstOrDefault<Fechamento>(sQuery);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        
        public IEnumerable<Fechamento> ObterListaFechamento(string codigoMarcacao, string matricula)
        {
            try
            {
               
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    string sQuery = $@"Select 
                                    LTRIM(RTRIM(ZYU_DTMARC)) as DataLancamento,
                                     sum(LTRIM(RTRIM(ZYU_THOREX))) as  TotalHoraExedente,
                                     sum(LTRIM(RTRIM(ZYU_THORAB))) as  TotalAbono,
                                     sum(LTRIM(RTRIM(ZYU_THORAS))) as  TotalHora,
                                     sum(LTRIM(RTRIM(ZYU_THORNT)))  as  TotalFaltaAtraso
                                     from ZYU010 
                                     where ZYU_CODIGO = '{codigoMarcacao}' AND ZYU_MATUSU = '{matricula}'  AND (ZYU_STATUS = '2' OR ZYU_STATUS = '3' OR ZYU_STATUS = '4') AND ZYU_PROJET <> '00000' AND D_E_L_E_T_ <> '*' 
                                    group by LTRIM(RTRIM(ZYU_DTMARC))";
                    dbConnection.Open();
                    dbConnection.Execute(sQuery);
                    var result =  dbConnection.Query<Fechamento>(sQuery);

                    return result;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<Fechamento> ObterListaFechamentoPorDia(string codigoMarcacao, string matricula)
        {
            try
            {

                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    string sQuery = $@"Select 
                                    LTRIM(RTRIM(ZYU_DTMARC)) as DataLancamento,
                                     sum(LTRIM(RTRIM(ZYU_THOREX))) as  TotalHoraExedente,
                                     sum(LTRIM(RTRIM(ZYU_THORAB))) as  TotalAbono,
                                     sum(LTRIM(RTRIM(ZYU_THORAS))) as  TotalHora,
                                     sum(LTRIM(RTRIM(ZYU_THORNT)))  as  TotalFaltaAtraso
                                     from ZYU010 
                                     where ZYU_CODIGO = '{codigoMarcacao}' AND ZYU_MATUSU = '{matricula}'  AND (ZYU_STATUS = '2' OR ZYU_STATUS = '3') AND ZYU_PROJET = '00000' AND D_E_L_E_T_ <> '*' 
                                    group by LTRIM(RTRIM(ZYU_DTMARC))";
                    dbConnection.Open();
                    dbConnection.Execute(sQuery);
                    var result = dbConnection.Query<Fechamento>(sQuery);
                    return result;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       

    }
}
