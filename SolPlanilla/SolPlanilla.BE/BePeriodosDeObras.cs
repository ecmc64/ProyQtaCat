using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SolPlanilla.BE
{
	public class BePeriodosDeObras
	{
		public Guid IdEmpresa { get; set; }
		public Guid IdObra { get; set; }
		public Guid IdPersona { get; set; }
		public Guid IdPeriodo { get; set; }
	}
}
