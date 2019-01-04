using Dapper;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Domain.Enty;
using TimeSheet.Infrastructure.Interface;

namespace TimeSheet.Infrastructure.Repository
{
    public class JornadaTrabalhoRepository 
    {
        private const string ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=stark.intranet.bahiagas.com.br)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ap12hml)));User Id=ap6;Password=ap6;";

        public JornadaTrabalhoRepository()
        {
            
        }

        public void Add(JornadaTrabalho item)
        {
            try
            {
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                    string sQuery = $@"INSERT INTO ZYV010 (ZYV_DESCR, ZYV_DTINI, ZYV_DTFIN, ZYV_JORNAD, ZYV_HRINI, ZYV_HRIFIN,ZYV_HFINAL, ZYV_INTINI,ZYV_INTFIN, ZYV_INTMIN,ZYV_INTMAX)
                                    VALUES('{item.DescJornada}', replace('{item.DataInicio.ToString("dd/MM/yyyy")}','/'), replace('{item.DataFim.ToString("dd/MM/yyyy")}','/'), {item.JornadaDiaria}, '{item.HoraInicioDe}','{item.HoraInicioAte}',
                                               '{item.HoraFinal}',  '{item.InterInicio}', '{item.InterFim}','{item.InterMin}', '{item.InterMax}')";
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
                JornadaTrabalho jornadaTrabalho = new JornadaTrabalho();
                using (OracleConnection dbConnection = new OracleConnection(ConnectionString))
                {
                   
                    string sQuery = $@"Select LTRIM(RTRIM(ZYV_CODIGO)) AS Codigo,
                                     LTRIM(RTRIM(ZYV_DESCR)) AS DescJornada,
                                    TO_DATE(LTRIM(RTRIM(ZYV_DTINI)),'DD/MM/RRRR') AS DataInicio,
                                    TO_DATE(LTRIM(RTRIM(ZYV_DTFIN)),'DD/MM/RRRR')  AS DataFim,
                                     LTRIM(RTRIM(ZYV_JORNAD)) AS JornadaDiaria,
                                     LTRIM(RTRIM(ZYV_HRINI)) AS HoraInicioDe,
                                     LTRIM(RTRIM(ZYV_HRIFIN)) AS HoraInicioAte,
                                     LTRIM(RTRIM(ZYV_HFINAL)) AS HoraFinal,
                                     LTRIM(RTRIM(ZYV_INTINI)) AS InterInicio,
                                     LTRIM(RTRIM(ZYV_INTFIN)) AS InterFim,
                                     LTRIM(RTRIM(ZYV_INTMIN)) AS InterMin,
                                     LTRIM(RTRIM(ZYV_INTMAX)) AS InterMax 
                                     from ZYV010
                                     WHERE D_E_L_E_T_  <> '*'";
                      dbConnection.Open();
                    var jtResult =  dbConnection.Query<JornadaTrabalhoDb>(sQuery);
                    foreach (JornadaTrabalhoDb QueryResult in jtResult)
                    {
                        jornadaTrabalho.Codigo = QueryResult.Codigo;
                        jornadaTrabalho.DescJornada = QueryResult.DescJornada;
                        jornadaTrabalho.DataInicio = QueryResult.DataInicio;
                        jornadaTrabalho.DataFim = QueryResult.DataFim;
                        jornadaTrabalho.HoraInicioDe = TimeSpan.Parse(QueryResult.HoraInicioDe);
                        jornadaTrabalho.HoraInicioAte = TimeSpan.Parse(QueryResult.HoraInicioAte);
                        jornadaTrabalho.InterInicio = TimeSpan.Parse(QueryResult.InterInicio);
                        jornadaTrabalho.HoraInicioAte = TimeSpan.Parse(QueryResult.HoraInicioAte);
                        jornadaTrabalho.InterInicio = TimeSpan.Parse(QueryResult.InterInicio);
                        jornadaTrabalho.InterFim = TimeSpan.Parse(QueryResult.InterFim);
                        jornadaTrabalho.InterMin = TimeSpan.Parse(QueryResult.InterMin);
                        jornadaTrabalho.InterMax = TimeSpan.Parse(QueryResult.InterMax);
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
                            SET ZYV_DESCR = '{item.DescJornada}' , ZYV_DTINI = replace('{item.DataInicio.ToString("dd/MM/yyyy")}','/'), ZYV_DTFIN = replace('{item.DataFim.ToString("dd/MM/yyyy")}','/'),
                            ZYV_JORNAD = {item.JornadaDiaria}, ZYV_HRINI = '{item.HoraInicioDe}', ZYV_HRIFIN =  '{item.HoraInicioAte}', ZYV_HFINAL =  '{item.HoraFinal}',
                            ZYV_INTINI= '{item.InterInicio}', ZYV_INTFIN = '{item.InterFim}',  ZYV_INTMIN = '{item.InterFim}', ZYV_INTMAX = '{item.InterMax}'
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
                                     LTRIM(RTRIM(ZYV_DESCR)) AS DescJornada,
                                    TO_DATE(LTRIM(RTRIM(ZYV_DTINI)),'DD/MM/RRRR') AS DataInicio,
                                    TO_DATE(LTRIM(RTRIM(ZYV_DTFIN)),'DD/MM/RRRR')  AS DataFim,
                                     LTRIM(RTRIM(ZYV_JORNAD)) AS JornadaDiaria,
                                     LTRIM(RTRIM(ZYV_HRINI)) AS HoraInicioDe,
                                     LTRIM(RTRIM(ZYV_HRIFIN)) AS HoraInicioAte,
                                     LTRIM(RTRIM(ZYV_HFINAL)) AS HoraFinal,
                                     LTRIM(RTRIM(ZYV_INTINI)) AS InterInicio,
                                     LTRIM(RTRIM(ZYV_INTFIN)) AS InterFim,
                                     LTRIM(RTRIM(ZYV_INTMIN)) AS InterMin,
                                     LTRIM(RTRIM(ZYV_INTMAX)) AS InterMax 
                                     from ZYV010
                                     WHERE ZYV_CODIGO = '{codigo}' AND D_E_L_E_T_  <> '*'";
                var QueryResult = dbConnection.QueryFirstOrDefault<JornadaTrabalhoDb>(sQuery);

                    jornadaTrabalho.Codigo = QueryResult.Codigo;
                    jornadaTrabalho.DescJornada = QueryResult.DescJornada;
                    jornadaTrabalho.DataInicio = QueryResult.DataInicio;
                    jornadaTrabalho.DataFim = QueryResult.DataFim;
                    jornadaTrabalho.HoraInicioDe = TimeSpan.Parse(QueryResult.HoraInicioDe);
                    jornadaTrabalho.HoraInicioAte = TimeSpan.Parse(QueryResult.HoraInicioAte);
                    jornadaTrabalho.HoraFinal = TimeSpan.Parse(QueryResult.HoraFinal);
                    jornadaTrabalho.InterInicio = TimeSpan.Parse(QueryResult.InterInicio);
                    jornadaTrabalho.InterFim = TimeSpan.Parse(QueryResult.InterFim);
                    jornadaTrabalho.InterMin = TimeSpan.Parse(QueryResult.InterMin);
                    jornadaTrabalho.InterMax = TimeSpan.Parse(QueryResult.InterMax);
                    jornadaTrabalho.JornadaDiaria = QueryResult.JornadaDiaria;
                return jornadaTrabalho;
            }
        }

        public void Remove(string id)
        {
            throw new NotImplementedException();
        }

    }
}
