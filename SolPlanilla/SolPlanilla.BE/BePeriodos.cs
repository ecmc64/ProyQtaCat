using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SolPlanilla.BE
{
	public class BePeriodos
	{
		public Guid IdPeriodo { get; set; }
		public BeMaestroEmpresa Empresa { get; set; }
		public int Anio { get; set; }
		public bool Activo { get; set; }
		public string UsuarioCreador { get; set; }
		public DateTime FechaCreacion { get; set; }
		public string UsuarioModificador { get; set; }
		public DateTime FechaModificacion { get; set; }
		public int Mes { get; set; }
		public int SemanaInicio { get; set; }
		public int SemanaFin { get; set; }

	    public BeEstadoEntidad Estado { get; set; }
	}
}
