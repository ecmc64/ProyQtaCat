using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolPlanilla.DA;
using SolPlanilla.BE;

namespace SolPlanilla.BL
{
    public class BlPeriodos
    {
        public bool ValidarImportacion(BePeriodos pPeriodo)
        {
            var oDaPeriodo = new DaPeriodos();

            var periodo = oDaPeriodo.GetPeriodoByAnioMes(pPeriodo);

            return true;
        }
    }
}
