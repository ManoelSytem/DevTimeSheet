using Dapper;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Domain.Enty;

namespace TimeSheet.Infrastructure.Repository
{
    public class FechamentoRepository
    {
        private const string ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=stark.intranet.bahiagas.com.br)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ap12hml)));User Id=ap6;Password=ap6;";


        public FechamentoRepository()
        {

        }

        public void Add(Fechamento item, string filial, string dataProthues, string matUser)
        {
            try
            {
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    string sQuery = $@"INSERT INTO ZYU010 (ZYU_FILIAL,ZYU_CODIGO,ZYU_DATA,ZYU_HORA,ZYU_MATUSU,ZYU_THOREX,ZYU_THORAT,ZYU_THORFT,ZYU_THORAB,ZYU_THORAS, R_E_C_N_O_,  R_E_C_D_E_L_) 
                                    VALUES ('{filial}','{item.CodigoMarcacao}','{dataProthues}','{DateTime.Now.ToShortTimeString()}','{matUser}', {Convert.ToString(item.TotalHoraExedente).Replace(",", ".")},{Convert.ToString(item.TotalAtraso).Replace(",", ".")},{item.TotalFalta},{Convert.ToString(item.TotalAbono).Replace(",", ".")},{Convert.ToString(item.TotalHora).Replace(",", ".")},(SELECT NVL(MAX(X.R_E_C_N_O_),0)+1 FROM ZYY010 X),0)";
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
