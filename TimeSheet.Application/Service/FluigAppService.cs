﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Application.Interface;
using TimeSheet.Domain;
using TimeSheet.Domain.Enty;
using TimeSheet.Domain.Interface.Service;

namespace TimeSheet.Application
{
    public class FluigAppService : IFluigAppService
    {
        private readonly IFluigService Service;
        private readonly IConfiguration Configuration;

        public FluigAppService(IFluigService service,
            IConfiguration configuration)
        {
            Service = service;
            Configuration = configuration;
        }

        public string[][] IniciarProcesso(string userCodFluig, string matricula, string filial, string GrupoGerencia, string codmarcacao)
        {
            var fluigProcess = new FluigProcess()
            {
                Username = Configuration.GetSection("Fluig")["UserName"],
                Password = Configuration.GetSection("Fluig")["Password"],
                UserCordFluig = Configuration.GetSection("Fluig")["UserName"],
                CompanyId = Convert.ToInt32(Configuration.GetSection("Fluig")["CompanyId"]),
                IdProcesso = Configuration.GetSection("Fluig")["IdProcesso"],
                Atividade = 0,
                Completatarefa = true,
                Gestor = false,
                ColleagueId = new string[] { },
                Comment = "",
                CardData = new string[][] {
                    new[] { "txtGrupoGerencia", "GETIN"},
                    new[] { "hddFilial", filial },
                    new[] { "hddCodigo",  codmarcacao }, // CODIGO DA ZYU_CODIGO
                    new[] { "hddDivergencia", ""},
                    new[] { "hddAprovCoord",  "" },
                    new[] { "hddAprovGerencia",  "" },
                    new[] { "txtMatricula", matricula },
                    new[] { "txtNomeColaborador", ""},
                    new[] { "hddMatFluig", Configuration.GetSection("Fluig")["UserName"]},
                    //ZY
                }
            };

            return Service.IniciarProcesso(fluigProcess);
        }

        public Marcacao ObterCodFluig(string codMarcacao, string codFluig)
        {
            return Service.ObterCodFluig(codMarcacao, codFluig);
        }

        public Usuario ObterUserCodFluig(string email)
        {
           return Service.ObterUserCodPorEmailFluig(email);
        }

        public Usuario ObterUserGerencia(string centroCusto)
        {
            return Service.ObterUserGerencia(centroCusto);
        }

        public void SalvarIdProcessoFluig(string CodMarcacao, string processId)
        {
            Service.SalvarIdProcessoFluig(CodMarcacao, processId);
        }

        public Fechamento SaveProcessIdFluigFechamento(string processId)
        {
            throw new NotImplementedException();
        }

        public void SaveProcessIdFluigFechamento(string processId, string matricula, string codMarcacao)
        {
            throw new NotImplementedException();
        }

        public void ValidarUserFluig(Usuario user)
        {
            if (user == null)
            {
                throw new Exception("Usuário fluig não encontrado! Favor contatar o coordenador!");
            }
        }

        public Marcacao VerificaExisteFechamentoFluig(string processId, string matricula, string codMarcacao)
        {
            return Service.ObterMarcacaoFechamentoFluig(processId, matricula, codMarcacao);
        }
    }
}
