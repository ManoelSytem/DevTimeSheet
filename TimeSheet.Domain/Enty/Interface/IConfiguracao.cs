using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheet.Domain.Enty.Interface
{
    public interface IConfiguracao
    {
        IEnumerable<Configuracao> ObterConfiguracaoPorCodigo(string id);
        void SalvarConfiguracao(Configuracao config);
    }
}
