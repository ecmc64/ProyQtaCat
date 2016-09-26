using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolPlanilla.BE;
using SolPlanilla.DA;

namespace SolPlanilla.BL
{
    public class BlPagoObrero
    {
        public bool ImportarPagoObrero(BePeriodosDeObras pPeriodosDeObras)
        {
            var oDaMaestroObrero = new DaMaestroObrero();
            var obrero = oDaMaestroObrero.GetMaestroObreroByCodigoAlterno(pPeriodosDeObras.Empresa,
                pPeriodosDeObras.Obrero.CodigoAlterno);

            if (obrero != null)
            {
                pPeriodosDeObras.Obrero = obrero;

                var oObreroObra = new DaObreroPorObra();
                var obreoPorObra = new BeObreroPorObra
                {
                    Empresa = pPeriodosDeObras.Empresa,
                    Obra = pPeriodosDeObras.Obra,
                    Obrero = pPeriodosDeObras.Obrero,
                    CategoriaObrero = obrero.Categoria,
                    Activo = true,
                    FechaCreacion = pPeriodosDeObras.FechaCreacion,
                    FechaModificacion = pPeriodosDeObras.FechaModificacion,
                    UsuarioCreador = pPeriodosDeObras.UsuarioCreador,
                    UsuarioModificador = pPeriodosDeObras.UsuarioModificador
                };

                var listaObreroObra = oObreroObra.GetObrerosPorObra(obreoPorObra);

                var q = listaObreroObra.Count == 0
                    ? oObreroObra.InsObreroPorObra(obreoPorObra)
                    : oObreroObra.UpdObreroPorObra(obreoPorObra);


                var oPeriodoDeObraDa = new DaPeriodosDeObras();
                var l = oPeriodoDeObraDa.GetPeriodosDeObras(pPeriodosDeObras);

                

            }
            else
            {
                pPeriodosDeObras.EstadoEntidad = new BeEstadoEntidad
                {
                    Correcto = false,
                    ErrorEjecutar = null,
                    NumeroFilasAfectadas = 0
                };
            }

            return true;
        }
    }
}
