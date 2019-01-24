﻿using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Domain.Enty;
using TimeSheet.Domain.Interface;
using TimeSheet.Infrastructure.Repository;

namespace TimeSheet.Infrastructure.ServiceRepository
{
    public class MarcacaoServiceRepository : IMarcacao
    {
        private readonly MarcacaoRepository __marcacaoRepository;

        public MarcacaoServiceRepository()
        {
            __marcacaoRepository = new MarcacaoRepository();
        }

        public void AtualizarMarcacao(Marcacao item)
        {
            throw new NotImplementedException();
        }

        public void DeleteMarcacao(string codigo)
        {
            __marcacaoRepository.Delete(codigo);
        }

        public List<Marcacao> ObterListMarcacaoPorCodigo(string codigo)
        {
           return __marcacaoRepository.ObterListaMarcacaoPorCodigo(codigo);
        }

        public List<Marcacao> ObterListMarcacaoPorMatUser(string mat)
        {
           return __marcacaoRepository.ObterListaMarcacaoPorMatricula(mat);
        }

        public Marcacao ObterMarcacao(string codigo)
        {
            return __marcacaoRepository.ObterMarcacaoPorCodigo(codigo);
        }

        public void SalvarMarcacao(Marcacao item)
        {
            __marcacaoRepository.Add(item);
        }
    }
}
