using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SolPlanilla.BE
{
    public class BeEstadoEntidad
    {
        public bool Correcto { get; set; }
        public int NumeroFilasAfectadas { get; set; }
        public Exception ErrorEjecutar { get; set; }
        //Mensaje desde Everis
        //Segundo mensaje
    }
}
