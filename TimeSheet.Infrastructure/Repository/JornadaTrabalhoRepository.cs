using Dapper;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Domain.Enty;
using TimeSheet.Domain.Util;
using TimeSheet.Infrastructure.Interface;

namespace TimeSheet.Infrastructure.Repository
{
    public class JornadaTrabalhoRepository 
    {
        private const string Connectionteste = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=stark.intranet.bahiagas.com.br)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ap12hml)));User Id=ap6;Password=ap6;";
        private const string ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=bgasha-scan.intranet.bahiagas.com.br)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=BAHIAGAS)));User Id=ap6;Password=msbd106";

        public JornadaTrabalhoRepository()
        {
            
        }

        public void Add(JornadaTrabalho item)
        {
            try
            {
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    string sQuery = $@"INSERT INTO ZYV010 (ZYV_FILIAL,ZYV_DESCR, ZYV_DTINI, ZYV_DTFIN, ZYV_JORNAD, ZYV_HRINI, ZYV_HRIFIN,ZYV_HFINAL, ZYV_INTINI,ZYV_INTFIN, ZYV_INTMIN,ZYV_INTMAX,ZYV_JORMAX, ZYV_JORMIN, R_E_C_N_O_)
                                    VALUES('{item.Filial}','{item.DescJornada}', '{Convert.ToString(item.DataInicio).ToDateProtheusConvert()}', '{Convert.ToString(item.DataFim).ToDateProtheusConvert()}', '{item.JornadaDiaria}', '{item.HoraInicioDe}','{item.HoraInicioAte}',
                                               '{item.HoraFinal}','{item.InterInicio}', '{item.InterFim}','{item.InterMin}', '{item.InterMax}','{item.JornadaMax}','{item.JornadaMin}',(SELECT MAX(X.R_E_C_N_O_)+1 FROM ZYV010 X))";
                    dbConnection.Open();
                    dbConnection.Execute(sQuery);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<JornadaTrabalho> FindAll()
        {
            try
            {
                   List<JornadaTrabalho> listJornadaTrabalho = new List<JornadaTrabalho>();
                JornadaTrabalho jornadaTrabalho;
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                   
                    string sQuery = $@"Select LTRIM(RTRIM(ZYV_CODIGO)) AS Codigo,
                                     LTRIM(RTRIM(ZYV_FILIAL)) AS Filial,
                                     LTRIM(RTRIM(ZYV_DESCR)) AS DescJornada,
                                     LTRIM(RTRIM(ZYV_DTINI)) AS DataInicio,
                                     LTRIM(RTRIM(ZYV_DTFIN)) AS DataFim,
                                     LTRIM(RTRIM(ZYV_JORNAD)) AS JornadaDiaria,
                                     LTRIM(RTRIM(ZYV_HRINI)) AS HoraInicioDe,
                                     LTRIM(RTRIM(ZYV_HRIFIN)) AS HoraInicioAte,
                                     LTRIM(RTRIM(ZYV_HFINAL)) AS HoraFinal,
                                     LTRIM(RTRIM(ZYV_INTINI)) AS InterInicio,
                                     LTRIM(RTRIM(ZYV_INTFIN)) AS InterFim,
                                     LTRIM(RTRIM(ZYV_INTMIN)) AS InterMin,
                                     LTRIM(RTRIM(ZYV_INTMAX)) AS InterMax,
                                     LTRIM(RTRIM(ZYV_JORMAX)) AS JornadaMax,
                                     LTRIM(RTRIM(ZYV_JORMIN)) AS JornadaMin
                                     from ZYV010 WHERE D_E_L_E_T_  <> '*'";
                      dbConnection.Open();
                    var jtResult =  dbConnection.Query<JornadaTrabalhoDb>(sQuery);
                    foreach (JornadaTrabalhoDb QueryResult in jtResult)
                    {
                        jornadaTrabalho = new JornadaTrabalho();
                        jornadaTrabalho.Codigo = QueryResult.Codigo;
                        jornadaTrabalho.DescJornada = QueryResult.DescJornada;
                        jornadaTrabalho.DataInicio = Convert.ToDateTime(QueryResult.DataInicio.ToDateProtheusReverseformate());
                        jornadaTrabalho.DataFim = Convert.ToDateTime(QueryResult.DataFim.ToDateProtheusReverseformate());
                        jornadaTrabalho.HoraInicioDe = TimeSpan.Parse(QueryResult.HoraInicioDe);
                        jornadaTrabalho.HoraInicioAte = TimeSpan.Parse(QueryResult.HoraInicioAte);
                        jornadaTrabalho.InterInicio = TimeSpan.Parse(QueryResult.InterInicio);
                        jornadaTrabalho.HoraInicioAte = TimeSpan.Parse(QueryResult.HoraInicioAte);
                        jornadaTrabalho.InterInicio = TimeSpan.Parse(QueryResult.InterInicio);
                        jornadaTrabalho.InterFim = TimeSpan.Parse(QueryResult.InterFim);
                        jornadaTrabalho.InterMin = TimeSpan.Parse(QueryResult.InterMin);
                        jornadaTrabalho.InterMax = TimeSpan.Parse(QueryResult.InterMax);
                        jornadaTrabalho.JornadaDiaria = TimeSpan.Parse(QueryResult.JornadaDiaria);
                        if (QueryResult.JornadaMin == null) { jornadaTrabalho.JornadaMin = TimeSpan.Parse("00:00"); }
                        else
                        { jornadaTrabalho.JornadaMin = TimeSpan.Parse(QueryResult.JornadaMin); }
                        jornadaTrabalho.Filial = QueryResult.Filial;
                        if (QueryResult.JornadaMax == null) { jornadaTrabalho.JornadaMax = TimeSpan.Parse("00:00"); } else
                        {jornadaTrabalho.JornadaMax = TimeSpan.Parse(QueryResult.JornadaMax);}
                        listJornadaTrabalho.Add(jornadaTrabalho);
                    }

                    return listJornadaTrabalho;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public void Update(JornadaTrabalho item)
        {
            try
            {
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    string sQuery = $@"UPDATE ZYV010  
                            SET ZYV_DESCR = '{item.DescJornada}' , ZYV_DTINI = '{Convert.ToString(item.DataInicio).ToDateProtheusConvert()}', ZYV_DTFIN = '{Convert.ToString(item.DataFim).ToDateProtheusConvert()}',
                            ZYV_JORNAD = '{item.JornadaDiaria}', ZYV_HRINI = '{item.HoraInicioDe}', ZYV_HRIFIN =  '{item.HoraInicioAte}', ZYV_HFINAL =  '{item.HoraFinal}',
                            ZYV_INTINI= '{item.InterInicio}', ZYV_INTFIN = '{item.InterFim}',  ZYV_INTMIN = '{item.InterMin}', ZYV_INTMAX = '{item.InterMax}', ZYV_FILIAL = '{item.Filial}', ZYV_JORMAX = '{item.JornadaMax}', ZYV_JORMIN = '{item.JornadaMin}'
                            WHERE ZYV_CODIGO ='{item.Codigo}'";
                    dbConnection.Open();
                    dbConnection.Execute(sQuery);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JornadaTrabalho FindByID(string codigo)
        {
            JornadaTrabalho jornadaTrabalho = new JornadaTrabalho();
            using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
            {
                dbConnection.Open();
                var sQuery = $@"Select LTRIM(RTRIM(ZYV_CODIGO)) AS Codigo,
                                     LTRIM(RTRIM(ZYV_FILIAL)) AS Filial,
                                     LTRIM(RTRIM(ZYV_DESCR)) AS DescJornada,
                                     LTRIM(RTRIM(ZYV_DTINI)) AS DataInicio,
                                     LTRIM(RTRIM(ZYV_DTFIN)) AS DataFim,
                                     LTRIM(RTRIM(ZYV_JORNAD)) AS JornadaDiaria,
                                     LTRIM(RTRIM(ZYV_HRINI)) AS HoraInicioDe,
                                     LTRIM(RTRIM(ZYV_HRIFIN)) AS HoraInicioAte,
                                     LTRIM(RTRIM(ZYV_HFINAL)) AS HoraFinal,
                                     LTRIM(RTRIM(ZYV_INTINI)) AS InterInicio,
                                     LTRIM(RTRIM(ZYV_INTFIN)) AS InterFim,
                                     LTRIM(RTRIM(ZYV_INTMIN)) AS InterMin,
                                     LTRIM(RTRIM(ZYV_INTMAX)) AS InterMax,
                                     LTRIM(RTRIM(ZYV_JORMAX)) AS JornadaMax,
                                     LTRIM(RTRIM(ZYV_JORMIN)) AS JornadaMin
                                     from ZYV010
                                     WHERE ZYV_CODIGO = '{codigo}' AND D_E_L_E_T_  <> '*'";
                var QueryResult = dbConnection.QueryFirstOrDefault<JornadaTrabalhoDb>(sQuery);

                    jornadaTrabalho.Codigo = QueryResult.Codigo;
                    jornadaTrabalho.DescJornada = QueryResult.DescJornada;
                    jornadaTrabalho.DataInicio = Convert.ToDateTime(QueryResult.DataInicio.ToDateProtheusReverseformate());
                    jornadaTrabalho.DataFim = Convert.ToDateTime(QueryResult.DataFim.ToDateProtheusReverseformate());
                    jornadaTrabalho.HoraInicioDe = TimeSpan.Parse(QueryResult.HoraInicioDe);
                    jornadaTrabalho.HoraInicioAte = TimeSpan.Parse(QueryResult.HoraInicioAte);
                    jornadaTrabalho.HoraFinal = TimeSpan.Parse(QueryResult.HoraFinal);
                    jornadaTrabalho.InterInicio = TimeSpan.Parse(QueryResult.InterInicio);
                    jornadaTrabalho.InterFim = TimeSpan.Parse(QueryResult.InterFim);
                    jornadaTrabalho.InterMin = TimeSpan.Parse(QueryResult.InterMin);
                    jornadaTrabalho.InterMax = TimeSpan.Parse(QueryResult.InterMax);
                    jornadaTrabalho.JornadaDiaria = TimeSpan.Parse(QueryResult.JornadaDiaria);
                    if (QueryResult.JornadaMin == null) { jornadaTrabalho.JornadaMin = TimeSpan.Parse("00:00"); }
                    else
                    { jornadaTrabalho.JornadaMin = TimeSpan.Parse(QueryResult.JornadaMin); }
                    if (QueryResult.JornadaMax == null) { jornadaTrabalho.JornadaMax = TimeSpan.Parse("00:00"); }
                    else
                    { jornadaTrabalho.JornadaMax = TimeSpan.Parse(QueryResult.JornadaMax); }
                      jornadaTrabalho.Filial = QueryResult.Filial;
                return jornadaTrabalho;
            }
        }

        public void Remove(string id)
        {
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    string sQuery = $@"UPDATE ZYV010 
                                   SET D_E_L_E_T_ = '*',
                                   R_E_C_D_E_L_ = (SELECT MAX(X.R_E_C_D_E_L_)+1 FROM ZYX010 X)
                                   WHERE ZYV_CODIGO = '{id}'";
                    dbConnection.Open();
                    dbConnection.Execute(sQuery);
                }
        }

    }
}
