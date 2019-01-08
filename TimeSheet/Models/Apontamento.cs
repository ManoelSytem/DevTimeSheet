using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheet.Models
{
    public class Apontamento
    {
        public TimeSpan hora { get; set; }

        public Apontamento()
        {
            this.hora = TimeSpan.Parse("08:00:00");
        }
    }
}
