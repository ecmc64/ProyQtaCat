using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolPlanilla.BE;
using SolPlanilla.DA;

namespace SolPlanilla.BL
{
    public class BlMaestroTasa
    {
        public Exception ErrorConsulta;

        public List<BeMaestroTasa> ConsultarTasa()
        {
            var oDa = new DaMaestroTasa();
            var lista = oDa.GetMaestroTasa();
            ErrorConsulta = oDa.ErrorConsulta;
            return lista;
        }

        public BeMaestroTasa GrabarTasa(BeMaestroTasa pTasa, bool pGrabar)
        {
            var oDa = new DaMaestroTasa();

            pTasa = pGrabar
                ? oDa.InsTasa(pTasa)
                : oDa.UpdTasa(pTasa);

            return pTasa;
        }
    }
}
