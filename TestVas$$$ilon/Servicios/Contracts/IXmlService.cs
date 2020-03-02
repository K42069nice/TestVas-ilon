using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestVas___ilon.Models;

namespace TestVas___ilon.Servicios.Contracts
{
    public interface IXmlService
    {
        List<PlanProduccion> DataConversion(string xml);

    }
}
