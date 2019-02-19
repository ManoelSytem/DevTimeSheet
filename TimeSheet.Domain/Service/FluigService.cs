using TimeSheet.Domain.Enty;
using TimeSheet.Domain.Enty.Interface;
using TimeSheet.Domain.Interface;
using TimeSheet.Domain.Interface.Service;
using TimeSheet.Domain.Proxy;

namespace TimeSheet.Domain.Service
{
    public class FluigService : IFluigService
    {
        private readonly WorkflowEngineServiceClient WSFluig;
        private readonly IMarcacao _marcacaoServiceRepository;
        private readonly IFluig _fluigAppServiceRepository;

        public FluigService(IMarcacao marcacaoServiceRepository, IFluig fluigAppServiceRepository) {
            WSFluig = new WorkflowEngineServiceClient();
            _marcacaoServiceRepository = marcacaoServiceRepository;
            _fluigAppServiceRepository = fluigAppServiceRepository;
        }

        // 
        public string[][] IniciarProcesso(FluigProcess fluigProcess)
        {

            // WSFluig.saveAndSendTaskAsync processd id restartar um novo processo.
            // se existe um id gravado table ingual chama  WSFluig.saveAndSendTaskAsync. caso 
            return WSFluig.startProcessAsync(fluigProcess.Username,
                fluigProcess.Password,
                fluigProcess.CompanyId,
                fluigProcess.IdProcesso,
                fluigProcess.Atividade,
                fluigProcess.ColleagueId,
                fluigProcess.Comment,
                fluigProcess.UserCordFluig,// o codigo do retorno da consulta do email.
                fluigProcess.Completatarefa,
                fluigProcess.AttachmentsFluig,
                fluigProcess.CardData,
                fluigProcess.AppointmentFluig,
                fluigProcess.Gestor).GetAwaiter().GetResult().result;
        }

        public Marcacao ObterMarcacaoFechamentoFluig(string processId, string matricula, string codMarcacao)
        {
            return _marcacaoServiceRepository.ObterMarcacao(codMarcacao);
        }

        public Usuario ObterUserCodPorEmailFluig(string email)
        {
            return _fluigAppServiceRepository.ObterUsuarioFluig(email);
        }

        public Fechamento SalvarIdProcessoFluig(string processId)
        {
            throw new System.NotImplementedException();
        }
    }
}
