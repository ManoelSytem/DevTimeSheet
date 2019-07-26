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
    public class ConfiguracaoRepository : AbstractRepository<Configuracao>
    {
        public ConfiguracaoRepository(IConfiguration configuration) : base(configuration) { }


        public override void Add(Configuracao item, string filial, string matricula)
        {
            try
            {
                if (matricula == null) matricula = "NULL";
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    string sQuery = $@"INSERT INTO ZYX010 (ZYX_CODIGO, ZYX_DLIFEC,  ZYX_FEMAIL, ZYX_DEMAIL, ZYX_INIMAR, ZYX_FINMAR, ZYX_CODDIV,ZYX_MATUSU,ZYX_AEMAIL, R_E_C_N_O_,  R_E_C_D_E_L_)"
                                    + "VALUES('"+item.Codigo+ "'" + ", " + item.DiaMesLimiteFecha+ ","+
                                    "'"+item.Frequencia_email+ "'" + ", " + item.Qtddiadatafechamento+ "" + ", " + item.DiaInicio + "" + "," + item.DiaFim + ","+ " '" + item.CodDivergencia + "'" + "," +" '"+matricula+ "'"+"," +" '"+item.AssuntoEmail+ "'"+ ",(SELECT NVL(MAX(X.R_E_C_N_O_),0)+1 FROM ZYX010 X),0)";
                    dbConnection.Open();
                    dbConnection.Execute(sQuery);
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

        public override Configuracao Find()
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
                    return  dbConnection.QueryFirstOrDefault<Configuracao>(sql);
                   
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
         
        }

        public override Configuracao FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override void Remove(string id)
        {
            try
            {
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    string sQuery = $@"UPDATE ZYX010 
                                   SET D_E_L_E_T_ = '*',
                                   R_E_C_D_E_L_ = (SELECT MAX(X.R_E_C_D_E_L_)+1 FROM ZYX010 X)
                                   WHERE ZYX_CODIGO = '{id}'";
                    dbConnection.Open();
                    dbConnection.Execute(sQuery);
                    string uQuery = $@"UPDATE ZYX010 
                                   SET R_E_C_N_O_ = (SELECT X.R_E_C_D_E_L_ FROM ZYX010 X WHERE ZYX_CODIGO = '{id}')
                                   WHERE ZYX_CODIGO = '{id}'";
                    dbConnection.Execute(uQuery);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Update(Configuracao item)
        {
            try
            {
                if (item.MatriculaUsuario == null) item.MatriculaUsuario = "NULL";
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    string sQuery = $@"UPDATE ZYX010 
                            SET ZYX_DLIFEC = {item.DiaMesLimiteFecha }, ZYX_FEMAIL = '{item.Frequencia_email}',
                            ZYX_DEMAIL = {item.Qtddiadatafechamento}, ZYX_INIMAR = {item.DiaInicio}, ZYX_FINMAR = {item.DiaFim}, ZYX_CODDIV = '{item.CodDivergencia}',
                            ZYX_MATUSU = '{item.FilialProtheus}',
                            ZYX_AEMAIL = '{item.AssuntoEmail}'
                            WHERE ZYX_CODIGO ='{item.Codigo}'";
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
