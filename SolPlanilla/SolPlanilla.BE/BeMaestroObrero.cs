using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SolPlanilla.BE
{
	public class BeMaestroObrero : BeMaestroPersona
	{
		public BeMaestroCategoriaObrero Categoria { get; set; }
        public string CodigoAlterno { get; set; }
    }
}
