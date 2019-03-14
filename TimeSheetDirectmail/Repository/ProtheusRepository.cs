using Dapper;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetDirectmail.Model;

namespace TimeSheetDirectmail.Repository
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

        public List<Usuario> ObterUsuarioSemLancamento()
        {
            List<Usuario> usuario = new List<Usuario>();

            return usuario;
        }


        public Configuracao ObterConfiguracao()
        {

            try
            {
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    dbConnection.Open();
                    var sql = @" SELECT LTRIM(RTRIM(ZYX_CODIGO)) AS Codigo
                              ,LTRIM(RTRIM(ZYX_INIMAR)) AS DiaInicio
                              ,LTRIM(RTRIM(ZYX_FINMAR)) AS DiaFim
                              ,LTRIM(RTRIM(ZYX_CODDIV)) AS CodDivergencia
                              ,LTRIM(RTRIM(ZYX_FEMAIL)) AS Frequencia_email
                              ,LTRIM(RTRIM(ZYX_DEMAIL)) AS Qtddiadatafechamento
                              ,LTRIM(RTRIM(ZYX_DLIFEC)) AS DiaMesLimiteFecha
                              ,LTRIM(RTRIM(ZYX_AEMAIL)) AS AssuntoEmail 
                            FROM ZYX010
                            WHERE D_E_L_E_T_  <> '*'";
                    return dbConnection.QueryFirstOrDefault<Configuracao>(sql);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
