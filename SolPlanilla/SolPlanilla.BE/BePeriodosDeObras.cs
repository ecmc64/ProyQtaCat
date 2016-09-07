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
		public BeMaestroEmpresa Empresa { get; set; }
		public BeMaestroObras Obra { get; set; }
		public BeMaestroObrero Obrero { get; set; }
		public BePeriodos Periodo { get; set; }
		public double Jornal { get; set; }
		public double Dominical { get; set; }
		public double DescansoMedico { get; set; }
		public double Feriado { get; set; }
		public double Buc { get; set; }
		public double Altura { get; set; }
		public double Agua { get; set; }
		public double Pasaje { get; set; }
		public double Escolar { get; set; }
		public double Movilidad { get; set; }
		public double HoraExtra { get; set; }
		public double Reintegro { get; set; }
		public double Vacaciones { get; set; }
		public double Gratificacion { get; set; }
		public double Viatico { get; set; }
		public double Sepelio { get; set; }
		public double Altitud { get; set; }
		public double Ley29351 { get; set; }
		public string UsuarioCreador { get; set; }
		public DateTime FechaCreacion { get; set; }
		public string UsuarioModificador { get; set; }
		public DateTime FechaModificacion { get; set; }


		public BeEstadoEntidad EstadoEntidad { get; set; }
	}
}
