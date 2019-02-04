using System;
using System.Collections.Generic;
using System.Text;

namespace TimeSheet.Util
{
    public interface INotificacao
    {
        void EnviarEmail(IEnumerable<string> email, string mensagem);
        void EnviarEmail(string email, string mensagem);
    }
}
