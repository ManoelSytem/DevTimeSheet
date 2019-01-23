using Dapper;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Domain.Enty;

namespace TimeSheet.Infrastructure.Repository
{
    public class MarcacaoRepository
    {
        private const string ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=stark.intranet.bahiagas.com.br)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ap12hml)));User Id=ap6;Password=ap6;";

        public MarcacaoRepository()
        {

        }

        public void Add(Marcacao item)
        {
            try
            {
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    string sQuery = $@"INSERT INTO ZYZ010 (ZYZ_FILIAL, ZYZ_MATUSU, ZYZ_ANOMES, ZYZ_STATUS, ZYZ_CODINT, R_E_C_N_O_)
                             VALUES('{item.Filial}', '{item.MatUsuario}', '{item.AnoMes}','{item.Status}', '{item.codigojornada}', (SELECT MAX(X.R_E_C_N_O_)+1 FROM ZYV010 X))";
                    dbConnection.Open();
                    dbConnection.Execute(sQuery);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Marcacao> ObterListaMarcacaoPorMatricula(string matricula)
        {
            try
            {
                List<Marcacao> listMarcacao = new List<Marcacao>();
                Marcacao marcacao;
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    string sQuery = $@"Select  LTRIM(RTRIM(ZYZ_MATUSU)) as MatUsuario, LTRIM(RTRIM(ZYZ_CODIGO))  as Codigo, ZYZ_ANOMES as AnoMes, ZYZ_STATUS as Status from ZYZ010
                                        Where ZYZ_MATUSU = '{matricula}' AND D_E_L_E_T_ <> '*' ";
                    dbConnection.Open();
                    dbConnection.Execute(sQuery);

                    var QueryResult = dbConnection.Query<Marcacao>(sQuery);
                    foreach (Marcacao MarcacaoResult in QueryResult)
                    {
                        marcacao = new Marcacao();
                        marcacao.MatUsuario = MarcacaoResult.MatUsuario;
                        marcacao.AnoMes = MarcacaoResult.AnoMes;
                        marcacao.Status = MarcacaoResult.Status;
                        marcacao.Codigo = MarcacaoResult.Codigo;
                        listMarcacao.Add(marcacao);
                    }
                    return listMarcacao;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Marcacao> ObterListaMarcacaoPorCodigo(string codigo)
        {
            try
            {
                List<Marcacao> listMarcacao = new List<Marcacao>();
                Marcacao marcacao;
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    string sQuery = $@"Select  ZYZ_ANOMES as AnoMes, ZYZ_STATUS as Status from ZYZ010
                                        Where ZYZ_CODIGO = '{codigo}' AND  D_E_L_E_T_ <> '*'";
                    dbConnection.Open();
                    dbConnection.Execute(sQuery);

                    var QueryResult = dbConnection.Query<Marcacao>(sQuery);
                    foreach (Marcacao MarcacaoResult in QueryResult)
                    {
                        marcacao = new Marcacao();
                        marcacao.AnoMes = MarcacaoResult.AnoMes;
                        marcacao.Status = MarcacaoResult.Status;
                        marcacao.Codigo = MarcacaoResult.Codigo;
                        listMarcacao.Add(marcacao);
                    }
                    return listMarcacao;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(string codigo)
        {

            using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
            {
                string sQuery = $@"UPDATE ZYZ010 
                                   SET D_E_L_E_T_ = '*',
                                   R_E_C_D_E_L_ = R_E_C_N_O_
                                   WHERE ZYZ_CODIGO = '{codigo}'
                                   UPDATE ZYY010 
                                   SET D_E_L_E_T_ = '*',
                                   R_E_C_D_E_L_ = R_E_C_N_O_
                                   WHERE ZYY_CODIGO = '{codigo}'";
                dbConnection.Open();
                dbConnection.Execute(sQuery);
            }
        }
    }
}
