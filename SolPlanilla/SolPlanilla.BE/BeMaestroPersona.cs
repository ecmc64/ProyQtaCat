using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SolPlanilla.BE
{
	public class BeMaestroPersona
	{
		public Guid IdPersona { get; set; }
		public bool Activo { get; set; }
		public string Nombres { get; set; }
		public string Apellidos { get; set; }
		public string Direccion { get; set; }
		public BeEstadoEntidad EstadoEntidad { get; set; }
		public BeMaestroEmpresa Empresa { get; set; }
		public BeMaestroDocumento Documento { get; set; }
		public string UsuarioCreador { get; set; }
		public DateTime FechaCreacion { get; set; }
		public string UsuarioModificador { get; set; }
		public DateTime FechaModificacion { get; set; }

	}
}
