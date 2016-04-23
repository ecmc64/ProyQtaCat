using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolPlanilla.BE;
using SolPlanilla.DA;

namespace SolPlanilla.BL
{
    public class BlMaestroUit
    {

        public Exception ErrorConsulta;

        public List<BeMaestroUit> ConsultarUit()
        {
            var oDa = new DaMaestroUit();
            var lista = oDa.GetMaestroUit();
            ErrorConsulta = oDa.ErrorConsulta;
            return lista;
        }

        public BeMaestroUit GrabarUit(BeMaestroUit pUit, bool pGrabar)
        {
            var oDa = new DaMaestroUit();

            pUit = pGrabar
                ? oDa.InsUit(pUit)
                : oDa.UpdUit(pUit);

            return pUit;
        }


    }
}
