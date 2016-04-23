using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SolPlanilla.BE
{
	public class BeMaestroDocumento
	{
		public Guid IdDocumento { get; set; }
		public Guid IdEmpresa { get; set; }
		public bool Activo { get; set; }
		public string NombreDocumento { get; set; }
		public string UsuarioCreador { get; set; }
		public string UsuarioModificador { get; set; }
		public DateTime FechaCreacion { get; set; }
		public DateTime FechaModificacion { get; set; }
		public string NumDocumento { get; set; }

		public BeMaestroEmpresa Empresa { get; set; }
		public BeEstadoEntidad EstadoEntidad { get; set; }
	}
}
