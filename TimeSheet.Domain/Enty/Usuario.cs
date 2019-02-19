using System;
using System.Collections.Generic;
using System.Text;

namespace TimeSheet.Domain.Enty
{
     public class Usuario : EntityBase
    {
        public string SubjectId { get; set; }
        public string Nome { get; set; }
        public string Endpoint { get; set; }
        public string Gerencia { get; set; }
        public string Email { get; set; }
        public string CodigoFluig { get; set; }
    }
}

