using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVas___ilon.Models
{
    public class PlanProduccion
    {
        public int Id { get; set; }
        public string NumeroOrden { get; set; }
        public string Operacion { get; set; }
        public DateTime FechaPrevista { get; set; }
        public int Estado { get; set; }
        public string Data { get; set; }
        public string Hash { get; set; }

    }
}
