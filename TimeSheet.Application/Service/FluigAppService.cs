using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Application.Interface;
using TimeSheet.Domain;
using TimeSheet.Domain.Enty;
using TimeSheet.Domain.Interface.Service;
using TimeSheet.Domain.Util;

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

        public string[][] IniciarProcesso(string userCodFluig, string matricula, string filial, string grupoGerencia, string codmarcacao, string coordenacao)
        {
            var fluigProcess = new FluigProcess()
            {
                Username = Configuration.GetSection("Fluig")["UserName"],
                Password = Configuration.GetSection("Fluig")["Password"],
                UserCordFluig = userCodFluig, 
                CompanyId = Convert.ToInt32(Configuration.GetSection("Fluig")["CompanyId"]),
                IdProcesso = Configuration.GetSection("Fluig")["IdProcesso"],
                Atividade = 0,
                Completatarefa = true,
                Gestor = false,
                ColleagueId = new string[] { },
                Comment = "",
                CardData = new string[][] {
                    new[] { "txtGrupoGerencia", grupoGerencia},
                    new[] { "hddFilial", filial },
                    new[] { "txtGrupoCoord", coordenacao},
                    new[] { "hddCodigo",  codmarcacao}, 
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

        public string[][] RestartProcesso(string userCodFluig, string codigoProcessoFluig, string matricula, string filial, string GrupoGerencia, string codmarcacao)
        {
            var fluigProcess = new FluigProcess()
            {
                Username = Configuration.GetSection("Fluig")["UserName"],
                Password = Configuration.GetSection("Fluig")["Password"],
                UserCordFluig = userCodFluig,
                CompanyId = Convert.ToInt32(Configuration.GetSection("Fluig")["CompanyId"]),
                IdProcesso = codigoProcessoFluig,
                Atividade = 12,
                Completatarefa = true,
                Gestor = false,
                ColleagueId = new string[] { },
                Comment = "Movimentação automática realizada pelo fechamento do TimeSheet!",
                CardData = new string[][] { }
            };

            return Service.RestartProcessoFluig(fluigProcess);
        }

        public Marcacao ObterCodFluig(string codMarcacao)
        {
            return Service.ObterCodFluig(codMarcacao);
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
                throw new Exception("Fechamento não realizado, usuário fluig não encontrado! Favor contatar o coordenador!");
            }
        }

        public Marcacao VerificaExisteFechamentoFluig(string processId, string matricula, string codMarcacao)
        {
            return Service.ObterMarcacaoFechamentoFluig(processId, matricula, codMarcacao);
        }

        public bool ValidaNovoProcesso(Marcacao marcacao)
        {
            if (marcacao.CodigoFluig == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
