using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SolPlanilla.BE;
using SolPlanilla.BL;

namespace SolPlanilla.WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class ServicioPlanilla : IServicioPlanilla
    {
        #region Miembros de IServicioPlanilla

        public bool TestConexion()
        {
            return true;
        }

        #region Mantenimientos

        #region Mantenimiento Categoria Obrero

        public BeMaestroCategoriaObrero ConsultarCategoriaObrero(BeMaestroCategoriaObrero pCategoriaObrero)
        {
            var oBlcategoria = new BlCategoriaObrero();
            pCategoriaObrero = oBlcategoria.ConsultarCategoriaObrero(pCategoriaObrero);
            oBlcategoria = null;
            return pCategoriaObrero;
        }

        public List<BeMaestroCategoriaObrero> ConsultarCategoriaObreroLista(BeMaestroEmpresa pEmpresa)
        {
            var oBlcategoria = new BlCategoriaObrero();
            var lista = oBlcategoria.ConsultarCategoriaObrero(pEmpresa);
            oBlcategoria = null;
            return lista;
        }

        public BeMaestroCategoriaObrero GrabarCategoriaObrero(BeMaestroCategoriaObrero pCategoriaObrero, bool pGrabar)
        {
            var oBlcategoria = new BlCategoriaObrero();
            pCategoriaObrero = oBlcategoria.GrabarCategoriaObrero(pCategoriaObrero, pGrabar);
            oBlcategoria = null;
            return pCategoriaObrero;
        }

        #endregion

        #region MantenimientoDocumento

        public BeMaestroDocumento ConsultarDocumento(BeMaestroDocumento pDocumento)
        {
            var oBlDocumento = new BlMaestroDocumento();
            pDocumento = oBlDocumento.ConsultarDocumento(pDocumento);
            oBlDocumento = null;
            return pDocumento;
        }

        public List<BeMaestroDocumento> ConsultarDocumentoLista(BeMaestroEmpresa pEmpresa)
        {
            var oBlDocumento = new BlMaestroDocumento();
            var lista = oBlDocumento.ConsultarDocumento(pEmpresa);
            oBlDocumento = null;
            return lista;
        }

        public BeMaestroDocumento GrabarDocumento(BeMaestroDocumento pDocumento, bool pGrabar)
        {
            var oBlDocumento = new BlMaestroDocumento();

            pDocumento = oBlDocumento.GrabarDocumento(pDocumento, pGrabar);
            oBlDocumento = null;
            return pDocumento;

        }

        #endregion

        #region Mantenimiento Obrero
        public BeMaestroObrero ConsultarObrero(BeMaestroObrero pObrero)
        {
            var oBlObrero = new BlMaestroObrero();
            pObrero = oBlObrero.ConsultarObrero(pObrero);
            oBlObrero = null;
            return pObrero;
        }

        public List<BeMaestroObrero> ConsultarObreroLista(BeMaestroEmpresa pEmpresa)
        {
            var oBlObrero = new BlMaestroObrero();
            var obreros = oBlObrero.ConsultarObrero(pEmpresa);
            oBlObrero = null;
            return obreros;
        }
        
        public BeMaestroObrero GrabarObrero(BeMaestroObrero pObrero, bool pGrabar)
        {
            var oBlObrero = new BlMaestroObrero();
            pObrero = oBlObrero.GrabarObrero(pObrero, pGrabar);
            oBlObrero = null;
            return pObrero;
        }
        #endregion

        #region Mantenimiento Empresa
        
        public List<BeMaestroEmpresa> ConsultarEmpresaLista()
        {
            var oBlempresa = new BlMaestroEmpresa();
            var lista = oBlempresa.ConsultarEmpresa();
            oBlempresa = null;
            return lista;
        }

        public BeMaestroEmpresa GrabarEmpresa(BeMaestroEmpresa pEmpresa, bool pGrabar)
        {
            var oBlempresa = new BlMaestroEmpresa();
            pEmpresa = oBlempresa.GrabarEmpresa(pEmpresa, pGrabar);
            oBlempresa = null;
            return pEmpresa;
        }
        
        #endregion

        #region Mantenimiento Uit

        public List<BeMaestroUit> ConsultarUitLista()
        {
            var oBluit = new BlMaestroUit();
            var lista = oBluit.ConsultarUit();
            oBluit = null;
            return lista;
        }

        public BeMaestroUit GrabarUit(BeMaestroUit pUit, bool pGrabar)
        {
            var oBluit = new BlMaestroUit();
            pUit = oBluit.GrabarUit(pUit, pGrabar);
            oBluit = null;
            return pUit;
        }
        #endregion

        #region Mantenimiento Tasa
        public List<BeMaestroTasa> ConsultarTasaLista()
        {
            var oBltasa = new BlMaestroTasa();
            var lista = oBltasa.ConsultarTasa();
            oBltasa = null;
            return lista;
        }
        public BeMaestroTasa GrabarTasa(BeMaestroTasa pTasa, bool pGrabar)
        {
            var oBltasa = new BlMaestroTasa();
            pTasa = oBltasa.GrabarTasa(pTasa, pGrabar);
            oBltasa = null;
            return pTasa;
        }
        #endregion

        #region Mantenimiento Obras

        public List<BeMaestroObras> ConsultarObrasLista(BeMaestroEmpresa pEmpresa)
        {
            var oBlObras = new BlMaestroObras();
            var listado = oBlObras.ConsultarObras(pEmpresa);
            oBlObras = null;
            return listado;
        }
        #endregion

        #region Periodos
        public List<BePeriodos> ConsultarPeriodoLista(BeMaestroEmpresa pEmpresa)
        {
            var oBlPeriodos = new BlPeriodos();
            var listado = oBlPeriodos.ListarPeriodos(pEmpresa);
            oBlPeriodos = null;
            return listado;
        }

        public BePeriodos GrabarPeriodos(BePeriodos pPeriodo, bool pGrabar)
        {
            var oBlPeriodos = new BlPeriodos();
            pPeriodo = oBlPeriodos.GrabarPeriodos(pPeriodo, pGrabar);
            oBlPeriodos = null;
            return pPeriodo;
        }
        #endregion

        #endregion



        #region Importaciones
        public BeMaestroObrero ImportarObrero(BeMaestroObrero pObrero)
        {
            var oBlObrero = new BlMaestroObrero();
            return oBlObrero.ImportarObrero(pObrero);

        }

        public BeMaestroObras ImportarObras(BeMaestroObras pObra)
        {
            var oBlObras = new BlMaestroObras();
            return oBlObras.ImportarObras(pObra);
        }

        public BePeriodosDeObras ImportarPagosDeObras(BePeriodosDeObras pPeriodosDeObras)
        {


            return pPeriodosDeObras;
        }
        #endregion



        #endregion

    }
}
