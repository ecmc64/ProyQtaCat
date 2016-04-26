using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolPlanilla.BE;
using System.IO;

namespace SolPlanilla.Interface
{
    public partial class FrmImportConsolidado : Form
    {
        private string _rutaArchivo;  //nombre de archivo ee
        private string _nombreArchivo;  //Path
        public FrmImportConsolidado()
        {
            InitializeComponent();
        }

        #region Eventos

        #endregion

        #region Funciones

        void ImportarPagos()
        {
            _rutaArchivo = txtRuta.Text.Trim();

            /*
             * Listar obras
             * Listar Obreros
             * por obra, 
             *      buscar archivo
             *      leer tabla 9: codigos de equivalencia de obrero
             *      leer tabla 13: Periodos de Año / Mes / Semana inicio y fin
             *      Leer tablas con las semanas/Años enconrados en tabla 13
             * */

            //Listar obras
            using (var proxy = new  ProxyWeb.ServicioPlanillaClient(GlobalVars.PuertoWcf))
            {
                var listadoObras = proxy.ConsultarObrasLista(GlobalVars.Empresa);
                var listadoObreros = proxy.ConsultarCategoriaObreroLista(GlobalVars.Empresa);

                foreach (var obra in listadoObras)
                {
                    if(ExisteArchivo(obra.CodigoAntiguo))
                    {

                    }
                    else
                    {

                    }
                }
            }
        }

        private bool ExisteArchivo(string pCodigoObra)
        {
            return File.Exists(string.Concat(_rutaArchivo, pCodigoObra, ".mdb"));
        }
        #endregion
    }
}
