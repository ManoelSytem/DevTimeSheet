using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeSheet.Domain.Enty
{
    public class Lancamento
    {
        public string Codigo { get; set; }
        public string Seq { get; set; }
        public string CodLancamento { get; set; }
        public string DateLancamento { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFim { get; set; }
        public string codEmpredimento { get; set; }
        public string DescricaoEmp { get; set; }
        public string Observacao { get; set; }
        public int CodObservacao { get; set; }
        public int CodDivergencia { get; set; }
        public string Status { get; set; }
        public string[] EmpreendimentoIds { get; set; }
        public virtual ICollection<Empreendimento> Projetos { get; set; }
        public string Fase { get; set; }


        public void ValidaHorasLancamentoOutraMarcacao(List<Lancamento> listlancamentoRelizado)
        {
            foreach (Lancamento LancamentoResult in listlancamentoRelizado)
            {
                if (LancamentoResult.Seq != this.Seq)
                {
                    if (!(this.HoraInicio >= LancamentoResult.HoraFim || this.HoraInicio <= LancamentoResult.HoraInicio && this.HoraFim <= LancamentoResult.HoraInicio))
                        throw new Exception("Não pode existir horas sobrepostas para o mesmo dia.");
                }
            }

        }

        public List<Fechamento> CalcularLancamentoPorData(IOrderedEnumerable<Lancamento> orderedlistalancamento, JornadaTrabalho jornadaTrabalho, Configuracao configura)
        {
            List<Fechamento> listaFechamentoPorData = new List<Fechamento>();

            listaFechamentoPorData = CalcularTotalHoraExedenteETrabalhada(orderedlistalancamento.OrderBy(c => c.DateLancamento), jornadaTrabalho);
            //Fechamento.TotalAtraso = Math.Round(CalcularAtraso(orderedlistalancamento.OrderBy(c => c.DateLancamento), jornadaTrabalho), 2);
            //Fechamento.TotalFalta = CalcularQuantidadeDeDiaSemApontamento(orderedlistalancamento.OrderBy(c => c.DateLancamento), jornadaTrabalho);
            //Fechamento.TotalAbono = CalcularTotalDeAbono(orderedlistalancamento.OrderBy(c => c.DateLancamento), configura);
            //Fechamento.TotalHora = Math.Round(CalcularTotalHoras(orderedlistalancamento.OrderBy(c => c.DateLancamento), jornadaTrabalho), 2);
            return listaFechamentoPorData;
        }

        private int CalcularQuantidadeDeDiaSemApontamento(IOrderedEnumerable<Lancamento> orderedEnumerable, JornadaTrabalho jornadaTrabalho)
        {
            throw new NotImplementedException();
        }

        public List<Fechamento> CalcularTotalHoraExedenteETrabalhada(IOrderedEnumerable<Lancamento> lancamentoList, JornadaTrabalho jornada)
        {
           
            List<Fechamento> listFechamentoHorasExedentes = new List<Fechamento>();
            TimeSpan totalHoraDiaLancamento = TimeSpan.Parse("00:00:00");
            TimeSpan totalLancamento = TimeSpan.Parse("00:00:00");
            string datalancamento = "0";
            var jrDiaria = jornada.JornadaDiaria;

            foreach (Lancamento LancamentoResult in lancamentoList)
            {
                
                if (datalancamento != LancamentoResult.DateLancamento && datalancamento != "0")
                {
                    Fechamento novo = new Fechamento();
                    if (totalLancamento > jrDiaria)
                    {
                        novo.TotalHora = Math.Round(Convert.ToDouble(totalLancamento.TotalHours), 2);
                        novo.DataLancamento = LancamentoResult.DateLancamento;
                        totalLancamento = totalLancamento - jrDiaria;
                        novo.TotalHoraExedente = Math.Round(Convert.ToDouble(totalLancamento.TotalHours),2);
                        listFechamentoHorasExedentes.Add(novo);
                        totalLancamento = TimeSpan.Parse("00:00:00");
                    }
                    else  {
                        novo.TotalHoraExedente = 0;
                        novo.DataLancamento = LancamentoResult.DateLancamento;
                        novo.TotalHora = Math.Round(Convert.ToDouble(totalLancamento.TotalHours), 2);
                        listFechamentoHorasExedentes.Add(novo);
                    }
                   
                }
                datalancamento = LancamentoResult.DateLancamento;
                totalLancamento += LancamentoResult.HoraFim - LancamentoResult.HoraInicio;
            }

            return listFechamentoHorasExedentes;
        }


        public List<Fechamento> CalcularTotalDeAbono(IOrderedEnumerable<Lancamento> lancamentoList, Configuracao config)
        {
            List<Fechamento> listFechamentoTotalAbono = new List<Fechamento>();
            int totalAbono = 0;
            string datalancamento = "0";
            foreach (Lancamento LancamentoResult in lancamentoList)
            {

                if (datalancamento != LancamentoResult.DateLancamento && datalancamento != "0")
                {
                    if (LancamentoResult.CodDivergencia == Convert.ToInt16(config.CodDivergencia))
                    {
                        Fechamento novo = new Fechamento();
                        novo.TotalAbono = totalAbono++;
                    }
                }
                datalancamento = LancamentoResult.DateLancamento;
                totalAbono++;

            }
            return listFechamentoTotalAbono;
        }

        public double CalcularAtraso(IOrderedEnumerable<Lancamento> lancamentoList, JornadaTrabalho jornada)
        {
            TimeSpan TotalAtraso = TimeSpan.Parse("00:00:00");
            foreach (Lancamento LancamentoResult in lancamentoList)
            {
                if (LancamentoResult.HoraInicio > jornada.HoraInicioDe)
                {
                    TotalAtraso += LancamentoResult.HoraInicio - jornada.HoraInicioDe;
                }

            }
            return TotalAtraso.TotalHours;
        }

        public double CalcularTotalHoras(IOrderedEnumerable<Lancamento> lancamentoList, JornadaTrabalho jornada)
        {
            TimeSpan TotalHoras = TimeSpan.Parse("00:00:00");
            foreach (Lancamento LancamentoResult in lancamentoList)
            {

                TotalHoras += LancamentoResult.HoraFim - LancamentoResult.HoraInicio;

            }
            return TotalHoras.TotalHours;
        }

    }
    public class LancamentoDb
    {
        public string Codigo { get; set; }
        public string Seq { get; set; }
        public string CodLancamento { get; set; }
        public string DateLancamento { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFim { get; set; }
        public string codEmpredimento { get; set; }
        public string DescricaoEmp { get; set; }
        public string Observacao { get; set; }
        public int CodObservacao { get; set; }
        public int CodDivergencia { get; set; }
        public string Status { get; set; }
        public string[] EmpreendimentoIds { get; set; }
        public virtual ICollection<Empreendimento> Projetos { get; set; }
        public string Fase { get; set; }
    }
      
}
