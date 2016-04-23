using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SolPlanilla.BE
{
    public class BeMaestroUit
    {
            public BeMaestroEmpresa Empresa { get; set; }
            public int Anio { get; set; }
            public decimal MontoUnidadImpositivaTrib { get; set; }
            public string UsuarioCreador { get; set; }
            public string UsuarioModificador { get; set; }
            public DateTime FechaCreacion { get; set; }
            public DateTime FechaModificacion { get; set; }

            public BeEstadoEntidad EstadoEntidad { get; set; }
        
    }
}
