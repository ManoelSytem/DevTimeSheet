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


        public override void Add(Configuracao item)
        {
            try
            {
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    string sQuery = "INSERT INTO ZYX010 (ZYX_CODIGO, ZYX_DLIFEC,  ZYX_FEMAIL, ZYX_DEMAIL, ZYX_INIMAR, ZYX_FINMAR, ZYX_CODDIV)"
                                    + "VALUES('"+item.Codigo+ "'" + ", " + item.DiaMesLimiteFecha+ ","+
                                    "'"+item.Frequencia_email+ "'" + ", " + item.Qtddiadatafechamento+ "" + ", " + item.DiaInicio + "" + "," + item.DiaFim + "," + " '" + item.CodDivergencia+"'"+")";
                    dbConnection.Open();
                    dbConnection.Execute(sQuery);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
          
        }

        public override IEnumerable<Configuracao> FindAll()
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
                            FROM ZYX010
                            WHERE D_E_L_E_T_  <> '*'";
                    return  dbConnection.Query<Configuracao>(sql);
                   
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

        public override void Remove(int id)
        {
            try
            {
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    string sQuery = @"UPDATE ZYX010 
                                   SET D_E_L_E_T_ = '*',
                                   R_E_C_D_E_L_ = (SELECT MAX(X.R_E_C_D_E_L_)+1 FROM ZYX010 X),
                                   R_E_C_N_O_ = (SELECT X.R_E_C_D_E_L_ FROM ZYX010 X)
                                   WHERE ZYX_CODIGO = '{id}'";
                    dbConnection.Open();
                    dbConnection.Execute(sQuery);
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
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    string sQuery = $@"UPDATE ZYX010 
                            SET ZYX_FILIAL = 'nu', ZYX_DLIFEC = {item.DiaMesLimiteFecha }, ZYX_FEMAIL = '{item.Frequencia_email}',
                            ZYX_DEMAIL = {item.Qtddiadatafechamento}, ZYX_INIMAR = {item.DiaInicio}, ZYX_FINMAR = {item.DiaFim}, ZYX_CODDIV = '{item.CodDivergencia}',
                            ZYX_MATUSU = 'nu'
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
