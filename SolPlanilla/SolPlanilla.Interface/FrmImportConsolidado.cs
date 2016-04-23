using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolPlanilla.Interface
{
    public partial class FrmImportConsolidado : Form
    {
        private string _rutaArchivo;
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
            }
        }
        #endregion
    }
}
