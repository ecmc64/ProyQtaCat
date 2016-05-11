﻿using System;
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
             * Listar obras ok
             * Listar Obreros ok
             * por obra, ok
             *      buscar archivo ok
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
                        var objLeerMdb = new Clases.LeerMdb(string.Concat(_rutaArchivo, "WPAG", obra.CodigoAntiguo));
                        var listaSemanasTrabajadas = objLeerMdb.ListarPeriodos(obra.CodigoAntiguo);

                        foreach (var periodo in listaSemanasTrabajadas)
                        {
                            /*
                             * si validar e insertar/act periodo
                             * Leer trabajadores del periodo tabla 9/ concatenar codigo general
                             * Leer tabla 11 pago salarios
                             * consolidar tabla para importacion
                             * proxy enviar a importar/actualizar
                             * sino
                             * ya fue
                             * */
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show(string.Format("No existe archivo para {0}", obra.DireccionObra), @"Buscar Archivo Obra", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
