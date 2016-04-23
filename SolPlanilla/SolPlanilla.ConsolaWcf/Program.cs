using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SolPlanilla.ConsolaWcf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            using (var servicioWcf = new ServiceHost(typeof (WCF.ServicioPlanilla)))
            {
                servicioWcf.Open();
                Console.WriteLine("Servicio planilla en linea");
                Console.ReadLine();
            }
        }
    }
}
