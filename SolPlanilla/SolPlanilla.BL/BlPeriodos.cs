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
            oDaPeriodo = null;
            return true;
        }

        public BePeriodos GrabarPeriodos(BePeriodos pPeriodo, bool pGrabar)
        {
            var oDaPeriodo = new DaPeriodos();

            pPeriodo = pGrabar ? oDaPeriodo.InsPeriodos(pPeriodo) : oDaPeriodo.UpdPeriodos(pPeriodo);
            oDaPeriodo = null;
            return pPeriodo;
        }

        public List<BePeriodos> ListarPeriodos(BeMaestroEmpresa pEmpresa)
        {
            var oDaPeriodo = new DaPeriodos();

            var lista = oDaPeriodo.GetPeriodos(pEmpresa);
            oDaPeriodo = null;
            return lista;
        }

    }
}
