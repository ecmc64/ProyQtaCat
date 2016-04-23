using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolPlanilla.BE;
using SolPlanilla.DA;

namespace SolPlanilla.BL
{
    public class BlMaestroEmpresa
    {
        public Exception ErrorConsulta;

        public List<BeMaestroEmpresa> ConsultarEmpresa()
        {
            var oDa = new DaMaestroEmpresa();
            var lista = oDa.GetMaestroEmpresa();
            ErrorConsulta = oDa.ErrorConsulta;
            return lista;
        }

        public BeMaestroEmpresa GrabarEmpresa(BeMaestroEmpresa pEmpresa, bool pGrabar)
        {
            var oDa = new DaMaestroEmpresa();

            pEmpresa = pGrabar
                ? oDa.InsEmpresa(pEmpresa)
                : oDa.UpdEmpresa(pEmpresa);

            return pEmpresa;
            }
    }
}
