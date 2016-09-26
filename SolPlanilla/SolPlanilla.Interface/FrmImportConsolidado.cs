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
using SolPlanilla.Interface.Clases;

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

            using (var proxy = new  ProxyWeb.ServicioPlanillaClient(GlobalVars.PuertoWcf))
            {
                var listadoObras = proxy.ConsultarObrasLista(GlobalVars.Empresa);
                //var listadoObreros = proxy.ConsultarCategoriaObreroLista(GlobalVars.Empresa);
                var listadoPeriodosSistema = proxy.ConsultarPeriodoLista(GlobalVars.Empresa);
                var objPeriodo = new BePeriodos();

                foreach (var obra in listadoObras) //Por cada obra
                {
                    if(ExisteArchivo(obra.CodigoAntiguo))
                    {
                        var objLeerMdb = new Clases.LeerMdb(string.Concat(_rutaArchivo, "WPAG", obra.CodigoAntiguo));
                        var listaSemanasTrabajadas = objLeerMdb.ListarPeriodos(obra.CodigoAntiguo);

                        foreach (var periodo in listaSemanasTrabajadas) //Por cada registro de semanas definidas por cada mes
                        {
                            if (!SincronizarPeriodoSistema(periodo, listadoPeriodosSistema, objPeriodo))
                            {
                                objPeriodo = proxy.GrabarPeriodos(objPeriodo, true);  //Sincroniza periodos del sistema en la importacion
                                listadoPeriodosSistema.Add(objPeriodo);
                            }

                            for (var semana = objPeriodo.SemanaInicio; semana <= objPeriodo.SemanaFin; semana++) // Recorrido de inicio a fin del mes por semanas
                            {
                                var listaCodigoTrabajadorSemana = objLeerMdb.ListarCodigoSemanaDelObrero(semana.ToString("00"), objPeriodo.Anio.ToString("####"));
                                var listaPagoTrabajadoresSemana = objLeerMdb.ListarPagoObreroSemana(semana.ToString("00"), objPeriodo.Anio.ToString("####"));

                                foreach (var codigoEquivalencia in listaCodigoTrabajadorSemana) //Recorriendo tabla de equivalencias de codigo y trabajadores para importar
                                {
                                    var objTrabSemana =
                                        listaPagoTrabajadoresSemana.Find(
                                            x => x.CodigoObra == codigoEquivalencia.CodigoSemana);

                                    var objPeriodosDeObra = new BePeriodosDeObras
                                    {
                                        Empresa = GlobalVars.Empresa,
                                        Obra = obra,
                                        Periodo = objPeriodo
                                    };
                                    objPeriodosDeObra.UsuarioCreador = objPeriodosDeObra.UsuarioModificador = GlobalVars.Usuario;
                                    objPeriodosDeObra.FechaCreacion = objPeriodosDeObra.FechaModificacion = DateTime.Now;

                                    objPeriodosDeObra.Obrero = new BeMaestroObrero
                                    {
                                        CodigoAlterno = codigoEquivalencia.Codigo,
                                        Empresa = GlobalVars.Empresa
                                    };
                                    objPeriodosDeObra.Jornal = objTrabSemana.Jornal;
                                    objPeriodosDeObra.Dominical = objTrabSemana.Dominical;
                                    objPeriodosDeObra.DescansoMedico = objTrabSemana.DescansoMedico;
                                    objPeriodosDeObra.Feriado = objTrabSemana.Feriado;
                                    objPeriodosDeObra.Buc = objTrabSemana.Buc;
                                    objPeriodosDeObra.Altura = objTrabSemana.Altura;
                                    objPeriodosDeObra.Agua = objTrabSemana.Agua;
                                    objPeriodosDeObra.Pasaje = objTrabSemana.Pasaje;
                                    objPeriodosDeObra.Escolar = objTrabSemana.Escolar;
                                    objPeriodosDeObra.Movilidad = objTrabSemana.Movilidad;
                                    objPeriodosDeObra.HoraExtra = objTrabSemana.HoraExtra;
                                    objPeriodosDeObra.Reintegro = objTrabSemana.Reintegro;
                                    objPeriodosDeObra.Vacaciones = objTrabSemana.Vacaciones;
                                    objPeriodosDeObra.Gratificacion = objTrabSemana.Gratificacion;
                                    objPeriodosDeObra.Viatico = objTrabSemana.Viatico;
                                    objPeriodosDeObra.Sepelio = objTrabSemana.Sepelio;
                                    objPeriodosDeObra.Altitud = objTrabSemana.Altitud;
                                    objPeriodosDeObra.Ley29351 = objTrabSemana.Ley29351;


                                    //objPeriodosDeObra = proxy.ImportarPagosDeObras(objPeriodosDeObra);

                                    //Evaluar si existe error
                                }
                            }
                            
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
            return File.Exists(string.Concat(_rutaArchivo, "WPAG", pCodigoObra, ".mdb"));
        }

        private bool SincronizarPeriodoSistema(BeImpPeriodos pPeriodoImportado, List<BePeriodos> pListaPeriodosSistema, BePeriodos pObjPeriodo)
        {
            var insUpdPeriodo = pListaPeriodosSistema.Exists(
                x =>
                    x.Anio == pPeriodoImportado.Anio && x.Mes == pPeriodoImportado.Mes &&
                    x.SemanaInicio == pPeriodoImportado.SemanaInicio);

            if (insUpdPeriodo)
            {
                pObjPeriodo = pListaPeriodosSistema.Find(x =>
                    x.Anio == pPeriodoImportado.Anio && x.Mes == pPeriodoImportado.Mes &&
                    x.SemanaInicio == pPeriodoImportado.SemanaInicio);
            }
            else
            {
                pObjPeriodo.IdPeriodo = new Guid();
                pObjPeriodo.Empresa = GlobalVars.Empresa;
                pObjPeriodo.Activo = true;
                pObjPeriodo.Anio = pPeriodoImportado.Anio;
                pObjPeriodo.FechaCreacion = DateTime.Now;
                pObjPeriodo.FechaModificacion = DateTime.Now;
                pObjPeriodo.Mes = pPeriodoImportado.Mes;
                pObjPeriodo.UsuarioCreador = GlobalVars.Usuario;
                pObjPeriodo.UsuarioModificador = GlobalVars.Usuario;
                pObjPeriodo.SemanaInicio = pPeriodoImportado.SemanaInicio;
                pObjPeriodo.SemanaFin = pPeriodoImportado.SemanaFin;

            }
            return insUpdPeriodo;
        }
        #endregion
    }
}
