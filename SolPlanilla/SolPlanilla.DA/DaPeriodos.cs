using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolPlanilla.BE;

namespace SolPlanilla.DA
{
    public class DaPeriodos
    {
        public Exception ErrorConsulta;

        private const string CadenaSelect = "Select  ";

        public List<BePeriodos> GetPerios(BeMaestroEmpresa pEmpresa)
        {
            return new List<BePeriodos>();
        }

        public BePeriodos InsPeriodos(BePeriodos pPeriodo)
        {
            return pPeriodo;
        }

        public BePeriodos UpdPeriodos(BePeriodos pPeriodo)
        {
            return pPeriodo;
        }

        private BePeriodos CargarEntidad(IDataReader pReader)
        {
            var periodo = new BePeriodos();

            try
            {
                
            }
            catch (Exception ex)
            {
                periodo = null;
                ErrorConsulta = ex;
            }
            return periodo;
        }
    }
}
