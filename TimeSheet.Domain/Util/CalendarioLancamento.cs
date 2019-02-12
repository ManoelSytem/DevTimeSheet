using System;
using System.Collections.Generic;
using System.Globalization;
using TimeSheet.Domain.Enty;
using TimeSheet.Domain.Util;


namespace TimeSheet.Domain
{
    public class CalendarioLancamento
    {
      
        public CalendarioLancamento()
        {
            
        }


        public List<MesCalendario> ObterMesCalendarioSemEComLancamento(List<Lancamento> lancamentolist, Marcacao marcacao)
        {
            List<MesCalendario> mesCalendarioSemEcomLancamento = new List<MesCalendario>();
            MesCalendario dataSemLancamento, dataComLancamento;
            DateTime initialDate = Convert.ToDateTime(marcacao.DataInicio.ToDateProtheusReverseformate());
            DateTime finalDate = Convert.ToDateTime(marcacao.DataFim.ToDateProtheusReverseformate());

            var days = 0;
            days = initialDate.Subtract(finalDate).Days;

            if (days < 0)
                days = days * -1;

            for (int i = 1; i <= days; i++)
            {
                initialDate = initialDate.AddDays(1);
                dataSemLancamento = new MesCalendario();
                dataComLancamento = new MesCalendario();
                {
                    if (!DataLancamentoExiste(initialDate, lancamentolist))
                    {
                        dataSemLancamento.Data = initialDate.ToShortDateString();
                        dataSemLancamento.DataDia = initialDate.Day.ToString();
                        dataSemLancamento.Dia = ObterNomeDataDia(initialDate);
                        dataSemLancamento.Status = "2";
                        mesCalendarioSemEcomLancamento.Add(dataSemLancamento);
                    }
                    else
                    {
                        dataComLancamento.Data = initialDate.ToShortDateString();
                        dataComLancamento.DataDia = initialDate.Day.ToString();
                        dataComLancamento.Dia = ObterNomeDataDia(initialDate);
                        dataComLancamento.Status = "1";
                        mesCalendarioSemEcomLancamento.Add(dataSemLancamento);
                    }
                }
            }

            return mesCalendarioSemEcomLancamento;
        }

        public List<SemanaCalendario> ObterSemanaCalendario(List<MesCalendario> mescalendario)
        {
            var count = 0;
            List<SemanaCalendario> semanaCalendario = new List<SemanaCalendario>();
            SemanaCalendario nova = new SemanaCalendario();
            foreach(MesCalendario mesc in mescalendario)
            {
                count++;
                nova.verificarDiaESetarDia(mesc.Dia, mesc.DataDia, nova);
                if(count >= 7) { 
                semanaCalendario.Add(nova);
                }
            }
            return semanaCalendario;
        }
        public bool DataLancamentoExiste(DateTime data, List<Lancamento> lancamentolist)
        {
            bool valor = false;
            foreach (Lancamento LancamentoResult in lancamentolist)
            {
                if (Convert.ToDateTime(LancamentoResult.DateLancamento.ToDateProtheusReverseformate()) == data)
                {
                    valor = true;
                }
            }
            return valor;
        }

        public string ObterNomeDataDia(DateTime data)
        {
            CultureInfo culture = new CultureInfo("pt-BR");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;
            string datanome = dtfi.GetDayName(data.DayOfWeek);

            return datanome;
        }

       

    }


    public class MesCalendario
    {

        public string Dia { get; set; }
        public string Data { get; set; }
        public string DataDia { get; set; }
        public string Status{ get; set; }

    }

    public class SemanaCalendario
    {

        public SemanaCalendario()
        {

        }

        public string Segunda { get; set; }
        public string Terca { get; set; }
        public string Quarta { get; set; }
        public string Quinta { get; set; }
        public string Sexta { get; set; }
        public string Sabado { get; set; }
        public string Domingo { get; set; }


        public void verificarDiaESetarDia(string dia, string valor, SemanaCalendario semana)
        {
            switch (dia)
            {
                case "segunda-feira":
                    semana.Segunda = valor;
                    break;
                case "terça-feira":
                    semana.Terca= valor;
                    break;
                case "quarta-feira":
                    semana.Quarta = valor;
                    break;
                case "quinta-feira":
                    semana.Quinta = valor;
                    break;
                case "sexta-feira":
                    semana.Sexta = valor;
                    break;
                case "sábado":
                    semana.Sabado = valor;
                    break;
                case "domingo":
                    semana.Domingo = valor;
                    break;
                default:
                    break;
            }
        }
    }
}




