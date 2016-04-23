using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolPlanilla.BE;
using SolPlanilla.DA;

namespace SolPlanilla.BL
{
    public class BlMaestroDocumento
    {

        public BeMaestroDocumento ConsultarDocumento(BeMaestroDocumento pDocumento)
        {
            var oDa = new DaMaestroDocumento();
            pDocumento = oDa.GetDocumento(pDocumento);

            oDa = null;

            return pDocumento;
        }

        public List<BeMaestroDocumento> ConsultarDocumento(BeMaestroEmpresa pEmpresa)
        {
            var oDa = new DaMaestroDocumento();
            var lista = oDa.GetDocumento(pEmpresa);

            oDa = null;

            return lista;
        }


        public BeMaestroDocumento GrabarDocumento(BeMaestroDocumento pDocumento, bool pGrabar)
        {
            var oDa = new DaMaestroDocumento();

            pDocumento = pGrabar
                ? oDa.InsDocumento(pDocumento)
                : oDa.UpdDocumento(pDocumento);

            return pDocumento;
        }
    }
}