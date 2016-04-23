using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SolPlanilla.BE
{
	public class BeMaestroEmpresa
	{
		public Guid IdEmpresa { get; set; }
		public string RazonSocial { get; set; }
		public string Ruc { get; set; }
		public string Direccion { get; set; }
		public bool Activo { get; set; }


        public BeEstadoEntidad EstadoEntidad { get; set; }
        
        //Hola desde git
	}
}
