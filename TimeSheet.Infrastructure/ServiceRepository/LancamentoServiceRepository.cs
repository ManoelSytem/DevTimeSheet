﻿using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Domain.Enty;
using TimeSheet.Domain.Interface;
using TimeSheet.Infrastructure.Repository;

namespace TimeSheet.Infrastructure.ServiceRepository
{
    public class LancamentoServiceRepository : ILancamento
    {
        private readonly LancamentoRepository _LancamentoRepository;

        public LancamentoServiceRepository()
        {
            _LancamentoRepository = new LancamentoRepository();
        }

        public void AtualizarLancamento(Lancamento item)
        {
            throw new NotImplementedException();
        }

        public void DeleteLancamento(string codigo)
        {
            throw new NotImplementedException();
        }

        public List<Lancamento> ObterLancamento(string data, string matricula)
        {
            return _LancamentoRepository.ObterListaMarcacaoPorDataMatricula(data, matricula);
        }

        public Lancamento ObterLancamentoEdit(string data, string matricula, string codlancamento)
        {
           return _LancamentoRepository.ObterListaMarcacaoEdit(data,matricula, codlancamento);
        }

        public void SalvarLancamento(Lancamento item, string filial, string dataProthues)
        {
            _LancamentoRepository.Add(item, filial, dataProthues);
        }
    }
}
