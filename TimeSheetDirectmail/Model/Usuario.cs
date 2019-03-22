using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetDirectmail.Model
{
    public class Usuario
    {
        public string SubjectId { get; set; }
        public string Nome { get; set; }
        public string Endpoint { get; set; }
        public string Gerencia { get; set; }
        public string Email { get; set; }
        public string CodigoFluig { get; set; }
        public Guid Id { get; internal set; }
    }
}
