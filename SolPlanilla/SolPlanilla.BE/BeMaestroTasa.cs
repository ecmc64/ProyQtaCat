using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolPlanilla.BE
{
    public class BeMaestroTasa
    {
        public Guid IdTasa { get; set; }
        public BeMaestroEmpresa Empresa { get; set; }
        public string UsuarioCreador { get; set; }
        public string UsuarioModificador { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public Decimal Tasas { get; set; }
        public int RentaExcesoUit { get; set; }
        public int RentaHastaUit { get; set; }
        public BeEstadoEntidad EstadoEntidad { get; set; }
    }
}
