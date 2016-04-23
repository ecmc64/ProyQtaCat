using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolPlanilla.BE;
using SolPlanilla.DA;

namespace SolPlanilla.BL
{
    public class BlMaestroObras
    {
        public BeMaestroObras ConsultarObras(BeMaestroObras pObra)
        {
            var oDa = new DaMaestroObra();

            pObra = oDa.GetMaestroObras(pObra);
            oDa = null;
            return pObra;
        }

        public List<BeMaestroObras> ConsultarObras(BeMaestroEmpresa pEmpresa)
        {
            var oDa = new DaMaestroObra();

            var lista = oDa.GetMaestroObras(pEmpresa);
            oDa = null;
            return lista;
        }

        public BeMaestroObras GrabarObra(BeMaestroObras pObra, bool pGrabar)
        {
            var oDa = new DaMaestroObra();

            pObra = pGrabar ? oDa.InsMaestroObras(pObra) : oDa.UpdMaestroObra(pObra);

            return pObra;
        }

        public BeMaestroObras ImportarObras(BeMaestroObras pObra)
        {
            var oDa = new DaMaestroObra();
            var obraDb = oDa.GetMaestroObrasByCodigoAntiguo(pObra);
            pObra.EstadoEntidad = obraDb.EstadoEntidad;

            if (pObra.EstadoEntidad.Correcto)
            {
                if (obraDb.EstadoEntidad.NumeroFilasAfectadas != 0)
                {
                    pObra.IdObra = obraDb.IdObra;
                }

                pObra = GrabarObra(pObra, obraDb.EstadoEntidad.NumeroFilasAfectadas == 0);
            }

            return pObra;
        }
    }
}
