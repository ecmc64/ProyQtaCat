using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SolPlanilla.BE
{
	public class BeObreroPorObra
	{
		public Guid IdEmpresa { get; set; }
		public Guid IdObra { get; set; }
		public Guid IdPersona { get; set; }
		public string UsuarioCreador { get; set; }
		public DateTime FechaCreacion { get; set; }
		public string UsuarioModificador { get; set; }
		public DateTime FechaModificacion { get; set; }
		public bool Activo { get; set; }
	}
}
