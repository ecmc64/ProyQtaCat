using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SolPlanilla.BE
{
	public class BeMaestroObras
	{
		public BeMaestroEmpresa Empresa { get; set; }
		public Guid IdObra { get; set; }
		public string Descripcion { get; set; }
		public DateTime FechaInicio { get; set; }
		public DateTime FechaFin { get; set; }
		public bool Activo { get; set; }
		public string DireccionObra { get; set; }
		public string RucObra { get; set; }
		public string UsuarioCreador { get; set; }
		public DateTime FechaCreacion { get; set; }
		public string UsuarioModificador { get; set; }
		public DateTime FechaModificacion { get; set; }
	    public string CodigoAntiguo { get; set; }


        public BeEstadoEntidad EstadoEntidad { get; set; }

	}
}
